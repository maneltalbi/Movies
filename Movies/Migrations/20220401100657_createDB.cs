using Microsoft.EntityFrameworkCore.Migrations;

namespace Movies.Migrations
{
    public partial class createDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    original_title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    release_date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    poster_path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    popularity = table.Column<double>(type: "float", nullable: false),
                    title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    video = table.Column<bool>(type: "bit", nullable: false),
                    vote_average = table.Column<double>(type: "float", nullable: false),
                    vote_count = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
