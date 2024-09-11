using System.ComponentModel.DataAnnotations;

namespace InventoryManagementBlazorClient.Dtos
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Category name is required.")]
        [StringLength(100, ErrorMessage = "Category name cannot be longer than 100 characters.")]
        [MinLength(3, ErrorMessage = "Category name must be at least 3 characters.")]
        public string Name { get; set; }
    }
}

