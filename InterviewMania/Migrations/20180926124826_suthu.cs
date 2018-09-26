using Microsoft.EntityFrameworkCore.Migrations;

namespace InterviewMania.Migrations
{
    public partial class suthu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PostDescription",
                table: "Posts",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostDescription",
                table: "Posts");
        }
    }
}
