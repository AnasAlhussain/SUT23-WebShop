using Microsoft.EntityFrameworkCore;
using SUT23_WebShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_WebShop.Data
{
    internal class WebShopDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = LAPTOP-ASDGP29P;Initial Catalog = SUT23_WebShopDB;Integrated Security=True;");
        }
    }
}
