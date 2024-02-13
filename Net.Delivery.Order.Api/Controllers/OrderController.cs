using Microsoft.AspNetCore.Mvc;
using Net.Delivery.Order.Domain.Entities;
using Net.Delivery.Order.Domain.Services;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Net.Delivery.Order.Api.Controllers
{
    /// <summary>
    /// Order Api
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        /// <summary>
        /// Creates an order api controller
        /// </summary>
        /// <param name="orderService">Order service instance</param>
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        /// <summary>
        /// Creates an order
        /// </summary>
        /// <param name="items">Order items</param>
        /// <param name="customer">Order customer</param>
        [HttpPost("create-order")]
        public async void CreateOrder([FromForm] IList<string> items, [FromForm] Customer customer)
        {
           await _orderService.CreateOrder(items, customer);
        }

        /// <summary>
        /// Updates an order situation
        /// </summary>
        /// <param name="orderId">Order identification</param>
        /// <param name="orderSituation">Order situation</param>
        [HttpPut("update-order-situation")]
        public async void UpdateOrderSituation([FromForm] string orderId, [FromForm] OrderSituation orderSituation)
        {
            await _orderService.UpdateOrderSituation(orderId, orderSituation);
        }

        /// <summary>
        /// Gets all orders to delivery
        /// </summary>
        [HttpGet("get-all-orders-to-delivery")]
        public IList<Domain.Entities.Order> GetAllOrdersToDelivery()
        {
           return _orderService.GetAllOrdersToDelivery();
        }
    }
}
