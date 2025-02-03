
using FinanceNow.Data;
using FinanceNow.Domain.Interfaces;
using FinanceNow.Entities;
using FinanceNow.Repository;

namespace FinanceNow.Infra.Repository
{
    public class ContaRepository : BaseRepository<Conta>, IContaRepository
    {
        public ContaRepository(FinanceNowContext context) : base(context)
        {
        }
    }
}
