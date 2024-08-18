using BookTime.Web.Data;
using BookTime.Web.Entities;
using BookTime.Web.Services;
using Microsoft.EntityFrameworkCore;

namespace Test.Services
{
    [TestClass]
    public class BookServiceTests
    {
        private BookContext _context;
        private BookService _bookService;

        [TestInitialize]
        public void SetUp()
        {
            var options = new DbContextOptionsBuilder<BookContext>()
                .UseInMemoryDatabase(databaseName: "BookTimeTest")
                .Options;

            _context = new BookContext(options);

            SeedDatabase(_context);

            _bookService = new BookService(_context);
        }

        [TestCleanup]
        public void Cleanup()
        {
            _context.Database.EnsureDeleted();
            _context.Dispose();
        }

        [TestMethod]
        public async Task GetBookAsync_WithExistingBook_ReturnsBookDetails()
        {
            var bookDetails = await _bookService.GetBookAsync(1);

            Assert.IsNotNull(bookDetails);
            Assert.AreEqual(1, bookDetails.Id);
            Assert.AreEqual("Test Book", bookDetails.Title);
            Assert.AreEqual("Test Author", bookDetails.Author.Name);
            Assert.AreEqual("test-author", bookDetails.Author.Slug);
        }

        private void SeedDatabase(BookContext context)
        {
            var author = new Author { Id = 1, Name = "Test Author", Slug = "test-author" };
            var book = new Book { Id = 1, Title = "Test Book", Author = author, Description = "Test Description", NumPages = 100, Image = "test.jpg" };

            context.Authors.Add(author);
            context.Books.Add(book);
            context.SaveChanges();
        }
    }
}