using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchmoekelMission6.Models;

namespace SchmoekelMission6.Models
{
    public class MovieContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Parameterized constructor that accepts DbContextOptions
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Action" },
                new Category { CategoryId = 2, CategoryName = "Drama" }
                // Add more categories as needed
            );

            // Seed Movies
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieId = 1,
                    CategoryId = 1,
                    Title = "The Matrix",
                    Year = 1999,
                    Director = "Lana Wachowski, Lilly Wachowski",
                    Rating = MovieRatingEnum.R,
                    Edited = EditedEnum.No,
                    LentTo = "Olivia",
                    CopiedToPlex = "Yes",
                    Notes = "Classic Sci-Fi"
                }
                // Add more movies as needed
            );

            // ... other model configurations

            base.OnModelCreating(modelBuilder);
        }
    }
}
