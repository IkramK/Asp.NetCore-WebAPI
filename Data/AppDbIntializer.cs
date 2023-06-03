using My_Books.Data.Models;
using My_Books.Data.ViewModels;

namespace My_Books.Data
{
    public class AppDbIntializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using(var serviceScope= applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                if (!context.Authers.Any())
                {
                    context.Authers.AddRange(new Auther
                    {
                        Name = "Khalid",
                    },
                    new Auther
                    {
                        Name = "Tariq",
                    },
                    new Auther
                    {
                        Name = "Nasir",
                    },
                    new Auther
                    {
                        Name = "Yasir",
                    }
                    );
                    context.SaveChanges();
                }
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new Publisher
                    {
                        Name = "Ikram",
                    },
                    new Publisher
                    {
                        Name = "Farman",
                    },
                    new Publisher
                    {
                        Name = "Ehsan",
                    }
                    );
                    context.SaveChanges();
                }
                if (!context.Books.Any())
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
                        PubId=1,

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
                        PubId = 2,

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
                        PubId = 3,
                    }
                    );
                    context.SaveChanges();
                }
            }
        }
    }
}
