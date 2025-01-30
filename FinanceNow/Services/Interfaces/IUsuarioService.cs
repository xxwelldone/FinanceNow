using FinanceNow.Entities;
using FinanceNow.Entities.DTO;

namespace FinanceNow.Services.Interfaces
{
    public interface IUsuarioService
    {
        Task<UsuarioResponseDTO> CreateAsync(UsuarioCreateDTO usuario);
        Task<UsuarioLoggedDTO> LoginAsync(UsuarioLoginDTO loginDTO);

    }
}
