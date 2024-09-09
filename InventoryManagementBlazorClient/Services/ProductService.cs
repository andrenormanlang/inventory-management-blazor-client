using System.Net.Http.Json;
using InventoryManagementBlazorClient.Models;
using InventoryManagementBlazorClient.Dtos;

namespace InventoryManagementBlazorClient.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            // Ensure non-null result by returning an empty list if the response is null.
            return await _httpClient.GetFromJsonAsync<List<Product>>("product") ?? new List<Product>();
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"product/{productId}");
        }

        public async Task<HttpResponseMessage> CreateProductAsync(Product product)
        {
            return await _httpClient.PostAsJsonAsync("product", product);
        }

        public async Task<HttpResponseMessage> UpdateProductAsync(int productId, Product product)
        {
            return await _httpClient.PutAsJsonAsync($"product/{productId}", product);
        }

        public async Task<HttpResponseMessage> DeleteProductAsync(int productId)
        {
            return await _httpClient.DeleteAsync($"product/{productId}");
        }

        public async Task<HttpResponseMessage> CreateProductsBulkAsync(IEnumerable<Product> products)
        {
            return await _httpClient.PostAsJsonAsync("product/bulk", products);
        }
    }
}
