using Microsoft.EntityFrameworkCore;

namespace BookBarn.Models
{
    public class BookBarnContext : DbContext
    {
        public BookBarnContext(DbContextOptions<BookBarnContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books => Set<Book>();
        public DbSet<Author> Authors => Set<Author>();

    }
}
