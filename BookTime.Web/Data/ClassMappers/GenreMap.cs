using BookTime.Web.Entities;
using CsvHelper.Configuration;

namespace BookTime.Web.Data.ClassMappers
{
    public class GenreMap : ClassMap<Genre>
    {
        public GenreMap()
        {
            Map(m => m.Id).Name("Id");
            Map(m => m.Name).Name("Name");
            Map(m => m.Slug).Name("Slug");
            Map(m => m.WasRead).Name("WasRead");
        }
    }
}
