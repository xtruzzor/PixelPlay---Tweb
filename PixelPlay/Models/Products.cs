using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PixelPlay.Models
{
    public class Products
    {
        public int Id { get; set; }

        [Required]
        public string? GameName { get; set; }

        [Required]
        public string? Description { get; set; }

        [Required]
        public string? Platform { get; set; }

        [Required]
        public string? Publisher { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public decimal? Price { get; set; }

        public string? Image { get; set; }

        [Required]
        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }

        [Required]
        [Display(Name = "Product Type")]
        public int ProductTypeId { get; set; }

        [ForeignKey("ProductTypeId")]
        public ProductTypes? ProductTypes { get; set; }

    }
}
