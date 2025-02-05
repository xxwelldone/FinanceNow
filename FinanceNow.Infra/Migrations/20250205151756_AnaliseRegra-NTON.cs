using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceNow.Migrations
{
    /// <inheritdoc />
    public partial class AnaliseRegraNTON : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnaliseRegra_analises_AnaliseId",
                table: "AnaliseRegra");

            migrationBuilder.DropForeignKey(
                name: "FK_AnaliseRegra_regras_RegraId",
                table: "AnaliseRegra");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnaliseRegra",
                table: "AnaliseRegra");

            migrationBuilder.RenameTable(
                name: "AnaliseRegra",
                newName: "analiseregras");

            migrationBuilder.RenameIndex(
                name: "IX_AnaliseRegra_RegraId",
                table: "analiseregras",
                newName: "IX_analiseregras_RegraId");

            migrationBuilder.RenameIndex(
                name: "IX_AnaliseRegra_AnaliseId",
                table: "analiseregras",
                newName: "IX_analiseregras_AnaliseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_analiseregras",
                table: "analiseregras",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_analiseregras_analises_AnaliseId",
                table: "analiseregras",
                column: "AnaliseId",
                principalTable: "analises",
                principalColumn: "AnaliseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_analiseregras_regras_RegraId",
                table: "analiseregras",
                column: "RegraId",
                principalTable: "regras",
                principalColumn: "RegraId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_analiseregras_analises_AnaliseId",
                table: "analiseregras");

            migrationBuilder.DropForeignKey(
                name: "FK_analiseregras_regras_RegraId",
                table: "analiseregras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_analiseregras",
                table: "analiseregras");

            migrationBuilder.RenameTable(
                name: "analiseregras",
                newName: "AnaliseRegra");

            migrationBuilder.RenameIndex(
                name: "IX_analiseregras_RegraId",
                table: "AnaliseRegra",
                newName: "IX_AnaliseRegra_RegraId");

            migrationBuilder.RenameIndex(
                name: "IX_analiseregras_AnaliseId",
                table: "AnaliseRegra",
                newName: "IX_AnaliseRegra_AnaliseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnaliseRegra",
                table: "AnaliseRegra",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnaliseRegra_analises_AnaliseId",
                table: "AnaliseRegra",
                column: "AnaliseId",
                principalTable: "analises",
                principalColumn: "AnaliseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AnaliseRegra_regras_RegraId",
                table: "AnaliseRegra",
                column: "RegraId",
                principalTable: "regras",
                principalColumn: "RegraId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
