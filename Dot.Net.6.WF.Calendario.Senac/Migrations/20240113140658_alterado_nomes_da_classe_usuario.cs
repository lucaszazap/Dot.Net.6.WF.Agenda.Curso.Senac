using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dot.Net._6.WF.Calendario.Senac.Migrations
{
    public partial class alterado_nomes_da_classe_usuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Usuarios",
                newName: "Cpf");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Usuarios",
                newName: "DataNascimento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataNascimento",
                table: "Usuarios",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "Cpf",
                table: "Usuarios",
                newName: "Nome");
        }
    }
}
