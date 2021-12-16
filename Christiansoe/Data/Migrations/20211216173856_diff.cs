using Microsoft.EntityFrameworkCore.Migrations;

namespace Christiansoe.Data.Migrations
{
    public partial class diff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageName",
                table: "Animal");

            migrationBuilder.AddColumn<int>(
                name: "Difficulty",
                table: "Assignment",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Difficulty",
                table: "Assignment");

            migrationBuilder.AddColumn<string>(
                name: "ImageName",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
