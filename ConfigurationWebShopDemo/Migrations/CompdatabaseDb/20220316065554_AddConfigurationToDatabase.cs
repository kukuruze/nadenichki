using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationWebShopDemo.Migrations.CompdatabaseDb
{
    public partial class AddConfigurationToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Configurations",
                columns: table => new
                {
                    ConfigurationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MotherBoard = table.Column<string>(nullable: false),
                    SSD = table.Column<string>(nullable: false),
                    HDD = table.Column<string>(nullable: false),
                    RAM = table.Column<string>(nullable: false),
                    CPU = table.Column<string>(nullable: false),
                    GPU = table.Column<string>(nullable: false),
                    SoundCard = table.Column<string>(nullable: false),
                    WWANCard = table.Column<string>(nullable: false),
                    Computer_Case = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Configurations", x => x.ConfigurationId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Configurations");
        }
    }
}
