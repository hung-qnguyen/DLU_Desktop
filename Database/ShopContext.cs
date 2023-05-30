using GroupProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupProject.Database
{
    public class ShopContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ShopContext"].ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User() { Id = 1, UserName = "admin", Password = "admin123", Role = User.UserRole.Admin },
                new User() { Id = 2, UserName = "user", Password = "user", Role = User.UserRole.User });
            modelBuilder.Entity<Category>().HasData(
                new Category() { CategoryId = 1, CategoryName = "ao thun", CategoryDesc = "" },
                new Category() { CategoryId = 2, CategoryName = "quan tay", CategoryDesc = "" });


            //modelBuilder.Entity<Product>().OnDelete(DeleteBehavior.Cascade);
            
        }

    }
}
