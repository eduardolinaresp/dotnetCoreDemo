using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleDemoApp.Migrations
{
    public partial class initial_create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TblStudents",
                columns: table => new
                {
                    NroStudent = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdStudent = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Nombre = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Clase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TblStudents", x => x.NroStudent);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TblStudents");
        }
    }
}
