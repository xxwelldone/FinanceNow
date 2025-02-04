using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FinanceNow.Migrations
{
    /// <inheritdoc />
    public partial class Proposta : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "solicitacoes",
                columns: table => new
                {
                    SolicitacaoId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<int>(type: "integer", nullable: false),
                    ValorSolicitado = table.Column<double>(type: "double precision", nullable: false),
                    Emergencia = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_solicitacoes", x => x.SolicitacaoId);
                    table.ForeignKey(
                        name: "FK_solicitacoes_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "cliente_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "analises",
                columns: table => new
                {
                    AnaliseId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PermitirProposta = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    Score = table.Column<double>(type: "double precision", nullable: false),
                    SolicitacaoId = table.Column<int>(type: "integer", nullable: false),
                    ClienteId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_analises", x => x.AnaliseId);
                    table.ForeignKey(
                        name: "FK_analises_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "cliente_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_analises_solicitacoes_SolicitacaoId",
                        column: x => x.SolicitacaoId,
                        principalTable: "solicitacoes",
                        principalColumn: "SolicitacaoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "propostas",
                columns: table => new
                {
                    PropostaId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ValorDisponibilizado = table.Column<double>(type: "double precision", nullable: false),
                    Juros = table.Column<double>(type: "double precision", nullable: false),
                    DataDisponivel = table.Column<DateOnly>(type: "date", nullable: false),
                    DataQuitar = table.Column<DateOnly>(type: "date", nullable: false),
                    ClienteId = table.Column<int>(type: "integer", nullable: false),
                    AnaliseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_propostas", x => x.PropostaId);
                    table.ForeignKey(
                        name: "FK_propostas_analises_AnaliseId",
                        column: x => x.AnaliseId,
                        principalTable: "analises",
                        principalColumn: "AnaliseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_propostas_clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "clientes",
                        principalColumn: "cliente_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_analises_ClienteId",
                table: "analises",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_analises_SolicitacaoId",
                table: "analises",
                column: "SolicitacaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_propostas_AnaliseId",
                table: "propostas",
                column: "AnaliseId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_propostas_ClienteId",
                table: "propostas",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_solicitacoes_ClienteId",
                table: "solicitacoes",
                column: "ClienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "propostas");

            migrationBuilder.DropTable(
                name: "analises");

            migrationBuilder.DropTable(
                name: "solicitacoes");
        }
    }
}
