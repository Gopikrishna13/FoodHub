using FoodHub.Services;
using FoodHub.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class RiderManagementForm : Form
    {
        private FoodHubService foodHubService;

        public RiderManagementForm()
        {
            InitializeComponent();
            foodHubService = new FoodHubService();
            InitializeDataGridView();
            LoadRiders();
            this.Activated += RiderManagementForm_Activated;
        }

        private void InitializeDataGridView()
        {
            ridersDataGridView.EnableHeadersVisualStyles = false;
            ridersDataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 73, 94);
            ridersDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            ridersDataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            ridersDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            ridersDataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            ridersDataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            ridersDataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(52, 73, 94);
            ridersDataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            ridersDataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            ridersDataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 249, 250);
            
            UpdateColumn.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            UpdateColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            UpdateColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            
            DeleteColumn.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            DeleteColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DeleteColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }

        private void LoadRiders()
        {
            try
            {
                var riders = foodHubService.GetAllRiders();
                ridersDataGridView.Rows.Clear();

                foreach (var rider in riders)
                {
                    ridersDataGridView.Rows.Add(
                        rider.RiderID,
                        $"{rider.FirstName} {rider.LastName}",
                        rider.NIC,
                        rider.ContactNumber,
                        rider.LicenseNumber,
                        rider.UserName,
                        "✏️ Edit",
                        "🗑️ Delete"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading riders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RefreshGrid()
        {
            try
            {
                ridersDataGridView.Rows.Clear();
                var riders = foodHubService.GetAllRiders();
                
                foreach (var rider in riders)
                {
                    ridersDataGridView.Rows.Add(
                        rider.RiderID,
                        $"{rider.FirstName} {rider.LastName}",
                        rider.NIC,
                        rider.ContactNumber,
                        rider.LicenseNumber,
                        rider.UserName,
                        "✏️ Edit",
                        "🗑️ Delete"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing rider list: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RiderManagementForm_Activated(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void addRiderButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddRiderForm addForm = new AddRiderForm();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening add rider form: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ridersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var riderId = ridersDataGridView.Rows[e.RowIndex].Cells["RiderID"].Value?.ToString();
                
                if (e.ColumnIndex == ridersDataGridView.Columns["UpdateColumn"].Index)
                {
                    UpdateRider(int.Parse(riderId));
                }
                else if (e.ColumnIndex == ridersDataGridView.Columns["DeleteColumn"].Index)
                {
                    DeleteRider(int.Parse(riderId));
                }
            }
        }

        private void UpdateRider(int riderId)
        {
            try
            {
                EditRiderForm editForm = new EditRiderForm(riderId);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    RefreshGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating rider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteRider(int riderId)
        {
            try
            {
                var rider = foodHubService.GetSingleRider(riderId);
                var result = MessageBox.Show($"Are you sure you want to delete rider '{rider.FirstName} {rider.LastName}' and all dependents?", 
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                
                if (result == DialogResult.Yes)
                {
                    bool deleted = foodHubService.DeleteRider(riderId);
                    
                    if (deleted)
                    {
                        MessageBox.Show("Rider and dependents deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        RefreshGrid();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete rider.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting rider: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
