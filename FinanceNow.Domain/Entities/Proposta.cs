using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceNow.Entities;

namespace FinanceNow.Domain.Entities
{
    public class Proposta
    {
        public int PropostaId { get; set; }
        public double ValorDisponibilizado { get; set; }
        public double Juros { get; set; }
        public DateOnly DataDisponivel { get; set; }
        public DateOnly DataQuitar { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public int AnaliseId { get; set; }
        public Analise Analise { get; set; }
    }
}
