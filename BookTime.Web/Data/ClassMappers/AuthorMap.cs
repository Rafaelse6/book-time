using BookTime.Web.Entities;
using CsvHelper.Configuration;

namespace BookTime.Web.Data.ClassMappers
{
    public class AuthorMap : ClassMap<Author>
    {
        public AuthorMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.Name).Name("Name");
            Map(m => m.Slug).Name("Slug");
        }
    }
}
