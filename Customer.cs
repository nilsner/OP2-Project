
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projectwork.Data
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone{ get; set; }
        public string Email{ get; set; }
        public List<Order> order { get; set; }

        public Customer() 
        {
            order = new List<Order>();
        }
    }
}
