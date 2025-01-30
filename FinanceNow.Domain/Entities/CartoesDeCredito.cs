using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public sealed class CartoesDeCredito
{
    public int CartaoId { get; set; }

    public int? ClienteId { get; set; }

    public string? Bandeira { get; set; }

    public decimal? Limite { get; set; }

    public DateOnly? DataVencimentoFatura { get; set; }

    public Cliente? Cliente { get; set; }
}
