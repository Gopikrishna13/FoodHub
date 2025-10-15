namespace FoodHub
{
    partial class RiderManagementForm
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
            this.ridersDataGridView = new System.Windows.Forms.DataGridView();
            this.RiderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LicenseNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DependentsCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdateColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addRiderButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ridersDataGridView)).BeginInit();
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
            this.titleLabel.Size = new System.Drawing.Size(289, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Rider Management";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.ridersDataGridView);
            this.contentPanel.Controls.Add(this.addRiderButton);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(30);
            this.contentPanel.Size = new System.Drawing.Size(1200, 630);
            this.contentPanel.TabIndex = 1;
            // 
            // ridersDataGridView
            // 
            this.ridersDataGridView.AllowUserToAddRows = false;
            this.ridersDataGridView.AllowUserToDeleteRows = false;
            this.ridersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ridersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ridersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ridersDataGridView.ColumnHeadersHeight = 40;
            this.ridersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ridersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RiderID,
            this.FullName,
            this.NIC,
            this.ContactNumber,
            this.LicenseNumber,
            this.Age,
            this.DependentsCount,
            this.UpdateColumn,
            this.DeleteColumn});
            this.ridersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ridersDataGridView.Location = new System.Drawing.Point(30, 85);
            this.ridersDataGridView.Name = "ridersDataGridView";
            this.ridersDataGridView.ReadOnly = true;
            this.ridersDataGridView.RowHeadersVisible = false;
            this.ridersDataGridView.RowHeadersWidth = 51;
            this.ridersDataGridView.RowTemplate.Height = 45;
            this.ridersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ridersDataGridView.Size = new System.Drawing.Size(1140, 515);
            this.ridersDataGridView.TabIndex = 2;
            // 
            // RiderID
            // 
            this.RiderID.HeaderText = "Rider ID";
            this.RiderID.MinimumWidth = 6;
            this.RiderID.Name = "RiderID";
            this.RiderID.ReadOnly = true;
            this.RiderID.Width = 80;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Full Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 200;
            // 
            // NIC
            // 
            this.NIC.HeaderText = "NIC";
            this.NIC.MinimumWidth = 6;
            this.NIC.Name = "NIC";
            this.NIC.ReadOnly = true;
            this.NIC.Width = 120;
            // 
            // ContactNumber
            // 
            this.ContactNumber.HeaderText = "Contact Number";
            this.ContactNumber.MinimumWidth = 6;
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.ReadOnly = true;
            this.ContactNumber.Width = 130;
            // 
            // LicenseNumber
            // 
            this.LicenseNumber.HeaderText = "License Number";
            this.LicenseNumber.MinimumWidth = 6;
            this.LicenseNumber.Name = "LicenseNumber";
            this.LicenseNumber.ReadOnly = true;
            this.LicenseNumber.Width = 140;
            // 
            // Age
            // 
            this.Age.HeaderText = "Age";
            this.Age.MinimumWidth = 6;
            this.Age.Name = "Age";
            this.Age.ReadOnly = true;
            this.Age.Width = 60;
            // 
            // DependentsCount
            // 
            this.DependentsCount.HeaderText = "Dependents";
            this.DependentsCount.MinimumWidth = 6;
            this.DependentsCount.Name = "DependentsCount";
            this.DependentsCount.ReadOnly = true;
            this.DependentsCount.Width = 125;
            // 
            // UpdateColumn
            // 
            this.UpdateColumn.HeaderText = "Update";
            this.UpdateColumn.MinimumWidth = 6;
            this.UpdateColumn.Name = "UpdateColumn";
            this.UpdateColumn.ReadOnly = true;
            this.UpdateColumn.Text = "✏️ Edit";
            this.UpdateColumn.UseColumnTextForButtonValue = true;
            this.UpdateColumn.Width = 125;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.MinimumWidth = 6;
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "🗑️ Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            this.DeleteColumn.Width = 125;
            // 
            // addRiderButton
            // 
            this.addRiderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.addRiderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addRiderButton.FlatAppearance.BorderSize = 0;
            this.addRiderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addRiderButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addRiderButton.ForeColor = System.Drawing.Color.White;
            this.addRiderButton.Location = new System.Drawing.Point(30, 20);
            this.addRiderButton.Name = "addRiderButton";
            this.addRiderButton.Size = new System.Drawing.Size(160, 45);
            this.addRiderButton.TabIndex = 0;
            this.addRiderButton.Text = "👤 Add New Rider";
            this.addRiderButton.UseVisualStyleBackColor = false;
            this.addRiderButton.Click += new System.EventHandler(this.addRiderButton_Click);
            // 
            // RiderManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RiderManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rider Management";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ridersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button addRiderButton;
        private System.Windows.Forms.DataGridView ridersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn LicenseNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn DependentsCount;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}
