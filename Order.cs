using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OP2_Project.Data
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
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

        private ProdductContext prodductContext;
        public List<OrderLine> orderLines;
        public List<Product> products;
        public List<Customer> customers;


        public Order(ProdductContext context)
        {
            prodductContext = context;
            orderLines = new List<OrderLine>();
            products = new List<Product>();
            customers = new List<Customer>();
        }

        
        public void UpdateProduct(Product Products)
        {
            //görs lättast pages-filen. Se Nisses labb4
        }

        public async Task<List<Product>> AllProducts()
        {
            return await Task.Run(() => products);
        }

        public void AddProducts(Product Products)
        {
            products.Add(Products);
        }

        public void RemoveProducts(Product Products)
        {
            products.Remove(Products);
        }
    }
}
