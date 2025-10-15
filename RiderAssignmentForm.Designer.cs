namespace FoodHub
{
    partial class RiderAssignmentForm
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
            this.assignButton = new System.Windows.Forms.Button();
            this.assignmentPanel = new System.Windows.Forms.Panel();
            this.startMeterTextBox = new System.Windows.Forms.TextBox();
            this.startMeterLabel = new System.Windows.Forms.Label();
            this.bikeComboBox = new System.Windows.Forms.ComboBox();
            this.bikeLabel = new System.Windows.Forms.Label();
            this.riderComboBox = new System.Windows.Forms.ComboBox();
            this.riderLabel = new System.Windows.Forms.Label();
            this.orderInfoLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.assignmentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(500, 60);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(20, 15);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(172, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Assign Rider";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.buttonsPanel);
            this.contentPanel.Controls.Add(this.assignmentPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.contentPanel.Size = new System.Drawing.Size(500, 390);
            this.contentPanel.TabIndex = 1;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.cancelButton);
            this.buttonsPanel.Controls.Add(this.assignButton);
            this.buttonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsPanel.Location = new System.Drawing.Point(20, 320);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(460, 50);
            this.buttonsPanel.TabIndex = 1;
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
            this.cancelButton.Location = new System.Drawing.Point(350, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 35);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // assignButton
            // 
            this.assignButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.assignButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.assignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.assignButton.FlatAppearance.BorderSize = 0;
            this.assignButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignButton.ForeColor = System.Drawing.Color.White;
            this.assignButton.Location = new System.Drawing.Point(240, 10);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(100, 35);
            this.assignButton.TabIndex = 0;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = false;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // assignmentPanel
            // 
            this.assignmentPanel.BackColor = System.Drawing.Color.White;
            this.assignmentPanel.Controls.Add(this.startMeterTextBox);
            this.assignmentPanel.Controls.Add(this.startMeterLabel);
            this.assignmentPanel.Controls.Add(this.bikeComboBox);
            this.assignmentPanel.Controls.Add(this.bikeLabel);
            this.assignmentPanel.Controls.Add(this.riderComboBox);
            this.assignmentPanel.Controls.Add(this.riderLabel);
            this.assignmentPanel.Controls.Add(this.orderInfoLabel);
            this.assignmentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.assignmentPanel.Location = new System.Drawing.Point(20, 20);
            this.assignmentPanel.Name = "assignmentPanel";
            this.assignmentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.assignmentPanel.Size = new System.Drawing.Size(460, 300);
            this.assignmentPanel.TabIndex = 0;
            // 
            // startMeterTextBox
            // 
            this.startMeterTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMeterTextBox.Location = new System.Drawing.Point(150, 220);
            this.startMeterTextBox.Name = "startMeterTextBox";
            this.startMeterTextBox.Size = new System.Drawing.Size(200, 30);
            this.startMeterTextBox.TabIndex = 6;
            // 
            // startMeterLabel
            // 
            this.startMeterLabel.AutoSize = true;
            this.startMeterLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startMeterLabel.Location = new System.Drawing.Point(20, 223);
            this.startMeterLabel.Name = "startMeterLabel";
            this.startMeterLabel.Size = new System.Drawing.Size(124, 23);
            this.startMeterLabel.TabIndex = 5;
            this.startMeterLabel.Text = "Start Meter (km):";
            // 
            // bikeComboBox
            // 
            this.bikeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bikeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeComboBox.FormattingEnabled = true;
            this.bikeComboBox.Location = new System.Drawing.Point(150, 170);
            this.bikeComboBox.Name = "bikeComboBox";
            this.bikeComboBox.Size = new System.Drawing.Size(280, 31);
            this.bikeComboBox.TabIndex = 4;
            // 
            // bikeLabel
            // 
            this.bikeLabel.AutoSize = true;
            this.bikeLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeLabel.Location = new System.Drawing.Point(20, 173);
            this.bikeLabel.Name = "bikeLabel";
            this.bikeLabel.Size = new System.Drawing.Size(91, 23);
            this.bikeLabel.TabIndex = 3;
            this.bikeLabel.Text = "Select Bike:";
            // 
            // riderComboBox
            // 
            this.riderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.riderComboBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riderComboBox.FormattingEnabled = true;
            this.riderComboBox.Location = new System.Drawing.Point(150, 120);
            this.riderComboBox.Name = "riderComboBox";
            this.riderComboBox.Size = new System.Drawing.Size(280, 31);
            this.riderComboBox.TabIndex = 2;
            // 
            // riderLabel
            // 
            this.riderLabel.AutoSize = true;
            this.riderLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.riderLabel.Location = new System.Drawing.Point(20, 123);
            this.riderLabel.Name = "riderLabel";
            this.riderLabel.Size = new System.Drawing.Size(96, 23);
            this.riderLabel.TabIndex = 1;
            this.riderLabel.Text = "Select Rider:";
            // 
            // orderInfoLabel
            // 
            this.orderInfoLabel.AutoSize = true;
            this.orderInfoLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInfoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.orderInfoLabel.Location = new System.Drawing.Point(20, 20);
            this.orderInfoLabel.Name = "orderInfoLabel";
            this.orderInfoLabel.Size = new System.Drawing.Size(134, 28);
            this.orderInfoLabel.TabIndex = 0;
            this.orderInfoLabel.Text = "Order #12345";
            // 
            // RiderAssignmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RiderAssignmentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Assign Rider to Order";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.assignmentPanel.ResumeLayout(false);
            this.assignmentPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Panel assignmentPanel;
        private System.Windows.Forms.TextBox startMeterTextBox;
        private System.Windows.Forms.Label startMeterLabel;
        private System.Windows.Forms.ComboBox bikeComboBox;
        private System.Windows.Forms.Label bikeLabel;
        private System.Windows.Forms.ComboBox riderComboBox;
        private System.Windows.Forms.Label riderLabel;
        private System.Windows.Forms.Label orderInfoLabel;
    }
}
