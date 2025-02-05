using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinanceNow.Migrations
{
    /// <inheritdoc />
    public partial class FixNameAnaliseRegra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                newName: "analise_regras");

            migrationBuilder.RenameIndex(
                name: "IX_analiseregras_RegraId",
                table: "analise_regras",
                newName: "IX_analise_regras_RegraId");

            migrationBuilder.RenameIndex(
                name: "IX_analiseregras_AnaliseId",
                table: "analise_regras",
                newName: "IX_analise_regras_AnaliseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_analise_regras",
                table: "analise_regras",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_analise_regras_analises_AnaliseId",
                table: "analise_regras",
                column: "AnaliseId",
                principalTable: "analises",
                principalColumn: "AnaliseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_analise_regras_regras_RegraId",
                table: "analise_regras",
                column: "RegraId",
                principalTable: "regras",
                principalColumn: "RegraId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_analise_regras_analises_AnaliseId",
                table: "analise_regras");

            migrationBuilder.DropForeignKey(
                name: "FK_analise_regras_regras_RegraId",
                table: "analise_regras");

            migrationBuilder.DropPrimaryKey(
                name: "PK_analise_regras",
                table: "analise_regras");

            migrationBuilder.RenameTable(
                name: "analise_regras",
                newName: "analiseregras");

            migrationBuilder.RenameIndex(
                name: "IX_analise_regras_RegraId",
                table: "analiseregras",
                newName: "IX_analiseregras_RegraId");

            migrationBuilder.RenameIndex(
                name: "IX_analise_regras_AnaliseId",
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
    }
}
