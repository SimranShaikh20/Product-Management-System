using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductManagmentSystem.Models;

namespace ProductManagmentSystem.Data
{
    public class ProductManagmentSystemContext : DbContext
    {
        public ProductManagmentSystemContext (DbContextOptions<ProductManagmentSystemContext> options)
            : base(options)
        {
        }

        public DbSet<ProductManagmentSystem.Models.Product> Product { get; set; } = default!;
    }
}
