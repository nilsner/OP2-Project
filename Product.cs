using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OP2_Project.Data
{

    public class Product
    {
        public List<Product> products;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
        public DateTime RestockingDate { get; set; }

        //public async Task<List<Product>> DisplayEmptyStock()
        //{
        //    return await products.Where(b => b.Stock == 0).ToListAsync();
        //}

        public async Task<List<Product>> AllProducts()
        {
            return await Task.Run(() => products);
        }
        public Product()
        {
            products = new List<Product>();
        }
    }
}
