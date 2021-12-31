using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterApp.Migrations
{
    public partial class UpdateEventOneToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_EventMembers_EventId",
                table: "EventMembers",
                column: "EventId");

            migrationBuilder.AddForeignKey(
                name: "FK_EventMembers_Events_EventId",
                table: "EventMembers",
                column: "EventId",
                principalTable: "Events",
                principalColumn: "EventId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EventMembers_Events_EventId",
                table: "EventMembers");

            migrationBuilder.DropIndex(
                name: "IX_EventMembers_EventId",
                table: "EventMembers");
        }
    }
}
