namespace FoodHub
{
    partial class AddRiderForm
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
            this.personalInfoPanel = new System.Windows.Forms.Panel();
            this.personalInfoTitle = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.nicLabel = new System.Windows.Forms.Label();
            this.nicTextBox = new System.Windows.Forms.TextBox();
            this.dobLabel = new System.Windows.Forms.Label();
            this.dobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.contactInfoPanel = new System.Windows.Forms.Panel();
            this.contactInfoTitle = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.licenseLabel = new System.Windows.Forms.Label();
            this.licenseTextBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.dependentsPanel = new System.Windows.Forms.Panel();
            this.dependentsTitle = new System.Windows.Forms.Label();
            this.dependentsDataGridView = new System.Windows.Forms.DataGridView();
            this.DependentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Relationship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DependentDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RemoveDependent = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addDependentPanel = new System.Windows.Forms.Panel();
            this.depNameLabel = new System.Windows.Forms.Label();
            this.depNameTextBox = new System.Windows.Forms.TextBox();
            this.relationshipLabel = new System.Windows.Forms.Label();
            this.relationshipComboBox = new System.Windows.Forms.ComboBox();
            this.depDobLabel = new System.Windows.Forms.Label();
            this.depDobDatePicker = new System.Windows.Forms.DateTimePicker();
            this.addDependentButton = new System.Windows.Forms.Button();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.personalInfoPanel.SuspendLayout();
            this.contactInfoPanel.SuspendLayout();
            this.dependentsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsDataGridView)).BeginInit();
            this.addDependentPanel.SuspendLayout();
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
            this.headerPanel.Size = new System.Drawing.Size(1000, 70);
            this.headerPanel.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(30, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(190, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Add New Rider";
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
            this.closeButton.Location = new System.Drawing.Point(920, 20);
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
            this.contentPanel.Controls.Add(this.dependentsPanel);
            this.contentPanel.Controls.Add(this.contactInfoPanel);
            this.contentPanel.Controls.Add(this.personalInfoPanel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(30);
            this.contentPanel.Size = new System.Drawing.Size(1000, 730);
            this.contentPanel.TabIndex = 1;
            // 
            // personalInfoPanel
            // 
            this.personalInfoPanel.BackColor = System.Drawing.Color.White;
            this.personalInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.personalInfoPanel.Controls.Add(this.ageTextBox);
            this.personalInfoPanel.Controls.Add(this.ageLabel);
            this.personalInfoPanel.Controls.Add(this.dobDatePicker);
            this.personalInfoPanel.Controls.Add(this.dobLabel);
            this.personalInfoPanel.Controls.Add(this.nicTextBox);
            this.personalInfoPanel.Controls.Add(this.nicLabel);
            this.personalInfoPanel.Controls.Add(this.lastNameTextBox);
            this.personalInfoPanel.Controls.Add(this.lastNameLabel);
            this.personalInfoPanel.Controls.Add(this.middleNameTextBox);
            this.personalInfoPanel.Controls.Add(this.middleNameLabel);
            this.personalInfoPanel.Controls.Add(this.firstNameTextBox);
            this.personalInfoPanel.Controls.Add(this.firstNameLabel);
            this.personalInfoPanel.Controls.Add(this.personalInfoTitle);
            this.personalInfoPanel.Location = new System.Drawing.Point(30, 30);
            this.personalInfoPanel.Name = "personalInfoPanel";
            this.personalInfoPanel.Size = new System.Drawing.Size(460, 280);
            this.personalInfoPanel.TabIndex = 0;
            // 
            // personalInfoTitle
            // 
            this.personalInfoTitle.AutoSize = true;
            this.personalInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personalInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.personalInfoTitle.Location = new System.Drawing.Point(20, 15);
            this.personalInfoTitle.Name = "personalInfoTitle";
            this.personalInfoTitle.Size = new System.Drawing.Size(167, 25);
            this.personalInfoTitle.TabIndex = 0;
            this.personalInfoTitle.Text = "Personal Information";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.firstNameLabel.Location = new System.Drawing.Point(25, 55);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(84, 19);
            this.firstNameLabel.TabIndex = 1;
            this.firstNameLabel.Text = "First Name *";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTextBox.Location = new System.Drawing.Point(130, 53);
            this.firstNameTextBox.MaxLength = 50;
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.middleNameLabel.Location = new System.Drawing.Point(25, 90);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(91, 19);
            this.middleNameLabel.TabIndex = 3;
            this.middleNameLabel.Text = "Middle Name";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middleNameTextBox.Location = new System.Drawing.Point(130, 88);
            this.middleNameTextBox.MaxLength = 50;
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.middleNameTextBox.TabIndex = 4;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lastNameLabel.Location = new System.Drawing.Point(25, 125);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(83, 19);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name *";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTextBox.Location = new System.Drawing.Point(130, 123);
            this.lastNameTextBox.MaxLength = 50;
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 23);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // nicLabel
            // 
            this.nicLabel.AutoSize = true;
            this.nicLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.nicLabel.Location = new System.Drawing.Point(25, 160);
            this.nicLabel.Name = "nicLabel";
            this.nicLabel.Size = new System.Drawing.Size(38, 19);
            this.nicLabel.TabIndex = 7;
            this.nicLabel.Text = "NIC *";
            // 
            // nicTextBox
            // 
            this.nicTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nicTextBox.Location = new System.Drawing.Point(130, 158);
            this.nicTextBox.MaxLength = 12;
            this.nicTextBox.Name = "nicTextBox";
            this.nicTextBox.Size = new System.Drawing.Size(150, 23);
            this.nicTextBox.TabIndex = 8;
            // 
            // dobLabel
            // 
            this.dobLabel.AutoSize = true;
            this.dobLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dobLabel.Location = new System.Drawing.Point(25, 195);
            this.dobLabel.Name = "dobLabel";
            this.dobLabel.Size = new System.Drawing.Size(98, 19);
            this.dobLabel.TabIndex = 9;
            this.dobLabel.Text = "Date of Birth *";
            // 
            // dobDatePicker
            // 
            this.dobDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dobDatePicker.Location = new System.Drawing.Point(130, 193);
            this.dobDatePicker.Name = "dobDatePicker";
            this.dobDatePicker.Size = new System.Drawing.Size(150, 23);
            this.dobDatePicker.TabIndex = 10;
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.ageLabel.Location = new System.Drawing.Point(25, 230);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(40, 19);
            this.ageLabel.TabIndex = 11;
            this.ageLabel.Text = "Age *";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ageTextBox.Location = new System.Drawing.Point(130, 228);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(80, 23);
            this.ageTextBox.TabIndex = 12;
            // 
            // contactInfoPanel
            // 
            this.contactInfoPanel.BackColor = System.Drawing.Color.White;
            this.contactInfoPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contactInfoPanel.Controls.Add(this.passwordTextBox);
            this.contactInfoPanel.Controls.Add(this.passwordLabel);
            this.contactInfoPanel.Controls.Add(this.usernameTextBox);
            this.contactInfoPanel.Controls.Add(this.usernameLabel);
            this.contactInfoPanel.Controls.Add(this.licenseTextBox);
            this.contactInfoPanel.Controls.Add(this.licenseLabel);
            this.contactInfoPanel.Controls.Add(this.addressTextBox);
            this.contactInfoPanel.Controls.Add(this.addressLabel);
            this.contactInfoPanel.Controls.Add(this.contactTextBox);
            this.contactInfoPanel.Controls.Add(this.contactLabel);
            this.contactInfoPanel.Controls.Add(this.contactInfoTitle);
            this.contactInfoPanel.Location = new System.Drawing.Point(510, 30);
            this.contactInfoPanel.Name = "contactInfoPanel";
            this.contactInfoPanel.Size = new System.Drawing.Size(460, 280);
            this.contactInfoPanel.TabIndex = 1;
            // 
            // contactInfoTitle
            // 
            this.contactInfoTitle.AutoSize = true;
            this.contactInfoTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactInfoTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.contactInfoTitle.Location = new System.Drawing.Point(20, 15);
            this.contactInfoTitle.Name = "contactInfoTitle";
            this.contactInfoTitle.Size = new System.Drawing.Size(194, 25);
            this.contactInfoTitle.TabIndex = 0;
            this.contactInfoTitle.Text = "Contact & Login Info";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.contactLabel.Location = new System.Drawing.Point(25, 55);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(119, 19);
            this.contactLabel.TabIndex = 1;
            this.contactLabel.Text = "Contact Number *";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactTextBox.Location = new System.Drawing.Point(160, 53);
            this.contactTextBox.MaxLength = 15;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(150, 23);
            this.contactTextBox.TabIndex = 2;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.addressLabel.Location = new System.Drawing.Point(25, 90);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(69, 19);
            this.addressLabel.TabIndex = 3;
            this.addressLabel.Text = "Address *";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTextBox.Location = new System.Drawing.Point(160, 88);
            this.addressTextBox.MaxLength = 255;
            this.addressTextBox.Multiline = true;
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(250, 60);
            this.addressTextBox.TabIndex = 4;
            // 
            // licenseLabel
            // 
            this.licenseLabel.AutoSize = true;
            this.licenseLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.licenseLabel.Location = new System.Drawing.Point(25, 165);
            this.licenseLabel.Name = "licenseLabel";
            this.licenseLabel.Size = new System.Drawing.Size(125, 19);
            this.licenseLabel.TabIndex = 5;
            this.licenseLabel.Text = "License Number *";
            // 
            // licenseTextBox
            // 
            this.licenseTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licenseTextBox.Location = new System.Drawing.Point(160, 163);
            this.licenseTextBox.MaxLength = 20;
            this.licenseTextBox.Name = "licenseTextBox";
            this.licenseTextBox.Size = new System.Drawing.Size(150, 23);
            this.licenseTextBox.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.usernameLabel.Location = new System.Drawing.Point(25, 200);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(82, 19);
            this.usernameLabel.TabIndex = 7;
            this.usernameLabel.Text = "Username *";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.Location = new System.Drawing.Point(160, 198);
            this.usernameTextBox.MaxLength = 255;
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(150, 23);
            this.usernameTextBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.passwordLabel.Location = new System.Drawing.Point(25, 235);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(76, 19);
            this.passwordLabel.TabIndex = 9;
            this.passwordLabel.Text = "Password *";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(160, 233);
            this.passwordTextBox.MaxLength = 255;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(150, 23);
            this.passwordTextBox.TabIndex = 10;
            // 
            // dependentsPanel
            // 
            this.dependentsPanel.BackColor = System.Drawing.Color.White;
            this.dependentsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dependentsPanel.Controls.Add(this.addDependentPanel);
            this.dependentsPanel.Controls.Add(this.dependentsDataGridView);
            this.dependentsPanel.Controls.Add(this.dependentsTitle);
            this.dependentsPanel.Location = new System.Drawing.Point(30, 330);
            this.dependentsPanel.Name = "dependentsPanel";
            this.dependentsPanel.Size = new System.Drawing.Size(940, 300);
            this.dependentsPanel.TabIndex = 2;
            // 
            // dependentsTitle
            // 
            this.dependentsTitle.AutoSize = true;
            this.dependentsTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dependentsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.dependentsTitle.Location = new System.Drawing.Point(20, 15);
            this.dependentsTitle.Name = "dependentsTitle";
            this.dependentsTitle.Size = new System.Drawing.Size(120, 25);
            this.dependentsTitle.TabIndex = 0;
            this.dependentsTitle.Text = "Dependents";
            // 
            // dependentsDataGridView
            // 
            this.dependentsDataGridView.AllowUserToAddRows = false;
            this.dependentsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dependentsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dependentsDataGridView.ColumnHeadersHeight = 35;
            this.dependentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dependentsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DependentName,
            this.Relationship,
            this.DependentDOB,
            this.RemoveDependent});
            this.dependentsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.dependentsDataGridView.Location = new System.Drawing.Point(25, 50);
            this.dependentsDataGridView.Name = "dependentsDataGridView";
            this.dependentsDataGridView.ReadOnly = true;
            this.dependentsDataGridView.RowHeadersVisible = false;
            this.dependentsDataGridView.RowTemplate.Height = 35;
            this.dependentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dependentsDataGridView.Size = new System.Drawing.Size(550, 150);
            this.dependentsDataGridView.TabIndex = 1;
            // 
            // DependentName
            // 
            this.DependentName.HeaderText = "Name";
            this.DependentName.Name = "DependentName";
            this.DependentName.ReadOnly = true;
            this.DependentName.Width = 180;
            // 
            // Relationship
            // 
            this.Relationship.HeaderText = "Relationship";
            this.Relationship.Name = "Relationship";
            this.Relationship.ReadOnly = true;
            this.Relationship.Width = 130;
            // 
            // DependentDOB
            // 
            this.DependentDOB.HeaderText = "Date of Birth";
            this.DependentDOB.Name = "DependentDOB";
            this.DependentDOB.ReadOnly = true;
            this.DependentDOB.Width = 120;
            // 
            // RemoveDependent
            // 
            this.RemoveDependent.HeaderText = "Remove";
            this.RemoveDependent.Name = "RemoveDependent";
            this.RemoveDependent.ReadOnly = true;
            this.RemoveDependent.Text = "🗑️ Remove";
            this.RemoveDependent.UseColumnTextForButtonValue = true;
            this.RemoveDependent.Width = 100;
            // 
            // addDependentPanel
            // 
            this.addDependentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.addDependentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addDependentPanel.Controls.Add(this.addDependentButton);
            this.addDependentPanel.Controls.Add(this.depDobDatePicker);
            this.addDependentPanel.Controls.Add(this.depDobLabel);
            this.addDependentPanel.Controls.Add(this.relationshipComboBox);
            this.addDependentPanel.Controls.Add(this.relationshipLabel);
            this.addDependentPanel.Controls.Add(this.depNameTextBox);
            this.addDependentPanel.Controls.Add(this.depNameLabel);
            this.addDependentPanel.Location = new System.Drawing.Point(600, 50);
            this.addDependentPanel.Name = "addDependentPanel";
            this.addDependentPanel.Size = new System.Drawing.Size(315, 200);
            this.addDependentPanel.TabIndex = 2;
            // 
            // depNameLabel
            // 
            this.depNameLabel.AutoSize = true;
            this.depNameLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.depNameLabel.Location = new System.Drawing.Point(15, 20);
            this.depNameLabel.Name = "depNameLabel";
            this.depNameLabel.Size = new System.Drawing.Size(122, 19);
            this.depNameLabel.TabIndex = 0;
            this.depNameLabel.Text = "Add Dependent:";
            // 
            // depNameTextBox
            // 
            this.depNameTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depNameTextBox.Location = new System.Drawing.Point(20, 50);
            this.depNameTextBox.MaxLength = 100;
            this.depNameTextBox.Name = "depNameTextBox";
           // this.depNameTextBox.PlaceholderText = "Dependent Name";
            this.depNameTextBox.Size = new System.Drawing.Size(200, 23);
            this.depNameTextBox.TabIndex = 1;
            // 
            // relationshipLabel
            // 
            this.relationshipLabel.AutoSize = true;
            this.relationshipLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationshipLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.relationshipLabel.Location = new System.Drawing.Point(20, 85);
            this.relationshipLabel.Name = "relationshipLabel";
            this.relationshipLabel.Size = new System.Drawing.Size(76, 15);
            this.relationshipLabel.TabIndex = 2;
            this.relationshipLabel.Text = "Relationship:";
            // 
            // relationshipComboBox
            // 
            this.relationshipComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.relationshipComboBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relationshipComboBox.FormattingEnabled = true;
            this.relationshipComboBox.Items.AddRange(new object[] {
            "Spouse",
            "Child",
            "Parent",
            "Sibling",
            "Other"});
            this.relationshipComboBox.Location = new System.Drawing.Point(20, 105);
            this.relationshipComboBox.Name = "relationshipComboBox";
            this.relationshipComboBox.Size = new System.Drawing.Size(150, 23);
            this.relationshipComboBox.TabIndex = 3;
            // 
            // depDobLabel
            // 
            this.depDobLabel.AutoSize = true;
            this.depDobLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDobLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.depDobLabel.Location = new System.Drawing.Point(20, 140);
            this.depDobLabel.Name = "depDobLabel";
            this.depDobLabel.Size = new System.Drawing.Size(76, 15);
            this.depDobLabel.TabIndex = 4;
            this.depDobLabel.Text = "Date of Birth:";
            // 
            // depDobDatePicker
            // 
            this.depDobDatePicker.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depDobDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.depDobDatePicker.Location = new System.Drawing.Point(20, 160);
            this.depDobDatePicker.Name = "depDobDatePicker";
            this.depDobDatePicker.Size = new System.Drawing.Size(150, 23);
            this.depDobDatePicker.TabIndex = 5;
            // 
            // addDependentButton
            // 
            this.addDependentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.addDependentButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDependentButton.FlatAppearance.BorderSize = 0;
            this.addDependentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addDependentButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDependentButton.ForeColor = System.Drawing.Color.White;
            this.addDependentButton.Location = new System.Drawing.Point(190, 160);
            this.addDependentButton.Name = "addDependentButton";
            this.addDependentButton.Size = new System.Drawing.Size(100, 23);
            this.addDependentButton.TabIndex = 6;
            this.addDependentButton.Text = "➕ Add";
            this.addDependentButton.UseVisualStyleBackColor = false;
            // 
            // buttonPanel
            // 
            this.buttonPanel.Controls.Add(this.cancelButton);
            this.buttonPanel.Controls.Add(this.saveButton);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonPanel.Location = new System.Drawing.Point(30, 650);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(940, 50);
            this.buttonPanel.TabIndex = 3;
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
            this.saveButton.Location = new System.Drawing.Point(680, 5);
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
            this.cancelButton.Location = new System.Drawing.Point(820, 5);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(120, 40);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "✖️ Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            // 
            // AddRiderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddRiderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Rider";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.personalInfoPanel.ResumeLayout(false);
            this.personalInfoPanel.PerformLayout();
            this.contactInfoPanel.ResumeLayout(false);
            this.contactInfoPanel.PerformLayout();
            this.dependentsPanel.ResumeLayout(false);
            this.dependentsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dependentsDataGridView)).EndInit();
            this.addDependentPanel.ResumeLayout(false);
            this.addDependentPanel.PerformLayout();
            this.buttonPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel personalInfoPanel;
        private System.Windows.Forms.Label personalInfoTitle;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.TextBox middleNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label nicLabel;
        private System.Windows.Forms.TextBox nicTextBox;
        private System.Windows.Forms.Label dobLabel;
        private System.Windows.Forms.DateTimePicker dobDatePicker;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Panel contactInfoPanel;
        private System.Windows.Forms.Label contactInfoTitle;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label licenseLabel;
        private System.Windows.Forms.TextBox licenseTextBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Panel dependentsPanel;
        private System.Windows.Forms.Label dependentsTitle;
        private System.Windows.Forms.DataGridView dependentsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn DependentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Relationship;
        private System.Windows.Forms.DataGridViewTextBoxColumn DependentDOB;
        private System.Windows.Forms.DataGridViewButtonColumn RemoveDependent;
        private System.Windows.Forms.Panel addDependentPanel;
        private System.Windows.Forms.Label depNameLabel;
        private System.Windows.Forms.TextBox depNameTextBox;
        private System.Windows.Forms.Label relationshipLabel;
        private System.Windows.Forms.ComboBox relationshipComboBox;
        private System.Windows.Forms.Label depDobLabel;
        private System.Windows.Forms.DateTimePicker depDobDatePicker;
        private System.Windows.Forms.Button addDependentButton;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}
