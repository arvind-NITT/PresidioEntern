using Microsoft.EntityFrameworkCore;
using PizzaShopAPI.models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace PizzaShopAPI.context
{
    public class PizzaShopContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-QL1TE6V\\SQLEXPRESS;Integrated Security=true;Initial Catalog=dbPizzaShopAPI16may;");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<User> Users { get; set; }

        public DbSet<UserCredential> UserCredentials { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>().HasData(
                new Pizza() { PizzaName = "Pizza", Price = 550, Quantity = 10, Size = "M" },
                new Pizza() { PizzaName = "Cheese Pizza", Price = 150, Quantity = 10, Size = "L" },
                new Pizza() { PizzaName = "Veggie Pizza", Price = 150, Quantity = 10, Size = "S" }




             );




        }
    }
}

