using Sparcpoint.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sparcpoint.Abstract
{
    public interface IProductRepository
    {
        Task<Product> AddProductAsync(Product product);
        Task<IEnumerable<Product>> SearchProductsAsync(ProductSearchCriteria criteria);
        Task AddInventoryAsync(int productId, int quantity);
        Task RemoveInventoryAsync(int productId, int quantity);
        Task<int> GetInventoryCountAsync(int productId);
    }
}
