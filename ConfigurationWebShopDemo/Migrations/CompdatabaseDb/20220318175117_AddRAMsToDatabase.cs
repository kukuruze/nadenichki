using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationWebShopDemo.Migrations.CompdatabaseDb
{
    public partial class AddRAMsToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "RAMs",
               columns: table => new
               {
                   ram_id = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   ram_capacity = table.Column<string>(nullable: false),
                   ram_price = table.Column<decimal>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_RAMs", x => x.ram_id);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RAMs");
        }
    }
}
