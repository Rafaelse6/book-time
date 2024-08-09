using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BookTime.Web.Entities
{
    public class Author
    {

        [Key]
        public int Id { get; set; }

        [Required, MaxLength(120), Unicode(false)]
        public string Name { get; set; }

        [Required, MaxLength(100), Unicode(false)]
        public string Slug { get; set; }
    }
}
