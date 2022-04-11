using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterApp.Migrations
{
    public partial class AddSurveyFunction : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Survey1Option",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Survey1Question",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Survey1Answer",
                table: "EventMembers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Survey1Option",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Survey1Question",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Survey1Answer",
                table: "EventMembers");
        }
    }
}
