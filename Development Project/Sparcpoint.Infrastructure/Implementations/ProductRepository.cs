using Sparcpoint.Abstract;
using Sparcpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparcpoint.Infrastructure.Implementations
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Product> AddProductAsync(Product product)
        {
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return product;
        }

        public async Task<IEnumerable<Product>> SearchProductsAsync(ProductSearchCriteria criteria)
        {
            // Implement search logic based on criteria
        }

        public async Task AddInventoryAsync(int productId, int quantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                product.Inventory += quantity;
                await _context.SaveChangesAsync();
            }
        }

        public async Task RemoveInventoryAsync(int productId, int quantity)
        {
            var product = await _context.Products.FindAsync(productId);
            if (product != null)
            {
                product.Inventory -= quantity;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> GetInventoryCountAsync(int productId)
        {
            var product = await _context.Products.FindAsync(productId);
            return product?.Inventory ?? 0;
        }
    }
}
