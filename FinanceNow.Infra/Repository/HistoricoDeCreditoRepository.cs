using System;
using FinanceNow.Data;
using FinanceNow.Domain.Interfaces;
using FinanceNow.Entities;
using FinanceNow.Repository;



namespace FinanceNow.Infra.Repository
{
    public class HistoricoDeCreditoRepository : BaseRepository<HistoricoDeCredito>, IHistoricoDeCreditoRepository
    {
        public HistoricoDeCreditoRepository(FinanceNowContext context) : base(context)
        {
        }

      
    }
}
