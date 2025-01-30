

using FinanceNow.Data;
using FinanceNow.Repository;
using FinanceNow.Repository.Interfaces;

namespace FinanceNow.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUsuarioRepository _usuarioRepository;
        protected FinanceNowContext _context;

        public UnitOfWork(FinanceNowContext context)
        {
            _context = context;
        }

        public IUsuarioRepository UsuarioRepository => _usuarioRepository = _usuarioRepository ?? new UsuarioRepository(_context);

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
