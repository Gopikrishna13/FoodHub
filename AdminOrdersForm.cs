using System;
using System.Linq;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class AdminOrdersForm : Form
    {
        private FoodHubService foodHubService;

        public AdminOrdersForm()
        {
            InitializeComponent();
            foodHubService = new FoodHubService();
            LoadAllOrders();
        }

        private void LoadAllOrders()
        {
            try
            {
                var orders = foodHubService.GetAllOrders();
                ordersDataGridView.Rows.Clear();

                foreach (var order in orders.OrderByDescending(o => o.OrderDate).ThenByDescending(o => o.OrderTime))
                {
                    string customerName = order.Customer != null ? 
                        $"{order.Customer.Name}" : 
                        "Unknown Customer";

                    ordersDataGridView.Rows.Add(
                        order.OrderID,
                        customerName,
                        order.OrderDate.ToShortDateString(),
                        order.OrderTime.ToString(@"hh\:mm"),
                        $"${order.OrderAmount:F2}",
                        order.OrderStatus,
                        order.PaymentMethod,
                        "🏍️ Assign",
                        "🔄 Update"
                    );
                }

                if (orders.Count == 0)
                {
                    MessageBox.Show("No orders found in the system.", 
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
                
                if (e.ColumnIndex == ordersDataGridView.Columns["AssignRiderColumn"].Index)
                {
                    AssignRiderToOrder(int.Parse(orderId));
                }
                else if (e.ColumnIndex == ordersDataGridView.Columns["UpdateStatusColumn"].Index)
                {
                    UpdateOrderStatus(int.Parse(orderId));
                }
            }
        }

        private void AssignRiderToOrder(int orderId)
        {
            try
            {
                var orders = foodHubService.GetAllOrders();
                var order = orders.FirstOrDefault(o => o.OrderID == orderId);
                
                if (order == null)
                {
                    MessageBox.Show("Order not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (order.OrderStatus != "Pending")
                {
                    MessageBox.Show("Only pending orders can be assigned to riders.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                RiderAssignmentForm assignmentForm = new RiderAssignmentForm(orderId);
                if (assignmentForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllOrders();
                    MessageBox.Show("Rider assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning rider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateOrderStatus(int orderId)
        {
            try
            {
                var currentRow = ordersDataGridView.Rows.Cast<DataGridViewRow>()
                    .FirstOrDefault(r => r.Cells["OrderID"].Value?.ToString() == orderId.ToString());
                
                if (currentRow != null)
                {
                    string currentStatus = currentRow.Cells["OrderStatus"].Value?.ToString();
                    
                    string[] allStatusOptions = { "Pending", "Delivered", "Cancelled" };
                    var availableOptions = allStatusOptions.Where(s => s != currentStatus).ToArray();
                    
                    if (availableOptions.Length == 0)
                    {
                        MessageBox.Show("No status changes available for this order.", "No Options", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    
                    string message = $"Current Status: {currentStatus}\n\nSelect new status:\n\n";
                    for (int i = 0; i < availableOptions.Length; i++)
                    {
                        message += $"{i + 1}. {availableOptions[i]}\n";
                    }
                    
                    string input = Microsoft.VisualBasic.Interaction.InputBox(
                        message + $"\nEnter the number (1-{availableOptions.Length}):",
                        "Update Order Status",
                        "1"
                    );
                    
                    if (!string.IsNullOrEmpty(input) && int.TryParse(input, out int choice) && choice >= 1 && choice <= availableOptions.Length)
                    {
                        string newStatus = availableOptions[choice - 1];
                        
                        if (newStatus == "Delivered")
                        {
                            string endMeterInput = Microsoft.VisualBasic.Interaction.InputBox(
                                "Enter the end meter reading for this delivery:",
                                "End Meter Reading",
                                ""
                            );
                            
                            if (!string.IsNullOrEmpty(endMeterInput) && int.TryParse(endMeterInput, out int endMeterReading))
                            {
                                bool meterSuccess = foodHubService.UpdateDeliveryEndReading(orderId, endMeterReading);
                                if (!meterSuccess)
                                {
                                    MessageBox.Show("Failed to update meter reading, but will continue with status update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else if (!string.IsNullOrEmpty(endMeterInput))
                            {
                                MessageBox.Show("Invalid meter reading. Status will not be updated.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                        }
                        
                        bool success = foodHubService.UpdateOrderStatus(orderId, newStatus);
                        
                        if (success)
                        {
                            MessageBox.Show($"Order status updated to '{newStatus}' successfully!", 
                                "Status Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LoadAllOrders();
                        }
                        else
                        {
                            MessageBox.Show("Failed to update order status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (!string.IsNullOrEmpty(input))
                    {
                        MessageBox.Show($"Please enter a valid number between 1 and {availableOptions.Length}.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
