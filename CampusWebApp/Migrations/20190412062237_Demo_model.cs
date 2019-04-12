using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CampusWebApp.Migrations
{
    public partial class Demo_model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Prospect",
                table: "Prospect");

            migrationBuilder.RenameTable(
                name: "Prospect",
                newName: "Prospects");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prospects",
                table: "Prospects",
                column: "ProspectId");

            migrationBuilder.CreateTable(
                name: "Demos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Office = table.Column<string>(nullable: true),
                    Extn = table.Column<int>(nullable: false),
                    StartDate = table.Column<DateTime>(nullable: false),
                    Salary = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Demos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Demos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prospects",
                table: "Prospects");

            migrationBuilder.RenameTable(
                name: "Prospects",
                newName: "Prospect");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prospect",
                table: "Prospect",
                column: "ProspectId");
        }
    }
}
