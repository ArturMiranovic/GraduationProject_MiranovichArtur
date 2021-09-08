using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication_Artur.Migrations
{
    public partial class AddAllTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BikeUser_Bike_BikeId",
                table: "BikeUser");

            migrationBuilder.DropForeignKey(
                name: "FK_BikeUser_Users_UsersId",
                table: "BikeUser");

            migrationBuilder.DropTable(
                name: "Bike");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "BikeUser",
                newName: "OwnerId");

            migrationBuilder.RenameColumn(
                name: "BikeId",
                table: "BikeUser",
                newName: "MyBikesId");

            migrationBuilder.RenameIndex(
                name: "IX_BikeUser_UsersId",
                table: "BikeUser",
                newName: "IX_BikeUser_OwnerId");

            migrationBuilder.CreateTable(
                name: "Bikes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    BikeSize = table.Column<int>(type: "int", nullable: false),
                    BikeClass = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bikes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brakes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrakeSize = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brakes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Switches",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SwitchSize = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Switches", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserInformation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInformation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserInformation_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Wheels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Diameter = table.Column<int>(type: "int", nullable: false),
                    WhellSize = table.Column<double>(type: "float", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wheels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BikeUser1",
                columns: table => new
                {
                    LikeBikesId = table.Column<long>(type: "bigint", nullable: false),
                    PotentialBuyerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BikeUser1", x => new { x.LikeBikesId, x.PotentialBuyerId });
                    table.ForeignKey(
                        name: "FK_BikeUser1_Bikes_LikeBikesId",
                        column: x => x.LikeBikesId,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BikeUser1_Users_PotentialBuyerId",
                        column: x => x.PotentialBuyerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    BikeId = table.Column<long>(type: "bigint", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Bikes_BikeId",
                        column: x => x.BikeId,
                        principalTable: "Bikes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Comments_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                name: "IX_BikeSwitch_SwitchesId",
                table: "BikeSwitch",
                column: "SwitchesId");

            migrationBuilder.CreateIndex(
                name: "IX_BikeUser1_PotentialBuyerId",
                table: "BikeUser1",
                column: "PotentialBuyerId");

            migrationBuilder.CreateIndex(
                name: "IX_BikeWheel_WheelsId",
                table: "BikeWheel",
                column: "WheelsId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_BikeId",
                table: "Comments",
                column: "BikeId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_UserId",
                table: "Comments",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserInformation_UserId",
                table: "UserInformation",
                column: "UserId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BikeUser_Bikes_MyBikesId",
                table: "BikeUser",
                column: "MyBikesId",
                principalTable: "Bikes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BikeUser_Users_OwnerId",
                table: "BikeUser",
                column: "OwnerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BikeUser_Bikes_MyBikesId",
                table: "BikeUser");

            migrationBuilder.DropForeignKey(
                name: "FK_BikeUser_Users_OwnerId",
                table: "BikeUser");

            migrationBuilder.DropTable(
                name: "BikeBrake");

            migrationBuilder.DropTable(
                name: "BikeSwitch");

            migrationBuilder.DropTable(
                name: "BikeUser1");

            migrationBuilder.DropTable(
                name: "BikeWheel");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "UserInformation");

            migrationBuilder.DropTable(
                name: "Brakes");

            migrationBuilder.DropTable(
                name: "Switches");

            migrationBuilder.DropTable(
                name: "Wheels");

            migrationBuilder.DropTable(
                name: "Bikes");

            migrationBuilder.RenameColumn(
                name: "OwnerId",
                table: "BikeUser",
                newName: "UsersId");

            migrationBuilder.RenameColumn(
                name: "MyBikesId",
                table: "BikeUser",
                newName: "BikeId");

            migrationBuilder.RenameIndex(
                name: "IX_BikeUser_OwnerId",
                table: "BikeUser",
                newName: "IX_BikeUser_UsersId");

            migrationBuilder.CreateTable(
                name: "Bike",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<long>(type: "bigint", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bike", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_BikeUser_Bike_BikeId",
                table: "BikeUser",
                column: "BikeId",
                principalTable: "Bike",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BikeUser_Users_UsersId",
                table: "BikeUser",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
