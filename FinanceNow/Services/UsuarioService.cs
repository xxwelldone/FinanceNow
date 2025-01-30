using System.Security.Cryptography;
using System.Text;
using AutoMapper;
using FinanceNow.Entities;
using FinanceNow.Entities.DTO;
using FinanceNow.Mappings;
using FinanceNow.Services.Interfaces;
using FinanceNow.UOW;

namespace FinanceNow.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mappingToDTO;
        private readonly IAuthenticate _authenticate;

        public UsuarioService(IUnitOfWork unitOfWork, IMapper mappingToDTO, IAuthenticate authenticate)
        {
            _unitOfWork = unitOfWork;
            _mappingToDTO = mappingToDTO;
            _authenticate = authenticate;
        }

        public async Task<UsuarioResponseDTO> CreateAsync(UsuarioCreateDTO usuarioCreateDTO)
        {
            Usuario user = _mappingToDTO.Map<Usuario>(usuarioCreateDTO);
            bool userExist = await _authenticate.UserExists(user.Email);

            if (userExist)
            {
                throw new Exception("Usuário já cadastrado no sistema");
            }

            using HMAC crypt = new HMACSHA512();
            byte[] passwordHash = crypt.ComputeHash(Encoding.UTF8.GetBytes(usuarioCreateDTO.Password));
            byte[] passwordSalt = crypt.Key;
            user.PasswordSalt = passwordSalt;
            user.PasswordHash = passwordHash;

            await _unitOfWork.UsuarioRepository.Create(user);
            await _unitOfWork.Commit();

            UsuarioResponseDTO responseDTO = _mappingToDTO.Map<UsuarioResponseDTO>(user);

            return responseDTO;

        }
        public async Task<UsuarioLoggedDTO> LoginAsync(UsuarioLoginDTO loginDTO)
        {

            Usuario user = await _unitOfWork.UsuarioRepository.GetFirstAsync(x => x.Email.ToLower() == loginDTO.Email.ToLower());
            if (user == null)
            {
                throw new Exception("Usuário inválido");
            }
            bool isAuthenticated = await _authenticate.AuthenticateAsync(loginDTO.Email, loginDTO.Password);
            if (!isAuthenticated)
            {
                throw new Exception("Usuário ou senha inválidos");
            }
            string token = _authenticate.GenerateToken(user);
            return new UsuarioLoggedDTO { Token = token };

        }
    }
}
