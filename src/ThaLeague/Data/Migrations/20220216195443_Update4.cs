using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThaLeague.Data.Migrations
{
    public partial class Update4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Spotify",
                table: "Audio",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Spotify",
                table: "Audio");
        }
    }
}
