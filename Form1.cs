using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FoodHub.Services;
using FoodHub.Models;

namespace FoodHub
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UserName.Text) || string.IsNullOrWhiteSpace(PasswordEntry.Text))
                MessageBox.Show("Please Fill The Credentials!");


            validateUsers(UserName.Text, PasswordEntry.Text);

        

        }

        private void validateUsers(string username, string password)
        {
            if (username == "Admin")
            {
                if (PasswordEntry.Text == "admin@123")
                {
                    Form3 form3 = new Form3();
                    form3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Login");
                }
            }
            else if (username.StartsWith("rider"))
            {
                try
                {
                    FoodHubService service = new FoodHubService();
                    string hashedPassword = HashPassword(password);
                    
                    Rider rider = service.AuthenticateRider(username, hashedPassword);
                    
                    if (rider != null)
                    {
                        RiderDashboardForm riderDashboard = new RiderDashboardForm(rider);
                        riderDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please check your credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    FoodHubService service = new FoodHubService();
                    string hashedPassword = HashPassword(password);
                    
                    Customer customer = service.AuthenticateCustomer(username, hashedPassword);
                    
                    if (customer != null)
                    {
                        CustomerDashboardForm customerDashboard = new CustomerDashboardForm(customer);
                        customerDashboard.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password. Please try again or create a new account.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Login error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SignUp.Enabled = checkBox1.Checked;
        }
    }
}
