using System;
using System.Linq;
using System.Windows.Forms;
using FoodHub.Models;
using FoodHub.Services;

namespace FoodHub
{
    public partial class FoodItemManagementForm : Form
    {
        private FoodHubService foodHubService;

        public FoodItemManagementForm()
        {
            InitializeComponent();
            foodHubService = new FoodHubService();
            LoadFoodItems();
        }

        private void LoadFoodItems()
        {
            try
            {
                var foodItems = foodHubService.GetAllFoodItems();
                foodItemsDataGridView.Rows.Clear();

                foreach (var item in foodItems)
                {
                    var ingredients = foodHubService.GetFoodItemIngredients(item.ItemID);
                    string ingredientsInfo = GetIngredientsDisplayText(ingredients);
                    
                    foodItemsDataGridView.Rows.Add(
                        item.ItemID,
                        item.ItemName,
                        item.Category,
                        $"${item.Price:F2}",
                        ingredientsInfo,
                        "✏️ Edit",
                        "🗑️ Delete"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading food items: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetIngredientsDisplayText(System.Collections.Generic.List<Ingredient> ingredients)
        {
            if (ingredients.Count == 0)
            {
                return "No ingredients";
            }
            else if (ingredients.Count == 1)
            {
                return $"1 - {ingredients[0].IngredientName}";
            }
            else
            {
                return $"{ingredients.Count} - {string.Join(", ", ingredients.Take(2).Select(i => i.IngredientName))}{(ingredients.Count > 2 ? "..." : "")}";
            }
        }

        private void RefreshGrid()
        {
            LoadFoodItems();
        }

        private void FoodItemManagementForm_Activated(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addFoodItemButton_Click(object sender, EventArgs e)
        {
            AddFoodItemForm addForm = new AddFoodItemForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                RefreshGrid();
            }
        }

        private void foodItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var itemId = foodItemsDataGridView.Rows[e.RowIndex].Cells["ItemID"].Value?.ToString();
                
                if (e.ColumnIndex == foodItemsDataGridView.Columns["UpdateColumn"].Index)
                {
                    UpdateFoodItem(int.Parse(itemId));
                }
                else if (e.ColumnIndex == foodItemsDataGridView.Columns["DeleteColumn"].Index)
                {
                    DeleteFoodItem(int.Parse(itemId));
                }
                else if (e.ColumnIndex == foodItemsDataGridView.Columns["IngredientsCount"].Index)
                {
                    ShowIngredientsDetails(int.Parse(itemId));
                }
            }
        }

        private void UpdateFoodItem(int itemId)
        {
            try
            {
                EditFoodItemForm editForm = new EditFoodItemForm(itemId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                    MessageBox.Show("Food item updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating food item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteFoodItem(int itemId)
        {
            try
            {
                var foodItem = foodHubService.GetSingleFoodItem(itemId);
                if (foodItem != null)
                {
                   
                    string status = foodHubService.CheckFoodItemDeletionStatus(itemId);

                  
                    var statusResult = MessageBox.Show($"{status}\n\nDo you want to proceed with deletion?",
                        "Deletion Status", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                    if (statusResult == DialogResult.Yes)
                    {
                        string result = foodHubService.DeleteFoodItem(itemId);

                        if (result == "SUCCESS")
                        {
                            RefreshGrid();
                            MessageBox.Show("Food item deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            // Show detailed error and offer force delete option
                            var forceResult = MessageBox.Show($"{result}\n\nDo you want to FORCE DELETE this item? This will remove it from all orders!",
                                "Deletion Failed - Force Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                            if (forceResult == DialogResult.Yes)
                            {
                                string forceDeleteResult = foodHubService.ForceDeleteFoodItem(itemId);

                                if (forceDeleteResult == "SUCCESS")
                                {
                                    RefreshGrid();
                                    MessageBox.Show("Food item force deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show($"Force delete failed: {forceDeleteResult}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }
                    else if (statusResult == DialogResult.Cancel)
                    {
                        return; // User cancelled
                    }
                    else
                    {
                        MessageBox.Show("Food item not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting food item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ShowIngredientsDetails(int itemId)
        {
            try
            {
                var ingredients = foodHubService.GetFoodItemIngredients(itemId);
                var foodItem = foodHubService.GetSingleFoodItem(itemId);
                
                if (ingredients.Count == 0)
                {
                    MessageBox.Show($"Food item '{foodItem.ItemName}' has no ingredients.", 
                        "Ingredients Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var message = $"Ingredients for {foodItem.ItemName}:\n\n";
                foreach (var ingredient in ingredients)
                {
                    message += $"• {ingredient.IngredientName}\n";
                }

                MessageBox.Show(message, "Ingredients Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading ingredients details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
