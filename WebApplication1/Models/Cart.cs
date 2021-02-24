using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Cart
    {
        public int Id { get; set; }

        public int Amount { get; set; }

        public Customer Customer { get; set; }
    }
}
