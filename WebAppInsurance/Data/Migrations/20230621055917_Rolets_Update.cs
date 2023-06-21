using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppInsurance.Data.Migrations
{
    /// <inheritdoc />
    public partial class Rolets_Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AdditionalOption",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalOption1",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalOption2",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalOption3",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalOption4",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AdditionalOption5",
                table: "Insurance",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdditionalOption",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "AdditionalOption1",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "AdditionalOption2",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "AdditionalOption3",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "AdditionalOption4",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "AdditionalOption5",
                table: "Insurance");
        }
    }
}
