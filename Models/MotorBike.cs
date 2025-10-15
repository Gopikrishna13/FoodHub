using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FoodHub.Models
{
    public class MotorBike
    {
        [Key]
        [StringLength(20)]
        public string BikeRegNo { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Brand { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Model { get; set; }
        
        [Required]
        [StringLength(50)]
        public string EngineNumber { get; set; }
        
        [Required]
        public DateTime RegisteredDate { get; set; }
        
        // Navigation properties
        public virtual ICollection<BikeColor> BikeColors { get; set; }
        public virtual ICollection<BikeAssignment> BikeAssignments { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
        
        public MotorBike()
        {
            BikeColors = new HashSet<BikeColor>();
            BikeAssignments = new HashSet<BikeAssignment>();
            Deliveries = new HashSet<Delivery>();
        }
    }
}
