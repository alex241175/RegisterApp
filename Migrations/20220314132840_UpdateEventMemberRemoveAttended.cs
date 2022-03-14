using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterApp.Migrations
{
    public partial class UpdateEventMemberRemoveAttended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attended",
                table: "EventMembers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Attended",
                table: "EventMembers",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
