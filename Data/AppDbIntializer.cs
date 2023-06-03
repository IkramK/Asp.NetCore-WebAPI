using My_Books.Data.Models;

namespace My_Books.Data
{
    public class AppDbIntializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope= applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if(!context.Books.Any())
                {
                    context.Books.AddRange(new Book 
                    {
                        Title="1st Book",
                        Description="New Book",
                        IsRead=true,
                        DateRead=DateTime.Now.AddDays(-10),
                        Rate=4,
                        Genre="Bio",
                        Author="First Author",
                        CoverUrl="Http...",
                        DateAdded=DateTime.Now,

                    },
                    new Book
                    {
                        Title = "2nd Book",
                        Description = "New Book",
                        IsRead = false,
                        Rate = 4,
                        Genre = "Bio",
                        Author = "First Author",
                        CoverUrl = "Http...",
                        DateAdded = DateTime.Now,

                    },
                    new Book
                    {
                        Title = "3rd Book",
                        Description = "New Book",
                        IsRead = true,
                        DateRead = DateTime.Now.AddDays(-10),
                        Rate = 4,
                        Genre = "Bio",
                        Author = "First Author",
                        CoverUrl = "Http...",
                        DateAdded = DateTime.Now,

                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
