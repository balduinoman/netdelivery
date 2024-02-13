using System;
using System.Collections.Generic;

namespace Net.Delivery.Order.Domain.Entities
{
    /// <summary>
    /// Order entity
    /// </summary>
    public class Order
    {
        /// <summary>
        /// Order id
        /// </summary>
        public string OrderId { get; set; }

        /// <summary>
        /// Order date
        /// </summary>
        public DateTime OrderCreateDate { get; set; }

        /// <summary>
        /// Order last update
        /// </summary>
        public DateTime OrderLastUpdate { get; set; }

        /// <summary>
        /// Order`s situation
        /// </summary>
        public OrderSituation OrderSituation { get; set; }

        /// <summary>
        /// Order`s items
        /// </summary>
        public IList<string> Items { get; set; }

        /// <summary>
        /// Order`s customer
        /// </summary>
        public Customer Customer { get; set; }

        /// <summary>
        /// Order builder
        /// </summary>
        /// <param name="items">Order items</param>
        /// <param name="customer">Order customer</param>
        public Order(IList<string> items, Customer customer)
        {
            OrderId = Guid.NewGuid().ToString();
            OrderCreateDate = DateTime.Now;
            OrderLastUpdate = OrderCreateDate;
            OrderSituation = OrderSituation.CREATED;
            Items = items;
            Customer = customer;
        }

        public Order()
        {

        }
    }
}
