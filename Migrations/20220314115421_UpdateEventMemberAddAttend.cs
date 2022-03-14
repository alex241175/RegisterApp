using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterApp.Migrations
{
    public partial class UpdateEventMemberAddAttend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Attend",
                table: "EventMembers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Attend",
                table: "EventMembers");
        }
    }
}
