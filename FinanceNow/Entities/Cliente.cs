using System;
using System.Collections.Generic;

namespace FinanceNow.Entities;

public partial class Cliente
{
    public int ClienteId { get; set; }

    public string? Nome { get; set; }

    public string? Sobrenome { get; set; }

    public DateOnly? DataNascimento { get; set; }

    public string? Cpf { get; set; }

    public string? Rg { get; set; }

    public string? Endereco { get; set; }

    public string? Telefone { get; set; }

    public string? Email { get; set; }

    public decimal? Renda { get; set; }

    public string? Profissao { get; set; }

    public virtual ICollection<CartoesDeCredito> CartoesDeCreditos { get; set; } = new List<CartoesDeCredito>();

    public virtual ICollection<Conta> Conta { get; set; } = new List<Conta>();

    public virtual ICollection<Emprestimo> Emprestimos { get; set; } = new List<Emprestimo>();

    public virtual ICollection<HistoricoDeCredito> HistoricoDeCreditos { get; set; } = new List<HistoricoDeCredito>();
}
