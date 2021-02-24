using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }

        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }

        public Category Category { get; set; }

    }
}
