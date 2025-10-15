using System;
using System.Linq;
using System.Data.Entity;
using FoodHub.Data;
using FoodHub.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;

namespace FoodHub.Services
{
    /// <summary>
    /// Example service class showing how to use the FoodHub database context
    /// </summary>
    public class FoodHubService
    {
        /// <summary>
        /// Add a new customer with enhanced error handling and debugging
        /// </summary>
        public bool AddCustomer(Customer customer)
        {
            try
            {
                // Validate customer object
                if (customer == null)
                {

                    return false;
                }

                

                using (var context = new FoodHubContext())
                {
                   
                  

                    var existingCustomer = context.Customers.FirstOrDefault(c => c.NIC == customer.NIC && c.UserName==customer.UserName);
                    
                    if (existingCustomer != null)
                    {
                        
                        return false;
                    }
                  

                    // Add customer
                    context.Customers.Add(customer);
               
                    
                    int result = context.SaveChanges();
              
                    
                    return result > 0;
                }
            }
         
          
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error adding customer: {ex.Message}");
                Console.WriteLine($"Stack trace: {ex.StackTrace}");
                return false;
            }
        }

        public bool AddDependant(Dependent dependent)
        {
            using (var context = new FoodHubContext())
            {
                context.Dependents.Add(dependent);
                int result = context.SaveChanges();
                return result > 0;
            }
        }
        public bool AddRider(Rider rider)
        {
            if (rider == null)
            {

                return false;
            }



            using (var context = new FoodHubContext())
            {



                var existingRider = context.Riders.FirstOrDefault(c => c.NIC == rider.NIC && c.UserName == rider.UserName);

                if (existingRider != null)
                {

                    return false;
                }


         
                context.Riders.Add(rider);


                int result = context.SaveChanges();


                return result > 0;
            }
        }
        public bool AddBike(MotorBike motorBike)
        {
            if (motorBike == null)
                return false;

            using (var context = new FoodHubContext())
            {
                var existingBike = context.MotorBikes.FirstOrDefault(c => c.BikeRegNo == motorBike.BikeRegNo && c.EngineNumber== motorBike.EngineNumber);

                if (existingBike != null)
                {
                    return false;
                }

                context.MotorBikes.Add(motorBike);
                int result = context.SaveChanges();
                return result > 0;

            }

        }

        public bool AddBikeColor(BikeColor bikeColor)
        {
            if (bikeColor == null)
                return false;

            using (var context = new FoodHubContext())
            {
                

                context.BikeColors.Add(bikeColor);
                int result = context.SaveChanges();
                return result > 0;

            }
        }

        public int TotalUsers()
        {
            using (var context = new FoodHubContext())
            {
                int totalUsers=context.Customers.Count();
                return totalUsers;
            }
        }

        public int TotalBikes()
        {
            using (var context = new FoodHubContext())
            {
                int totalBikes=context.MotorBikes.Count();
                return totalBikes;
            }
        }

        public int TotalRiders()
        {
            using (var context = new FoodHubContext())
            {
                return context.Riders.Count();
            }
        }

        public int TotalOrders()
        {
            using (var context = new FoodHubContext())
            {
                return context.Orders.Count();
            }
        }

        public int PendingOrders()
        {
            using (var context = new FoodHubContext())
            {
                return context.Orders.Where(o=>o.OrderStatus=="Pending").Count();
            }
        }

        public int DeliveredOrders()
        {
            using (var context = new FoodHubContext())
            {
                return context.Orders.Where(o => o.OrderStatus == "Delivered").Count();
            }
        }

        public int CancelledOrders()
        {
            using (var context = new FoodHubContext())
            {
                return context.Orders.Where(o => o.OrderStatus == "Cancelled").Count();
            }
        }

