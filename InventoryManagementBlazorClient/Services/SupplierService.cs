using System.Net.Http.Json;
using InventoryManagementBlazorClient.Models;

namespace InventoryManagementBlazorClient.Services
{
    public class SupplierService
    {
        private readonly HttpClient _httpClient;

        public SupplierService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Supplier>> GetSuppliersAsync()
        {
            return await _httpClient.GetFromJsonAsync<List<Supplier>>("supplier");
        }

        public async Task<Supplier> GetSupplierByIdAsync(int supplierId)
        {
            return await _httpClient.GetFromJsonAsync<Supplier>($"supplier/{supplierId}");
        }

        public async Task<HttpResponseMessage> CreateSupplierAsync(Supplier supplier)
        {
            return await _httpClient.PostAsJsonAsync("supplier", supplier);
        }

        public async Task<HttpResponseMessage> UpdateSupplierAsync(int supplierId, Supplier supplier)
        {
            return await _httpClient.PutAsJsonAsync($"supplier/{supplierId}", supplier);
        }

        public async Task<HttpResponseMessage> DeleteSupplierAsync(int supplierId)
        {
            return await _httpClient.DeleteAsync($"supplier/{supplierId}");
        }

        public async Task<HttpResponseMessage> CreateSuppliersBulkAsync(IEnumerable<Supplier> suppliers)
        {
            return await _httpClient.PostAsJsonAsync("supplier/bulk", suppliers);
        }
    }
}
