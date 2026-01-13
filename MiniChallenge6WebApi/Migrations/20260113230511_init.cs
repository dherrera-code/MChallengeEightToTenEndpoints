using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Day5ReviewApi.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GuessIt",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RandomNum = table.Column<int>(type: "INTEGER", nullable: false),
                    GuessCounter = table.Column<int>(type: "INTEGER", nullable: false),
                    Difficulty = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuessIt", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GuessIt");
        }
    }
}
