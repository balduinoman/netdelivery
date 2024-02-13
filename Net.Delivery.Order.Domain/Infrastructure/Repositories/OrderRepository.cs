using Net.Delivery.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Net.Delivery.Order.Domain.Infrastructure.Repositories
{
    /// <summary>
    /// Order repository
    /// </summary>
    public class OrderRepository : IOrderRepository
    {
        /// <summary>
        /// This is like a memory database
        /// </summary>
        private static IList<Entities.Order> _orderDataBase = new List<Entities.Order>();

        /// <summary>
        /// Add an order into database
        /// </summary>
        /// <param name="order">Order's data</param>
        public void Add(Entities.Order order)
        {
            _orderDataBase.Add(order);
        }

        /// <summary>
        /// Get all orders from database
        /// </summary>
        /// <returns>All orders</returns>
        public IList<Entities.Order> GetAll()
        {
            return _orderDataBase.ToList();
        }

        /// <summary>
        /// Get an order from database by its id
        /// </summary>
        /// <returns>Order related to the id asked</returns>
        public Entities.Order GetOrderById(string OrderId)
        {
            Entities.Order orderRecovered = _orderDataBase.FirstOrDefault(o => o.OrderId.Equals(OrderId));

            if (orderRecovered == null)
                throw new Exception("Order not found");

            return orderRecovered;
        }

        /// <summary>
        /// Get all orders from database for determined situation
        /// </summary>
        /// <returns>All orders those have the requested situation</returns>
        public IList<Entities.Order> GetOrdersBySituation(OrderSituation orderSituation)
        {
            return _orderDataBase.Where(o => o.OrderSituation == orderSituation).ToList();
        }

        /// <summary>
        /// Update an order to database
        /// </summary>
        /// <param name="order">Order's data</param>
        public void Update(Entities.Order order)
        {
            Entities.Order orderRecovered = GetOrderById(order.OrderId);

            orderRecovered.OrderSituation = order.OrderSituation;
        }
    }
}
