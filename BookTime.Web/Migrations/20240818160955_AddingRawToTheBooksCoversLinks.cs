using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookTime.Web.Migrations
{
    /// <inheritdoc />
    public partial class AddingRawToTheBooksCoversLinks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/dune.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/harry-potter.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/the-shining.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/1984.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/brave-new-world.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/fahrenheit.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/the-handmaids-tale.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/the-left-hand-of-darkness.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/2001.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/foundation.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/stranger-in-a-strange-land.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/enders-game.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/do-androids-dream.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/kafka-on-the-shore.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/one-hundred-years.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/beloved.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/kindred.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/i-know-why.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/american-gods.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "https://raw.githubusercontent.com/Rafaelse6/books-data/main/discworld.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/dune.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/harry-potter.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/the-shining.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/1984.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/brave-new-world.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/fahrenheit.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/the-handmaids-tale.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/the-left-hand-of-darkness.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/2001.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/foundation.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/stranger-in-a-strange-land.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/enders-game.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/do-androids-dream.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/kafka-on-the-shore.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/one-hundred-years.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/beloved.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/kindred.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/i-know-why.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/american-gods.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20,
                column: "Image",
                value: "https://github.com/Rafaelse6/books-data/blob/main/discworld.jpg");
        }
    }
}
