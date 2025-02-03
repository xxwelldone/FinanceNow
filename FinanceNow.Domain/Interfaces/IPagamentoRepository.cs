using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceNow.Entities;
using FinanceNow.Repository.Interfaces;

namespace FinanceNow.Domain.Interfaces
{
    public interface IPagamentoRepository : IBaseRepository<Pagamento>
    {
    }
}
