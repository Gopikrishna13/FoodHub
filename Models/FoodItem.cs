using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class FoodItem
    {
        [Key]
        public int ItemID { get; set; }
        
        [Required]
        [StringLength(100)]
        public string ItemName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Category { get; set; }
        
        [Required]
        public decimal Price { get; set; }
        
        // Navigation properties
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<FoodItemIngredient> FoodItemIngredients { get; set; }
        
        public FoodItem()
        {
            OrderItems = new HashSet<OrderItem>();
            FoodItemIngredients = new HashSet<FoodItemIngredient>();
        }
    }
}
