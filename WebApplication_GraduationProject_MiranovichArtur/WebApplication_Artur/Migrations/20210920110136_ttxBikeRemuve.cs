using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class ttxBikeRemuve : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Chainrings",
                table: "Shareds");

            migrationBuilder.DropColumn(
                name: "WheelDiametr",
                table: "Shareds");

            migrationBuilder.AlterColumn<long>(
                name: "WheelDiameter",
                table: "Shareds",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<long>(
                name: "FrontChainrings",
                table: "Shareds",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RearChainrings",
                table: "Shareds",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FrontChainrings",
                table: "Shareds");

            migrationBuilder.DropColumn(
                name: "RearChainrings",
                table: "Shareds");

            migrationBuilder.AlterColumn<int>(
                name: "WheelDiameter",
                table: "Shareds",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<int>(
                name: "Chainrings",
                table: "Shareds",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "WheelDiametr",
                table: "Shareds",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
