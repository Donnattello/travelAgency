using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travelAgency.Data.Migrations
{
    public partial class InitialCreatew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UStatus",
                table: "User",
                newName: "URole");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "URole",
                table: "User",
                newName: "UStatus");
        }
    }
}
