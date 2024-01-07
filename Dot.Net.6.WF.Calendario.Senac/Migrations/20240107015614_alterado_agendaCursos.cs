using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Dot.Net._6.WF.Calendario.Senac.Migrations
{
    public partial class alterado_agendaCursos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AgendamentoCursos",
                table: "AgendamentoCursos");

            migrationBuilder.RenameTable(
                name: "AgendamentoCursos",
                newName: "AgendaCursos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgendaCursos",
                table: "AgendaCursos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AgendaCursos",
                table: "AgendaCursos");

            migrationBuilder.RenameTable(
                name: "AgendaCursos",
                newName: "AgendamentoCursos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AgendamentoCursos",
                table: "AgendamentoCursos",
                column: "Id");
        }
    }
}
