using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodHub.Models
{
    public class Rider
    {
        [Key]
        public int RiderID { get; set; }
        
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        
        [StringLength(50)]
        public string MiddleName { get; set; }
        
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        
        [Required]
        [StringLength(12)]
        public string NIC { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        [StringLength(15)]
        public string ContactNumber { get; set; }
        
        [Required]
        [StringLength(20)]
        public string LicenseNumber { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Address { get; set; }
        
        [Required]
        public int Age { get; set; }
        
        [Required]
        [StringLength(255)]
        public string Password { get; set; }


        [Required]
        [StringLength(255)]
        public string UserName { get; set; }
        
        // Navigation properties
        public virtual ICollection<Dependent> Dependents { get; set; }
        public virtual ICollection<BikeAssignment> BikeAssignments { get; set; }
        public virtual ICollection<Delivery> Deliveries { get; set; }
        
        public Rider()
        {
            Dependents = new HashSet<Dependent>();
            BikeAssignments = new HashSet<BikeAssignment>();
            Deliveries = new HashSet<Delivery>();
        }
    }
}
