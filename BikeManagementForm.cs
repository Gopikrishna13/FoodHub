using System;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class BikeManagementForm : Form
    {
        public BikeManagementForm()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {
            // Configure DataGridView appearance
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
            
            // Configure button columns
            UpdateColumn.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            UpdateColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            UpdateColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(39, 174, 96);
            
            DeleteColumn.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            DeleteColumn.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            DeleteColumn.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 76, 60);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBikeButton_Click(object sender, EventArgs e)
        {
            AddBikeForm addBikeForm = new AddBikeForm();
            addBikeForm.Show();
        }

    }
}
