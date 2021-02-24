using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class AppDbContext :DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : 
            base(options)
        {

        }

        public DbSet<CartDetail> CartDetails { get; set; }

        public DbSet<Product> Product { get; set; }

    }
}
