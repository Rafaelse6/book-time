using BookTime.Shared.DTOs;
using BookTime.Shared.Interfaces;
using BookTime.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace BookTime.Web.Services
{
    public class BookService : IBookService
    {
        private readonly IDbContextFactory<BookContext> _dbContextFactory;
        public BookService(IDbContextFactory<BookContext> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public async Task<BookDetailsDTO> GetBookAsync(int bookId)
        {
            using var context = _dbContextFactory.CreateDbContext();

            var book = await context.Books.Where(b => b.Id == bookId)
                .Select(b => new BookDetailsDTO(b.Id, b.Title, b.Image,
                            new AuthorDTO(b.Author.Name, b.Author.Slug), b.NumPages, b.Description, b.BooksGenres
                            .Select(bg => new GenreDTO(bg.Genre.Name, bg.Genre.Slug))
                            .ToArray()))
                            .FirstOrDefaultAsync();

            return book;
        }

        public async Task<PagedResult<BookListDTO>> GetBooksAsync(int pageNo, int pageSize, string? genreSlug = null)
        {
            using var context = _dbContextFactory.CreateDbContext();

            var query = context.Books.AsQueryable();

            if (!string.IsNullOrWhiteSpace(genreSlug))
            {
                query = context.Genres.Where(g => g.Slug == genreSlug).SelectMany(g => g.GenreBooks).Select(gb => gb.Book);
            }

            var totalCount = await query.CountAsync();

            var books = await query.OrderByDescending(b => b.Id)
                .Skip((pageNo - 1) * pageSize)
                .Take(pageSize)
                .Select(b => new BookListDTO(b.Id, b.Title, b.Image, new AuthorDTO(b.Author.Name, b.Author.Slug)))
                .ToArrayAsync();

            return new PagedResult<BookListDTO>(books, totalCount);
        }

        public async Task<PagedResult<BookListDTO>> GetBooksByAuthorAsync(int pageNo, int pageSize, string authorSlug)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var query = context.Books.Where(b => b.Author.Slug == authorSlug);
            var totalCount = await query.CountAsync();
            var books = await query
                .OrderByDescending(b => b.Id)
                .Skip((pageNo - 1) * pageSize)
                .Take(pageSize)
                .Select(b => new BookListDTO(b.Id, b.Title, b.Image, new AuthorDTO(b.Author.Name, b.Author.Slug)))
                .ToArrayAsync();

            return new PagedResult<BookListDTO>(books, totalCount);
        }

        public async Task<GenreDTO[]> GetReadAsync(bool wasRead)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var query = context.Genres.AsQueryable();
            if (wasRead)
            {
                query = query.Where(g => g.WasRead);
            }

            var genres = await query.Select(g => new GenreDTO(g.Name, g.Slug)).ToArrayAsync();

            return genres;
        }
    }
}
