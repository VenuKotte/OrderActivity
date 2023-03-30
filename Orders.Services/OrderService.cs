using Microsoft.EntityFrameworkCore;
using Orders.Database;
using Orders.Database.Dtos;
using Orders.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Services
{
    public class OrderService : IOrderService
    {
        private readonly OrderDbContext _context;
        public OrderService(OrderDbContext orderDbContext)
        {
            _context = orderDbContext;
        }

        public async Task<List<Customer>> GeCustomersAsync()
        {
            return await _context.customers.ToListAsync();
        }

        public async Task<List<Product>> GeProductsAsync()
        {
            return await _context.products.ToListAsync();
        }

        public async Task<List<OrderDetail>> GetOrderByIdAsync(int id)
        {
            var orderDetails = await _context.orderDetails
                                            .Include(od => od.Order)
                                                .ThenInclude(o => o.Customer)
                                            .Include(od => od.Product).Where(x => x.OrderId == id)
                                            .ToListAsync();


            return orderDetails;
        }

        public async Task<List<OrderDto>> GetOrderListAsync()
        {
           return await _context.orders.Include(o => o.Customer).Include(o => o.OrderDetail).ThenInclude(od => od.Product)
                                        .Select(o => new OrderDto
                                        {
                                            Id = o.Id,
                                            OrderNumber = o.OrderNumber,
                                            Customer = o.Customer,
                                            OrderDetail = o.OrderDetail,
                                            TotalAmount = o.OrderDetail.Sum(od => od.Quantity * od.Product.price)
                                        })
                                        .ToListAsync();
        }

        public async Task<bool> SaveOrderProductsAsync(OrderProductDto orderDetail)
        {
            var detailIds = _context.orderDetails.Where(x => x.OrderId == orderDetail.orderId).ToList();
            _context.orderDetails.RemoveRange(detailIds);
            if (orderDetail != null && orderDetail.orderProducts.Any())
            {               
                await _context.orderDetails.AddRangeAsync(orderDetail.orderProducts.Select(o => new OrderDetail
                {
                    OrderId = orderDetail.orderId,
                    ProductId = o.productId,
                    Quantity = o.quantity
                }));               
            }
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
