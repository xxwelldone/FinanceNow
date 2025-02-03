using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceNow.Data;
using FinanceNow.Domain.Interfaces;
using FinanceNow.Entities;
using FinanceNow.Repository;

namespace FinanceNow.Infra.Repository
{
    public class PagamentoRepository : BaseRepository<Pagamento>, IPagamentoRepository
    {
        public PagamentoRepository(FinanceNowContext context) : base(context)
        {
        }
    }
}
