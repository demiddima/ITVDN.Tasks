using Microsoft.EntityFrameworkCore;
using MiniAppAspNetMVC.Models;

namespace MiniAppAspNetMVC.Context
{
    public class DbUser : DbContext
    {
        public DbSet<UserRegistration> InfoUsers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=InfoUsers;Trusted_Connection=true");
        }
    }
}
