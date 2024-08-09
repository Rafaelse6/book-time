using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookTime.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(120)", unicode: false, maxLength: 120, nullable: false),
                    Slug = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<short>(type: "smallint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Slug = table.Column<string>(type: "varchar(75)", unicode: false, maxLength: 75, nullable: false),
                    WasRead = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumPages = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<string>(type: "varchar(180)", unicode: false, maxLength: 180, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Books_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GenreBooks",
                columns: table => new
                {
                    GenreId = table.Column<short>(type: "smallint", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreBooks", x => new { x.GenreId, x.BookId });
                    table.ForeignKey(
                        name: "FK_GenreBooks_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreBooks_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "Name", "Slug" },
                values: new object[,]
                {
                    { 1, "Frank Herbert", "frank-herbert" },
                    { 2, "J.K. Rowling", "j-k-rowling" },
                    { 3, "Stephen King", "stephen-king" },
                    { 4, "George Orwell", "george-orwell" },
                    { 5, "Aldous Huxley", "aldous-huxley" },
                    { 6, "Ray Bradbury", "ray-bradbury" },
                    { 7, "Margaret Atwood", "margaret-atwood" },
                    { 8, "Ursula K. Le Guin", "ursula-k-le-guin" },
                    { 9, "Arthur C. Clarke", "arthur-c-clarke" },
                    { 10, "Isaac Asimov", "isaac-asimov" },
                    { 11, "Robert Heinlein", "robert-heinlein" },
                    { 12, "Orson Scott Card", "orson-scott-card" },
                    { 13, "Philip K. Dick", "philip-k-dick" },
                    { 14, "Haruki Murakami", "haruki-murakami" },
                    { 15, "Gabriel Garc�a M�rquez", "gabriel-garcia-marquez" },
                    { 16, "Toni Morrison", "toni-morrison" },
                    { 17, "Octavia Butler", "octavia-butler" },
                    { 18, "Maya Angelou", "maya-angelou" },
                    { 19, "Neil Gaiman", "neil-gaiman" },
                    { 20, "Terry Pratchett", "terry-pratchett" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name", "Slug", "WasRead" },
                values: new object[,]
                {
                    { (short)1, "Science Fiction", "science-fiction", false },
                    { (short)2, "Fantasy", "fantasy", false },
                    { (short)3, "Mystery", "mystery", true },
                    { (short)4, "Horror", "horror", false },
                    { (short)5, "Romance", "romance", false },
                    { (short)6, "Thriller", "thriller", false },
                    { (short)7, "Dystopian", "dystopian", false },
                    { (short)8, "Historical Fiction", "historical-fiction", false },
                    { (short)9, "Contemporary", "contemporary", false },
                    { (short)10, "Young Adult", "young-adult", false },
                    { (short)11, "Nonfiction", "nonfiction", false },
                    { (short)12, "Biography", "biography", false },
                    { (short)13, "Autobiography", "autobiography", false },
                    { (short)14, "Memoir", "memoir", false },
                    { (short)15, "Self-Help", "self-help", false },
                    { (short)16, "Cookbooks", "cookbooks", false },
                    { (short)17, "Travel", "travel", false },
                    { (short)18, "Science", "science", false },
                    { (short)19, "History", "history", false },
                    { (short)20, "Philosophy", "philosophy", false }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "Description", "Image", "NumPages", "Title" },
                values: new object[,]
                {
                    { 1, 1, "A classic sci-fi novel.", "https://example.com/dune.jpg", 528, "Dune" },
                    { 2, 2, "A magical adventure.", "https://example.com/harry-potter.jpg", 306, "Harry Potter and the Sorcerer's Stone" },
                    { 3, 3, "A horror classic.", "https://example.com/the-shining.jpg", 447, "The Shining" },
                    { 4, 4, "A dystopian novel.", "https://example.com/1984.jpg", 328, "1984" },
                    { 5, 5, "A satirical novel.", "https://example.com/brave-new-world.jpg", 312, "Brave New World" },
                    { 6, 6, "A dystopian novel.", "https://example.com/fahrenheit-451.jpg", 256, "Fahrenheit 451" },
                    { 7, 7, "A dystopian novel.", "https://example.com/the-handmaids-tale.jpg", 310, "The Handmaid's Tale" },
                    { 8, 8, "A science fiction novel.", "https://example.com/the-left-hand-of-darkness.jpg", 296, "The Left Hand of Darkness" },
                    { 9, 9, "A science fiction novel.", "https://example.com/2001-a-space-odyssey.jpg", 304, "2001: A Space Odyssey" },
                    { 10, 10, "A science fiction novel.", "https://example.com/foundation.jpg", 464, "Foundation" },
                    { 11, 11, "A science fiction novel.", "https://example.com/stranger-in-a-strange-land.jpg", 392, "Stranger in a Strange Land" },
                    { 12, 12, "A science fiction novel.", "https://example.com/enders-game.jpg", 352, "Ender's Game" },
                    { 13, 13, "A science fiction novel.", "https://example.com/do-androids-dream-of-electric-sheep.jpg", 224, "Do Androids Dream of Electric Sheep?" },
                    { 14, 14, "A magical realism novel.", "https://example.com/kafka-on-the-shore.jpg", 464, "Kafka on the Shore" },
                    { 15, 15, "A magical realism novel.", "https://example.com/one-hundred-years-of-solitude.jpg", 428, "One Hundred Years of Solitude" },
                    { 16, 16, "A historical fiction novel.", "https://example.com/beloved.jpg", 320, "Beloved" },
                    { 17, 17, "A science fiction novel.", "https://example.com/kindred.jpg", 256, "Kindred" },
                    { 18, 18, "A memoir.", "https://example.com/i-know-why-the-caged-bird-sings.jpg", 272, "I Know Why the Caged Bird Sings" },
                    { 19, 19, "A fantasy novel.", "https://example.com/american-gods.jpg", 466, "American Gods" },
                    { 20, 20, "A fantasy novel.", "https://example.com/discworld.jpg", 384, "Discworld" }
                });

            migrationBuilder.InsertData(
                table: "GenreBooks",
                columns: new[] { "BookId", "GenreId" },
                values: new object[,]
                {
                    { 1, (short)1 },
                    { 8, (short)1 },
                    { 9, (short)1 },
                    { 10, (short)1 },
                    { 11, (short)1 },
                    { 12, (short)1 },
                    { 13, (short)1 },
                    { 2, (short)2 },
                    { 14, (short)2 },
                    { 15, (short)2 },
                    { 19, (short)2 },
                    { 20, (short)2 },
                    { 3, (short)3 },
                    { 4, (short)4 },
                    { 5, (short)5 },
                    { 6, (short)6 },
                    { 7, (short)7 },
                    { 17, (short)7 },
                    { 16, (short)8 },
                    { 18, (short)11 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_AuthorId",
                table: "Books",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_GenreBooks_BookId",
                table: "GenreBooks",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreBooks");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Authors");
        }
    }
}
