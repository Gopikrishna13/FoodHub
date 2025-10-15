using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class Customer
    {
        [Key]
        public int CustomerID { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(12)]
        public string NIC { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        [StringLength(15)]
        public string ContactNumber { get; set; }
        
        [Required]
        [StringLength(10)]
        public string AddressLineNo { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Lane { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Street { get; set; }
        
        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(255)]
        public string UserName { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }
        
        // Navigation property
        public virtual ICollection<Order> Orders { get; set; }
        
        public Customer()
        {
            Orders = new HashSet<Order>();
        }
    }
}
