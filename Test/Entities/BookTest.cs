using BookTime.Web.Entities;
using System.ComponentModel.DataAnnotations;
using static System.Net.Mime.MediaTypeNames;

namespace Test.Entities
{
    [TestClass]
    public class BookTest
    {
        [TestMethod]
        public void TestingBookEntity()
        {
            // Arrange
            var book = new Book();

            // Act
            book.Id = 1;
            book.Title = "Harry Potter";
            book.AuthorId = 1;
            book.Description = "Harry Potter and The Goblet of Fire";
            book.NumPages = 200;
            book.Image = "https://example.com/test-book.jpg";
            book.Author = new Author { Id = 1, Name = "JK Rowling", Slug = "jk-rowling" };


            Assert.AreEqual(1, book.Id);
            Assert.AreEqual("Harry Potter", book.Title);
            Assert.AreEqual(1, book.AuthorId);
            Assert.AreEqual("Harry Potter and The Goblet of Fire", book.Description);
            Assert.AreEqual(200, book.NumPages);
            Assert.AreEqual("https://example.com/test-book.jpg", book.Image);
            Assert.AreEqual("JK Rowling", book.Author.Name);

        }

        [TestMethod]
        [ExpectedException(typeof(ValidationException))]
        public void BookTitleIsRequiredThrowsValidationException()
        {
            // Arrange
            var book = new Book();

            book.Id = 1;
            book.AuthorId = 1;
            book.Description = "Harry Potter and The Goblet of Fire";
            book.NumPages = 200;
            book.Image = "https://example.com/test-book.jpg";
            book.Author = new Author { Id = 1, Name = "JK Rowling", Slug = "jk-rowling" };

            // Act
            ValidateEntity(book);
        }

        [TestMethod]
        public void Book_GenreBooksCollection_IsInitialized()
        {
            // Arrange
            var book = new Book();

            // Act & Assert
            Assert.IsNotNull(book.BooksGenres);
            Assert.AreEqual(0, book.BooksGenres.Count);
        }


        private void ValidateEntity(object entity)
        {
            var validationContext = new ValidationContext(entity, serviceProvider: null, items: null);
            Validator.ValidateObject(entity, validationContext, validateAllProperties: true);
        }
    }
}
