using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceNow.Data;
using FinanceNow.Domain.Entities;
using FinanceNow.Domain.Interfaces;
using FinanceNow.Repository;

namespace FinanceNow.Infra.Repository
{
    public class AnaliseRepository : BaseRepository<Analise>, IAnaliseRepository
    {
        public AnaliseRepository(FinanceNowContext context) : base(context)
        {
        }
    }
}
