namespace FoodHub
{
    partial class EditBikeForm
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
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.bikeInfoPanel.SuspendLayout();
            this.buttonPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.headerPanel.Controls.Add(this.titleLabel);
            this.headerPanel.Controls.Add(this.closeButton);
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
            this.titleLabel.Size = new System.Drawing.Size(165, 37);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "🏍️ Edit Bike";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.closeButton.FlatAppearance.BorderSize = 0;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.White;
            this.closeButton.Location = new System.Drawing.Point(440, 15);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(40, 30);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "✕";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.bikeInfoPanel);
            this.contentPanel.Controls.Add(this.buttonPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 60);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.contentPanel.Size = new System.Drawing.Size(500, 440);
            this.contentPanel.TabIndex = 1;
            // 
            // bikeInfoPanel
            // 
            this.bikeInfoPanel.BackColor = System.Drawing.Color.White;
            this.bikeInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bikeInfoPanel.Controls.Add(this.bikeInfoTitle);
            this.bikeInfoPanel.Controls.Add(this.regNoLabel);
            this.bikeInfoPanel.Controls.Add(this.regNoTextBox);
            this.bikeInfoPanel.Controls.Add(this.brandLabel);
            this.bikeInfoPanel.Controls.Add(this.brandTextBox);
            this.bikeInfoPanel.Controls.Add(this.modelLabel);
            this.bikeInfoPanel.Controls.Add(this.modelTextBox);
            this.bikeInfoPanel.Controls.Add(this.engineLabel);
            this.bikeInfoPanel.Controls.Add(this.engineTextBox);
            this.bikeInfoPanel.Controls.Add(this.dateLabel);
            this.bikeInfoPanel.Controls.Add(this.datePicker);
            this.bikeInfoPanel.Location = new System.Drawing.Point(20, 20);
            this.bikeInfoPanel.Name = "bikeInfoPanel";
            this.bikeInfoPanel.Size = new System.Drawing.Size(460, 320);
            this.bikeInfoPanel.TabIndex = 0;
            // 
            // bikeInfoTitle
            // 
            this.bikeInfoTitle.AutoSize = true;
            this.bikeInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bikeInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.bikeInfoTitle.Location = new System.Drawing.Point(20, 15);
            this.bikeInfoTitle.Name = "bikeInfoTitle";
            this.bikeInfoTitle.Size = new System.Drawing.Size(181, 32);
            this.bikeInfoTitle.TabIndex = 0;
            this.bikeInfoTitle.Text = "Bike Information";
            // 
            // regNoLabel
            // 
            this.regNoLabel.AutoSize = true;
            this.regNoLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.regNoLabel.Location = new System.Drawing.Point(25, 65);
            this.regNoLabel.Name = "regNoLabel";
            this.regNoLabel.Size = new System.Drawing.Size(139, 23);
            this.regNoLabel.TabIndex = 1;
            this.regNoLabel.Text = "Registration No:";
            // 
            // regNoTextBox
            // 
            this.regNoTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regNoTextBox.Location = new System.Drawing.Point(200, 62);
            this.regNoTextBox.Name = "regNoTextBox";
            this.regNoTextBox.ReadOnly = true;
            this.regNoTextBox.Size = new System.Drawing.Size(230, 30);
            this.regNoTextBox.TabIndex = 2;
            // 
            // brandLabel
            // 
            this.brandLabel.AutoSize = true;
            this.brandLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.brandLabel.Location = new System.Drawing.Point(25, 110);
            this.brandLabel.Name = "brandLabel";
            this.brandLabel.Size = new System.Drawing.Size(58, 23);
            this.brandLabel.TabIndex = 3;
            this.brandLabel.Text = "Brand:";
            // 
            // brandTextBox
            // 
            this.brandTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandTextBox.Location = new System.Drawing.Point(200, 107);
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(230, 30);
            this.brandTextBox.TabIndex = 4;
            // 
            // modelLabel
            // 
            this.modelLabel.AutoSize = true;
            this.modelLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.modelLabel.Location = new System.Drawing.Point(25, 155);
            this.modelLabel.Name = "modelLabel";
            this.modelLabel.Size = new System.Drawing.Size(61, 23);
            this.modelLabel.TabIndex = 5;
            this.modelLabel.Text = "Model:";
            // 
            // modelTextBox
            // 
            this.modelTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelTextBox.Location = new System.Drawing.Point(200, 152);
            this.modelTextBox.Name = "modelTextBox";
            this.modelTextBox.Size = new System.Drawing.Size(230, 30);
            this.modelTextBox.TabIndex = 6;
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.engineLabel.Location = new System.Drawing.Point(25, 200);
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(131, 23);
            this.engineLabel.TabIndex = 7;
            this.engineLabel.Text = "Engine Number:";
            // 
            // engineTextBox
            // 
            this.engineTextBox.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.engineTextBox.Location = new System.Drawing.Point(200, 197);
            this.engineTextBox.Name = "engineTextBox";
            this.engineTextBox.Size = new System.Drawing.Size(230, 30);
            this.engineTextBox.TabIndex = 8;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dateLabel.Location = new System.Drawing.Point(25, 245);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(135, 23);
            this.dateLabel.TabIndex = 9;
            this.dateLabel.Text = "Registered Date:";
            // 
            // datePicker
            // 
            this.datePicker.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(200, 242);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(230, 30);
            this.datePicker.TabIndex = 10;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.saveButton);
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Location = new System.Drawing.Point(20, 360);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(460, 60);
            this.buttonPanel.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.saveButton.FlatAppearance.BorderSize = 0;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(240, 15);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 40);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "💾 Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.White;
            this.cancelButton.Location = new System.Drawing.Point(360, 15);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 40);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "❌ Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // EditBikeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditBikeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Bike";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.bikeInfoPanel.ResumeLayout(false);
            this.bikeInfoPanel.PerformLayout();
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
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
