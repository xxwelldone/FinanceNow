using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceNow.Data;
using FinanceNow.Domain.Interfaces;
using FinanceNow.Repository;

namespace FinanceNow.Infra.Repository
{
    public class HistoricoDeCredito : BaseRepository<HistoricoDeCredito>, IHistoricoDeCredito
    {
        public HistoricoDeCredito(FinanceNowContext context) : base(context)
        {
        }
    }
}
