using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThaLeague.Data.Migrations
{
    public partial class Update2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ColorPicker",
                table: "Artist",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "DisplayName",
                table: "Artist",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Artist",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "ColorPicker",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "DisplayName",
                table: "Artist");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Artist");
        }
    }
}
