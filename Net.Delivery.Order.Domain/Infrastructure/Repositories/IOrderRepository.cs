using Net.Delivery.Order.Domain.Entities;
using System.Collections.Generic;

namespace Net.Delivery.Order.Domain.Infrastructure.Repositories
{
    /// <summary>
    /// Order repository
    /// </summary>
    public interface IOrderRepository
    {
        /// <summary>
        /// Add an order into database
        /// </summary>
        /// <param name="order">Order's data</param>
        void Add(Entities.Order order);

        /// <summary>
        /// Update an order to database
        /// </summary>
        /// <param name="order">Order's data</param>
        void Update(Entities.Order order);

        /// <summary>
        /// Get all orders from database
        /// </summary>
        /// <returns>All orders</returns>
        IList<Entities.Order> GetAll();

        /// <summary>
        /// Get an order from database by its id
        /// </summary>
        /// <returns>Order related to the id requested</returns>
        Entities.Order GetOrderById(string OrderId);

        /// <summary>
        /// Get all orders from database for determined situation
        /// </summary>
        /// <returns>All orders those have the requested situation</returns>
        IList<Entities.Order> GetOrdersBySituation(OrderSituation orderSituation);
    }
}
