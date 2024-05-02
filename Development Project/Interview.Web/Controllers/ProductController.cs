using Interview.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interview.Web.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // NOTE: Sample Action
        [HttpGet]
        public Task<IActionResult> GetAllProducts()
        {
            return Task.FromResult((IActionResult)Ok(new object[] { }));
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] ProductDto productDto)
        {
            var product = await _productService.AddProductAsync(productDto);
            return Ok(product);
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchProducts([FromQuery] ProductSearchCriteriaDto criteria)
        {
            var products = await _productService.SearchProductsAsync(criteria);
            return Ok(products);
        }

        [HttpPost("{productId}/inventory/add")]
        public async Task<IActionResult> AddInventory(int productId, [FromBody] int quantity)
        {
            await _productService.AddInventoryAsync(productId, quantity);
            return Ok();
        }

        [HttpPost("{productId}/inventory/remove")]
        public async Task<IActionResult> RemoveInventory(int productId, [FromBody] int quantity)
        {
            await _productService.RemoveInventoryAsync(productId, quantity);
            return Ok();
        }

        [HttpGet("{productId}/inventory/count")]
        public async Task<IActionResult> GetInventoryCount(int productId)
        {
            var count = await _productService.GetInventoryCountAsync(productId);
            return Ok(count);
        }
    }
}
