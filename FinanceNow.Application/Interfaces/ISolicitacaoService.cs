using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FinanceNow.Domain.Entities;

namespace FinanceNow.Application.Interfaces
{
    public interface ISolicitacaoService
    {
        Task<Solicitacao> CreateSolicitacao(string cpf, double amount, bool emergency)
    }
}
