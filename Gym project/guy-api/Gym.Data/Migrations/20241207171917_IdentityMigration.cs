using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Gym.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ListClient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Pel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnumhealthFund = table.Column<int>(type: "int", nullable: false),
                    IsActiveClient = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListClient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListTrainer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Pel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeOfFitness = table.Column<int>(type: "int", nullable: false),
                    IsActiveTrainer = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListTrainer", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ListLesson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    TrainerId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Target_audience = table.Column<int>(type: "int", nullable: false),
                    Day = table.Column<int>(type: "int", nullable: false),
                    Start = table.Column<TimeSpan>(type: "time", nullable: false),
                    During = table.Column<int>(type: "int", nullable: false),
                    End = table.Column<TimeSpan>(type: "time", nullable: false),
                    EnumLevel = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true),
                    TrainerId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ListLesson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ListLesson_ListClient_ClientId",
                        column: x => x.ClientId,
                        principalTable: "ListClient",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ListLesson_ListTrainer_TrainerId1",
                        column: x => x.TrainerId1,
                        principalTable: "ListTrainer",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ListLesson_ClientId",
                table: "ListLesson",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_ListLesson_TrainerId1",
                table: "ListLesson",
                column: "TrainerId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ListLesson");

            migrationBuilder.DropTable(
                name: "ListClient");

            migrationBuilder.DropTable(
                name: "ListTrainer");
        }
    }
}
