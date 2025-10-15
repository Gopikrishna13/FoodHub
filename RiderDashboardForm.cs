using System;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class RiderDashboardForm : Form
    {
        private FoodHubService foodHubService;
        private Rider currentRider;

        public RiderDashboardForm(Rider rider)
        {
            InitializeComponent();
            currentRider = rider;
            foodHubService = new FoodHubService();
            LoadDashboardStats();
            UpdateWelcomeMessage();
        }

        private void UpdateWelcomeMessage()
        {
            welcomeLabel.Text = $"Welcome, {currentRider.FirstName} {currentRider.LastName}!";
        }

        private void LoadDashboardStats()
        {
            try
            {
                int totalOrders = foodHubService.GetRiderTotalOrders(currentRider.RiderID);
                int pendingOrders = foodHubService.GetRiderPendingOrders(currentRider.RiderID);
                int deliveredOrders = foodHubService.GetRiderDeliveredOrders(currentRider.RiderID);
                decimal totalDistance = foodHubService.GetRiderTotalDistance(currentRider.RiderID);

                TotalOrders.Text = totalOrders.ToString();
                Pending.Text = pendingOrders.ToString();
                Delivered.Text = deliveredOrders.ToString();
                TotalDistance.Text = $"{totalDistance:F1} km";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard statistics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MyOrdersLabel_Click(object sender, EventArgs e)
        {
            try
            {
                RiderOrdersForm ordersForm = new RiderOrdersForm(currentRider);
                ordersForm.ShowDialog();
                LoadDashboardStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                
                if (result == DialogResult.Yes)
                {
                    Form1 loginForm = new Form1();
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error during logout: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
