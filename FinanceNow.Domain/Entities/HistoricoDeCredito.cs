using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public sealed class HistoricoDeCredito
{
    public int HistoricoId { get; set; }

    public int? ClienteId { get; set; }

    public DateOnly? Data { get; set; }

    public string? Descricao { get; set; }

    public   Cliente? Cliente { get; set; }
}
