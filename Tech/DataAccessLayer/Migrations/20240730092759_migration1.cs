using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migration1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AboutTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutDetail = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    AboutFirstImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutFirstSentence = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    AboutSecondSentence = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    AboutThirdSentence = table.Column<string>(type: "nvarchar(65)", maxLength: 65, nullable: false),
                    AboutSecondImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutFirstTitle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AboutFirstExplanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutSecondTitle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AboutSecondExplanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutThirdTitle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AboutThirdExplanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutFourthTitle = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    AboutFourthExplanation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AboutFooterImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AboutFooterTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AboutFooterText = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    AboutStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    AdminId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdminNameSurname = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    AdminImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminPassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdminStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.AdminId);
                });

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    BlogId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogThumbnailImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BlogCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BlogWriterId = table.Column<int>(type: "int", nullable: true),
                    BlogStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.BlogId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactMobilePhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInstagram = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactYoutube = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactFacebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactX = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactLinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "ServiceHeaders",
                columns: table => new
                {
                    ServiceHeaderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceHeaderKeyword = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    ServiceHeaderDescription = table.Column<string>(type: "nvarchar(110)", maxLength: 110, nullable: false),
                    ServiceHeaderStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServiceHeaders", x => x.ServiceHeaderId);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    ServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(35)", maxLength: 35, nullable: false),
                    ServiceTitle = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ServiceDescription = table.Column<string>(type: "nvarchar(1300)", maxLength: 1300, nullable: false),
                    ServiceImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstEffectiveSentence = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    SecondEffectiveSentence = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ThirdEffectiveSentence = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    ServiceStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.ServiceId);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    SliderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceHeader = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    ServiceText = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    SliderImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderVideoLink = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.SliderId);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    TeamMemberId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamMemberNameSurname = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TeamMemberImage = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TeamMemberLinkedIn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SliderStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.TeamMemberId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "ServiceHeaders");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
