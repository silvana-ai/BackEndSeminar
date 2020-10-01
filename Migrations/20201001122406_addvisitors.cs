using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SignToSeminarie.Migrations
{
    public partial class addvisitors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Seminars",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Namn = table.Column<string>(nullable: true),
                    Beskrivning = table.Column<string>(nullable: true),
                    Datum = table.Column<DateTime>(nullable: false),
                    Maxplats = table.Column<int>(nullable: false),
                    status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seminars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Förnamn = table.Column<string>(nullable: false),
                    Efternamn = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: false),
                    Adress = table.Column<string>(nullable: true),
                    Tel = table.Column<string>(nullable: true),
                    seminarId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Visitors_Seminars_seminarId",
                        column: x => x.seminarId,
                        principalTable: "Seminars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visitors_seminarId",
                table: "Visitors",
                column: "seminarId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Seminars");
        }
    }
}
