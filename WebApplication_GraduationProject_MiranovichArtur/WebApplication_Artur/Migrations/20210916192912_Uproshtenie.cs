using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class Uproshtenie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Brakes");

            migrationBuilder.DropTable(
                name: "Wheels");

            migrationBuilder.AddColumn<long>(
                name: "BrakeDiametr",
                table: "Switches",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<int>(
                name: "WheelDiameter",
                table: "Switches",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BrakeDiametr",
                table: "Switches");

            migrationBuilder.DropColumn(
                name: "WheelDiameter",
                table: "Switches");

            migrationBuilder.CreateTable(
                name: "Brakes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Diametr = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brakes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Brakes_Bikes_Id",
                        column: x => x.Id,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wheels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Diameter = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheels", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Wheels_Bikes_Id",
                        column: x => x.Id,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }
    }
}
