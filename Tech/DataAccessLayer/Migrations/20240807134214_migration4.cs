using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migration4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactMails",
                columns: table => new
                {
                    ContactMailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ContactNameSurname = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    ContactMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactMailSubject = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactMailMessage = table.Column<string>(type: "nvarchar(350)", maxLength: 350, nullable: false),
                    ContactMailDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactMailStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactMails", x => x.ContactMailId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactMails");
        }
    }
}
