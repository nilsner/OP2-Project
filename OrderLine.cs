
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projectwork.Data
{
    public class OrderLine
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product product { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public Order order { get; set; }
        public OrderLine()
        {
        }
    }
}
