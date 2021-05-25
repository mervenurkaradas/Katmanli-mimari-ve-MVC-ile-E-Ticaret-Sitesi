using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Order
    {

        public Order()
        {
            OrderItems = new List<OrderItems>();
        }
        public int Id { get; set; }
        public string OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public string UserId  { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string OrderNote { get; set; }
        public List<OrderItems> OrderItems { get; set; }
    }
}
