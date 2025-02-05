using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FinanceNow.Migrations
{
    /// <inheritdoc />
    public partial class Regras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "regras",
                columns: table => new
                {
                    RegraId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descricao = table.Column<string>(type: "text", nullable: true),
                    TipoRegra = table.Column<string>(type: "text", nullable: false),
                    Operador = table.Column<string>(type: "text", nullable: false),
                    ValorComparacao = table.Column<double>(type: "double precision", nullable: false),
                    Peso = table.Column<double>(type: "double precision", nullable: false),
                    Ativo = table.Column<bool>(type: "boolean", nullable: false),
                    AnaliseId = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_regras", x => x.RegraId);
                    table.ForeignKey(
                        name: "FK_regras_analises_AnaliseId",
                        column: x => x.AnaliseId,
                        principalTable: "analises",
                        principalColumn: "AnaliseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_regras_AnaliseId",
                table: "regras",
                column: "AnaliseId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "regras");
        }
    }
}
