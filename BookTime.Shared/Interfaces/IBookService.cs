using BookTime.Shared.DTOs;

namespace BookTime.Shared.Interfaces
{
    public interface IBookService
    {
        Task<BookDetailsDTO> GetBookAsync(int bookId);
        Task<PagedResult<BookListDTO>> GetBooksAsync(int pageNo, int pageSize, string? genreSlug = null);
        Task<PagedResult<BookListDTO>> GetBooksByAuthorAsync(int pageNo, int pageSize, string authorSlug);
        Task<GenreDTO[]> GetReadAsync(bool wasRead);
    }
}
