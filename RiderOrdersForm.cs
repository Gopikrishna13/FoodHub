using System;
using System.Linq;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class RiderOrdersForm : Form
    {
        private FoodHubService foodHubService;
        private Rider currentRider;

        public RiderOrdersForm(Rider rider)
        {
            InitializeComponent();
            currentRider = rider;
            foodHubService = new FoodHubService();
            LoadRiderOrders();
        }

        private void LoadRiderOrders()
        {
            try
            {
                ordersDataGridView.Rows.Clear();
                var orders = foodHubService.GetRiderOrders(currentRider.RiderID);

                foreach (var order in orders)
                {
                    string customerName = order.Customer != null ? order.Customer.Name : "Unknown Customer";
                    
                    ordersDataGridView.Rows.Add(
                        order.OrderID,
                        customerName,
                        order.OrderDate.ToShortDateString(),
                        order.OrderTime.ToString(@"hh\:mm"),
                        $"${order.OrderAmount:F2}",
                        order.OrderStatus,
                        order.PaymentMethod,
                        "📋 View"
                    );
                }

                if (orders.Count == 0)
                {
                    ordersDataGridView.Rows.Add("No orders assigned", "", "", "", "", "", "", "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var orderId = ordersDataGridView.Rows[e.RowIndex].Cells["OrderID"].Value?.ToString();
                
                if (e.ColumnIndex == ordersDataGridView.Columns["ViewDetailsColumn"].Index && !string.IsNullOrEmpty(orderId) && orderId != "No orders assigned")
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
                var orders = foodHubService.GetAllOrders();
                var order = orders.FirstOrDefault(o => o.OrderID == orderId);
                
                if (orderItems.Count == 0)
                {
                    MessageBox.Show("No items found for this order.", "Order Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string customerName = order?.Customer != null ? 
                    $"{order.Customer.Name}" : 
                    "Unknown Customer";

                var message = $"Order #{orderId} Details:\n";
                message += $"Customer: {customerName}\n";
                message += $"Date: {order?.OrderDate.ToShortDateString()}\n";
                message += $"Time: {order?.OrderTime.ToString(@"hh\:mm")}\n";
                message += $"Status: {order?.OrderStatus}\n\n";
                message += "Items:\n";

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
