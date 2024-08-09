using BookTime.Web.Entities;
using CsvHelper.Configuration;

namespace BookTime.Web.Data.ClassMappers
{
    public class GenreBooksMap : ClassMap<GenreBooks>
    {
        public GenreBooksMap()
        {
            Map(m => m.BookId).Name("BookId");
            Map(m => m.GenreId).Name("GenreId");
        }
    }
}
