using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace FinanceNow.Migrations
{
    /// <inheritdoc />
    public partial class Usuario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    UsuarioId = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    NomeCompleto = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DataNascimento = table.Column<DateOnly>(type: "date", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    Celular = table.Column<string>(type: "text", nullable: true),
                    CPF = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: true),
                    Password = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.UsuarioId);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.DropTable(
                name: "Usuarios");

          
        }
    }
}
