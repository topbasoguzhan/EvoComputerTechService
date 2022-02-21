using Microsoft.EntityFrameworkCore.Migrations;

namespace EvoComputerTechService.Migrations
{
    public partial class AddIssue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IssueStates",
                table: "Issues",
                newName: "IssueState");

            migrationBuilder.RenameColumn(
                name: "CreateDate",
                table: "Issues",
                newName: "CreatedDate");

            migrationBuilder.AlterColumn<string>(
                name: "Longitude",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AlterColumn<string>(
                name: "Latitude",
                table: "Issues",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IssueState",
                table: "Issues",
                newName: "IssueStates");

            migrationBuilder.RenameColumn(
                name: "CreatedDate",
                table: "Issues",
                newName: "CreateDate");

            migrationBuilder.AlterColumn<double>(
                name: "Longitude",
                table: "Issues",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Latitude",
                table: "Issues",
                type: "float",
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
