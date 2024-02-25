using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutDetails1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDetails2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutImage1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutMapLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                });

            migrationBuilder.CreateTable(
                name: "Advertisers",
                columns: table => new
                {
                    AdvertiserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertiserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiserAbout = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiserMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiserPassword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiserPassword1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiserStatus = table.Column<bool>(type: "bit", nullable: false),
                    AdvertiserImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertisers", x => x.AdvertiserID);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactSubject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "Estates",
                columns: table => new
                {
                    EstateID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EstateTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateImage2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateImage3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateImage4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateImage5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstatePrice = table.Column<int>(type: "int", nullable: false),
                    EstateOzellik1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik4 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik5 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik6 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik7 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik8 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik9 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik10 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik11 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik12 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik13 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik14 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateOzellik15 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EstateCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstateStatus = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    AdvertiserID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Estates", x => x.EstateID);
                    table.ForeignKey(
                        name: "FK_Estates_Advertisers_AdvertiserID",
                        column: x => x.AdvertiserID,
                        principalTable: "Advertisers",
                        principalColumn: "AdvertiserID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Estates_Categories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CommentStatus = table.Column<bool>(type: "bit", nullable: false),
                    EstateID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentID);
                    table.ForeignKey(
                        name: "FK_Comments_Estates_EstateID",
                        column: x => x.EstateID,
                        principalTable: "Estates",
                        principalColumn: "EstateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_EstateID",
                table: "Comments",
                column: "EstateID");

            migrationBuilder.CreateIndex(
                name: "IX_Estates_AdvertiserID",
                table: "Estates",
                column: "AdvertiserID");

            migrationBuilder.CreateIndex(
                name: "IX_Estates_CategoryID",
                table: "Estates",
                column: "CategoryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Estates");

            migrationBuilder.DropTable(
                name: "Advertisers");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
