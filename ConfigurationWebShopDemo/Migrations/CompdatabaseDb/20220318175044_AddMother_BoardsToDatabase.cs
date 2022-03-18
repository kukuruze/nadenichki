using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationWebShopDemo.Migrations.CompdatabaseDb
{
    public partial class AddMother_BoardsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HDDs",
                columns: table => new
                {
                    hdd_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    hdd_capacity = table.Column<string>(nullable: false),
                    hdd_price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HDDs", x => x.hdd_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HDDs");
        }
    }
}
