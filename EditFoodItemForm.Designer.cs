namespace FoodHub
{
    partial class EditFoodItemForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.ingredientsPanel = new System.Windows.Forms.Panel();
            this.ingredientsLabel = new System.Windows.Forms.Label();
            this.ingredientsDataGridView = new System.Windows.Forms.DataGridView();
            this.IngredientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foodItemPanel = new System.Windows.Forms.Panel();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.itemNameTextBox = new System.Windows.Forms.TextBox();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.foodItemInfoLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.ingredientsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).BeginInit();
            this.foodItemPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(800, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(30, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(215, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Edit Food Item";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.buttonsPanel);
            this.contentPanel.Controls.Add(this.ingredientsPanel);
            this.contentPanel.Controls.Add(this.foodItemPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(30);
            this.contentPanel.Size = new System.Drawing.Size(800, 580);
            this.contentPanel.TabIndex = 1;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.saveButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(30, 490);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(740, 60);
            this.buttonsPanel.TabIndex = 2;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(620, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(500, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 40);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ingredientsPanel
            // 
            this.ingredientsPanel.BackColor = System.Drawing.Color.White;
            this.ingredientsPanel.Controls.Add(this.ingredientsLabel);
            this.ingredientsPanel.Controls.Add(this.ingredientsDataGridView);
            this.ingredientsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ingredientsPanel.Location = new System.Drawing.Point(30, 230);
            this.ingredientsPanel.Name = "ingredientsPanel";
            this.ingredientsPanel.Padding = new System.Windows.Forms.Padding(20);
            this.ingredientsPanel.Size = new System.Drawing.Size(740, 260);
            this.ingredientsPanel.TabIndex = 1;
            // 
            // ingredientsLabel
            // 
            this.ingredientsLabel.AutoSize = true;
            this.ingredientsLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ingredientsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ingredientsLabel.Location = new System.Drawing.Point(20, 20);
            this.ingredientsLabel.Name = "ingredientsLabel";
            this.ingredientsLabel.Size = new System.Drawing.Size(217, 32);
            this.ingredientsLabel.TabIndex = 0;
            this.ingredientsLabel.Text = "Ingredients (Read-Only)";
            // 
            // ingredientsDataGridView
            // 
            this.ingredientsDataGridView.AllowUserToAddRows = false;
            this.ingredientsDataGridView.AllowUserToDeleteRows = false;
            this.ingredientsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ingredientsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ingredientsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ingredientsDataGridView.ColumnHeadersHeight = 35;
            this.ingredientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ingredientsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IngredientName});
            this.ingredientsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ingredientsDataGridView.Location = new System.Drawing.Point(25, 60);
            this.ingredientsDataGridView.Name = "ingredientsDataGridView";
            this.ingredientsDataGridView.ReadOnly = true;
            this.ingredientsDataGridView.RowHeadersVisible = false;
            this.ingredientsDataGridView.RowHeadersWidth = 51;
            this.ingredientsDataGridView.RowTemplate.Height = 35;
            this.ingredientsDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ingredientsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ingredientsDataGridView.Size = new System.Drawing.Size(690, 180);
            this.ingredientsDataGridView.TabIndex = 1;
            // 
            // IngredientName
            // 
            this.IngredientName.HeaderText = "Ingredient Name";
            this.IngredientName.MinimumWidth = 6;
            this.IngredientName.Name = "IngredientName";
            this.IngredientName.ReadOnly = true;
            // 
            // foodItemPanel
            // 
            this.foodItemPanel.BackColor = System.Drawing.Color.White;
            this.foodItemPanel.Controls.Add(this.priceTextBox);
            this.foodItemPanel.Controls.Add(this.priceLabel);
            this.foodItemPanel.Controls.Add(this.categoryComboBox);
            this.foodItemPanel.Controls.Add(this.categoryLabel);
            this.foodItemPanel.Controls.Add(this.itemNameTextBox);
            this.foodItemPanel.Controls.Add(this.itemNameLabel);
            this.foodItemPanel.Controls.Add(this.foodItemInfoLabel);
            this.foodItemPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.foodItemPanel.Location = new System.Drawing.Point(30, 30);
            this.foodItemPanel.Name = "foodItemPanel";
            this.foodItemPanel.Padding = new System.Windows.Forms.Padding(20);
            this.foodItemPanel.Size = new System.Drawing.Size(740, 200);
            this.foodItemPanel.TabIndex = 0;
            // 
            // priceTextBox
            // 
            this.priceTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceTextBox.Location = new System.Drawing.Point(150, 150);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 30);
            this.priceTextBox.TabIndex = 6;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(25, 153);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(49, 23);
            this.priceLabel.TabIndex = 5;
            this.priceLabel.Text = "Price:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Appetizer",
            "Main Course",
            "Dessert",
            "Beverage",
            "Salad",
            "Soup",
            "Side Dish"});
            this.categoryComboBox.Location = new System.Drawing.Point(150, 110);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(300, 31);
            this.categoryComboBox.TabIndex = 4;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.Location = new System.Drawing.Point(25, 113);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(82, 23);
            this.categoryLabel.TabIndex = 3;
            this.categoryLabel.Text = "Category:";
            // 
            // itemNameTextBox
            // 
            this.itemNameTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameTextBox.Location = new System.Drawing.Point(150, 70);
            this.itemNameTextBox.Name = "itemNameTextBox";
            this.itemNameTextBox.Size = new System.Drawing.Size(400, 30);
            this.itemNameTextBox.TabIndex = 2;
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameLabel.Location = new System.Drawing.Point(25, 73);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(95, 23);
            this.itemNameLabel.TabIndex = 1;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // foodItemInfoLabel
            // 
            this.foodItemInfoLabel.AutoSize = true;
            this.foodItemInfoLabel.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodItemInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.foodItemInfoLabel.Location = new System.Drawing.Point(20, 20);
            this.foodItemInfoLabel.Name = "foodItemInfoLabel";
            this.foodItemInfoLabel.Size = new System.Drawing.Size(207, 32);
            this.foodItemInfoLabel.TabIndex = 0;
            this.foodItemInfoLabel.Text = "Food Item Details";
            // 
            // EditFoodItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditFoodItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Food Item";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ingredientsPanel.ResumeLayout(false);
            this.ingredientsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ingredientsDataGridView)).EndInit();
            this.foodItemPanel.ResumeLayout(false);
            this.foodItemPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel ingredientsPanel;
        private System.Windows.Forms.Label ingredientsLabel;
        private System.Windows.Forms.DataGridView ingredientsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngredientName;
        private System.Windows.Forms.Panel foodItemPanel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox itemNameTextBox;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.Label foodItemInfoLabel;
    }
}
