using Net.Delivery.Order.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Net.Delivery.Order.Domain.Services
{
    /// <summary>
    /// Contract within all the order service behaviors
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Creates an order
        /// </summary>
        /// <param name="items">Order items</param>
        /// <param name="customer">Order customer</param>
        Task CreateOrder(IList<string> items, Customer customer);

        /// <summary>
        /// Updates an order
        /// </summary>
        /// <param name="orderId">Order identification</param>
        /// <param name="orderSituation">Order situation</param>
        Task UpdateOrderSituation(string orderId, OrderSituation orderSituation);

        /// <summary>
        /// Gets all orders to delivery
        /// </summary>
        IList<Entities.Order> GetAllOrdersToDelivery();
    }
}
