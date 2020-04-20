using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Modals;

namespace WebApplication1.DataAccess
{
    public class UserContext : DbContext
    {
        public UserContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Document> Documents { get; set; }
        public List<User> getUsers() => Users.ToList();
        public List<Document> getDocuments() => Documents.ToList();
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Username = "Chaman",
                    Email = "chaman.raghav@vicesoftware.com",
                    Password = "123465487"
                },
                new User
                {
                    Id = 2,
                    Username = "Sanjeev",
                    Email = "sanjeevsharma@vicesofteware.com",
                    Password = "12457845"
                });
            modelBuilder.Entity<Document>().HasData(
                new Document
                {
                    id = 1001,
                    Customer_Name = "Chaman",
                    isFlagged = true
                },
                new Document
                {
                    id = 1002,
                    Customer_Name = "Sanjeev",
                    isFlagged = true
                });
        }
    }
}
