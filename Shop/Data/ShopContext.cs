using Microsoft.EntityFrameworkCore;
using Shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class ShopContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; }=null!;
        public DbSet<Product> Products { get; set; } = null!;
        public ShopContext(DbContextOptions options):base(options)
        { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ShopDatabase;Integrated Security=True;TrustServerCertificate=True;");
        //}


    }
}
