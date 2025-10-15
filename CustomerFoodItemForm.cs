using System;
using System.Linq;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class CustomerFoodItemForm : Form
    {
        private FoodHubService foodHubService;
        private Customer currentCustomer;

        public CustomerFoodItemForm(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
            foodHubService = new FoodHubService();
            LoadFoodItems();
        }

        private void LoadFoodItems()
        {
            try
            {
                var foodItems = foodHubService.GetAllFoodItems();
                foodItemsDataGridView.Rows.Clear();

                foreach (var item in foodItems)
                {
                    var ingredients = foodHubService.GetFoodItemIngredients(item.ItemID);
                    string ingredientsInfo = GetIngredientsDisplayText(ingredients);
                    
                    foodItemsDataGridView.Rows.Add(
                        item.ItemID,
                        item.ItemName,
                        item.Category,
                        $"${item.Price:F2}",
                        ingredientsInfo,
                        "🛒 Order Now"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading food items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetIngredientsDisplayText(System.Collections.Generic.List<Ingredient> ingredients)
        {
            if (ingredients.Count == 0)
            {
                return "No ingredients";
            }
            else if (ingredients.Count == 1)
            {
                return $"1 - {ingredients[0].IngredientName}";
            }
            else
            {
                return $"{ingredients.Count} - {string.Join(", ", ingredients.Take(2).Select(i => i.IngredientName))}{(ingredients.Count > 2 ? "..." : "")}";
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void foodItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var itemId = foodItemsDataGridView.Rows[e.RowIndex].Cells["ItemID"].Value?.ToString();
                
                if (e.ColumnIndex == foodItemsDataGridView.Columns["OrderColumn"].Index)
                {
                    PlaceOrder(int.Parse(itemId));
                }
                else if (e.ColumnIndex == foodItemsDataGridView.Columns["IngredientsCount"].Index)
                {
                    ShowIngredientsDetails(int.Parse(itemId));
                }
            }
        }

        private void PlaceOrder(int itemId)
        {
            try
            {
                var foodItem = foodHubService.GetSingleFoodItem(itemId);
                if (foodItem != null)
                {
                    string quantityInput = Microsoft.VisualBasic.Interaction.InputBox(
                        $"How many {foodItem.ItemName} would you like to order?\n\nPrice: ${foodItem.Price:F2} each",
                        "Order Quantity",
                        "1"
                    );

                    if (!string.IsNullOrEmpty(quantityInput) && int.TryParse(quantityInput, out int quantity) && quantity > 0)
                    {
                        Order order = new Order();
                        order.CustomerID = currentCustomer.CustomerID;
                        order.OrderDate = DateTime.Now.Date;
                        order.OrderTime = DateTime.Now.TimeOfDay;
                        order.OrderStatus = "Pending";
                        order.PaymentMethod = "Cash";
                        order.OrderAmount = foodItem.Price * quantity;

                        Order addedOrder = foodHubService.AddOrder(order);

                        if (addedOrder != null)
                        {
                            OrderItem orderItem = new OrderItem();
                            orderItem.OrderID = addedOrder.OrderID;
                            orderItem.ItemID = itemId;
                            orderItem.Quantity = quantity;

                            bool orderItemAdded = foodHubService.AddOrderItem(orderItem);

                            if (orderItemAdded)
                            {
                                MessageBox.Show($"Order placed successfully!\n\nItem: {foodItem.ItemName}\nQuantity: {quantity}\nTotal: ${order.OrderAmount:F2}\nStatus: Pending", 
                                    "Order Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.DialogResult = DialogResult.OK;
                            }
                            else
                            {
                                MessageBox.Show("Failed to add order item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Failed to place order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (!string.IsNullOrEmpty(quantityInput))
                    {
                        MessageBox.Show("Please enter a valid quantity (positive number).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error placing order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowIngredientsDetails(int itemId)
        {
            try
            {
                var ingredients = foodHubService.GetFoodItemIngredients(itemId);
                var foodItem = foodHubService.GetSingleFoodItem(itemId);
                
                if (ingredients.Count == 0)
                {
                    MessageBox.Show($"Food item '{foodItem.ItemName}' has no ingredients listed.", 
                        "Ingredients Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var message = $"Ingredients for {foodItem.ItemName}:\n\n";
                foreach (var ingredient in ingredients)
                {
                    message += $"• {ingredient.IngredientName}\n";
                }

                MessageBox.Show(message, "Ingredients Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ingredients details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