        /// <summary>
        /// Get all customers (for debugging purposes)
        /// </summary>
        public System.Collections.Generic.List<Customer> GetAllCustomers()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Customers.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting all customers: {ex.Message}");
                return new System.Collections.Generic.List<Customer>();
            }
        }

        public List<MotorBike>GetAllBikes()
        {
            using (var context = new FoodHubContext())
            {
                return context.MotorBikes.ToList();
            }
        }

        public void DeleteBikeColor(string RegNo)
        {
            using (var context = new FoodHubContext())
            {
                
                var colors = context.BikeColors
                                    .Where(c => c.BikeRegNo == RegNo)
                                    .ToList();

                if (colors.Any())
                {
                    context.BikeColors.RemoveRange(colors);
                    context.SaveChanges();
                }
            }

        }
        public bool DeleteBike(string bikeRegNo)
        {
            using (var context = new FoodHubContext())
            {
               
                var bike = context.MotorBikes.FirstOrDefault(b => b.BikeRegNo == bikeRegNo);
                if (bike == null)
                    return false;
                DeleteBikeColor(bikeRegNo);
                context.MotorBikes.Remove(bike); 
                context.SaveChanges();
                return true;
            }
        }

        public MotorBike UpdateBike(MotorBike motorBike)
        {
            if (motorBike == null)
                return null;
            using (var context = new FoodHubContext())
            {
                var existingBike = context.MotorBikes
                              .FirstOrDefault(b => b.BikeRegNo == motorBike.BikeRegNo);

                if (existingBike != null)
                {
                    
                    existingBike.Brand = motorBike.Brand;
                    existingBike.Model = motorBike.Model;
                    existingBike.EngineNumber = motorBike.EngineNumber;
                    existingBike.RegisteredDate = motorBike.RegisteredDate;

                    
                }
                

                context.SaveChanges();
                return motorBike;

            }

        }

        public MotorBike GetSingleBike(string RegNo)
        {
            using (var context = new FoodHubContext())
            {
                var bike = context.MotorBikes.FirstOrDefault(b => b.BikeRegNo == RegNo);
                return bike;
            }
        }
        /// <summary>
        /// Clear all customers (for testing purposes - use with caution!)
        /// </summary>
        public bool ClearAllCustomers()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var allCustomers = context.Customers.ToList();
                    context.Customers.RemoveRange(allCustomers);
                    int result = context.SaveChanges();
                    Console.WriteLine($"Removed {result} customers from database");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error clearing customers: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Example: Get customer by ID
        /// </summary>
        public Customer GetCustomer(int customerId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Customers
                        .Include("Orders") // Load related orders
                        .FirstOrDefault(c => c.CustomerID == customerId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting customer: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Example: Create a new order
        /// </summary>
        public bool CreateOrder(Order order)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    context.Orders.Add(order);
                    return context.SaveChanges() > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating order: {ex.Message}");
                return false;
            }
        }

        /// <summary>
        /// Example: Get all food items by category
        /// </summary>
        public System.Collections.Generic.List<FoodItem> GetFoodItemsByCategory(string category)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.FoodItems
                        .Where(fi => fi.Category == category)
                        .OrderBy(fi => fi.ItemName)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting food items: {ex.Message}");
                return new System.Collections.Generic.List<FoodItem>();
            }
        }

        /// <summary>
        /// Example: Authenticate customer login
        /// </summary>
        public Customer AuthenticateCustomer(string nic, string password)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Customers
                        .FirstOrDefault(c => c.NIC == nic && c.Password == password);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error authenticating customer: {ex.Message}");
                return null;
            }
        }

        /// <summary>
        /// Example: Get available riders
        /// </summary>
        public System.Collections.Generic.List<Rider> GetAvailableRiders()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Riders
                        .Include("BikeAssignments")
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting riders: {ex.Message}");
                return new System.Collections.Generic.List<Rider>();
            }
        }

        public System.Collections.Generic.List<Rider> GetAllRiders()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Riders.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting all riders: {ex.Message}");
                return new System.Collections.Generic.List<Rider>();
            }
        }

        public Rider GetSingleRider(int riderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Riders.FirstOrDefault(r => r.RiderID == riderId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting rider: {ex.Message}");
                return null;
            }
        }

        public bool UpdateRider(Rider rider)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var existingRider = context.Riders.FirstOrDefault(r => r.RiderID == rider.RiderID);
                    if (existingRider != null)
                    {
                        existingRider.FirstName = rider.FirstName;
                        existingRider.LastName = rider.LastName;
                        existingRider.MiddleName = rider.MiddleName;
                        existingRider.NIC = rider.NIC;
                        existingRider.DateOfBirth = rider.DateOfBirth;
                        existingRider.Age = rider.Age;
                        existingRider.ContactNumber = rider.ContactNumber;
                        existingRider.Address = rider.Address;
                        existingRider.LicenseNumber = rider.LicenseNumber;
                        existingRider.UserName = rider.UserName;
                        existingRider.Password = rider.Password;
                        
                        int result = context.SaveChanges();
                        return result > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating rider: {ex.Message}");
                return false;
            }
        }

        public bool DeleteRider(int riderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var rider = context.Riders.FirstOrDefault(r => r.RiderID == riderId);
                    if (rider != null)
                    {
                        var dependents = context.Dependents.Where(d => d.RiderID == riderId).ToList();
                        context.Dependents.RemoveRange(dependents);
                        context.Riders.Remove(rider);
                        int result = context.SaveChanges();
                        return result > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting rider: {ex.Message}");
                return false;
            }
        }

        public System.Collections.Generic.List<Dependent> GetRiderDependents(int riderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Dependents.Where(d => d.RiderID == riderId).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting rider dependents: {ex.Message}");
                return new System.Collections.Generic.List<Dependent>();
            }
        }

        /// <summary>
        /// Example: Initialize database (create if not exists)
        /// </summary>
        public bool InitializeDatabase()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    // This will create the database if it doesn't exist
                    return context.Database.CreateIfNotExists();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error initializing database: {ex.Message}");
                return false;
            }
        }
    }
}
