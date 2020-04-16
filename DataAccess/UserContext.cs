using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Modals;

namespace WebApplication1.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id=1,
                    Username = "Chaman",
                    Email = "chaman.raghav@vicesoftware.com",
                    Password = "123465487"
                },
                new User
                {
                    Id=2,
                    Username="Sanjeev",
                    Email="sanjeevsharma@vicesofteware.com",
                    Password="12457845"
                });
        }
    }
}
