using System;
using System.Linq;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class CustomerOrdersForm : Form
    {
        private FoodHubService foodHubService;
        private Customer currentCustomer;

        public CustomerOrdersForm(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
            foodHubService = new FoodHubService();
            LoadCustomerOrders();
        }

        private void LoadCustomerOrders()
        {
            try
            {
                var orders = foodHubService.GetCustomerOrders(currentCustomer.CustomerID);
                ordersDataGridView.Rows.Clear();

                foreach (var order in orders.OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.OrderTime))
                {
                    ordersDataGridView.Rows.Add(
                        order.OrderID,
                        order.OrderDate.ToShortDateString(),
                        order.OrderTime.ToString(@"hh\:mm"),
                        $"${order.OrderAmount:F2}",
                        order.OrderStatus,
                        order.PaymentMethod,
                        "📋 View Details"
                    );
                }

                if (orders.Count == 0)
                {
                    MessageBox.Show("You have no orders yet. Start by ordering some delicious food!", 
                        "No Orders", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var orderId = ordersDataGridView.Rows[e.RowIndex].Cells["OrderID"].Value?.ToString();
                
                if (e.ColumnIndex == ordersDataGridView.Columns["ViewDetailsColumn"].Index)
                {
                    ShowOrderDetails(int.Parse(orderId));
                }
            }
        }

        private void ShowOrderDetails(int orderId)
        {
            try
            {
                var orderItems = foodHubService.GetOrderItems(orderId);
                
                if (orderItems.Count == 0)
                {
                    MessageBox.Show("No items found for this order.", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var message = $"Order #{orderId} Details:\n\n";
                decimal totalAmount = 0;

                foreach (var item in orderItems)
                {
                    var foodItem = foodHubService.GetSingleFoodItem(item.ItemID);
                    if (foodItem != null)
                    {
                        decimal itemTotal = foodItem.Price * item.Quantity;
                        totalAmount += itemTotal;
                        
                        message += $"• {foodItem.ItemName}\n";
                        message += $"  Quantity: {item.Quantity}\n";
                        message += $"  Price: ${foodItem.Price:F2} each\n";
                        message += $"  Subtotal: ${itemTotal:F2}\n\n";
                    }
                }

                message += $"Total Amount: ${totalAmount:F2}";

                MessageBox.Show(message, "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading order details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
