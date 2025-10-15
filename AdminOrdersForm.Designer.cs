namespace FoodHub
{
    partial class AdminOrdersForm
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
            this.ordersDataGridView = new System.Windows.Forms.DataGridView();
            this.OrderID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PaymentMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AssignRiderColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.UpdateStatusColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.headerPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).BeginInit();
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
            this.titleLabel.Size = new System.Drawing.Size(218, 41);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Orders Manager";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.ordersDataGridView);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(0, 70);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(1700, 630);
            this.contentPanel.TabIndex = 1;
            // 
            // ordersDataGridView
            // 
            this.ordersDataGridView.AllowUserToAddRows = false;
            this.ordersDataGridView.AllowUserToDeleteRows = false;
            this.ordersDataGridView.AllowUserToResizeColumns = false;
            this.ordersDataGridView.AllowUserToResizeRows = false;
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.ordersDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ordersDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ordersDataGridView.ColumnHeadersHeight = 40;
            this.ordersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ordersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderID,
            this.CustomerName,
            this.OrderDate,
            this.OrderTime,
            this.OrderAmount,
            this.OrderStatus,
            this.PaymentMethod,
            this.AssignRiderColumn,
            this.UpdateStatusColumn});
            this.ordersDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ordersDataGridView.Location = new System.Drawing.Point(30, 30);
            this.ordersDataGridView.Name = "ordersDataGridView";
            this.ordersDataGridView.ReadOnly = true;
            this.ordersDataGridView.RowHeadersVisible = false;
            this.ordersDataGridView.RowHeadersWidth = 51;
            this.ordersDataGridView.RowTemplate.Height = 45;
            this.ordersDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.ordersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.ordersDataGridView.AllowUserToResizeColumns = false;
            this.ordersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ordersDataGridView.Size = new System.Drawing.Size(1640, 570);
            this.ordersDataGridView.TabIndex = 0;
            this.ordersDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ordersDataGridView_CellContentClick);
            // 
            // OrderID
            // 
            this.OrderID.HeaderText = "Order ID";
            this.OrderID.MinimumWidth = 6;
            this.OrderID.Name = "OrderID";
            this.OrderID.ReadOnly = true;
            this.OrderID.Width = 120;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.MinimumWidth = 6;
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 300;
            // 
            // OrderDate
            // 
            this.OrderDate.HeaderText = "Order Date";
            this.OrderDate.MinimumWidth = 6;
            this.OrderDate.Name = "OrderDate";
            this.OrderDate.ReadOnly = true;
            this.OrderDate.Width = 200;
            // 
            // OrderTime
            // 
            this.OrderTime.HeaderText = "Order Time";
            this.OrderTime.MinimumWidth = 6;
            this.OrderTime.Name = "OrderTime";
            this.OrderTime.ReadOnly = true;
            this.OrderTime.Width = 200;
            // 
            // OrderAmount
            // 
            this.OrderAmount.HeaderText = "Total Amount";
            this.OrderAmount.MinimumWidth = 6;
            this.OrderAmount.Name = "OrderAmount";
            this.OrderAmount.ReadOnly = true;
            this.OrderAmount.Width = 150;
            // 
            // OrderStatus
            // 
            this.OrderStatus.HeaderText = "Status";
            this.OrderStatus.MinimumWidth = 6;
            this.OrderStatus.Name = "OrderStatus";
            this.OrderStatus.ReadOnly = true;
            this.OrderStatus.Width = 140;
            // 
            // PaymentMethod
            // 
            this.PaymentMethod.HeaderText = "Payment Method";
            this.PaymentMethod.MinimumWidth = 6;
            this.PaymentMethod.Name = "PaymentMethod";
            this.PaymentMethod.ReadOnly = true;
            this.PaymentMethod.Width = 250;
            // 
            // AssignRiderColumn
            // 
            this.AssignRiderColumn.HeaderText = "Assign Rider";
            this.AssignRiderColumn.MinimumWidth = 6;
            this.AssignRiderColumn.Name = "AssignRiderColumn";
            this.AssignRiderColumn.ReadOnly = true;
            this.AssignRiderColumn.Text = "🏍️ Assign";
            this.AssignRiderColumn.UseColumnTextForButtonValue = true;
            this.AssignRiderColumn.Width = 150;
            // 
            // UpdateStatusColumn
            // 
            this.UpdateStatusColumn.HeaderText = "Update Status";
            this.UpdateStatusColumn.MinimumWidth = 6;
            this.UpdateStatusColumn.Name = "UpdateStatusColumn";
            this.UpdateStatusColumn.ReadOnly = true;
            this.UpdateStatusColumn.Text = "🔄 Update";
            this.UpdateStatusColumn.UseColumnTextForButtonValue = true;
            this.UpdateStatusColumn.Width = 150;
            // 
            // AdminOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminOrdersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orders Manager";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.DataGridView ordersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn PaymentMethod;
        private System.Windows.Forms.DataGridViewButtonColumn AssignRiderColumn;
        private System.Windows.Forms.DataGridViewButtonColumn UpdateStatusColumn;
    }
}
