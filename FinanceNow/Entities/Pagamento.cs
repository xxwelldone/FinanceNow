using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public partial class Pagamento
{
    public int PagamentoId { get; set; }

    public int? EmprestimoId { get; set; }

    public decimal? Valor { get; set; }

    public DateOnly? DataPagamento { get; set; }

    public virtual Emprestimo? Emprestimo { get; set; }
}
