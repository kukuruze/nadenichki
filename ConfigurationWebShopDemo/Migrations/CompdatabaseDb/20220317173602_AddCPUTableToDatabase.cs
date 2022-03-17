using Microsoft.EntityFrameworkCore.Migrations;

namespace ConfigurationWebShopDemo.Migrations.CompdatabaseDb
{
    public partial class AddCPUTableToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Configurations",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "ConfigurationId",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "MotherBoard",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "SoundCard",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "WWANCard",
                table: "Configurations");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Configurations",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Configuration_Id",
                table: "Configurations",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Mother_Board",
                table: "Configurations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sound_Card",
                table: "Configurations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WWAN_Card",
                table: "Configurations",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Configurations",
                table: "Configurations",
                column: "Configuration_Id");

            migrationBuilder.CreateTable(
                name: "CPU",
                columns: table => new
                {
                    cpu_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cpu_model = table.Column<string>(nullable: false),
                    cpu_price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CPU", x => x.cpu_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CPU");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Configurations",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "Configuration_Id",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "Mother_Board",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "Sound_Card",
                table: "Configurations");

            migrationBuilder.DropColumn(
                name: "WWAN_Card",
                table: "Configurations");

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal));

            migrationBuilder.AddColumn<int>(
                name: "ConfigurationId",
                table: "Configurations",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "MotherBoard",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SoundCard",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "WWANCard",
                table: "Configurations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Configurations",
                table: "Configurations",
                column: "ConfigurationId");
        }
    }
}
