using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class OrderItem
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        
        [Key, Column(Order = 1)]
        [ForeignKey("FoodItem")]
        public int ItemID { get; set; }
        
        [Required]
        public int Quantity { get; set; }
        
        // Navigation properties
        public virtual Order Order { get; set; }
        public virtual FoodItem FoodItem { get; set; }
    }
}
