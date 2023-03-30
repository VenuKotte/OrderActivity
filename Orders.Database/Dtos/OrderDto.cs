using Orders.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Database.Dtos
{
    public class OrderDto : Order
    {
       public decimal TotalAmount { get; set; }
    }
}
