using Microsoft.EntityFrameworkCore.Migrations;

namespace SolorFrontAndBack.Migrations
{
    public partial class addTeam1Team2Tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EmpDesc2",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "ImageUrl2",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "Name2",
                table: "Team");

            migrationBuilder.DropColumn(
                name: "position2",
                table: "Team");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpDesc2",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl2",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name2",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "position2",
                table: "Team",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
