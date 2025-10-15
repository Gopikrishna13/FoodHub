using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class BikeColor
    {
        [Key, Column(Order = 0)]
        [ForeignKey("MotorBike")]
        [StringLength(20)]
        public string BikeRegNo { get; set; }
        
        [Key, Column(Order = 1)]
        [StringLength(30)]
        public string Color { get; set; }
        
        // Navigation property
        public virtual MotorBike MotorBike { get; set; }
    }
}
