using BookTime.Web.Entities;

namespace Test.Entities
{
    [TestClass]
    public class GenreTest
    {
        [TestMethod]
        public void TestingGenreEntity()
        {
            // Arrange
            var genre = new Genre();

            //Act
            genre.Id = 1;
            genre.Name = "Fantasy";
            genre.Slug = "fantasy";
            genre.WasRead = false;

            // Assert
            Assert.AreEqual(1, genre.Id);
            Assert.AreEqual("Fantasy", genre.Name);
            Assert.AreEqual("fantasy", genre.Slug);
            Assert.IsFalse(genre.WasRead);
        }

        [TestMethod]
        public void GenreShouldHandleEmpyGenreBooksCollection()
        {
            // Arrange
            var genre = new Genre();

            // Act & Assert
            Assert.IsNotNull(genre.GenreBooks);
            Assert.AreEqual(0, genre.GenreBooks.Count);
        }

        [TestMethod]
        public void GenreShouldAddAndRetrieveGenreBooks()
        {
            // Arrange
            var genre = new Genre
            {
                Id = 1,
                Name = "Fantasy",
                Slug = "fantasy",
                WasRead = false
            };

            var book = new Book
            {
                Id = 1,
                Title = "Sample Book",
                Description = "This is a sample book",
                NumPages = 300,
                Image = "sample-image-url"
            };

            var genreBook = new GenreBooks
            {
                GenreId = genre.Id,
                BookId = book.Id,
                Genre = genre,
                Book = book
            };

            // Act
            genre.GenreBooks.Add(genreBook);

            //Assert
            Assert.AreEqual(1, genre.GenreBooks.Count);
            Assert.AreEqual(genreBook, genre.GenreBooks.First());
            Assert.AreEqual(genre, genre.GenreBooks.First().Genre);
            Assert.AreEqual(book, genre.GenreBooks.First().Book);
        }
    }
}
