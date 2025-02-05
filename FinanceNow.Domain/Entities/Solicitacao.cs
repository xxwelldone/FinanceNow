using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceNow.Entities;

namespace FinanceNow.Domain.Entities
{
    public class Solicitacao
    {
        public int SolicitacaoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public Analise? Analise { get; set; }

        public double ValorSolicitado { get; set; }
        public bool Emergencia { get; set; }

        public Solicitacao( Cliente cliente, Analise? analise, double valorSolicitado, bool emergencia)
        {
           
            ClienteId = cliente.ClienteId;
            Cliente = cliente;
            Analise = analise;
            ValorSolicitado = valorSolicitado;
            Emergencia = emergencia;
        }

        public Solicitacao()
        {
        }
    }
}
