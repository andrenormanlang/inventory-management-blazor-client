using System.ComponentModel.DataAnnotations;

namespace InventoryManagementBlazorClient.Dtos
{
    public class ProductDto
    {
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name cannot be longer than 100 characters.")]
        [MinLength(5, ErrorMessage = "Product name must be at least 5 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot be longer than 500 characters.")]
        [MinLength(50, ErrorMessage = "Description must be at least 50 characters.")]
        public string Description { get; set; }

        [Range(5.00, double.MaxValue, ErrorMessage = "Price must be greater than 5.")]
        public double Price { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        public string? CategoryName { get; set; }
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Supplier is required.")]
        public string? SupplierName { get; set; }
        public int SupplierId { get; set; }
    }
}

