using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Orders.Database;
using Orders.Database.Dtos;
using Orders.Database.Entities;
using Orders.Services;

namespace Orders.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // get list of orders
        [HttpGet]
        [Route("orders")]
        public async Task<IActionResult> GetOrdersAsync()
        {
            var orders = await _orderService.GetOrderListAsync();

            return Ok(orders);
        }

        // get order details through id
        [HttpGet]
        [Route("details")]
        public async Task<IActionResult> GetOrderByIdAsync(int id)
        {
            var orderDetails = await _orderService.GetOrderByIdAsync(id);
            return Ok(orderDetails);
        }

        // get list of products

        [HttpGet]
        [Route("products")]

        public async Task<IActionResult> GeProductsAsync()
        {
            var products = await _orderService.GeProductsAsync();

            return Ok(products);
        }

        // save products under a order

        [HttpPost]
        [Route("save/order/products")]
        public async  Task<IActionResult> SaveOrderProductsAsync([FromBody] OrderProductDto orderDetail)
        {
            var res = await _orderService.SaveOrderProductsAsync(orderDetail);
            return Ok(res);
        }

        // get list of customers

        [HttpGet]
        [Route("customers")]

        public async Task<IActionResult> GeCustomersAsync()
        {
            var customers = await _orderService.GeCustomersAsync();

            return Ok(customers);
        }



    }
}
