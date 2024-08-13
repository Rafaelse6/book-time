using BookTime.Web.Entities;

namespace Test.Entities
{
    [TestClass]
    public class GenreBookTest
    {
        [TestMethod]
        public void TestingGenreBooksEntity()
        {
            // Arrange
            var book = new Book();
            var genre = new Genre();
            var genreBook = new GenreBooks();

            // Act
            book.Id = 1;
            book.Title = "Harry Potter";
            book.AuthorId = 1;
            book.Description = "Harry Potter and The Goblet of Fire";
            book.NumPages = 200;
            book.Image = "https://example.com/test-book.jpg";
            book.Author = new Author { Id = 1, Name = "JK Rowling", Slug = "jk-rowling" };

            genre.Id = 1;
            genre.Name = "Fantasy";
            genre.Slug = "fantasy";
            genre.WasRead = false;

            genreBook.GenreId = genre.Id;
            genreBook.BookId = book.Id;
            genreBook.Genre = genre;
            genreBook.Book = book;

            genre.GenreBooks.Add(genreBook);
            book.BooksGenres.Add(genreBook);

            // Assert
            Assert.AreEqual(1, genre.GenreBooks.Count);
            Assert.AreEqual(1, book.BooksGenres.Count);
            Assert.AreEqual(genreBook, genre.GenreBooks.First());
            Assert.AreEqual(genreBook, book.BooksGenres.First());
            Assert.AreEqual(genre, genre.GenreBooks.First().Genre);
            Assert.AreEqual(book, genre.GenreBooks.First().Book);
            Assert.AreEqual(genre, book.BooksGenres.First().Genre);
            Assert.AreEqual(book, book.BooksGenres.First().Book);
        }
    }
}