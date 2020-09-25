using Microsoft.EntityFrameworkCore.Migrations;

namespace FAQ.App.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FAQ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Question = table.Column<string>(nullable: true),
                    Answer = table.Column<string>(nullable: true),
                    CategoryId = table.Column<string>(nullable: true),
                    TopicId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FAQ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FAQ_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FAQ_Topic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "gen", "General" },
                    { "his", "Hisotry" }
                });

            migrationBuilder.InsertData(
                table: "Topic",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { "cs", "C#" },
                    { "bs", "Bootstrap" },
                    { "js", "Javascript" }
                });

            migrationBuilder.InsertData(
                table: "FAQ",
                columns: new[] { "Id", "Answer", "CategoryId", "Question", "TopicId" },
                values: new object[,]
                {
                    { 3, "A general purpose object oriented language that uses a concise, Java-like syntax.", "gen", "What is C#?", "cs" },
                    { 4, "In 2002.", "his", "When was C# first released?", "cs" },
                    { 1, "A CSS framework for creating responsive web apps for multipe screen sizes.", "gen", "What is Bootstrap?", "bs" },
                    { 2, "In 2011.", "his", "When was Bootstrap first released?", "bs" },
                    { 5, "A general purpose scipting language that executes in a web browser.", "gen", "What is JavaScript?", "js" },
                    { 6, "In 1995.", "his", "When was JavaScript first released?", "js" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_FAQ_CategoryId",
                table: "FAQ",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FAQ_TopicId",
                table: "FAQ",
                column: "TopicId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FAQ");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}
