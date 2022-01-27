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

        public DbSet<AddFilm> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddFilm>().HasData(

                new AddFilm
                {
                    AppId = 1,
                    Category = "Family",
                    Title = "Cinderella",
                    Year = 1996,
                    Director = "Some Guy",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = "Such a great movie",
                },

                new AddFilm
                {
                    AppId = 2,
                    Category = "Family",
                    Title = "Pocahontus",
                    Year = 1990,
                    Director = "Some Guy",
                    Rating = "PG",
                    Edited = false,
                    Lent = "",
                    Notes = "Such a great movie",
                },

                new AddFilm
                {
                    AppId = 2,
                    Category = "Family",
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
 