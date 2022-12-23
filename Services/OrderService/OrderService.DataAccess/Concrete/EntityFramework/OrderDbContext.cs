using Microsoft.EntityFrameworkCore;
using OrderService.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderService.DataAccess.Concrete.EntityFramework
{
    public class OrderDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Data Source=WIN-OO1ICO19G9E;initial catalog=EcommerceOrderServiceDb;Trusted_connection=true;TrustServerCertificate=True;");
        }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
