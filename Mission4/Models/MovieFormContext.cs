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
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<FormResponse>().HasData(
                new FormResponse
                {
                    MovieId = 1,
                    Category = "Rom-Com",
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
                    Category = "Family",
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
                    Category = "Rom-Com",
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
