using System.Net.Http.Json;
using InventoryManagementBlazorClient.Models;

namespace InventoryManagementBlazorClient.Services
{
    public class CategoryService
    {
        private readonly HttpClient _httpClient;

        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Category>>("categories");
        }

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
        {
            return await _httpClient.GetFromJsonAsync<Category>($"categories/{categoryId}");
        }

        public async Task<HttpResponseMessage> CreateCategoryAsync(Category category)
        {
            return await _httpClient.PostAsJsonAsync("categories", category);
        }

        public async Task<HttpResponseMessage> UpdateCategoryAsync(int categoryId, Category category)
        {
            return await _httpClient.PutAsJsonAsync($"categories/{categoryId}", category);
        }

        public async Task<HttpResponseMessage> DeleteCategoryAsync(int categoryId)
        {
            return await _httpClient.DeleteAsync($"categories/{categoryId}");
        }

        public async Task<HttpResponseMessage> CreateCategoriesBulkAsync(IEnumerable<Category> categories)
        {
            return await _httpClient.PostAsJsonAsync("categories/bulk", categories);
        }
    }
}
