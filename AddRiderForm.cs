using FoodHub.Models;
using FoodHub.Services;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class AddRiderForm : Form
    {
        public AddRiderForm()
        {
            InitializeComponent();
            InitializeDependentsDataGridView();
            
         
            dependentsDataGridView.CellContentClick += DependentsDataGridView_CellContentClick;
        }

        private void InitializeDependentsDataGridView()
        {
        
            dependentsDataGridView.EnableHeadersVisualStyles = false;
            dependentsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dependentsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dependentsDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dependentsDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            dependentsDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            dependentsDataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dependentsDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            dependentsDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            dependentsDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            dependentsDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            
            // Configure button column
            RemoveDependent.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            RemoveDependent.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            RemoveDependent.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            dependentsDataGridView.Refresh();
        }

        private void addDependentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateDependentInput())
                {
                    
                    dependentsDataGridView.Rows.Add(
                        depNameTextBox.Text.Trim(),
                        relationshipComboBox.SelectedItem.ToString(),
                        depDobDatePicker.Value.ToShortDateString(),
                        "🗑️ Remove"
                    );

                 
                    ClearDependentInputs();

                    MessageBox.Show("Dependent added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding dependent: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateDependentInput()
        {
            // Validate dependent name
            if (string.IsNullOrWhiteSpace(depNameTextBox.Text))
            {
                MessageBox.Show("Please enter the dependent's name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                depNameTextBox.Focus();
                return false;
            }

            // Validate relationship selection
            if (relationshipComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a relationship.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                relationshipComboBox.Focus();
                return false;
            }

            // Validate date of birth
            if (depDobDatePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Date of birth cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                depDobDatePicker.Focus();
                return false;
            }

            // Check if dependent already exists
            foreach (DataGridViewRow row in dependentsDataGridView.Rows)
            {
                if (row.Cells["DependentName"].Value?.ToString().Equals(depNameTextBox.Text.Trim(), StringComparison.OrdinalIgnoreCase) == true)
                {
                    MessageBox.Show("A dependent with this name already exists.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    depNameTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ClearDependentInputs()
        {
            depNameTextBox.Clear();
            relationshipComboBox.SelectedIndex = -1;
            depDobDatePicker.Value = DateTime.Now.AddYears(-1); // Set to 1 year ago as default
            depNameTextBox.Focus();
        }

        private void DependentsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Check if the remove button was clicked
                if (e.RowIndex >= 0 && e.ColumnIndex == dependentsDataGridView.Columns["RemoveDependent"].Index)
                {
                    string dependentName = dependentsDataGridView.Rows[e.RowIndex].Cells["DependentName"].Value?.ToString();
                    
                    var result = MessageBox.Show($"Are you sure you want to remove dependent '{dependentName}'?", 
                        "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        dependentsDataGridView.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Dependent removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing dependent: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        public System.Collections.Generic.List<DependentInfo> GetDependentsData()
        {
            var dependents = new System.Collections.Generic.List<DependentInfo>();
            
            foreach (DataGridViewRow row in dependentsDataGridView.Rows)
            {
                if (row.Cells["DependentName"].Value != null)
                {
                    dependents.Add(new DependentInfo
                    {
                        Name = row.Cells["DependentName"].Value.ToString(),
                        Relationship = row.Cells["Relationship"].Value.ToString(),
                        DateOfBirth = DateTime.Parse(row.Cells["DependentDOB"].Value.ToString())
                    });
                }
            }
            
            return dependents;
        }

        public class DependentInfo
        {
            public string Name { get; set; }
            public string Relationship { get; set; }
            public DateTime DateOfBirth { get; set; }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateRiderInput())
                {
                    FoodHubService foodHubService = new FoodHubService();

                    Rider rider = new Rider();
                    rider.FirstName = firstNameTextBox.Text.Trim();
                    rider.LastName = lastNameTextBox.Text.Trim();
                    rider.MiddleName = middleNameTextBox.Text.Trim();
                    rider.NIC = nicTextBox.Text.Trim();
                    rider.DateOfBirth = dobDatePicker.Value;
                    rider.Age = int.Parse(ageTextBox.Text);
                    rider.ContactNumber = contactTextBox.Text.Trim();
                    rider.Address = addressTextBox.Text.Trim();
                    rider.LicenseNumber = licenseTextBox.Text.Trim();
                    rider.UserName = usernameTextBox.Text.Trim();
                    rider.Password = HashPassword(passwordTextBox.Text);

                    bool riderAdded = foodHubService.AddRider(rider);

                    if (riderAdded)
                    {
                        var dependents = GetDependentsData();
                        foreach (var dep in dependents)
                        {
                            Dependent dependent = new Dependent();
                            dependent.RiderID = rider.RiderID;
                            dependent.Name = dep.Name;
                            dependent.Relationship = dep.Relationship;
                            dependent.DateOfBirth = dep.DateOfBirth;
                            foodHubService.AddDependant(dependent);
                        }

                        MessageBox.Show("Rider added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add rider. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving rider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateRiderInput()
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

            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                MessageBox.Show("Please enter password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                passwordTextBox.Focus();
                return false;
            }

            return true;
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
    }
}
