using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public partial class CartoesDeCredito
{
    public int CartaoId { get; set; }

    public int? ClienteId { get; set; }

    public string? Bandeira { get; set; }

    public decimal? Limite { get; set; }

    public DateOnly? DataVencimentoFatura { get; set; }

    public virtual Cliente? Cliente { get; set; }
}
