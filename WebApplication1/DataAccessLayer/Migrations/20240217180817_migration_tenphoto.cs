using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class migration_tenphoto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EstateImage6",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstateImage7",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstateImage8",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstateImage9",
                table: "Estates",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstateImage6",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "EstateImage7",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "EstateImage8",
                table: "Estates");

            migrationBuilder.DropColumn(
                name: "EstateImage9",
                table: "Estates");
        }
    }
}
