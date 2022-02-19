using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterApp.Migrations
{
    public partial class EventMemberAddRemark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Remark",
                table: "EventMembers",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Remark",
                table: "EventMembers");
        }
    }
}
