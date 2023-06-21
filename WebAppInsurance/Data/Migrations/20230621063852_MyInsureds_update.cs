using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAppInsurance.Data.Migrations
{
    /// <inheritdoc />
    public partial class MyInsureds_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "InsuranceId",
                table: "Insurance",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Insurance_InsuranceId",
                table: "Insurance",
                column: "InsuranceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Insurance_Insurance_InsuranceId",
                table: "Insurance",
                column: "InsuranceId",
                principalTable: "Insurance",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Insurance_Insurance_InsuranceId",
                table: "Insurance");

            migrationBuilder.DropIndex(
                name: "IX_Insurance_InsuranceId",
                table: "Insurance");

            migrationBuilder.DropColumn(
                name: "InsuranceId",
                table: "Insurance");

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
    }
}
