using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TestEFCodeFirst.Migrations
{
    /// <inheritdoc />
    public partial class tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PersonId);
                });

            migrationBuilder.CreateTable(
                name: "TasksToDo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TasksToDo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivePartner",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    Abilities = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivePartner", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_ActivePartner_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HouseholdManager",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    numOfPeople = table.Column<int>(type: "int", nullable: false),
                    numOfrooms = table.Column<int>(type: "int", nullable: false),
                    apartmentArea = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HouseholdManager", x => x.PersonId);
                    table.ForeignKey(
                        name: "FK_HouseholdManager_People_PersonId",
                        column: x => x.PersonId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivePartner");

            migrationBuilder.DropTable(
                name: "HouseholdManager");

            migrationBuilder.DropTable(
                name: "TasksToDo");

            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
