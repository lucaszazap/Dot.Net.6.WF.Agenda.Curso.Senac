using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dot.Net._6.WF.Calendario.Senac.Migrations
{
    public partial class Alterado_ID_por_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Usuarios",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuarios",
                newName: "ID");
        }
    }
}
