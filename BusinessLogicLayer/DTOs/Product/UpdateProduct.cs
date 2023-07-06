using System.ComponentModel.DataAnnotations;

namespace BusinessLogicLayer.DTOs.Product
{
    public class UpdateProduct
    {
        public Guid Id { get; set; }


        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, MinimumLength = 0, ErrorMessage = "Name length should be between 0 and 100 characters.")]
        public string Name { get; set; }
    }
}
