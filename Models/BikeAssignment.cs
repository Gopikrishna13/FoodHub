using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class BikeAssignment
    {
        [Key]
        public int AssignmentID { get; set; }
        
        [Required]
        [ForeignKey("Rider")]
        public int RiderID { get; set; }
        
        [Required]
        [ForeignKey("MotorBike")]
        [StringLength(20)]
        public string BikeRegNo { get; set; }
        
        [Required]
        public DateTime AssignmentDate { get; set; }
        
        [Required]
        public int StartMeterReading { get; set; }
        
        public int? EndMeterReading { get; set; }
        
        // Navigation properties
        public virtual Rider Rider { get; set; }
        public virtual MotorBike MotorBike { get; set; }
    }
}
