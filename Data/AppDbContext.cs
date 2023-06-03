using Microsoft.EntityFrameworkCore;
using My_Books.Data.Models;

namespace My_Books.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
        //public DbSet<Auther> Authers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        // public DbSet<Books_Authers> Books_Authers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Book>()
            //.HasOne(b => b.Publisher)
            //.WithMany(p => p.Books)
            //.HasForeignKey(b => b.PublisherId);
        }
    }
}
