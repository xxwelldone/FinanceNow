using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FinanceNow.Application.Interfaces;
using FinanceNow.Domain.Entities;
using FinanceNow.Entities;
using FinanceNow.UOW;

namespace FinanceNow.Application.Services
{
    public class SolicitacaoService : ISolicitacaoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public async Task<Solicitacao> CreateSolicitacao(string cpf, double amount, bool emergency)
        {
            Cliente cliente = await _unitOfWork.ClienteRepository.GetFirstAsync(x => x.Cpf.ToUpper() == cpf.ToUpper());

            if (cliente is null) { throw new Exception("Cliente não foi localizado"); }
            Solicitacao solicitacao = new Solicitacao(cliente, null, amount, emergency);
            await _unitOfWork.SolicitacaoRepository.Create(solicitacao);
            await _unitOfWork.Commit();
            return solicitacao;

        }


    }
}
