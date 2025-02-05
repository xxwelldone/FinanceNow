using FinanceNow.Domain.Interfaces;
using FinanceNow.Repository.Interfaces;

namespace FinanceNow.UOW
{
    public interface IUnitOfWork
    {
        IUsuarioRepository UsuarioRepository { get; }
        ICartoesDeCreditoRepository CartoesDeCreditoRepository { get; }
        IClienteRepository ClienteRepository { get; }
        IContaRepository ContaRepository { get; }
        IEmprestimoRepository EmprestimoRepository { get; }
        IHistoricoDeCreditoRepository HistoricoDeCartao {  get; }
        IPagamentoRepository PagamentoRepository { get; }

        ISolicitacaoRepository SolicitacaoRepository { get; }
        IAnaliseRepository AnaliseRepository { get; }
        Task Commit();
    }
}
