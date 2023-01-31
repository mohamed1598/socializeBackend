using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Socialize.DataAccess.Migrations
{
    public partial class CreatingSecondPackageModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Packages",
                newName: "UserName");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Facebook",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Instagram",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PersonalWebsite",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Twitter",
                table: "Packages",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Facebook",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Instagram",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PersonalWebsite",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Packages");

            migrationBuilder.DropColumn(
                name: "Twitter",
                table: "Packages");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Packages",
                newName: "Name");
        }
    }
}
