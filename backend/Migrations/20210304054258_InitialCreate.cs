using Microsoft.EntityFrameworkCore.Migrations;

namespace PersonalWebsite.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentsInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    CellPhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentsInfo", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "StudentsInfo",
                columns: new[] { "Id", "Age", "CellPhoneNumber", "Email", "Name" },
                values: new object[] { 1L, 26, "(850)612-3487", "hbrockster13@gmail.com", "Hunter Brock" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentsInfo");
        }
    }
}
