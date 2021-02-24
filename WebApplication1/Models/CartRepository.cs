using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CartRepository : ICartDetailsRepository
    {
        private readonly AppDbContext dbContext;

        public CartRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IEnumerable<CartDetail> GetCartDetails()
        {
           return dbContext.CartDetails.ToList();
        }
    }
}
