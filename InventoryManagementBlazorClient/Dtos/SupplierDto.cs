using System.ComponentModel.DataAnnotations;

namespace InventoryManagementBlazorClient.Dtos
{
    public class SupplierDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Supplier name is required.")]
        [StringLength(100, ErrorMessage = "Supplier name cannot be longer than 100 characters.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Supplier address is required.")]
        [StringLength(200, ErrorMessage = "Supplier address cannot be longer than 200 characters.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Supplier phone is required.")]
        [Phone(ErrorMessage = "Please provide a valid phone number.")]
        [StringLength(15, ErrorMessage = "Phone number cannot be longer than 15 characters.")]
        public string Phone { get; set; }
    }
}
