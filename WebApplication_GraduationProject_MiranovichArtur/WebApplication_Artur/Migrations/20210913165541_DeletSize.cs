using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class DeletSize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BikeSwitch");

            migrationBuilder.DropColumn(
                name: "WhellSize",
                table: "Wheels");

            migrationBuilder.DropColumn(
                name: "SwitchSize",
                table: "Switches");

            migrationBuilder.DropColumn(
                name: "BrakeSize",
                table: "Brakes");

            migrationBuilder.AddColumn<int>(
                name: "Сurrency",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 3);

            migrationBuilder.AddColumn<int>(
                name: "Chainrings",
                table: "Switches",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<int>(
                name: "Rearstars",
                table: "Switches",
                type: "int",
                nullable: false,
                defaultValue: 1);

            migrationBuilder.AddColumn<long>(
                name: "Diametr",
                table: "Brakes",
                type: "bigint",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "BikeGearSelector",
                columns: table => new
                {
                    BikesId = table.Column<long>(type: "bigint", nullable: false),
                    SwitchesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeGearSelector", x => new { x.BikesId, x.SwitchesId });
                    table.ForeignKey(
                        name: "FK_BikeGearSelector_Bikes_BikesId",
                        column: x => x.BikesId,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BikeGearSelector_Switches_SwitchesId",
                        column: x => x.SwitchesId,
                        principalTable: "Switches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BikeGearSelector_SwitchesId",
                table: "BikeGearSelector",
                column: "SwitchesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BikeGearSelector");

            migrationBuilder.DropColumn(
                name: "Сurrency",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Chainrings",
                table: "Switches");

            migrationBuilder.DropColumn(
                name: "Rearstars",
                table: "Switches");

            migrationBuilder.DropColumn(
                name: "Diametr",
                table: "Brakes");

            migrationBuilder.AddColumn<double>(
                name: "WhellSize",
                table: "Wheels",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SwitchSize",
                table: "Switches",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "BrakeSize",
                table: "Brakes",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.CreateTable(
                name: "BikeSwitch",
                columns: table => new
                {
                    BikesId = table.Column<long>(type: "bigint", nullable: false),
                    SwitchesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeSwitch", x => new { x.BikesId, x.SwitchesId });
                    table.ForeignKey(
                        name: "FK_BikeSwitch_Bikes_BikesId",
                        column: x => x.BikesId,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BikeSwitch_Switches_SwitchesId",
                        column: x => x.SwitchesId,
                        principalTable: "Switches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BikeSwitch_SwitchesId",
                table: "BikeSwitch",
                column: "SwitchesId");
        }
    }
}
