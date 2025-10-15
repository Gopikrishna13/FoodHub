using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class AddFoodItemForm : Form
    {
        private FoodHubService foodHubService;

        public AddFoodItemForm()
        {
            InitializeComponent();
            foodHubService = new FoodHubService();
        }

        private void addIngredientButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateIngredientInput())
                {
                    ingredientsDataGridView.Rows.Add(
                        ingredientTextBox.Text.Trim(),
                        "🗑️ Remove"
                    );
                    ClearIngredientInputs();
                    MessageBox.Show("Ingredient added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding ingredient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateIngredientInput()
        {
            if (string.IsNullOrWhiteSpace(ingredientTextBox.Text))
            {
                MessageBox.Show("Please enter an ingredient name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ingredientTextBox.Focus();
                return false;
            }

            foreach (DataGridViewRow row in ingredientsDataGridView.Rows)
            {
                if (row.Cells["IngredientName"].Value?.ToString().Trim().ToLower() == ingredientTextBox.Text.Trim().ToLower())
                {
                    MessageBox.Show("This ingredient is already added.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ingredientTextBox.Focus();
                    return false;
                }
            }

            return true;
        }

        private void ClearIngredientInputs()
        {
            ingredientTextBox.Text = "";
        }

        private void IngredientsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == ingredientsDataGridView.Columns["RemoveIngredient"].Index)
                {
                    string ingredientName = ingredientsDataGridView.Rows[e.RowIndex].Cells["IngredientName"].Value?.ToString();
                    
                    var result = MessageBox.Show($"Are you sure you want to remove ingredient '{ingredientName}'?", 
                        "Confirm Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    if (result == DialogResult.Yes)
                    {
                        ingredientsDataGridView.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Ingredient removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error removing ingredient: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateFoodItemInput())
                {
                    FoodItem foodItem = new FoodItem();
                    foodItem.ItemName = itemNameTextBox.Text.Trim();
                    foodItem.Category = categoryComboBox.SelectedItem.ToString();
                    foodItem.Price = decimal.Parse(priceTextBox.Text);

                    FoodItem addedFoodItem = foodHubService.AddFoodItem(foodItem);

                    if (addedFoodItem != null)
                    {
                        var ingredients = GetIngredientsData();
                        foreach (var ingredientName in ingredients)
                        {
                            Ingredient ingredient = new Ingredient();
                            ingredient.IngredientName = ingredientName;
                            foodHubService.AddIngredient(ingredient);

                            var allIngredients = foodHubService.GetAllIngredients();
                            var addedIngredient = allIngredients.FirstOrDefault(i => i.IngredientName == ingredientName);
                            
                            if (addedIngredient != null)
                            {
                                FoodItemIngredient foodItemIngredient = new FoodItemIngredient();
                                foodItemIngredient.ItemID = addedFoodItem.ItemID;
                                foodItemIngredient.IngredientID = addedIngredient.IngredientID;
                                foodHubService.AddFoodItemIngredient(foodItemIngredient);
                            }
                        }

                        MessageBox.Show("Food item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to add food item. Food item with same name may already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving food item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFoodItemInput()
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

        private List<string> GetIngredientsData()
        {
            List<string> ingredients = new List<string>();
            foreach (DataGridViewRow row in ingredientsDataGridView.Rows)
            {
                if (row.Cells["IngredientName"].Value != null)
                {
                    ingredients.Add(row.Cells["IngredientName"].Value.ToString());
                }
            }
            return ingredients;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
