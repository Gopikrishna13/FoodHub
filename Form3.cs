using FoodHub.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class Form3 : Form
    {
        FoodHubService service;
        public Form3()
        {
            InitializeComponent();
            service = new FoodHubService();
            TotalUserCount.Text= service.TotalUsers().ToString();
            RiderCount.Text=service.TotalRiders().ToString();
            TotalBike.Text=service.TotalBikes().ToString();
            TotalOrder.Text=service.TotalOrders().ToString();
            Pending.Text=service.PendingOrders().ToString();
            Delivered.Text=service.DeliveredOrders().ToString();
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();

         
            this.Close();
        }

        private void BikeAddLabel_Click(object sender, EventArgs e)
        {
            BikeManagementForm bikeForm = new BikeManagementForm();
            bikeForm.ShowDialog();
            
            // Refresh dashboard statistics after bike management form is closed
            RefreshDashboardStats();
        }

        private void RiderAddLabel_Click(object sender, EventArgs e)
        {
            RiderManagementForm riderForm = new RiderManagementForm();
            riderForm.ShowDialog();
            RefreshDashboardStats();
        }

        private void FoodItemLabel_Click(object sender, EventArgs e)
        {
            FoodItemManagementForm foodItemForm = new FoodItemManagementForm();
            foodItemForm.ShowDialog();
            RefreshDashboardStats();
        }

        private void OrdersLabel_Click(object sender, EventArgs e)
        {
            AdminOrdersForm ordersForm = new AdminOrdersForm();
            ordersForm.ShowDialog();
            RefreshDashboardStats();
        }

        public void RefreshDashboardStats()
        {
            try
            {
                // Refresh all dashboard statistics
                TotalUserCount.Text = service.TotalUsers().ToString();
                RiderCount.Text = service.TotalRiders().ToString();
                TotalBike.Text = service.TotalBikes().ToString();
                TotalOrder.Text = service.TotalOrders().ToString();
                Pending.Text = service.PendingOrders().ToString();
                Delivered.Text = service.DeliveredOrders().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing dashboard: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
