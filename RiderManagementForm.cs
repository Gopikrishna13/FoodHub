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
            
            DependentsCount.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            DependentsCount.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DependentsCount.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(41, 128, 185);
            DependentsCount.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline);
        }

        private void LoadRiders()
        {
            try
            {
                var riders = foodHubService.GetAllRiders();
                ridersDataGridView.Rows.Clear();

                foreach (var rider in riders)
                {
                    var dependents = foodHubService.GetRiderDependents(rider.RiderID);
                    string dependentsInfo = GetDependentsDisplayText(dependents);
                    
                    var row = ridersDataGridView.Rows[ridersDataGridView.Rows.Add(
                        $"{rider.FirstName} {rider.LastName}",
                        rider.NIC,
                        rider.ContactNumber,
                        dependentsInfo,
                        "✏️ Edit",
                        "🗑️ Delete"
                    )];
                    row.Tag = rider.RiderID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading riders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetDependentsDisplayText(System.Collections.Generic.List<Dependent> dependents)
        {
            if (dependents == null || dependents.Count == 0)
            {
                return "No Dependents";
            }

            var dependentsList = new System.Collections.Generic.List<string>();
            foreach (var dep in dependents)
            {
                dependentsList.Add($"{dep.Name} ({dep.Relationship})");
            }
            
            return $"{dependents.Count} - " + string.Join(", ", dependentsList);
        }

        public void RefreshGrid()
        {
            try
            {
                ridersDataGridView.Rows.Clear();
                var riders = foodHubService.GetAllRiders();
                
                foreach (var rider in riders)
                {
                    var dependents = foodHubService.GetRiderDependents(rider.RiderID);
                    string dependentsInfo = GetDependentsDisplayText(dependents);
                    
                    var row = ridersDataGridView.Rows[ridersDataGridView.Rows.Add(
                        $"{rider.FirstName} {rider.LastName}",
                        rider.NIC,
                        rider.ContactNumber,
                        dependentsInfo,
                        "✏️ Edit",
                        "🗑️ Delete"
                    )];
                    row.Tag = rider.RiderID;
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
                var riderId = ridersDataGridView.Rows[e.RowIndex].Tag?.ToString();
                
                if (e.ColumnIndex == ridersDataGridView.Columns["UpdateColumn"].Index)
                {
                    UpdateRider(int.Parse(riderId));
                }
                else if (e.ColumnIndex == ridersDataGridView.Columns["DeleteColumn"].Index)
                {
                    DeleteRider(int.Parse(riderId));
                }
                else if (e.ColumnIndex == ridersDataGridView.Columns["DependentsCount"].Index)
                {
                    ShowDependentsDetails(int.Parse(riderId));
                }
            }
        }

        private void ShowDependentsDetails(int riderId)
        {
            try
            {
                var dependents = foodHubService.GetRiderDependents(riderId);
                var rider = foodHubService.GetSingleRider(riderId);
                
                if (dependents.Count == 0)
                {
                    MessageBox.Show($"Rider '{rider.FirstName} {rider.LastName}' has no dependents.", 
                        "Dependents Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var message = $"Dependents for {rider.FirstName} {rider.LastName}:\n\n";
                foreach (var dep in dependents)
                {
                    message += $"• {dep.Name}\n";
                    message += $"  Relationship: {dep.Relationship}\n";
                    message += $"  Date of Birth: {dep.DateOfBirth.ToShortDateString()}\n";
                    message += $"  Age: {DateTime.Now.Year - dep.DateOfBirth.Year} years\n\n";
                }

                MessageBox.Show(message, "Dependents Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dependents details: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
