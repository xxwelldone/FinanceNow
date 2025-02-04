using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceNow.Entities;

namespace FinanceNow.Domain.Entities
{
    public class Analise
    {
        public int AnaliseId { get; set; }
        public bool PermitirProposta { get; set; }
        public double Score { get; set; }

        public int SolicitacaoId { get; set; }
        public Solicitacao Solicitacao { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Proposta? Proposta { get; set; }

    }
}
