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
            return await _httpClient.GetFromJsonAsync<List<Category>>("category");
        }

        public async Task<Category> GetCategoryByIdAsync(int categoryId)
        {
            return await _httpClient.GetFromJsonAsync<Category>($"category/{categoryId}");
        }

        public async Task<HttpResponseMessage> CreateCategoryAsync(Category category)
        {
            return await _httpClient.PostAsJsonAsync("category", category);
        }

        public async Task<HttpResponseMessage> UpdateCategoryAsync(int categoryId, Category category)
        {
            return await _httpClient.PutAsJsonAsync($"category/{categoryId}", category);
        }

        public async Task<HttpResponseMessage> DeleteCategoryAsync(int categoryId)
        {
            return await _httpClient.DeleteAsync($"category/{categoryId}");
        }
    }
}
