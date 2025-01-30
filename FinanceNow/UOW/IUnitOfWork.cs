using FinanceNow.Repository.Interfaces;

namespace FinanceNow.UOW
{
    public interface IUnitOfWork
    {
        IUsuarioRepository UsuarioRepository { get; }
        Task Commit();
    }
}
