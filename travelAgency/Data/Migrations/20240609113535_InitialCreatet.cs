using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travelAgency.Data.Migrations
{
    public partial class InitialCreatet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Uage",
                table: "User");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Uage",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
