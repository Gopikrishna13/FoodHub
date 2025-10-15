using System;
using System.Windows.Forms;

namespace FoodHub
{
    public partial class AddRiderForm : Form
    {
        public AddRiderForm()
        {
            InitializeComponent();
            InitializeDependentsDataGridView();
        }

        private void InitializeDependentsDataGridView()
        {
            // Configure DataGridView appearance
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

        // Event handlers will be implemented when connecting to database functionality
        // For now, these are just placeholders for the UI design
    }
}
