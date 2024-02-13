namespace Net.Delivery.Order.Domain.Entities
{
    /// <summary>
    /// Customer entity
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Customer's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Customer's phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Customer's e-mail
        /// </summary>
        public string Email { get; set; }

    }
}
