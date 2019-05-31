using Microsoft.EntityFrameworkCore.Migrations;

namespace CodeFirst.Two.Migrations
{
    public partial class UpdateDogTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Dogs",
                schema: "AEO",
                newName: "Dogs");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "AEO");

            migrationBuilder.RenameTable(
                name: "Dogs",
                newName: "Dogs",
                newSchema: "AEO");
        }
    }
}
