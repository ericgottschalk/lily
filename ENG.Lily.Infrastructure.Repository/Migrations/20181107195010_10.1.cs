using Microsoft.EntityFrameworkCore.Migrations;

namespace ENG.Lily.Infrastructure.Repository.Migrations
{
    public partial class _101 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WhyInvest",
                table: "Project");

            migrationBuilder.AddColumn<string>(
                name: "WebSite",
                table: "Project",
                maxLength: 750,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "WebSite",
                table: "Project");

            migrationBuilder.AddColumn<string>(
                name: "WhyInvest",
                table: "Project",
                maxLength: 750,
                nullable: false,
                defaultValue: "");
        }
    }
}
