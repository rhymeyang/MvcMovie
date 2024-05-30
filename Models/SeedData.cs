using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            //Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }

            context.Movie.AddRange(

                new Movie
                {
                    Title = "When Harry Met Sally",
                    ReleaseDate = DateTime.Parse("1989-2-12"),
                    Genre = "Romantic Comedy",
                    Price = 7.99M,
                    Rating = 3.0M
                },
                new Movie
                {
                    Title = "Ghostbusters ",
                    ReleaseDate = DateTime.Parse("1984-3-13"),
                    Genre = "Comedy",
                    Price = 8.99M,
                    Rating = 4.5M
                },
                new Movie
                {
                    Title = "Ghostbusters 2",
                    ReleaseDate = DateTime.Parse("1986-2-23"),
                    Genre = "Comedy",
                    Price = 9.99M,
                    Rating = 5.5M
                },
                new Movie
                {
                    Title = "Rio Bravo",
                    ReleaseDate = DateTime.Parse("1959-4-15"),
                    Genre = "Western",
                    Price = 3.99M,
                    Rating = 6.5M
                },
                 new Movie
                 {
                     Title = "Back to Black",
                     ReleaseDate = DateTime.Parse("2024-05-17"),
                     Genre = "Biography",
                     Price = 12.00M,
                     Rating = 7.5M
                 },
                 new Movie
                 {
                     Title = "IF",
                     ReleaseDate = DateTime.Parse("2024-05-17"),
                     Genre = "Animation",
                     Price = 5.00M,
                     Rating = 8.5M
                 },
                 new Movie
                 {
                     Title = "Shinda Shinda No Papa",
                     ReleaseDate = DateTime.Parse("2024-05-10"),
                     Genre = "Comedy",
                     Price = 12.00M,
                     Rating = 9.0M
                 }
            );
            
            context.SaveChanges();
           
        }
    }
}