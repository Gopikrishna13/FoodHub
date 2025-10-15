using System;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class EditFoodItemForm : Form
    {
        private FoodHubService foodHubService;
        private FoodItem currentFoodItem;
        private int itemId;

        public EditFoodItemForm(int itemId)
        {
            InitializeComponent();
            this.itemId = itemId;
            foodHubService = new FoodHubService();
            LoadFoodItemDetails();
            LoadIngredients();
        }

        private void LoadFoodItemDetails()
        {
            try
            {
                currentFoodItem = foodHubService.GetSingleFoodItem(itemId);
                if (currentFoodItem != null)
                {
                    itemNameTextBox.Text = currentFoodItem.ItemName;
                    categoryComboBox.SelectedItem = currentFoodItem.Category;
                    priceTextBox.Text = currentFoodItem.Price.ToString("F2");
                }
                else
                {
                    MessageBox.Show("Food item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading food item details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadIngredients()
        {
            try
            {
                var ingredients = foodHubService.GetFoodItemIngredients(itemId);
                ingredientsDataGridView.Rows.Clear();

                foreach (var ingredient in ingredients)
                {
                    ingredientsDataGridView.Rows.Add(ingredient.IngredientName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ingredients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInput())
                {
                    currentFoodItem.ItemName = itemNameTextBox.Text.Trim();
                    currentFoodItem.Category = categoryComboBox.SelectedItem.ToString();
                    currentFoodItem.Price = decimal.Parse(priceTextBox.Text);

                    bool success = foodHubService.UpdateFoodItem(currentFoodItem);
                    
                    if (success)
                    {
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update food item.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating food item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(itemNameTextBox.Text))
            {
                MessageBox.Show("Please enter an item name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                itemNameTextBox.Focus();
                return false;
            }

            if (categoryComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a category.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categoryComboBox.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(priceTextBox.Text))
            {
                MessageBox.Show("Please enter a price.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceTextBox.Focus();
                return false;
            }

            if (!decimal.TryParse(priceTextBox.Text, out decimal price) || price <= 0)
            {
                MessageBox.Show("Please enter a valid price greater than 0.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                priceTextBox.Focus();
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
}
