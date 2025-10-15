using System;
using System.Linq;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class RiderAssignmentForm : Form
    {
        private FoodHubService foodHubService;
        private int orderId;

        public RiderAssignmentForm(int orderId)
        {
            InitializeComponent();
            this.orderId = orderId;
            foodHubService = new FoodHubService();
            LoadOrderInfo();
            LoadRiders();
            LoadBikes();
        }

        private void LoadOrderInfo()
        {
            try
            {
                var orders = foodHubService.GetAllOrders();
                var order = orders.FirstOrDefault(o => o.OrderID == orderId);
                
                if (order != null)
                {
                    string customerName = order.Customer != null ? order.Customer.Name : "Unknown Customer";
                    orderInfoLabel.Text = $"Order #{orderId}\nCustomer: {customerName}\nAmount: ${order.OrderAmount:F2}";
                }
                else
                {
                    orderInfoLabel.Text = $"Order #{orderId}\nOrder details not found";
                }
            }
            catch (Exception ex)
            {
                orderInfoLabel.Text = $"Order #{orderId}\nError loading order details";
                Console.WriteLine($"Error loading order info: {ex.Message}");
            }
        }

        private void LoadRiders()
        {
            try
            {
                var riders = foodHubService.GetAvailableRidersForAssignment();
                riderComboBox.Items.Clear();
                
                foreach (var rider in riders)
                {
                    var item = new ComboBoxItem
                    {
                        Text = $"{rider.FirstName} {rider.LastName} - {rider.ContactNumber}",
                        Value = rider.RiderID
                    };
                    riderComboBox.Items.Add(item);
                }
                
                if (riderComboBox.Items.Count > 0)
                {
                    riderComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading riders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBikes()
        {
            try
            {
                var bikes = foodHubService.GetAvailableBikes();
                bikeComboBox.Items.Clear();
                
                foreach (var bike in bikes)
                {
                    var item = new ComboBoxItem
                    {
                        Text = $"{bike.BikeRegNo} - {bike.Brand} {bike.Model}",
                        Value = bike.BikeRegNo
                    };
                    bikeComboBox.Items.Add(item);
                }
                
                if (bikeComboBox.Items.Count > 0)
                {
                    bikeComboBox.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bikes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void assignButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    var selectedRider = (ComboBoxItem)riderComboBox.SelectedItem;
                    var selectedBike = (ComboBoxItem)bikeComboBox.SelectedItem;
                    int startMeterReading = int.Parse(startMeterTextBox.Text);
                    
                    bool success = foodHubService.AssignRiderToOrder(
                        orderId, 
                        (int)selectedRider.Value, 
                        selectedBike.Value.ToString(), 
                        startMeterReading
                    );
                    
                    if (success)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to assign rider to order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error assigning rider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (riderComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a rider.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                riderComboBox.Focus();
                return false;
            }

            if (bikeComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a bike.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                bikeComboBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(startMeterTextBox.Text))
            {
                MessageBox.Show("Please enter the start meter reading.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                startMeterTextBox.Focus();
                return false;
            }

            if (!int.TryParse(startMeterTextBox.Text, out int meterReading) || meterReading < 0)
            {
                MessageBox.Show("Please enter a valid meter reading (positive number).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                startMeterTextBox.Focus();
                return false;
            }

            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

    public class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
