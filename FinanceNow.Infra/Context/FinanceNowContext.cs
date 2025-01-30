
using FinanceNow.Entities;
using Microsoft.EntityFrameworkCore;

namespace FinanceNow.Data;

public partial class FinanceNowContext : DbContext
{
    public FinanceNowContext()
    {
    }

    public FinanceNowContext(DbContextOptions<FinanceNowContext> options)
        : base(options)
    {
    }

    public   DbSet<CartoesDeCredito> CartoesDeCreditos { get; set; }

    public   DbSet<Cliente> Clientes { get; set; }

    public   DbSet<Conta> Contas { get; set; }

    public   DbSet<Emprestimo> Emprestimos { get; set; }

    public   DbSet<HistoricoDeCredito> HistoricoDeCreditos { get; set; }

    public   DbSet<Pagamento> Pagamentos { get; set; }
    public   DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CartoesDeCredito>(entity =>
        {
            entity.HasKey(e => e.CartaoId).HasName("cartoes_de_credito_pkey");

            entity.ToTable("cartoes_de_credito");

            entity.Property(e => e.CartaoId)
                .ValueGeneratedNever()
                .HasColumnName("cartao_id");
            entity.Property(e => e.Bandeira)
                .HasMaxLength(50)
                .HasColumnName("bandeira");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.DataVencimentoFatura).HasColumnName("data_vencimento_fatura");
            entity.Property(e => e.Limite)
                .HasPrecision(10, 2)
                .HasColumnName("limite");

            entity.HasOne(d => d.Cliente).WithMany(p => p.CartoesDeCreditos)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("cartoes_de_credito_cliente_id_fkey");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.ClienteId).HasName("clientes_pkey");

            entity.ToTable("clientes");

            entity.Property(e => e.ClienteId)
                .ValueGeneratedNever()
                .HasColumnName("cliente_id");
            entity.Property(e => e.Cpf)
                .HasMaxLength(11)
                .HasColumnName("cpf");
            entity.Property(e => e.DataNascimento).HasColumnName("data_nascimento");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("email");
            entity.Property(e => e.Endereco).HasColumnName("endereco");
            entity.Property(e => e.Nome)
                .HasMaxLength(100)
                .HasColumnName("nome");
            entity.Property(e => e.Profissao)
                .HasMaxLength(100)
                .HasColumnName("profissao");
            entity.Property(e => e.Renda)
                .HasPrecision(10, 2)
                .HasColumnName("renda");
            entity.Property(e => e.Rg)
                .HasMaxLength(20)
                .HasColumnName("rg");
            entity.Property(e => e.Sobrenome)
                .HasMaxLength(100)
                .HasColumnName("sobrenome");
            entity.Property(e => e.Telefone)
                .HasMaxLength(20)
                .HasColumnName("telefone");
        });

        modelBuilder.Entity<Conta>(entity =>
        {
            entity.HasKey(e => e.ContaId).HasName("contas_pkey");

            entity.ToTable("contas");

            entity.Property(e => e.ContaId)
                .ValueGeneratedNever()
                .HasColumnName("conta_id");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.DataAbertura).HasColumnName("data_abertura");
            entity.Property(e => e.Saldo)
                .HasPrecision(10, 2)
                .HasColumnName("saldo");
            entity.Property(e => e.TipoConta)
                .HasMaxLength(20)
                .HasColumnName("tipo_conta");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Conta)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("contas_cliente_id_fkey");
        });

        modelBuilder.Entity<Emprestimo>(entity =>
        {
            entity.HasKey(e => e.EmprestimoId).HasName("emprestimos_pkey");

            entity.ToTable("emprestimos");

            entity.Property(e => e.EmprestimoId)
                .ValueGeneratedNever()
                .HasColumnName("emprestimo_id");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.DataConcessao).HasColumnName("data_concessao");
            entity.Property(e => e.DataVencimento).HasColumnName("data_vencimento");
            entity.Property(e => e.TaxaJuros)
                .HasPrecision(5, 2)
                .HasColumnName("taxa_juros");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 2)
                .HasColumnName("valor");

            entity.HasOne(d => d.Cliente).WithMany(p => p.Emprestimos)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("emprestimos_cliente_id_fkey");
        });

        modelBuilder.Entity<HistoricoDeCredito>(entity =>
        {
            entity.HasKey(e => e.HistoricoId).HasName("historico_de_credito_pkey");

            entity.ToTable("historico_de_credito");

            entity.Property(e => e.HistoricoId)
                .ValueGeneratedNever()
                .HasColumnName("historico_id");
            entity.Property(e => e.ClienteId).HasColumnName("cliente_id");
            entity.Property(e => e.Data).HasColumnName("data");
            entity.Property(e => e.Descricao).HasColumnName("descricao");

            entity.HasOne(d => d.Cliente).WithMany(p => p.HistoricoDeCreditos)
                .HasForeignKey(d => d.ClienteId)
                .HasConstraintName("historico_de_credito_cliente_id_fkey");
        });

        modelBuilder.Entity<Pagamento>(entity =>
        {
            entity.HasKey(e => e.PagamentoId).HasName("pagamentos_pkey");

            entity.ToTable("pagamentos");

            entity.Property(e => e.PagamentoId)
                .ValueGeneratedNever()
                .HasColumnName("pagamento_id");
            entity.Property(e => e.DataPagamento).HasColumnName("data_pagamento");
            entity.Property(e => e.EmprestimoId).HasColumnName("emprestimo_id");
            entity.Property(e => e.Valor)
                .HasPrecision(10, 2)
                .HasColumnName("valor");

            entity.HasOne(d => d.Emprestimo).WithMany(p => p.Pagamentos)
                .HasForeignKey(d => d.EmprestimoId)
                .HasConstraintName("pagamentos_emprestimo_id_fkey");
        });
        modelBuilder.Entity<Usuario>(entity =>{
            entity.HasKey(e => e.UsuarioId);
            entity.Property(e => e.UsuarioId).ValueGeneratedOnAdd();
            entity.HasIndex(e => e.CPF).IsUnique();
            entity.HasIndex(e=> e.Email).IsUnique();
            entity.Property(e => e.NomeCompleto).HasMaxLength(100);
            entity.Property(e=> e.CPF).HasMaxLength(11);
            

            });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
