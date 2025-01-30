using FinanceNow.Data;
using FinanceNow.Entities;
using FinanceNow.Repository.Interfaces;

namespace FinanceNow.Repository
{
    public class UsuarioRepository : BaseRepository<Usuario>, IUsuarioRepository
    {
        public UsuarioRepository(FinanceNowContext context) : base(context)
        {
        }
    }
}
