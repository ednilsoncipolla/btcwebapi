using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace btc.Data.Migrations
{
    public partial class Fist_Migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Revendedores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreateAt = table.Column<DateTime>(nullable: true),
                    UpdateAt = table.Column<DateTime>(nullable: true),
                    Ativo = table.Column<bool>(nullable: true),
                    NomeCompleto = table.Column<string>(maxLength: 100, nullable: false),
                    CPF = table.Column<string>(nullable: true),
                    Email = table.Column<string>(maxLength: 100, nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revendedores", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Revendedores_Email",
                table: "Revendedores",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Revendedores");
        }
    }
}
