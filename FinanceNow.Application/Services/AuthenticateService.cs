using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using FinanceNow.Entities;
using FinanceNow.Services.Interfaces;
using FinanceNow.UOW;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace FinanceNow.Services
{
    public class AuthenticateService : IAuthenticate
    {
        private readonly IConfiguration _configuration;
        private readonly IUnitOfWork _unitOfWork;

        
        public AuthenticateService(IUnitOfWork unitOfWork, IConfiguration configuration)
        {
            _unitOfWork = unitOfWork;
            _configuration = configuration;
        }

        public async Task<bool> AuthenticateAsync(string email, string password)
        {
            Usuario user = await _unitOfWork.UsuarioRepository.GetFirstAsync(x => x.Email.ToUpper() == email.ToUpper());

            if (user == null) { return false; }
            using HMACSHA512 hmac = new HMACSHA512(user.PasswordSalt);
            var computedHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));

            for (int i = 0; i < computedHash.Length; i++)
            {
                if (computedHash[i] != user.PasswordHash[i])
                {
                    return false;
                }
            }
            return true;

        }

        public string GenerateToken(Usuario user)
        {
            Claim[] claims = new Claim[]
            {
                new Claim("id", user.UsuarioId.ToString()),
                new Claim("email", user.Email),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),

            };
            var privateKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["jwt:secretkey"]));
            var token = new JwtSecurityToken(
                expires: DateTime.Now.AddMinutes(30),
                claims: claims,
                signingCredentials: new SigningCredentials(privateKey, SecurityAlgorithms.HmacSha256),
                issuer: _configuration["jwt:issuer"],
                audience: _configuration["jwt:audience"]
                );
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public async Task<bool> UserExists(string email)
        {
            Usuario user = await _unitOfWork.UsuarioRepository.GetFirstAsync(x => x.Email.ToUpper() == email.ToUpper());

            if (user == null) { return false; }
            return true;
        }
        
    }
}
