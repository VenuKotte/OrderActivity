using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Database.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string?  name { get; set; }

        [Precision(18, 2)]
        public decimal  price { get; set; }
    }
}
