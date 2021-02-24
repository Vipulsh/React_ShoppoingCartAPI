using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class ProductRepository : IProductDetails
    {
        private readonly AppDbContext dbcontext;
        public ProductRepository(AppDbContext db)
        {
            dbcontext = db;
        }

        public IEnumerable<Product> GetProductDetails()
        {
            return dbcontext.Product.ToList();
        }
    }
}
