using Microsoft.EntityFrameworkCore.Migrations;

namespace EvoComputerTechService.Migrations
{
    public partial class IssuePicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IssuePicture",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IssuePicture",
                table: "Issues");
        }
    }
}
