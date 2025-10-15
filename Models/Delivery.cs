using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class Delivery
    {
        [Key]
        public int DeliveryID { get; set; }
        
        [Required]
        [ForeignKey("Order")]
        public int OrderID { get; set; }
        
        [Required]
        [ForeignKey("Rider")]
        public int RiderID { get; set; }
        
        [ForeignKey("MotorBike")]
        [StringLength(20)]
        public string BikeRegNo { get; set; }
        
        [Required]
        public DateTime DeliveryDateTime { get; set; }
        
        // Navigation properties
        public virtual Order Order { get; set; }
        public virtual Rider Rider { get; set; }
        public virtual MotorBike MotorBike { get; set; }
    }
}
