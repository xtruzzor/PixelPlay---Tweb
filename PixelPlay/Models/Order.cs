using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PixelPlay.Models
{
    public class Order
    {

        public Order()
        {
            OrderDetails = new List<OrderDetails>();
            
        }

        public int Id { get; set; }
        [Display(Name = "Order No")]
        public string? OrderNo { get; set; }

        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        

        public virtual List<OrderDetails> OrderDetails { get; set; }
    }
}
