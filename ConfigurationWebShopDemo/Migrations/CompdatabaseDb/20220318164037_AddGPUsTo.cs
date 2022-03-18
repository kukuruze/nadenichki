using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationWebShopDemo.Migrations.CompdatabaseDb
{
    public partial class AddGPUsTo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.CreateTable(
                name: "CPUs",
                columns: table => new
                {
                    cpu_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpu_model = table.Column<string>(nullable: false),
                    cpu_price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPUs", x => x.cpu_id);
                });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPUs");

            migrationBuilder.DropTable(
                name: "GPUs");

            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    cpu_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpu_model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cpu_price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.cpu_id);
                });
        }
    }
}
