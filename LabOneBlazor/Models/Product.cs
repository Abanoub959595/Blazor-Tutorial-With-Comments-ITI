using System.ComponentModel.DataAnnotations;

namespace LabOneBlazor.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name Is Required")]
        [MinLength(3, ErrorMessage = "Name Must be greater than three chars ")]
        [MaxLength(20, ErrorMessage = "Name Must be less than 20 chars ")]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
    }
}