using COMP003B.Assignment6.Models;
using Microsoft.EntityFrameworkCore;

namespace COMP003B.Assignment6.Data
{
    public class WebDevAcademyContext : DbContext
    {
        public WebDevAcademyContext(DbContextOptions<WebDevAcademyContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }  
        public DbSet<BookAuthor> BookAuthors { get; set; }
    }
}
