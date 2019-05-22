using Microsoft.EntityFrameworkCore.Migrations;

namespace CampusApp.Migrations
{
    public partial class spGetStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            var sp = @"CREATE PROCEDURE [dbo].[GetStudents]
                    @LastName varchar(50)
                AS
                BEGIN
                    SET NOCOUNT ON;
                    select * from Students where LastName like @LastName +'%'
                END";

            migrationBuilder.Sql(sp);

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
