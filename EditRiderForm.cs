using FoodHub.Services;
using FoodHub.Models;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class EditRiderForm : Form
    {
        private FoodHubService foodHubService;
        private Rider currentRider;
        private int riderId;

        public EditRiderForm(int riderIdParam)
        {
            InitializeComponent();
            foodHubService = new FoodHubService();
            riderId = riderIdParam;
            LoadRiderDetails();
            LoadDependents();
            
            // Add username generation for edit form (in case user changes name)
            firstNameTextBox.TextChanged += GenerateUsername;
            lastNameTextBox.TextChanged += GenerateUsername;
        }

        private void LoadRiderDetails()
        {
            try
            {
                currentRider = foodHubService.GetSingleRider(riderId);
                
                if (currentRider != null)
                {
                    firstNameTextBox.Text = currentRider.FirstName;
                    middleNameTextBox.Text = currentRider.MiddleName;
                    lastNameTextBox.Text = currentRider.LastName;
                    nicTextBox.Text = currentRider.NIC;
                    dobDatePicker.Value = currentRider.DateOfBirth;
                    ageTextBox.Text = currentRider.Age.ToString();
                    contactTextBox.Text = currentRider.ContactNumber;
                    addressTextBox.Text = currentRider.Address;
                    licenseTextBox.Text = currentRider.LicenseNumber;
                    usernameTextBox.Text = currentRider.UserName;
                    passwordTextBox.Text = "";
                }
                else
                {
                    MessageBox.Show("Rider not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading rider details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void LoadDependents()
        {
            try
            {
                var dependents = foodHubService.GetRiderDependents(riderId);
                dependentsDataGridView.Rows.Clear();

                foreach (var dependent in dependents)
                {
                    dependentsDataGridView.Rows.Add(
                        dependent.Name,
                        dependent.Relationship,
                        dependent.DateOfBirth.ToShortDateString()
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dependents: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    currentRider.FirstName = firstNameTextBox.Text.Trim();
                    currentRider.MiddleName = middleNameTextBox.Text.Trim();
                    currentRider.LastName = lastNameTextBox.Text.Trim();
                    currentRider.NIC = nicTextBox.Text.Trim();
                    currentRider.DateOfBirth = dobDatePicker.Value;
                    currentRider.Age = int.Parse(ageTextBox.Text);
                    currentRider.ContactNumber = contactTextBox.Text.Trim();
                    currentRider.Address = addressTextBox.Text.Trim();
                    currentRider.LicenseNumber = licenseTextBox.Text.Trim();
                    currentRider.UserName = usernameTextBox.Text.Trim();
                    
                    if (!string.IsNullOrWhiteSpace(passwordTextBox.Text))
                    {
                        currentRider.Password = HashPassword(passwordTextBox.Text);
                    }

                    bool updated = foodHubService.UpdateRider(currentRider);
                    
                    if (updated)
                    {
                        MessageBox.Show("Rider updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update rider. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating rider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                MessageBox.Show("Please enter first name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                firstNameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                MessageBox.Show("Please enter last name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lastNameTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(nicTextBox.Text))
            {
                MessageBox.Show("Please enter NIC.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nicTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(contactTextBox.Text))
            {
                MessageBox.Show("Please enter contact number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                contactTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(usernameTextBox.Text))
            {
                MessageBox.Show("Please enter username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                usernameTextBox.Focus();
                return false;
            }

            if (!int.TryParse(ageTextBox.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ageTextBox.Focus();
                return false;
            }

            return true;
        }

        private void GenerateUsername(object sender, EventArgs e)
        {
            try
            {
                // Only auto-generate if the current username follows the rider pattern
                if (usernameTextBox.Text.StartsWith("rider") || string.IsNullOrEmpty(usernameTextBox.Text))
                {
                    string firstName = firstNameTextBox.Text.Trim().ToLower();
                    string lastName = lastNameTextBox.Text.Trim().ToLower();
                    
                    if (!string.IsNullOrEmpty(firstName) && !string.IsNullOrEmpty(lastName))
                    {
                        Random random = new Random();
                        int randomNumber = random.Next(100, 999);
                        string username = $"rider{firstName}{lastName}{randomNumber}";
                        username = System.Text.RegularExpressions.Regex.Replace(username, @"[^a-zA-Z0-9]", "");
                        usernameTextBox.Text = username;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating username: {ex.Message}");
            }
        }

        public string HashPassword(string password)
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
