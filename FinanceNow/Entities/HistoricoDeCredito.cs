using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public partial class HistoricoDeCredito
{
    public int HistoricoId { get; set; }

    public int? ClienteId { get; set; }

    public DateOnly? Data { get; set; }

    public string? Descricao { get; set; }

    public virtual Cliente? Cliente { get; set; }
}
