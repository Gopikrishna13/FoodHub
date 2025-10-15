namespace FoodHub
{
    partial class BikeManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.headerPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.bikesDataGridView = new System.Windows.Forms.DataGridView();
            this.BikeRegNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EngineNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegisteredDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colors = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.searchPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.addBikeButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bikesDataGridView)).BeginInit();
            this.searchPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.headerPanel.Controls.Add(this.closeButton);
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1200, 70);
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
            this.closeButton.Location = new System.Drawing.Point(1120, 20);
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
            this.titleLabel.Size = new System.Drawing.Size(274, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Bike Management";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.bikesDataGridView);
            this.contentPanel.Controls.Add(this.searchPanel);
            this.contentPanel.Controls.Add(this.addBikeButton);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(30);
            this.contentPanel.Size = new System.Drawing.Size(1200, 630);
            this.contentPanel.TabIndex = 1;
            // 
            // bikesDataGridView
            // 
            this.bikesDataGridView.AllowUserToAddRows = false;
            this.bikesDataGridView.AllowUserToDeleteRows = false;
            this.bikesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bikesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.bikesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bikesDataGridView.ColumnHeadersHeight = 40;
            this.bikesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.bikesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BikeRegNo,
            this.Brand,
            this.Model,
            this.EngineNumber,
            this.RegisteredDate,
            this.Colors,
            this.UpdateColumn,
            this.DeleteColumn});
            this.bikesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.bikesDataGridView.Location = new System.Drawing.Point(30, 85);
            this.bikesDataGridView.Name = "bikesDataGridView";
            this.bikesDataGridView.ReadOnly = true;
            this.bikesDataGridView.RowHeadersVisible = false;
            this.bikesDataGridView.RowHeadersWidth = 51;
            this.bikesDataGridView.RowTemplate.Height = 45;
            this.bikesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bikesDataGridView.Size = new System.Drawing.Size(1140, 515);
            this.bikesDataGridView.TabIndex = 2;
            // 
            // BikeRegNo
            // 
            this.BikeRegNo.HeaderText = "Registration No";
            this.BikeRegNo.MinimumWidth = 6;
            this.BikeRegNo.Name = "BikeRegNo";
            this.BikeRegNo.ReadOnly = true;
            this.BikeRegNo.Width = 150;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.ReadOnly = true;
            this.Brand.Width = 120;
            // 
            // Model
            // 
            this.Model.HeaderText = "Model";
            this.Model.MinimumWidth = 6;
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            this.Model.Width = 120;
            // 
            // EngineNumber
            // 
            this.EngineNumber.HeaderText = "Engine Number";
            this.EngineNumber.MinimumWidth = 6;
            this.EngineNumber.Name = "EngineNumber";
            this.EngineNumber.ReadOnly = true;
            this.EngineNumber.Width = 150;
            // 
            // RegisteredDate
            // 
            this.RegisteredDate.HeaderText = "Registered Date";
            this.RegisteredDate.MinimumWidth = 6;
            this.RegisteredDate.Name = "RegisteredDate";
            this.RegisteredDate.ReadOnly = true;
            this.RegisteredDate.Width = 130;
            // 
            // Colors
            // 
            this.Colors.HeaderText = "Colors";
            this.Colors.MinimumWidth = 6;
            this.Colors.Name = "Colors";
            this.Colors.ReadOnly = true;
            this.Colors.Width = 200;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.HeaderText = "Update";
            this.UpdateColumn.MinimumWidth = 6;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Text = "✏️ Edit";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "🗑️ Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // searchPanel
            // 
            this.searchPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchPanel.BackColor = System.Drawing.Color.White;
            this.searchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchPanel.Controls.Add(this.searchTextBox);
            this.searchPanel.Controls.Add(this.searchLabel);
            this.searchPanel.Location = new System.Drawing.Point(798, 20);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(372, 45);
            this.searchPanel.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchTextBox.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextBox.Location = new System.Drawing.Point(102, 14);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(220, 25);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.searchLabel.Location = new System.Drawing.Point(3, 14);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(93, 23);
            this.searchLabel.TabIndex = 0;
            this.searchLabel.Text = "🔍 Search:";
            // 
            // addBikeButton
            // 
            this.addBikeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.addBikeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBikeButton.FlatAppearance.BorderSize = 0;
            this.addBikeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBikeButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBikeButton.ForeColor = System.Drawing.Color.White;
            this.addBikeButton.Location = new System.Drawing.Point(30, 20);
            this.addBikeButton.Name = "addBikeButton";
            this.addBikeButton.Size = new System.Drawing.Size(150, 45);
            this.addBikeButton.TabIndex = 0;
            this.addBikeButton.Text = "➕ Add New Bike";
            this.addBikeButton.UseVisualStyleBackColor = false;
            this.addBikeButton.Click += new System.EventHandler(this.addBikeButton_Click);
            // 
            // BikeManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BikeManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bike Management";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bikesDataGridView)).EndInit();
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button addBikeButton;
        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView bikesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BikeRegNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn EngineNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegisteredDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colors;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}
