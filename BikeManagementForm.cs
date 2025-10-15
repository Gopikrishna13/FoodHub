using FoodHub.Services;
using FoodHub.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class BikeManagementForm : Form
    {
        private FoodHubService foodHubService;

        public BikeManagementForm()
        {
            InitializeComponent();
            foodHubService = new FoodHubService();
            InitializeDataGridView();
            LoadBikes();
            
            
            this.Activated += BikeManagementForm_Activated;
        }

        private void InitializeDataGridView()
        {
            
            bikesDataGridView.EnableHeadersVisualStyles = false;
            bikesDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            bikesDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            bikesDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            bikesDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            bikesDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            bikesDataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            bikesDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            bikesDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            bikesDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            bikesDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            
           
            UpdateColumn.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            UpdateColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            UpdateColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            
            DeleteColumn.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            DeleteColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DeleteColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }

        private void LoadBikes()
        {
            try
            {
                var bikes = foodHubService.GetAllBikes();
                bikesDataGridView.Rows.Clear();

                foreach (var bike in bikes)
                {
                    bikesDataGridView.Rows.Add(
                        bike.BikeRegNo,
                        bike.Brand,
                        bike.Model,
                        bike.EngineNumber,
                        bike.RegisteredDate.ToShortDateString(),
                        "✏️ Edit",
                        "🗑️ Delete"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading bikes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBikeButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddBikeForm addBikeForm = new AddBikeForm();
                if (addBikeForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid(); // Refresh the grid after adding
                    MessageBox.Show("Bike added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening add bike form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bikesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var bikeRegNo = bikesDataGridView.Rows[e.RowIndex].Cells["BikeRegNo"].Value?.ToString();
                
                if (e.ColumnIndex == bikesDataGridView.Columns["UpdateColumn"].Index)
                {
                    
                    UpdateBike(bikeRegNo);
                }
                else if (e.ColumnIndex == bikesDataGridView.Columns["DeleteColumn"].Index)
                {
                   
                    DeleteBike(bikeRegNo);
                }
            }
        }

        private void UpdateBike(string bikeRegNo)
        {
            try
            {
                EditBikeForm editForm = new EditBikeForm(bikeRegNo);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating bike: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteBike(string bikeRegNo)
        {
            try
            {
                var result = MessageBox.Show($"Are you sure you want to delete bike {bikeRegNo}?", 
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    
                    try
                    {
                        bool deleted = foodHubService.DeleteBike(bikeRegNo);
                        
                        if (deleted)
                        {
                            MessageBox.Show("Bike deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            RefreshGrid(); 
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete bike. It may be in use or not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception deleteEx)
                    {
                        MessageBox.Show($"Failed to delete bike: {deleteEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting bike: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshGrid()
        {
            try
            {
                
                bikesDataGridView.Rows.Clear();
                
            
                var bikes = foodHubService.GetAllBikes();
                
         
                foreach (var bike in bikes)
                {
                    bikesDataGridView.Rows.Add(
                        bike.BikeRegNo,
                        bike.Brand,
                        bike.Model,
                        bike.EngineNumber,
                        bike.RegisteredDate.ToShortDateString(),
                        "✏️ Edit",
                        "🗑️ Delete"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing bike list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BikeManagementForm_Activated(object sender, EventArgs e)
        {
            
            RefreshGrid();
        }


    }
}
