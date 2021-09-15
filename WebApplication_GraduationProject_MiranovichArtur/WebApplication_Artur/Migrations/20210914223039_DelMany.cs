using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class DelMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BikeBrake");

            migrationBuilder.DropTable(
                name: "BikeGearSelector");

            migrationBuilder.DropTable(
                name: "BikeWheel");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Wheels",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Switches",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Brakes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddForeignKey(
                name: "FK_Brakes_Bikes_Id",
                table: "Brakes",
                column: "Id",
                principalTable: "Bikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Switches_Bikes_Id",
                table: "Switches",
                column: "Id",
                principalTable: "Bikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wheels_Bikes_Id",
                table: "Wheels",
                column: "Id",
                principalTable: "Bikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Brakes_Bikes_Id",
                table: "Brakes");

            migrationBuilder.DropForeignKey(
                name: "FK_Switches_Bikes_Id",
                table: "Switches");

            migrationBuilder.DropForeignKey(
                name: "FK_Wheels_Bikes_Id",
                table: "Wheels");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Wheels",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Switches",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<long>(
                name: "Id",
                table: "Brakes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.CreateTable(
                name: "BikeBrake",
                columns: table => new
                {
                    BikesId = table.Column<long>(type: "bigint", nullable: false),
                    BrakesId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeBrake", x => new { x.BikesId, x.BrakesId });
                    table.ForeignKey(
                        name: "FK_BikeBrake_Bikes_BikesId",
                        column: x => x.BikesId,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BikeBrake_Brakes_BrakesId",
                        column: x => x.BrakesId,
                        principalTable: "Brakes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateTable(
                name: "BikeWheel",
                columns: table => new
                {
                    BikesId = table.Column<long>(type: "bigint", nullable: false),
                    WheelsId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeWheel", x => new { x.BikesId, x.WheelsId });
                    table.ForeignKey(
                        name: "FK_BikeWheel_Bikes_BikesId",
                        column: x => x.BikesId,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BikeWheel_Wheels_WheelsId",
                        column: x => x.WheelsId,
                        principalTable: "Wheels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BikeBrake_BrakesId",
                table: "BikeBrake",
                column: "BrakesId");

            migrationBuilder.CreateIndex(
                name: "IX_BikeGearSelector_SwitchesId",
                table: "BikeGearSelector",
                column: "SwitchesId");

            migrationBuilder.CreateIndex(
                name: "IX_BikeWheel_WheelsId",
                table: "BikeWheel",
                column: "WheelsId");
        }
    }
}
