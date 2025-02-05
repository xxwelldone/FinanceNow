using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceNow.Domain.Entities
{
    public class AnaliseRegra
    {
        public int Id { get; set; }
        public int AnaliseId { get; set; }
        public int RegraId { get; set; }
        public Analise Analise { get; set; }
        public Regra Regra { get; set; }
    }
}
