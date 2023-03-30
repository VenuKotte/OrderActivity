using Orders.Database.Dtos;
using Orders.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Services
{
    public interface IOrderService
    {
        Task<List<OrderDto>> GetOrderListAsync();
        Task<List<Product>> GeProductsAsync();
        Task<List<Customer>> GeCustomersAsync();
        Task<List<OrderDetail>> GetOrderByIdAsync(int id);
        Task<bool> SaveOrderProductsAsync(OrderProductDto orderDetail);
    }
}
