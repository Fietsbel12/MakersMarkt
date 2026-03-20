using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakersMarkt.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                ConfigurationManager.ConnectionStrings["MakersMarkt"].ConnectionString,
                ServerVersion.Parse("8.0.30")
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Player" },
                new Role { RoleId = 2, RoleName = "Admin" }
            );

            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, UserName = "Admin", Password = BCrypt.Net.BCrypt.HashPassword("Admin123"), RoleId = 2, CreditBalance = 69 }
            );
        }
    }
}
