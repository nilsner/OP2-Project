using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Op2_ver._2.Data
{
    public class ProductService
    {
        private readonly CustomerManagementContext _context;
        public ProductService(CustomerManagementContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> AllProducts()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product> AddProductsAsync(Product prod)
        {
            try
            {
                _context.Products.Add(prod);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            return prod;
        }

        public async Task<Product> DeleteProductAsync(Product prod)
        {
            try
            {
                _context.Products.Remove(prod);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
            return prod;
        }

        public void UpdateProduct(Product prod)
        {
             
        }

        public async Task<List<Product>> DisplayStockZero()
        {
            return await _context.Products.Where(a => a.Stock == 0).ToListAsync();
        }
    }
}
