using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcMovieContext>>()))
            {
                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "The R.M.",
                        ReleaseDate = DateTime.Parse("2003-1-31"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 7.99M
                    },

                    new Movie
                    {
                        Title = "The Singles Ward",
                        ReleaseDate = DateTime.Parse("2002-2-1"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 8.99M
                    },

                    new Movie
                    {
                        Title = "Baptists at Our Barbecue",
                        ReleaseDate = DateTime.Parse("2004-5-13"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 9.99M
                    },

                    new Movie
                    {
                        Title = "Mobsters and Mormons",
                        ReleaseDate = DateTime.Parse("2005-4-15"),
                        Genre = "Comedy",
                        Rating = "PG",
                        Price = 3.99M
                    },

                    new Movie
                    {
                        Title = "Saints and Soldiers",
                        ReleaseDate = DateTime.Parse("2003-9-11"),
                        Genre = "Action",
                        Rating = "PG-13",
                        Price = 3.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}