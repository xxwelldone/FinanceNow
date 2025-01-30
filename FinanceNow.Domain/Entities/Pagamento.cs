using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public sealed class Pagamento
{
    public int PagamentoId { get; set; }

    public int? EmprestimoId { get; set; }

    public decimal? Valor { get; set; }

    public DateOnly? DataPagamento { get; set; }

    public   Emprestimo? Emprestimo { get; set; }
}
