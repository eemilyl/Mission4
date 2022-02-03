using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext (DbContextOptions<MovieFormContext> options) : base(options)
        {

        }
        public DbSet<FormResponse> Responses { get; set; }
        public DbSet<Category>Categories{ get; set; }
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName="Rom-Com"},
                new Category { CategoryID = 2, CategoryName = "Family"},
                new Category { CategoryID = 3, CategoryName = "Action"},
                new Category { CategoryID = 4, CategoryName = "Drama" },
                new Category { CategoryID = 5, CategoryName = "Horror" },
                new Category { CategoryID = 6, CategoryName = "Comedy" }
                );
            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    MovieId = 1,
                    CategoryID = 1,
                    Title = "Leap Year",
                    Year = "2010",
                    Director = "Anand Tucker",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new FormResponse
                {
                    MovieId = 2,
                    CategoryID = 2,
                    Title = "Cinderella",
                    Year = "2015",
                    Director = "Kenneth Branagh",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new FormResponse
                {
                    MovieId = 3,
                    CategoryID = 1,
                    Title = "10 Things I Hate About You",
                    Year = "1999",
                    Director = "Gil Junger",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
                );
        }
    }
}
