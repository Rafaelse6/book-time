using BookTime.Web.Entities;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using CsvHelper;
using BookTime.Web.Data.ClassMappers;

namespace BookTime.Web.Data
{
    public class BookContext : DbContext
    {
        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<GenreBooks> GenreBooks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GenreBooks>().HasKey(gb => new { gb.GenreId, gb.BookId });

            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true
            };

            // Read genres from CSV
            using (var reader = new StreamReader("Data/genre.csv"))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                csv.Context.RegisterClassMap<GenreMap>();
                var genres = csv.GetRecords<Genre>().ToList();
                modelBuilder.Entity<Genre>().HasData(genres);
            }

            // Read authors from CSV
            using (var reader = new StreamReader("Data/author.csv"))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                csv.Context.RegisterClassMap<AuthorMap>();
                var authors = csv.GetRecords<Author>().ToList();
                modelBuilder.Entity<Author>().HasData(authors);
            }

            // Read books from CSV
            using (var reader = new StreamReader("Data/book.csv"))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                csv.Context.RegisterClassMap<BookMap>();
                var books = csv.GetRecords<Book>().ToList();
                modelBuilder.Entity<Book>().HasData(books);
            }

            // Read genre_books from CSV
            using (var reader = new StreamReader("Data/genre_books.csv"))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                csv.Context.RegisterClassMap<GenreBooksMap>();
                var genreBooks = csv.GetRecords<GenreBooks>().ToList();
                modelBuilder.Entity<GenreBooks>().HasData(genreBooks);
            }
        }

    }
}
