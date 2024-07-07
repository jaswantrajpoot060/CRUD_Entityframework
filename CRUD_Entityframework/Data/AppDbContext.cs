using Microsoft.EntityFrameworkCore;

namespace CRUD_Entityframework.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Currency>().HasData(
                new Currency() { Id = 1, Title = "INR", Description = "Indian INR" },
                new Currency() { Id = 2, Title = "Dollar", Description = "Dollar" },
                new Currency() { Id = 3, Title = "Euro", Description = "Euro" },
                new Currency() { Id = 4, Title = "Diner", Description = "Diner" });

            modelBuilder.Entity<Language>().HasData(
                new Currency() { Id = 1, Title = "Hindi", Description = "Hindi" },
                new Currency() { Id = 2, Title = "English", Description = "English" },
                new Currency() { Id = 3, Title = "Urdu", Description = "Urdu" },
                new Currency() { Id = 4, Title = "Panjabi", Description = "Panjabi" });
        }
        public DbSet<Book> tblBook { get; set; }
        public DbSet<Language> tblLanguage { get; set; }
        public DbSet<BookPrice> tblBookPrice { get; set; }
        public DbSet<Currency> tblCurrency { get; set; }
    }
}
