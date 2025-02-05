

using FinanceNow.Data;
using FinanceNow.Domain.Interfaces;
using FinanceNow.Infra.Repository;
using FinanceNow.Repository;
using FinanceNow.Repository.Interfaces;

namespace FinanceNow.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private IUsuarioRepository _usuarioRepository;
        private ICartoesDeCreditoRepository _cartoesDeCreditoRepository;
        private IClienteRepository _clienteRepository;
        private IContaRepository _contaRepository;
        private IEmprestimoRepository _emprestimoRepository;
        private IHistoricoDeCreditoRepository _historicoDeCartao;
        private IPagamentoRepository _pagamentoRepository;

        ISolicitacaoRepository _solicitacaoRepository;
        IAnaliseRepository _analiseRepository;

        protected FinanceNowContext _context;


        public UnitOfWork(FinanceNowContext context)
        {
            _context = context;
        }

        public IUsuarioRepository UsuarioRepository => _usuarioRepository = _usuarioRepository ?? new UsuarioRepository(_context);
        public ICartoesDeCreditoRepository CartoesDeCreditoRepository => _cartoesDeCreditoRepository = _cartoesDeCreditoRepository ?? new CartaoDeCreditoRepository(_context);
        public IClienteRepository ClienteRepository => _clienteRepository = _clienteRepository ?? new ClienteRepository(_context);

        public IContaRepository ContaRepository => _contaRepository = _contaRepository ?? new ContaRepository(_context);
        public IEmprestimoRepository EmprestimoRepository => _emprestimoRepository = _emprestimoRepository ?? new EmprestimoRepository(_context);
        public IHistoricoDeCreditoRepository HistoricoDeCredito => _historicoDeCartao = _historicoDeCartao ?? new HistoricoDeCreditoRepository(_context);

        public IPagamentoRepository PagamentoRepository => _pagamentoRepository = _pagamentoRepository ?? new PagamentoRepository(_context);
        public ISolicitacaoRepository SolicitacaoRepository=>  _solicitacaoRepository = _solicitacaoRepository ?? new SolicitacaoRepository(_context);
        public IAnaliseRepository AnaliseRepository => _analiseRepository = _analiseRepository?? new AnaliseRepository(_context);

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }
    }
}
