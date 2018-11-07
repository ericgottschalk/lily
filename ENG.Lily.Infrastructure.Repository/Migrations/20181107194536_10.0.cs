using Microsoft.EntityFrameworkCore.Migrations;

namespace ENG.Lily.Infrastructure.Repository.Migrations
{
    public partial class _100 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hash",
                table: "Project",
                maxLength: 64,
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Project_Hash",
                table: "Project",
                column: "Hash",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Project_Hash",
                table: "Project");

            migrationBuilder.DropColumn(
                name: "Hash",
                table: "Project");
        }
    }
}
