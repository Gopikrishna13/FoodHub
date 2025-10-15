using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class Dependent
    {
        [Key]
        public int DependentID { get; set; }
        
        [Required]
        [ForeignKey("Rider")]
        public int RiderID { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Relationship { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        // Navigation property
        public virtual Rider Rider { get; set; }
    }
}
