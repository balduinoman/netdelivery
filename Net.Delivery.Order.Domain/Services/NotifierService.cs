using Net.Delivery.Order.Domain.Entities;

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
            SendEmail(order.Customer);
        }

        /// <summary>
        /// Sends email about order update to customer
        /// </summary>
        /// <param name="customer">Customer data</param>
        private void SendEmail(Customer customer)
        {

        }
    }
}
