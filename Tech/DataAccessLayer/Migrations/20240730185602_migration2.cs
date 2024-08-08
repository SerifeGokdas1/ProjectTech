using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ServiceText",
                table: "Sliders",
                newName: "SliderText");

            migrationBuilder.RenameColumn(
                name: "ServiceHeader",
                table: "Sliders",
                newName: "SliderHeader");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SliderText",
                table: "Sliders",
                newName: "ServiceText");

            migrationBuilder.RenameColumn(
                name: "SliderHeader",
                table: "Sliders",
                newName: "ServiceHeader");
        }
    }
}
