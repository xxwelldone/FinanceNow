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
    public class EmprestimoRepository : BaseRepository<Emprestimo>, IEmprestimoRepository
    {
        public EmprestimoRepository(FinanceNowContext context) : base(context)
        {
        }
    }
}
