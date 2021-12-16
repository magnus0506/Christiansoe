using Microsoft.EntityFrameworkCore.Migrations;

namespace Christiansoe.Data.Migrations
{
    public partial class newanimaldetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "Animal",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "Animal");
        }
    }
}
