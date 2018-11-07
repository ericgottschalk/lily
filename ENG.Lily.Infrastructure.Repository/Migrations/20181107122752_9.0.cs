using Microsoft.EntityFrameworkCore.Migrations;

namespace ENG.Lily.Infrastructure.Repository.Migrations
{
    public partial class _90 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CoverUrl",
                table: "Project",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CoverUrl",
                table: "Project");
        }
    }
}
