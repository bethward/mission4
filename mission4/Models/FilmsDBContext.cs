using System;
using Microsoft.EntityFrameworkCore;

namespace mission4.Models
{
    public class FilmsDBContext : DbContext
    {
        //Constructor
        public FilmsDBContext(DbContextOptions<FilmsDBContext> options) : base (options)
        {
                //blank for now
        }

        public DbSet<AddFilmModel> responses { get; set; }
        public DbSet< Category> Categories { get; set; }

  
        //Seed data
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action/Adventure"},
                new Category { CategoryId = 2, CategoryName = "Comedy" },
                new Category { CategoryId = 3, CategoryName = "Drama" },
                new Category { CategoryId = 4, CategoryName = "Family" },
                new Category { CategoryId = 5, CategoryName = "Horror/Suspense" },
                new Category { CategoryId = 6, CategoryName = "Miscellaneous" },
                new Category { CategoryId = 7, CategoryName = "Television" },
                new Category { CategoryId = 8, CategoryName = "VHS" }
                );

            mb.Entity<AddFilmModel>().HasData(

                new AddFilmModel
                {
                    AppId = 1,
                    CategoryId = 4,
                    Title = "Cinderella",
                    Year = 1996,
                    Director = "Some Guy",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = "Such a great movie",
                },

                new AddFilmModel
                {
                    AppId = 2,
                    CategoryId = 4,
                    Title = "Pocahontus",
                    Year = 1990,
                    Director = "Some Guy",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = "Such a great movie",
                },

                new AddFilmModel
                {
                    AppId = 3,
                    CategoryId = 4,
                    Title = "Princess and the Frog",
                    Year = 2010,
                    Director = "Some Guy",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = "Love the frogs",
                }
            );
        }
    }
}
 