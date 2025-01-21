using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CRUDApplication.Models;

namespace CRUDApplication.Data
{
    public class CRUDApplicationContext : DbContext
    {
        public CRUDApplicationContext (DbContextOptions<CRUDApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<CRUDApplication.Models.Product> Product { get; set; } = default!;

    }
}
