
namespace FinanceNow.Entities;

public sealed class Conta
{
    public int ContaId { get; set; }

    public int? ClienteId { get; set; }

    public string? TipoConta { get; set; }

    public DateOnly? DataAbertura { get; set; }

    public decimal? Saldo { get; set; }

    public Cliente? Cliente { get; set; }
}
