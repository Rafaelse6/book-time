namespace BookTime.Shared.DTOs
{
    public record BookDetailsDTO(int Id, string Title, string Image, AuthorDTO Author, 
                                int NumPages, string Description, GenreDTO[] Genres);
}
