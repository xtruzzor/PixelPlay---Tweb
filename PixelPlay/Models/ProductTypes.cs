﻿using System.ComponentModel.DataAnnotations;

namespace PixelPlay.Models
{
    public class ProductTypes
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Product Type")]
        public string? ProductType { get; set; }

    }
}
