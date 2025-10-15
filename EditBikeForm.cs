using FoodHub.Services;
using FoodHub.Models;
using System;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class EditBikeForm : Form
    {
        private FoodHubService foodHubService;
        private MotorBike currentBike;
        private string originalRegNo;

        public EditBikeForm(string bikeRegNo)
        {
            InitializeComponent();
            foodHubService = new FoodHubService();
            originalRegNo = bikeRegNo;
            LoadBikeDetails(bikeRegNo);
        }

        private void LoadBikeDetails(string bikeRegNo)
        {
            try
            {
                currentBike = foodHubService.GetSingleBike(bikeRegNo);
                
                if (currentBike != null)
                {
                    regNoTextBox.Text = currentBike.BikeRegNo;
                    brandTextBox.Text = currentBike.Brand;
                    modelTextBox.Text = currentBike.Model;
                    engineTextBox.Text = currentBike.EngineNumber;
                    datePicker.Value = currentBike.RegisteredDate;
                }
                else
                {
                    MessageBox.Show("Bike not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bike details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    currentBike.Brand = brandTextBox.Text.Trim();
                    currentBike.Model = modelTextBox.Text.Trim();
                    currentBike.EngineNumber = engineTextBox.Text.Trim();
                    currentBike.RegisteredDate = datePicker.Value;

                    var updated = foodHubService.UpdateBike(currentBike);
                    
                    if (updated!=null)
                    {
                        MessageBox.Show("Bike updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update bike. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating bike: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(brandTextBox.Text))
            {
                MessageBox.Show("Please enter a brand name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                brandTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(modelTextBox.Text))
            {
                MessageBox.Show("Please enter a model name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                modelTextBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(engineTextBox.Text))
            {
                MessageBox.Show("Please enter an engine number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                engineTextBox.Focus();
                return false;
            }

            if (datePicker.Value > DateTime.Now)
            {
                MessageBox.Show("Registered date cannot be in the future.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                datePicker.Focus();
                return false;
            }

            return true;
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
