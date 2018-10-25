using Microsoft.EntityFrameworkCore.Migrations;

namespace ENG.Lily.Infrastructure.Repository.Migrations
{
    public partial class _70 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Phrase",
                table: "User",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Phrase",
                table: "User");
        }
    }
}
