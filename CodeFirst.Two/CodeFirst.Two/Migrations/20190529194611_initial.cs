using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Two.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AEO");

            migrationBuilder.CreateTable(
                name: "Dogs",
                schema: "AEO",
                columns: table => new
                {
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true),
                    BirthDate = table.Column<DateTime>(nullable: false),
                    FatherName = table.Column<string>(type: "NVARCHAR(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Baths",
                columns: table => new
                {
                    LastUpdatedOn = table.Column<DateTime>(nullable: true),
                    Id = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Price = table.Column<float>(nullable: false),
                    DogId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baths", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baths_Dogs_DogId",
                        column: x => x.DogId,
                        principalSchema: "AEO",
                        principalTable: "Dogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Baths_DogId",
                table: "Baths",
                column: "DogId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Baths");

            migrationBuilder.DropTable(
                name: "Dogs",
                schema: "AEO");
        }
    }
}
