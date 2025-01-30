using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public partial class Conta
{
    public int ContaId { get; set; }

    public int? ClienteId { get; set; }

    public string? TipoConta { get; set; }

    public DateOnly? DataAbertura { get; set; }

    public decimal? Saldo { get; set; }

    public virtual Cliente? Cliente { get; set; }
}
