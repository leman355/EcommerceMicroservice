using BasketService.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketService.DataAccess.Concrete.EntityFramework
{
    public class BasketDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsbuilder)
        {
            optionsbuilder.UseSqlServer("Data Source=WIN-OO1ICO19G9E;initial catalog=EcommerceBasketServiceDb;Trusted_connection=true;TrustServerCertificate=True;");
        }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
    }
}
