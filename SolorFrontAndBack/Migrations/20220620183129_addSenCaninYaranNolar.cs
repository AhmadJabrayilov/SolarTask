using Microsoft.EntityFrameworkCore.Migrations;

namespace SolorFrontAndBack.Migrations
{
    public partial class addSenCaninYaranNolar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Team2",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageUrl2 = table.Column<string>(nullable: true),
                    Name2 = table.Column<string>(nullable: true),
                    position2 = table.Column<string>(nullable: true),
                    EmpDesc2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team2", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Team2");
        }
    }
}
