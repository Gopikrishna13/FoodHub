namespace FoodHub
{
    partial class FoodItemManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.addFoodItemButton = new System.Windows.Forms.Button();
            this.foodItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngredientsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1700, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(1620, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(30, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(279, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Food Item Management";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.addFoodItemButton);
            this.contentPanel.Controls.Add(this.foodItemsDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1700, 630);
            this.contentPanel.TabIndex = 1;
            // 
            // addFoodItemButton
            // 
            this.addFoodItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.addFoodItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addFoodItemButton.FlatAppearance.BorderSize = 0;
            this.addFoodItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addFoodItemButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addFoodItemButton.ForeColor = System.Drawing.Color.White;
            this.addFoodItemButton.Location = new System.Drawing.Point(30, 20);
            this.addFoodItemButton.Name = "addFoodItemButton";
            this.addFoodItemButton.Size = new System.Drawing.Size(150, 40);
            this.addFoodItemButton.TabIndex = 1;
            this.addFoodItemButton.Text = "👤 Add New";
            this.addFoodItemButton.UseVisualStyleBackColor = false;
            this.addFoodItemButton.Click += new System.EventHandler(this.addFoodItemButton_Click);
            // 
            // foodItemsDataGridView
            // 
            this.foodItemsDataGridView.AllowUserToAddRows = false;
            this.foodItemsDataGridView.AllowUserToDeleteRows = false;
            this.foodItemsDataGridView.AllowUserToResizeColumns = false;
            this.foodItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.foodItemsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.foodItemsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foodItemsDataGridView.ColumnHeadersHeight = 40;
            this.foodItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.foodItemsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.Category,
            this.Price,
            this.IngredientsCount,
            this.UpdateColumn,
            this.DeleteColumn});
            this.foodItemsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.foodItemsDataGridView.Location = new System.Drawing.Point(30, 85);
            this.foodItemsDataGridView.Name = "foodItemsDataGridView";
            this.foodItemsDataGridView.ReadOnly = true;
            this.foodItemsDataGridView.RowHeadersVisible = false;
            this.foodItemsDataGridView.RowHeadersWidth = 51;
            this.foodItemsDataGridView.RowTemplate.Height = 45;
            this.foodItemsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.foodItemsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foodItemsDataGridView.Size = new System.Drawing.Size(1600, 515);
            this.foodItemsDataGridView.TabIndex = 2;
            this.foodItemsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodItemsDataGridView_CellContentClick);
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "Item ID";
            this.ItemID.MinimumWidth = 6;
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            this.ItemID.Width = 80;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 250;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            this.Category.Width = 180;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Width = 120;
            // 
            // IngredientsCount
            // 
            this.IngredientsCount.HeaderText = "Ingredients (Click to View)";
            this.IngredientsCount.MinimumWidth = 6;
            this.IngredientsCount.Name = "IngredientsCount";
            this.IngredientsCount.ReadOnly = true;
            this.IngredientsCount.Width = 300;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.HeaderText = "Update";
            this.UpdateColumn.MinimumWidth = 6;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Text = "✏️ Edit";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            this.UpdateColumn.Width = 60;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "🗑️ Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 60;
            // 
            // FoodItemManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FoodItemManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Food Item Management";
            this.Activated += new System.EventHandler(this.FoodItemManagementForm_Activated);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foodItemsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button addFoodItemButton;
        private System.Windows.Forms.DataGridView foodItemsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientsCount;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}
