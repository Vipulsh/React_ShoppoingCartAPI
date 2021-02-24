﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class CartDetail
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int Price { get; set; }

        public string ProductName { get; set; }
        public Product Product { get; set; }

        public Cart Cart { get; set; }
    }
}
