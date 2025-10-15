using FoodHub.Models;
using FoodHub.Services;
using System;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class CustomerDashboardForm : Form
    {
        private FoodHubService service;
        private Customer currentCustomer;

        public CustomerDashboardForm(Customer customer)
        {
            InitializeComponent();
            currentCustomer = customer;
            service = new FoodHubService();
            
            welcomeLabel.Text = $"Welcome, {customer.Name}!";
            LoadCustomerStats();
        }

        private void LoadCustomerStats()
        {
            try
            {
                TotalOrders.Text = service.GetCustomerTotalOrders(currentCustomer.CustomerID).ToString();
                Pending.Text = service.GetCustomerPendingOrders(currentCustomer.CustomerID).ToString();
                Delivered.Text = service.GetCustomerDeliveredOrders(currentCustomer.CustomerID).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading customer statistics: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshDashboardStats()
        {
            LoadCustomerStats();
        }

        private void LogOutLabel_Click(object sender, EventArgs e)
        {
            Form1 loginForm = new Form1();
            loginForm.Show();
            this.Close();
        }

        private void FoodItemLabel_Click(object sender, EventArgs e)
        {
            CustomerFoodItemForm foodItemForm = new CustomerFoodItemForm(currentCustomer);
            foodItemForm.ShowDialog();
            RefreshDashboardStats();
        }

        private void MyOrdersLabel_Click(object sender, EventArgs e)
        {
            CustomerOrdersForm ordersForm = new CustomerOrdersForm(currentCustomer);
            ordersForm.ShowDialog();
        }
    }
}
