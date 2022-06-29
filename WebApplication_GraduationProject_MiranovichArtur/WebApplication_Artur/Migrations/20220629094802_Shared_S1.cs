using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class Shared_S1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Size",
                table: "Shareds",
                newName: "BikeSize");

            migrationBuilder.AlterColumn<long>(
                name: "WheelDiametr",
                table: "Shareds",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BikeSize",
                table: "Shareds",
                newName: "Size");

            migrationBuilder.AlterColumn<int>(
                name: "WheelDiametr",
                table: "Shareds",
                type: "int",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");
        }
    }
}
