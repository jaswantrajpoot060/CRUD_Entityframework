using Microsoft.EntityFrameworkCore;

namespace CRUD_Entityframework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> tblBook { get; set; }
        public DbSet<Language> tblLanguage { get; set; }
    }
}
