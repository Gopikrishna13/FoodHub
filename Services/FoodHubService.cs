using System;
using System.Linq;
using System.Data.Entity;
using FoodHub.Data;
using FoodHub.Models;

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
