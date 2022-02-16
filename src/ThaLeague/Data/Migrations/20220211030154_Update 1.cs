using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThaLeague.Data.Migrations
{
    public partial class Update1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audio_Artist_ArtistId",
                table: "Audio");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Audio",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Credits",
                table: "Audio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Featuring",
                table: "Audio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lyrics",
                table: "Audio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Producer",
                table: "Audio",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Audio_Artist_ArtistId",
                table: "Audio",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Audio_Artist_ArtistId",
                table: "Audio");

            migrationBuilder.DropColumn(
                name: "Credits",
                table: "Audio");

            migrationBuilder.DropColumn(
                name: "Featuring",
                table: "Audio");

            migrationBuilder.DropColumn(
                name: "Lyrics",
                table: "Audio");

            migrationBuilder.DropColumn(
                name: "Producer",
                table: "Audio");

            migrationBuilder.AlterColumn<int>(
                name: "ArtistId",
                table: "Audio",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Audio_Artist_ArtistId",
                table: "Audio",
                column: "ArtistId",
                principalTable: "Artist",
                principalColumn: "ArtistId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
