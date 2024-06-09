using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace travelAgency.Data.Migrations
{
    public partial class InitialCreateq : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "sex",
                table: "User",
                newName: "Usex");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "User",
                newName: "Uage");

            migrationBuilder.RenameColumn(
                name: "Tel",
                table: "User",
                newName: "UTel");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "User",
                newName: "UStatus");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "User",
                newName: "UName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "User",
                newName: "ULastName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "User",
                newName: "UEmail");

            migrationBuilder.AddColumn<string>(
                name: "UPassword",
                table: "User",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UPassword",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "Usex",
                table: "User",
                newName: "sex");

            migrationBuilder.RenameColumn(
                name: "Uage",
                table: "User",
                newName: "age");

            migrationBuilder.RenameColumn(
                name: "UTel",
                table: "User",
                newName: "Tel");

            migrationBuilder.RenameColumn(
                name: "UStatus",
                table: "User",
                newName: "Status");

            migrationBuilder.RenameColumn(
                name: "UName",
                table: "User",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "ULastName",
                table: "User",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "UEmail",
                table: "User",
                newName: "LastName");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
