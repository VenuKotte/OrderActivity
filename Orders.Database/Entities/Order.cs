using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Database.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Guid OrderNumber { get; set; }
        public int CustomerId { get; set; }
        public Customer? Customer { get; set; }
        public List<OrderDetail>? OrderDetail { get; set; }


    }
}
