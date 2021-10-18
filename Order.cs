
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projectwork.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId{ get; set; }
        public Customer customer { get; set; }
        public DateTime OrderDate { get; set; }
        public string DeliveryAdress { get; set; }
        public bool PaymentCompleted { get; set; }
        public bool Dispatched { get; set; }
        public List<OrderLine> items { get; set; }
        public Order()
        {
            items = new List<OrderLine>();
        }
    }
}
