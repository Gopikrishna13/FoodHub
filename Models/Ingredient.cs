using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodHub.Models
{
    public class Ingredient
    {
        [Key]
        public int IngredientID { get; set; }
        
        [Required]
        [StringLength(100)]
        public string IngredientName { get; set; }
        
        // Navigation property
        public virtual ICollection<FoodItemIngredient> FoodItemIngredients { get; set; }
        
        public Ingredient()
        {
            FoodItemIngredients = new HashSet<FoodItemIngredient>();
        }
    }
}
