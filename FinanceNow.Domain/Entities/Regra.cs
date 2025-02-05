using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceNow.Domain.Entities
{
    public sealed class Regra
    {
        public int RegraId { get; set; }

        // Descrição da regra (opcional, para facilitar a compreensão)
        public string? Descricao { get; set; }

        // Campo que define o tipo de regra (ex: "RendaMinima", "ScoreMinimo", "LimiteCartao", etc.)
        public string TipoRegra { get; set; }

        // Operador da regra (ex: ">", "<", "==", ">=", "<=")
        public string Operador { get; set; }

        // Valor de comparação para a regra
        public double ValorComparacao { get; set; }

        // Peso da regra no cálculo do score (opcional, dependendo da complexidade do sistema)
        public double Peso { get; set; }     
        public bool Ativo {  get; set; }

       
    }
}
