namespace FoodHub
{
    partial class AddBikeForm
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.bikeInfoPanel = new System.Windows.Forms.Panel();
            this.bikeInfoTitle = new System.Windows.Forms.Label();
            this.regNoLabel = new System.Windows.Forms.Label();
            this.regNoTextBox = new System.Windows.Forms.TextBox();
            this.brandLabel = new System.Windows.Forms.Label();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.modelLabel = new System.Windows.Forms.Label();
            this.modelTextBox = new System.Windows.Forms.TextBox();
            this.engineLabel = new System.Windows.Forms.Label();
            this.engineTextBox = new System.Windows.Forms.TextBox();
            this.dateLabel = new System.Windows.Forms.Label();
            this.registeredDatePicker = new System.Windows.Forms.DateTimePicker();
            this.colorsPanel = new System.Windows.Forms.Panel();
            this.colorsTitle = new System.Windows.Forms.Label();
            this.colorsListBox = new System.Windows.Forms.ListBox();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.addColorButton = new System.Windows.Forms.Button();
            this.removeColorButton = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.bikeInfoPanel.SuspendLayout();
            this.colorsPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(800, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(30, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(180, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add New Bike";
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
            this.closeButton.Location = new System.Drawing.Point(720, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(60, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.buttonPanel);
            this.contentPanel.Controls.Add(this.colorsPanel);
            this.contentPanel.Controls.Add(this.bikeInfoPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(30);
            this.contentPanel.Size = new System.Drawing.Size(800, 580);
            this.contentPanel.TabIndex = 1;
            // 
            // bikeInfoPanel
            // 
            this.bikeInfoPanel.BackColor = System.Drawing.Color.White;
            this.bikeInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bikeInfoPanel.Controls.Add(this.registeredDatePicker);
            this.bikeInfoPanel.Controls.Add(this.dateLabel);
            this.bikeInfoPanel.Controls.Add(this.engineTextBox);
            this.bikeInfoPanel.Controls.Add(this.engineLabel);
            this.bikeInfoPanel.Controls.Add(this.modelTextBox);
            this.bikeInfoPanel.Controls.Add(this.modelLabel);
            this.bikeInfoPanel.Controls.Add(this.brandTextBox);
            this.bikeInfoPanel.Controls.Add(this.brandLabel);
            this.bikeInfoPanel.Controls.Add(this.regNoTextBox);
            this.bikeInfoPanel.Controls.Add(this.regNoLabel);
            this.bikeInfoPanel.Controls.Add(this.bikeInfoTitle);
            this.bikeInfoPanel.Location = new System.Drawing.Point(30, 30);
            this.bikeInfoPanel.Name = "bikeInfoPanel";
            this.bikeInfoPanel.Size = new System.Drawing.Size(740, 280);
            this.bikeInfoPanel.TabIndex = 0;
            // 
            // bikeInfoTitle
            // 
            this.bikeInfoTitle.AutoSize = true;
            this.bikeInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.bikeInfoTitle.Location = new System.Drawing.Point(20, 15);
            this.bikeInfoTitle.Name = "bikeInfoTitle";
            this.bikeInfoTitle.Size = new System.Drawing.Size(180, 25);
            this.bikeInfoTitle.TabIndex = 0;
            this.bikeInfoTitle.Text = "Bike Information";
            // 
            // regNoLabel
            // 
            this.regNoLabel.AutoSize = true;
            this.regNoLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.regNoLabel.Location = new System.Drawing.Point(30, 60);
            this.regNoLabel.Name = "regNoLabel";
            this.regNoLabel.Size = new System.Drawing.Size(125, 20);
            this.regNoLabel.TabIndex = 1;
            this.regNoLabel.Text = "Registration No *";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoTextBox.Location = new System.Drawing.Point(200, 58);
            this.regNoTextBox.MaxLength = 20;
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.Size = new System.Drawing.Size(200, 25);
            this.regNoTextBox.TabIndex = 2;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.brandLabel.Location = new System.Drawing.Point(30, 110);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(58, 20);
            this.brandLabel.TabIndex = 3;
            this.brandLabel.Text = "Brand *";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextBox.Location = new System.Drawing.Point(200, 108);
            this.brandTextBox.MaxLength = 50;
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(200, 25);
            this.brandTextBox.TabIndex = 4;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.modelLabel.Location = new System.Drawing.Point(30, 160);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(60, 20);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model *";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(200, 158);
            this.modelTextBox.MaxLength = 50;
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(200, 25);
            this.modelTextBox.TabIndex = 6;
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.engineLabel.Location = new System.Drawing.Point(430, 60);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(125, 20);
            this.engineLabel.TabIndex = 7;
            this.engineLabel.Text = "Engine Number *";
            // 
            // engineTextBox
            // 
            this.engineTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineTextBox.Location = new System.Drawing.Point(430, 88);
            this.engineTextBox.MaxLength = 50;
            this.engineTextBox.Name = "engineTextBox";
            this.engineTextBox.Size = new System.Drawing.Size(200, 25);
            this.engineTextBox.TabIndex = 8;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dateLabel.Location = new System.Drawing.Point(430, 140);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(130, 20);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Registered Date *";
            // 
            // registeredDatePicker
            // 
            this.registeredDatePicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registeredDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.registeredDatePicker.Location = new System.Drawing.Point(430, 168);
            this.registeredDatePicker.Name = "registeredDatePicker";
            this.registeredDatePicker.Size = new System.Drawing.Size(200, 25);
            this.registeredDatePicker.TabIndex = 10;
            // 
            // colorsPanel
            // 
            this.colorsPanel.BackColor = System.Drawing.Color.White;
            this.colorsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.colorsPanel.Controls.Add(this.removeColorButton);
            this.colorsPanel.Controls.Add(this.addColorButton);
            this.colorsPanel.Controls.Add(this.colorTextBox);
            this.colorsPanel.Controls.Add(this.colorLabel);
            this.colorsPanel.Controls.Add(this.colorsListBox);
            this.colorsPanel.Controls.Add(this.colorsTitle);
            this.colorsPanel.Location = new System.Drawing.Point(30, 330);
            this.colorsPanel.Name = "colorsPanel";
            this.colorsPanel.Size = new System.Drawing.Size(740, 160);
            this.colorsPanel.TabIndex = 1;
            // 
            // colorsTitle
            // 
            this.colorsTitle.AutoSize = true;
            this.colorsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.colorsTitle.Location = new System.Drawing.Point(20, 15);
            this.colorsTitle.Name = "colorsTitle";
            this.colorsTitle.Size = new System.Drawing.Size(115, 25);
            this.colorsTitle.TabIndex = 0;
            this.colorsTitle.Text = "Bike Colors";
            // 
            // colorsListBox
            // 
            this.colorsListBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorsListBox.FormattingEnabled = true;
            this.colorsListBox.ItemHeight = 17;
            this.colorsListBox.Location = new System.Drawing.Point(30, 50);
            this.colorsListBox.Name = "colorsListBox";
            this.colorsListBox.Size = new System.Drawing.Size(200, 89);
            this.colorsListBox.TabIndex = 1;
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.colorLabel.Location = new System.Drawing.Point(280, 50);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(80, 20);
            this.colorLabel.TabIndex = 2;
            this.colorLabel.Text = "Add Color:";
            // 
            // colorTextBox
            // 
            this.colorTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorTextBox.Location = new System.Drawing.Point(280, 78);
            this.colorTextBox.MaxLength = 30;
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(150, 25);
            this.colorTextBox.TabIndex = 3;
            // 
            // addColorButton
            // 
            this.addColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.addColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addColorButton.FlatAppearance.BorderSize = 0;
            this.addColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addColorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addColorButton.ForeColor = System.Drawing.Color.White;
            this.addColorButton.Location = new System.Drawing.Point(450, 78);
            this.addColorButton.Name = "addColorButton";
            this.addColorButton.Size = new System.Drawing.Size(80, 25);
            this.addColorButton.TabIndex = 4;
            this.addColorButton.Text = "➕ Add";
            this.addColorButton.UseVisualStyleBackColor = false;
            // 
            // removeColorButton
            // 
            this.removeColorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.removeColorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeColorButton.FlatAppearance.BorderSize = 0;
            this.removeColorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeColorButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeColorButton.ForeColor = System.Drawing.Color.White;
            this.removeColorButton.Location = new System.Drawing.Point(280, 114);
            this.removeColorButton.Name = "removeColorButton";
            this.removeColorButton.Size = new System.Drawing.Size(100, 25);
            this.removeColorButton.TabIndex = 5;
            this.removeColorButton.Text = "🗑️ Remove";
            this.removeColorButton.UseVisualStyleBackColor = false;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.saveButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(30, 510);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(740, 40);
            this.buttonPanel.TabIndex = 2;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(480, 0);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 40);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "💾 Save";
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(620, 0);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 40);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "✖️ Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // AddBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBikeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Bike";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.bikeInfoPanel.ResumeLayout(false);
            this.bikeInfoPanel.PerformLayout();
            this.colorsPanel.ResumeLayout(false);
            this.colorsPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel bikeInfoPanel;
        private System.Windows.Forms.Label bikeInfoTitle;
        private System.Windows.Forms.Label regNoLabel;
        private System.Windows.Forms.TextBox regNoTextBox;
        private System.Windows.Forms.Label brandLabel;
        private System.Windows.Forms.TextBox brandTextBox;
        private System.Windows.Forms.Label modelLabel;
        private System.Windows.Forms.TextBox modelTextBox;
        private System.Windows.Forms.Label engineLabel;
        private System.Windows.Forms.TextBox engineTextBox;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker registeredDatePicker;
        private System.Windows.Forms.Panel colorsPanel;
        private System.Windows.Forms.Label colorsTitle;
        private System.Windows.Forms.ListBox colorsListBox;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.Button addColorButton;
        private System.Windows.Forms.Button removeColorButton;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
