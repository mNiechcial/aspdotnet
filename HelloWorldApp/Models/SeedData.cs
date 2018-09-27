using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorldApp.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using ( var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>() ) )
            {
                if (context.Film.Any())
                {
                    return;
                }
                context.Film.AddRange(
                    new Film

                    {
                        Title = "BlaBlaz Kodu" ,
                        ReleaseDate = DateTime.Parse( "1023-1-11" ) ,
                        Genre = "Romantic Comedy" ,
                        Price = 7.11M
                    } ,

                   new Film
                   {
                       Title = "Rio Bravo" ,
                       ReleaseDate = DateTime.Parse( "1959-4-15" ) ,
                       Genre = "Western" ,
                       Price = 3.99M
                   }
                    );
                context.SaveChanges();
            }
        }
    }
}
