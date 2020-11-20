using Microsoft.EntityFrameworkCore.Migrations;

namespace sudoku.Migrations
{
    public partial class AddLevelIdInUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EasyId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HardId",
                table: "User",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MediumId",
                table: "User",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EasyId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "HardId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MediumId",
                table: "User");
        }
    }
}
