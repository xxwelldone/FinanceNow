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
    public class SolicitacaoRepository : BaseRepository<Solicitacao>, ISolicitacaoRepository
    {
        public SolicitacaoRepository(FinanceNowContext context) : base(context)
        {
        }
    }
}
