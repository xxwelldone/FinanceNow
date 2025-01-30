﻿using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public partial class Emprestimo
{
    public int EmprestimoId { get; set; }

    public int? ClienteId { get; set; }

    public decimal? Valor { get; set; }

    public DateOnly? DataConcessao { get; set; }

    public DateOnly? DataVencimento { get; set; }

    public decimal? TaxaJuros { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual ICollection<Pagamento> Pagamentos { get; set; } = new List<Pagamento>();
}
