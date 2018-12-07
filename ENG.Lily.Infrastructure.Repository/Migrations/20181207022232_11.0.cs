using Microsoft.EntityFrameworkCore.Migrations;

namespace ENG.Lily.Infrastructure.Repository.Migrations
{
    public partial class _110 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreditCardCompany",
                table: "Fund");

            migrationBuilder.AddColumn<decimal>(
                name: "Budget",
                table: "Project",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "TaxId",
                table: "Fund",
                maxLength: 20,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Budget",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "Fund");

            migrationBuilder.AddColumn<int>(
                name: "CreditCardCompany",
                table: "Fund",
                nullable: false,
                defaultValue: 0);
        }
    }
}
