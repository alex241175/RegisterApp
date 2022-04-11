using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterApp.Migrations
{
    public partial class AddSurveyFunction2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Survey1Default",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Survey2Default",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Survey2Option",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Survey2Question",
                table: "Events",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Survey2Answer",
                table: "EventMembers",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Survey1Default",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Survey2Default",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Survey2Option",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Survey2Question",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "Survey2Answer",
                table: "EventMembers");
        }
    }
}
