using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class newmig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Advertisers_AdvertiserID",
                table: "Estates");

            migrationBuilder.AlterColumn<int>(
                name: "AdvertiserID",
                table: "Estates",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Advertisers_AdvertiserID",
                table: "Estates",
                column: "AdvertiserID",
                principalTable: "Advertisers",
                principalColumn: "AdvertiserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Estates_Advertisers_AdvertiserID",
                table: "Estates");

            migrationBuilder.AlterColumn<int>(
                name: "AdvertiserID",
                table: "Estates",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Estates_Advertisers_AdvertiserID",
                table: "Estates",
                column: "AdvertiserID",
                principalTable: "Advertisers",
                principalColumn: "AdvertiserID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
