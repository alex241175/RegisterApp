using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RegisterApp.Migrations
{
    public partial class UpdateEventAddMode : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Mode",
                table: "Events",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Mode",
                table: "Events");
        }
    }
}
