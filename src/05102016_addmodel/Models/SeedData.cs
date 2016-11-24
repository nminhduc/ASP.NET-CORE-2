using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using _05102016_addmodel.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace _05102016_addmodel.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                if (context.Movie.Any())
                {
                    return;
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Title = "when Harry meet Sally",
                        ReleaseData = DateTime.Parse("1989-1-11"),
                        Gener = "Romantic Comecy",
                        Rating = "R",
                        Price = 7.99M,
                    },
                    new Movie
                    {
                        Title = "Ghostbusters ",
                        ReleaseData = DateTime.Parse("1984-3-13"),
                        Gener = "Comedy",
                        Price = 8.99M,
                        Rating = "M",
                    },
                     new Movie
                     {
                         Title = "Ghostbusters 2",
                         ReleaseData = DateTime.Parse("1986-2-23"),
                         Gener = "Comedy",
                         Price = 9.99M,
                         Rating = "A",
                     },

                   new Movie
                   {
                       Title = "Rio Bravo",
                       ReleaseData = DateTime.Parse("1959-4-15"),
                       Gener = "Western",
                       Price = 3.99M,
                       Rating = "B",
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
