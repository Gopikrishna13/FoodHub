using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        
        [Required]
        [ForeignKey("Customer")]
        public int CustomerID { get; set; }
        
        [Required]
        public DateTime OrderDate { get; set; }
        
        [Required]
        public TimeSpan OrderTime { get; set; }
        
        [Required]
        [StringLength(50)]
        public string OrderStatus { get; set; }
        
        [Required]
        [StringLength(50)]
        public string PaymentMethod { get; set; }
        
        [Required]
        public decimal OrderAmount { get; set; }
        
        public DateTime? DispatchedTime { get; set; }
        
        // Navigation properties
        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
        
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
            Deliveries = new HashSet<Delivery>();
        }
    }
}
