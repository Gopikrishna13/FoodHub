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
            try
            {
                using (var context = new FoodHubContext())
                {
                    Console.WriteLine($"Adding dependent {dependent.Name} for rider ID {dependent.RiderID}");
                    context.Dependents.Add(dependent);
                    int result = context.SaveChanges();
                    Console.WriteLine($"Dependent save result: {result}");
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding dependent: {ex.Message}");
                return false;
            }
        }
        public Rider AddRider(Rider rider)
        {
            if (rider == null)
            {
                return null;
            }

            try
            {
                using (var context = new FoodHubContext())
                {
                    var existingRider = context.Riders.FirstOrDefault(c => c.NIC == rider.NIC && c.UserName == rider.UserName);

                    if (existingRider != null)
                    {
                        return null;
                    }

                    context.Riders.Add(rider);
                    int result = context.SaveChanges();
                    
                    if (result > 0)
                    {
                        return rider;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding rider: {ex.Message}");
                return null;
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
        /// Authenticate customer login using username
        /// </summary>
        public Customer AuthenticateCustomer(string username, string password)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Customers
                        .FirstOrDefault(c => c.UserName == username && c.Password == password);
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
                    var dependents = context.Dependents.Where(d => d.RiderID == riderId).ToList();
                    Console.WriteLine($"Found {dependents.Count} dependents for rider ID {riderId}");
                    return dependents;
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

        public System.Collections.Generic.List<FoodItem> GetAllFoodItems()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.FoodItems.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting all food items: {ex.Message}");
                return new System.Collections.Generic.List<FoodItem>();
            }
        }

        public FoodItem GetSingleFoodItem(int itemId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.FoodItems.FirstOrDefault(f => f.ItemID == itemId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting food item: {ex.Message}");
                return null;
            }
        }

        public FoodItem AddFoodItem(FoodItem foodItem)
        {
            if (foodItem == null)
            {
                return null;
            }

            try
            {
                using (var context = new FoodHubContext())
                {
                    var existingItem = context.FoodItems.FirstOrDefault(f => f.ItemName == foodItem.ItemName);

                    if (existingItem != null)
                    {
                        return null;
                    }

                    context.FoodItems.Add(foodItem);
                    int result = context.SaveChanges();
                    
                    if (result > 0)
                    {
                        return foodItem;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding food item: {ex.Message}");
                return null;
            }
        }

        public bool UpdateFoodItem(FoodItem foodItem)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var existingItem = context.FoodItems.FirstOrDefault(f => f.ItemID == foodItem.ItemID);
                    if (existingItem != null)
                    {
                        existingItem.ItemName = foodItem.ItemName;
                        existingItem.Category = foodItem.Category;
                        existingItem.Price = foodItem.Price;
                        int result = context.SaveChanges();
                        return result > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating food item: {ex.Message}");
                return false;
            }
        }

        public string DeleteFoodItem(int itemId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var foodItem = context.FoodItems.FirstOrDefault(f => f.ItemID == itemId);
                    if (foodItem == null)
                    {
                        return "Error: Food item not found";
                    }

                    // Check if food item is used in any orders
                    var orderItems = context.OrderItems.Where(oi => oi.ItemID == itemId).ToList();
                    if (orderItems.Any())
                    {
                        // Get order details for better error message
                        var orderIds = orderItems.Select(oi => oi.OrderID).Distinct().ToList();
                        var orderCount = orderIds.Count;
                        
                        return $"Cannot delete food item '{foodItem.ItemName}' because it is used in {orderCount} order(s). " +
                               $"Order IDs: {string.Join(", ", orderIds.Take(5))}" + 
                               (orderIds.Count > 5 ? "..." : "");
                    }

                    // Remove related FoodItemIngredients first (these can be safely deleted)
                    var foodItemIngredients = context.FoodItemIngredients.Where(fi => fi.ItemID == itemId).ToList();
                    if (foodItemIngredients.Any())
                    {
                        context.FoodItemIngredients.RemoveRange(foodItemIngredients);
                        Console.WriteLine($"Removed {foodItemIngredients.Count} ingredient associations");
                    }

                    // Now remove the food item
                    context.FoodItems.Remove(foodItem);
                    int result = context.SaveChanges();
                    
                    if (result > 0)
                    {
                        return "SUCCESS";
                    }
                    else
                    {
                        return "Error: Failed to delete food item from database";
                    }
                }
            }
            catch (System.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 547) // Foreign key constraint violation
                {
                    return "Cannot delete food item because it is referenced in existing orders. Please remove it from all orders first.";
                }
                return $"Database error: {ex.Message}";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting food item: {ex.Message}");
                return $"Unexpected error: {ex.Message}";
            }
        }

        /// <summary>
        /// Force delete food item and all related data (Admin only - use with caution!)
        /// </summary>
        public string ForceDeleteFoodItem(int itemId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var foodItem = context.FoodItems.FirstOrDefault(f => f.ItemID == itemId);
                    if (foodItem == null)
                    {
                        return "Error: Food item not found";
                    }

                    // Remove all OrderItems that reference this food item
                    var orderItems = context.OrderItems.Where(oi => oi.ItemID == itemId).ToList();
                    if (orderItems.Any())
                    {
                        context.OrderItems.RemoveRange(orderItems);
                        Console.WriteLine($"Removed {orderItems.Count} order item references");
                    }

                    // Remove related FoodItemIngredients
                    var foodItemIngredients = context.FoodItemIngredients.Where(fi => fi.ItemID == itemId).ToList();
                    if (foodItemIngredients.Any())
                    {
                        context.FoodItemIngredients.RemoveRange(foodItemIngredients);
                        Console.WriteLine($"Removed {foodItemIngredients.Count} ingredient associations");
                    }

                    // Now remove the food item
                    context.FoodItems.Remove(foodItem);
                    int result = context.SaveChanges();
                    
                    if (result > 0)
                    {
                        return "SUCCESS";
                    }
                    else
                    {
                        return "Error: Failed to delete food item from database";
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error force deleting food item: {ex.Message}");
                return $"Error: {ex.Message}";
            }
        }

        /// <summary>
        /// Check what's preventing a food item from being deleted
        /// </summary>
        public string CheckFoodItemDeletionStatus(int itemId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var foodItem = context.FoodItems.FirstOrDefault(f => f.ItemID == itemId);
                    if (foodItem == null)
                    {
                        return "Food item not found";
                    }

                    var orderItems = context.OrderItems.Where(oi => oi.ItemID == itemId).ToList();
                    var ingredients = context.FoodItemIngredients.Where(fi => fi.ItemID == itemId).ToList();

                    string status = $"Food Item: {foodItem.ItemName}\n";
                    status += $"- Used in {orderItems.Count} order items\n";
                    status += $"- Has {ingredients.Count} ingredient associations\n";

                    if (orderItems.Any())
                    {
                        var orderIds = orderItems.Select(oi => oi.OrderID).Distinct().Take(10).ToList();
                        status += $"- Referenced in orders: {string.Join(", ", orderIds)}\n";
                    }

                    if (orderItems.Any())
                    {
                        status += "\nCannot delete: Food item is used in existing orders";
                    }
                    else
                    {
                        status += "\nCan be safely deleted";
                    }

                    return status;
                }
            }
            catch (Exception ex)
            {
                return $"Error checking deletion status: {ex.Message}";
            }
        }

        public System.Collections.Generic.List<Ingredient> GetAllIngredients()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Ingredients.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting all ingredients: {ex.Message}");
                return new System.Collections.Generic.List<Ingredient>();
            }
        }

        public bool AddIngredient(Ingredient ingredient)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var existingIngredient = context.Ingredients.FirstOrDefault(i => i.IngredientName == ingredient.IngredientName);
                    if (existingIngredient == null)
                    {
                        context.Ingredients.Add(ingredient);
                        int result = context.SaveChanges();
                        return result > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding ingredient: {ex.Message}");
                return false;
            }
        }

        public bool AddFoodItemIngredient(FoodItemIngredient foodItemIngredient)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var existing = context.FoodItemIngredients.FirstOrDefault(fi => fi.ItemID == foodItemIngredient.ItemID && fi.IngredientID == foodItemIngredient.IngredientID);
                    if (existing == null)
                    {
                        context.FoodItemIngredients.Add(foodItemIngredient);
                        int result = context.SaveChanges();
                        return result > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding food item ingredient: {ex.Message}");
                return false;
            }
        }

        public System.Collections.Generic.List<Ingredient> GetFoodItemIngredients(int itemId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var ingredients = context.FoodItemIngredients
                        .Where(fi => fi.ItemID == itemId)
                        .Join(context.Ingredients, fi => fi.IngredientID, i => i.IngredientID, (fi, i) => i)
                        .ToList();
                    return ingredients;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting food item ingredients: {ex.Message}");
                return new System.Collections.Generic.List<Ingredient>();
            }
        }

        public bool RemoveFoodItemIngredient(int itemId, int ingredientId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var foodItemIngredient = context.FoodItemIngredients.FirstOrDefault(fi => fi.ItemID == itemId && fi.IngredientID == ingredientId);
                    if (foodItemIngredient != null)
                    {
                        context.FoodItemIngredients.Remove(foodItemIngredient);
                        int result = context.SaveChanges();
                        return result > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error removing food item ingredient: {ex.Message}");
                return false;
            }
        }

        public System.Collections.Generic.List<Order> GetAllOrders()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Orders.Include("Customer").ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting all orders: {ex.Message}");
                return new System.Collections.Generic.List<Order>();
            }
        }

        public System.Collections.Generic.List<Order> GetCustomerOrders(int customerId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Orders.Where(o => o.CustomerID == customerId).ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting customer orders: {ex.Message}");
                return new System.Collections.Generic.List<Order>();
            }
        }

        public int GetCustomerTotalOrders(int customerId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Orders.Count(o => o.CustomerID == customerId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting customer total orders: {ex.Message}");
                return 0;
            }
        }

        public int GetCustomerPendingOrders(int customerId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Orders.Count(o => o.CustomerID == customerId && o.OrderStatus == "Pending");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting customer pending orders: {ex.Message}");
                return 0;
            }
        }

        public int GetCustomerDeliveredOrders(int customerId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Orders.Count(o => o.CustomerID == customerId && o.OrderStatus == "Delivered");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting customer delivered orders: {ex.Message}");
                return 0;
            }
        }

        public Order AddOrder(Order order)
        {
            if (order == null)
            {
                return null;
            }

            try
            {
                using (var context = new FoodHubContext())
                {
                    context.Orders.Add(order);
                    int result = context.SaveChanges();
                    
                    if (result > 0)
                    {
                        return order;
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding order: {ex.Message}");
                return null;
            }
        }

        public bool AddOrderItem(OrderItem orderItem)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    context.OrderItems.Add(orderItem);
                    int result = context.SaveChanges();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding order item: {ex.Message}");
                return false;
            }
        }

        public System.Collections.Generic.List<OrderItem> GetOrderItems(int orderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.OrderItems
                        .Where(oi => oi.OrderID == orderId)
                        .Include("FoodItem")
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting order items: {ex.Message}");
                return new System.Collections.Generic.List<OrderItem>();
            }
        }

        public bool UpdateOrderStatus(int orderId, string status)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var order = context.Orders.FirstOrDefault(o => o.OrderID == orderId);
                    if (order != null)
                    {
                        order.OrderStatus = status;
                        int result = context.SaveChanges();
                        return result > 0;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating order status: {ex.Message}");
                return false;
            }
        }

        public System.Collections.Generic.List<Rider> GetAvailableRidersForAssignment()
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
                Console.WriteLine($"Error getting available riders: {ex.Message}");
                return new System.Collections.Generic.List<Rider>();
            }
        }

        public System.Collections.Generic.List<MotorBike> GetAvailableBikes()
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.MotorBikes.ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting available bikes: {ex.Message}");
                return new System.Collections.Generic.List<MotorBike>();
            }
        }

        public bool AssignRiderToOrder(int orderId, int riderId, string bikeRegNo, int startMeterReading)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var delivery = new Delivery
                    {
                        OrderID = orderId,
                        RiderID = riderId,
                        BikeRegNo = bikeRegNo,
                        DeliveryDateTime = DateTime.Now
                    };

                    context.Deliveries.Add(delivery);

                    var bikeAssignment = new BikeAssignment
                    {
                        RiderID = riderId,
                        BikeRegNo = bikeRegNo,
                        AssignmentDate = DateTime.Now,
                        StartMeterReading = startMeterReading
                    };

                    context.BikeAssignments.Add(bikeAssignment);

                    var order = context.Orders.FirstOrDefault(o => o.OrderID == orderId);
                    if (order != null)
                    {
                        order.OrderStatus = "Assigned";
                    }

                    int result = context.SaveChanges();
                    return result > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error assigning rider to order: {ex.Message}");
                return false;
            }
        }

        public bool UpdateDeliveryEndReading(int orderId, int endMeterReading)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var delivery = context.Deliveries.FirstOrDefault(d => d.OrderID == orderId);
                    if (delivery != null)
                    {
                        var bikeAssignment = context.BikeAssignments
                            .Where(ba => ba.RiderID == delivery.RiderID && ba.BikeRegNo == delivery.BikeRegNo)
                            .OrderByDescending(ba => ba.AssignmentDate)
                            .FirstOrDefault();

                        if (bikeAssignment != null)
                        {
                            bikeAssignment.EndMeterReading = endMeterReading;
                            int result = context.SaveChanges();
                            return result > 0;
                        }
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating delivery end reading: {ex.Message}");
                return false;
            }
        }

        public System.Collections.Generic.List<Order> GetRiderOrders(int riderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var orderIds = context.Deliveries
                        .Where(d => d.RiderID == riderId)
                        .Select(d => d.OrderID)
                        .ToList();

                    return context.Orders
                        .Where(o => orderIds.Contains(o.OrderID))
                        .Include("Customer")
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting rider orders: {ex.Message}");
                return new System.Collections.Generic.List<Order>();
            }
        }

        public int GetRiderTotalOrders(int riderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Deliveries.Count(d => d.RiderID == riderId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting rider total orders: {ex.Message}");
                return 0;
            }
        }

        public int GetRiderPendingOrders(int riderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var orderIds = context.Deliveries
                        .Where(d => d.RiderID == riderId)
                        .Select(d => d.OrderID)
                        .ToList();

                    return context.Orders
                        .Count(o => orderIds.Contains(o.OrderID) && (o.OrderStatus == "Assigned" || o.OrderStatus == "Pending"));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting rider pending orders: {ex.Message}");
                return 0;
            }
        }

        public int GetRiderDeliveredOrders(int riderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var orderIds = context.Deliveries
                        .Where(d => d.RiderID == riderId)
                        .Select(d => d.OrderID)
                        .ToList();

                    return context.Orders
                        .Count(o => orderIds.Contains(o.OrderID) && o.OrderStatus == "Delivered");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting rider delivered orders: {ex.Message}");
                return 0;
            }
        }

        public decimal GetRiderTotalDistance(int riderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    var assignments = context.BikeAssignments
                        .Where(ba => ba.RiderID == riderId && ba.EndMeterReading.HasValue)
                        .ToList();

                    decimal totalDistance = 0;
                    foreach (var assignment in assignments)
                    {
                        if (assignment.EndMeterReading.HasValue)
                        {
                            totalDistance += assignment.EndMeterReading.Value - assignment.StartMeterReading;
                        }
                    }

                    return totalDistance;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting rider total distance: {ex.Message}");
                return 0;
            }
        }

        public Delivery GetDeliveryByOrderId(int orderId)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Deliveries
                        .Include("Rider")
                        .Include("MotorBike")
                        .FirstOrDefault(d => d.OrderID == orderId);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting delivery by order ID: {ex.Message}");
                return null;
            }
        }

        public Rider AuthenticateRider(string username, string password)
        {
            try
            {
                using (var context = new FoodHubContext())
                {
                    return context.Riders
                        .FirstOrDefault(r => r.UserName == username && r.Password == password);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error authenticating rider: {ex.Message}");
                return null;
            }
        }
    }
}
