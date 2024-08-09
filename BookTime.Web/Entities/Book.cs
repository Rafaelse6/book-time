using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookTime.Web.Entities
{
    public class Book
    {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public string Description { get; set; }

        [Range(1, int.MaxValue)]
        public int NumPages { get; set; }

        [Required, MaxLength(180), Unicode(false)]
        public string Image { get; set; }

        [ForeignKey(nameof(AuthorId))]
        public virtual Author Author { get; set; }

        public virtual ICollection<GenreBooks> BooksGenres { get; set; } = new List<GenreBooks>();
    }
}
