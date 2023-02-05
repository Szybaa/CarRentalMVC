using Microsoft.EntityFrameworkCore;
using CarRentalMVC.Models;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using CarRentalMVC.Data;

namespace CarRentalMVC.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                context.Database.EnsureCreated();

                if (context.Users.Any())
                {
                    return; // dane już zostały dodane do bazy danych
                }

                var user = new Users()
                {
                    FirstName = "Maciek",
                    LastName = "Stainbach",
                    Email = "maciek@onet.pl",
                    DrivingLicenseYears = 5,
                    Password="haslo123"
                };

                context.Users.Add(user);
                context.SaveChanges();

                /* do uzupełnienia */
            }
        }

    }
}
