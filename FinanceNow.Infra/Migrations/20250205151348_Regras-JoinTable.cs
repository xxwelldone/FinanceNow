using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FinanceNow.Migrations
{
    /// <inheritdoc />
    public partial class RegrasJoinTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_regras_analises_AnaliseId",
                table: "regras");

            migrationBuilder.DropIndex(
                name: "IX_regras_AnaliseId",
                table: "regras");

            migrationBuilder.DropColumn(
                name: "AnaliseId",
                table: "regras");

            migrationBuilder.CreateTable(
                name: "AnaliseRegra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnaliseId = table.Column<int>(type: "integer", nullable: false),
                    RegraId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnaliseRegra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AnaliseRegra_analises_AnaliseId",
                        column: x => x.AnaliseId,
                        principalTable: "analises",
                        principalColumn: "AnaliseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AnaliseRegra_regras_RegraId",
                        column: x => x.RegraId,
                        principalTable: "regras",
                        principalColumn: "RegraId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnaliseRegra_AnaliseId",
                table: "AnaliseRegra",
                column: "AnaliseId");

            migrationBuilder.CreateIndex(
                name: "IX_AnaliseRegra_RegraId",
                table: "AnaliseRegra",
                column: "RegraId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnaliseRegra");

            migrationBuilder.AddColumn<int>(
                name: "AnaliseId",
                table: "regras",
                type: "integer",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_regras_AnaliseId",
                table: "regras",
                column: "AnaliseId");

            migrationBuilder.AddForeignKey(
                name: "FK_regras_analises_AnaliseId",
                table: "regras",
                column: "AnaliseId",
                principalTable: "analises",
                principalColumn: "AnaliseId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
