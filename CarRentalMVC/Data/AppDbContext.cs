using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection;

namespace CarRentalMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Models.Users> Users { get; set; } = default!;

        
    }
}
