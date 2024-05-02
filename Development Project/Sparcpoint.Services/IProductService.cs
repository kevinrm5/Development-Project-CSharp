using Interview.Web.Models;
using Sparcpoint.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Sparcpoint.Services
{
    public interface IProductService
    {
        Task<Product> AddProductAsync(ProductDto productDto);
        Task<IEnumerable<Product>> SearchProductsAsync(ProductSearchCriteriaDto criteria);
        Task AddInventoryAsync(int productId, int quantity);
        Task RemoveInventoryAsync(int productId, int quantity);
        Task<int> GetInventoryCountAsync(int productId);
    }
}
