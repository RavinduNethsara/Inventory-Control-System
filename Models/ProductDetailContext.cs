using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryControlSystem.Models
{
    public class ProductDetailContext : DbContext
    {
        public ProductDetailContext(DbContextOptions<ProductDetailContext> options) : base(options)
        {

        }

        public DbSet<Product> Product { get; set; }
        public DbSet<ProductCategory> ProductCategory { get; set; }
    }
}
