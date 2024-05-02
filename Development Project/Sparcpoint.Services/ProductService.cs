using Interview.Web.Models;
using Sparcpoint.Abstract;
using Sparcpoint.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparcpoint.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> AddProductAsync(ProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                // Map other properties from DTO
            };

            return await _productRepository.AddProductAsync(product);
        }

        public async Task<IEnumerable<Product>> SearchProductsAsync(ProductSearchCriteriaDto criteria)
        {
            // Map DTO criteria to domain model criteria and call repository method
        }

        public async Task AddInventoryAsync(int productId, int quantity)
        {
            await _productRepository.AddInventoryAsync(productId, quantity);
        }

        public async Task RemoveInventoryAsync(int productId, int quantity)
        {
            await _productRepository.RemoveInventoryAsync(productId, quantity);
        }

        public async Task<int> GetInventoryCountAsync(int productId)
        {
            return await _productRepository.GetInventoryCountAsync(productId);
        }
    }
}
