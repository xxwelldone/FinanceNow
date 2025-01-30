using FinanceNow.Entities;

namespace FinanceNow.Services.Interfaces
{
    public interface IAuthenticate
    {
        Task<bool> AuthenticateAsync(string email, string password);
        Task<bool> UserExists(string email);
        string GenerateToken(Usuario user);

    }
}
