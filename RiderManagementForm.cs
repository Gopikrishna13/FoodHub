using System;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class RiderManagementForm : Form
    {
        public RiderManagementForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Configure DataGridView appearance
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
            
            // Configure button columns
            UpdateColumn.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            UpdateColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            UpdateColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            
            DeleteColumn.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            DeleteColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DeleteColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }

        private void addRiderButton_Click(object sender, EventArgs e)
        {
            AddRiderForm addRiderForm = new AddRiderForm();
            addRiderForm.ShowDialog();
        }


    }
}
