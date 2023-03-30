using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Database.Dtos
{
    public  class OrderProductDto
    {
        public int customerId { get; set; }
        public int orderId { get; set; }

        public List<OrderProducts> orderProducts { get; set; }
    }

    public class OrderProducts
    {
        public decimal price { get; set;}
        public int productId { get; set;}
        public int quantity { get; set;}
    }
}
