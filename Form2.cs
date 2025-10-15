using FoodHub.Models;
using FoodHub.Services;
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

namespace FoodHub
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Input validation
            if (string.IsNullOrWhiteSpace(NameField.Text))
            {
                MessageBox.Show("Please enter a name.");

                return;
            }

            if (string.IsNullOrWhiteSpace(NICField.Text))
            {
                MessageBox.Show("Please enter a NIC number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(ContactField.Text))
            {
                MessageBox.Show("Please enter a contact number.");
                return;
            }

            if (string.IsNullOrWhiteSpace(UNameField.Text))
            {
                MessageBox.Show("Please enter a  username.");
                return;
            }

            if (UNameField.Text.IndexOf("Admin", StringComparison.OrdinalIgnoreCase) >= 0 ||UNameField.Text.IndexOf("Rider", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                MessageBox.Show("This User Name is not available!");
                return;
            }

                if (string.IsNullOrWhiteSpace(PasswordField.Text))
                {
                    MessageBox.Show("Please enter a password.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(AddressField.Text))
                {
                    MessageBox.Show("Please enter an address line number.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter a lane.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    MessageBox.Show("Please enter a street.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(textBox3.Text))
                {
                    MessageBox.Show("Please enter a city.");
                    return;
                }

                try
                {
                    Customer customer = new Customer();
                    customer.Name = NameField.Text.Trim();
                    customer.NIC = NICField.Text.Trim();
                    customer.DateOfBirth = DOBField.Value;
                    customer.ContactNumber = ContactField.Text.Trim();
                    customer.Password = HashPassword(PasswordField.Text.Trim());
                    customer.UserName = UNameField.Text;  
                    customer.AddressLineNo = AddressField.Text.Trim();
                    customer.City = textBox3.Text.Trim();
                    customer.Street = textBox2.Text.Trim();
                    customer.Lane = textBox1.Text.Trim();

                    FoodHubService foodHubService = new FoodHubService();




                    bool results = foodHubService.AddCustomer(customer);
                    if (results)
                    {
                        MessageBox.Show("Customer Created Successfully!");
                        ClearForm();
                    }
                    else
                    {
                        MessageBox.Show("Customer Creation Failed!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error creating customer: {ex.Message}");
                }
            }
        
        
        private void ClearForm()
        {
            NameField.Clear();
            NICField.Clear();
            ContactField.Clear();
            AddressField.Clear();
            PasswordField.Clear();
            textBox1.Clear();
            textBox2.Clear(); 
            textBox3.Clear(); 
            UNameField.Clear(); 
            DOBField.Value = DateTime.Now;
        }
        public  string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

            
                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                    result.Append(b.ToString("x2"));

                return result.ToString();
            }
        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
