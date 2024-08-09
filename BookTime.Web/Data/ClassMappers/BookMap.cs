using BookTime.Web.Entities;
using CsvHelper.Configuration;

namespace BookTime.Web.Data.ClassMappers
{
    public class BookMap : ClassMap<Book>
    {
        public BookMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.Title).Name("Title");
            Map(m => m.AuthorId).Name("AuthorId");
            Map(m => m.Description).Name("Description");
            Map(m => m.NumPages).Name("NumPages");
            Map(m => m.Image).Name("Image");
        }
    }
}
