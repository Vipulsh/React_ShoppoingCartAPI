using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface ICartDetailsRepository
    {

        IEnumerable<CartDetail> GetCartDetails();
    }
}
