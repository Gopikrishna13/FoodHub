using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class FoodItemIngredient
    {
        [Key, Column(Order = 0)]
        [ForeignKey("FoodItem")]
        public int ItemID { get; set; }
        
        [Key, Column(Order = 1)]
        [ForeignKey("Ingredient")]
        public int IngredientID { get; set; }
        
        // Navigation properties
        public virtual FoodItem FoodItem { get; set; }
        public virtual Ingredient Ingredient { get; set; }
    }
}
