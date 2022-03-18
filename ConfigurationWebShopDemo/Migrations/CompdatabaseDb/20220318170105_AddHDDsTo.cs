using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationWebShopDemo.Migrations.CompdatabaseDb
{
    public partial class AddHDDsTo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GPU");

            migrationBuilder.CreateTable(
                name: "GPUs",
                columns: table => new
                {
                    gpu_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gpu_model = table.Column<string>(nullable: false),
                    gpu_price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GPUs", x => x.gpu_id);
                });

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
                name: "GPUs");

            migrationBuilder.DropTable(
                name: "HDDs");

            migrationBuilder.CreateTable(
                name: "GPU",
                columns: table => new
                {
                    gpu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    gpu_model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gpu_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.gpu_id);
                });
        }
    }
}
