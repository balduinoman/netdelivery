using Net.Delivery.Order.Domain.Entities;
using System;

namespace Net.Delivery.Order.Domain.Services
{
    /// <summary>
    /// Notifier service
    /// </summary>
    public class NotifierService : INotifierService
    {
        /// <summary>
        /// Notifies the customer about some order update
        /// </summary>
        /// <param name="order">Order data</param>
        public void Notify(Entities.Order order)
        {
            SendEmail(order.Customer.Email);
        }

        /// <summary>
        /// Sends email about order update to customer
        /// </summary>
        /// <param name="customer">Customer data</param>
        private void SendEmail(string email)
        {
            Console.WriteLine("Email sent to recipient: " + email);
        }
    }
}
