using Microsoft.EntityFrameworkCore.Migrations;

namespace ENG.Lily.Infrastructure.Repository.Migrations
{
    public partial class _80 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Verified",
                table: "User",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Verified",
                table: "User");
        }
    }
}
