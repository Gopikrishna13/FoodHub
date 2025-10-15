namespace FoodHub
{
    partial class RiderDashboardForm
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
            this.LogOutLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.navigationPanel = new System.Windows.Forms.Panel();
            this.MyOrdersLabel = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.statsPanel = new System.Windows.Forms.Panel();
            this.distanceCard = new System.Windows.Forms.Panel();
            this.TotalDistance = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.deliveredCard = new System.Windows.Forms.Panel();
            this.Delivered = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pendingCard = new System.Windows.Forms.Panel();
            this.Pending = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.totalOrdersCard = new System.Windows.Forms.Panel();
            this.TotalOrders = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.navigationPanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.statsPanel.SuspendLayout();
            this.distanceCard.SuspendLayout();
            this.deliveredCard.SuspendLayout();
            this.pendingCard.SuspendLayout();
            this.totalOrdersCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.headerPanel.Controls.Add(this.LogOutLabel);
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Controls.Add(this.label1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(1400, 80);
            this.headerPanel.TabIndex = 0;
            // 
            // LogOutLabel
            // 
            this.LogOutLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LogOutLabel.AutoSize = true;
            this.LogOutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogOutLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutLabel.ForeColor = System.Drawing.Color.White;
            this.LogOutLabel.Location = new System.Drawing.Point(1300, 25);
            this.LogOutLabel.Name = "LogOutLabel";
            this.LogOutLabel.Padding = new System.Windows.Forms.Padding(10, 8, 10, 8);
            this.LogOutLabel.Size = new System.Drawing.Size(88, 44);
            this.LogOutLabel.TabIndex = 2;
            this.LogOutLabel.Text = "Logout";
            this.LogOutLabel.Click += new System.EventHandler(this.LogOutLabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FoodHub.Properties.Resources.Admin;
            this.pictureBox1.Location = new System.Drawing.Point(30, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "FoodHub Rider";
            // 
            // navigationPanel
            // 
            this.navigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.navigationPanel.Controls.Add(this.MyOrdersLabel);
            this.navigationPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.navigationPanel.Location = new System.Drawing.Point(0, 80);
            this.navigationPanel.Name = "navigationPanel";
            this.navigationPanel.Size = new System.Drawing.Size(250, 620);
            this.navigationPanel.TabIndex = 1;
            // 
            // MyOrdersLabel
            // 
            this.MyOrdersLabel.AutoSize = true;
            this.MyOrdersLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyOrdersLabel.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyOrdersLabel.ForeColor = System.Drawing.Color.White;
            this.MyOrdersLabel.Location = new System.Drawing.Point(25, 40);
            this.MyOrdersLabel.Name = "MyOrdersLabel";
            this.MyOrdersLabel.Padding = new System.Windows.Forms.Padding(15, 12, 15, 12);
            this.MyOrdersLabel.Size = new System.Drawing.Size(165, 54);
            this.MyOrdersLabel.TabIndex = 25;
            this.MyOrdersLabel.Text = "📋 My Orders";
            this.MyOrdersLabel.Click += new System.EventHandler(this.MyOrdersLabel_Click);
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.contentPanel.Controls.Add(this.statsPanel);
            this.contentPanel.Controls.Add(this.welcomeLabel);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(250, 80);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(30);
            this.contentPanel.Size = new System.Drawing.Size(1150, 620);
            this.contentPanel.TabIndex = 2;
            // 
            // statsPanel
            // 
            this.statsPanel.Controls.Add(this.distanceCard);
            this.statsPanel.Controls.Add(this.deliveredCard);
            this.statsPanel.Controls.Add(this.pendingCard);
            this.statsPanel.Controls.Add(this.totalOrdersCard);
            this.statsPanel.Location = new System.Drawing.Point(50, 120);
            this.statsPanel.Name = "statsPanel";
            this.statsPanel.Size = new System.Drawing.Size(1050, 400);
            this.statsPanel.TabIndex = 1;
            // 
            // distanceCard
            // 
            this.distanceCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(89)))), ((int)(((byte)(182)))));
            this.distanceCard.Controls.Add(this.TotalDistance);
            this.distanceCard.Controls.Add(this.label9);
            this.distanceCard.Location = new System.Drawing.Point(525, 200);
            this.distanceCard.Name = "distanceCard";
            this.distanceCard.Size = new System.Drawing.Size(300, 150);
            this.distanceCard.TabIndex = 3;
            // 
            // TotalDistance
            // 
            this.TotalDistance.AutoSize = true;
            this.TotalDistance.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalDistance.ForeColor = System.Drawing.Color.White;
            this.TotalDistance.Location = new System.Drawing.Point(100, 70);
            this.TotalDistance.Name = "TotalDistance";
            this.TotalDistance.Size = new System.Drawing.Size(103, 62);
            this.TotalDistance.TabIndex = 1;
            this.TotalDistance.Text = "0 km";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 32);
            this.label9.TabIndex = 0;
            this.label9.Text = "Total Distance";
            // 
            // deliveredCard
            // 
            this.deliveredCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.deliveredCard.Controls.Add(this.Delivered);
            this.deliveredCard.Controls.Add(this.label8);
            this.deliveredCard.Location = new System.Drawing.Point(525, 20);
            this.deliveredCard.Name = "deliveredCard";
            this.deliveredCard.Size = new System.Drawing.Size(300, 150);
            this.deliveredCard.TabIndex = 2;
            // 
            // Delivered
            // 
            this.Delivered.AutoSize = true;
            this.Delivered.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delivered.ForeColor = System.Drawing.Color.White;
            this.Delivered.Location = new System.Drawing.Point(130, 70);
            this.Delivered.Name = "Delivered";
            this.Delivered.Size = new System.Drawing.Size(52, 62);
            this.Delivered.TabIndex = 1;
            this.Delivered.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(180, 32);
            this.label8.TabIndex = 0;
            this.label8.Text = "Delivered Orders";
            // 
            // pendingCard
            // 
            this.pendingCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.pendingCard.Controls.Add(this.Pending);
            this.pendingCard.Controls.Add(this.label6);
            this.pendingCard.Location = new System.Drawing.Point(50, 200);
            this.pendingCard.Name = "pendingCard";
            this.pendingCard.Size = new System.Drawing.Size(300, 150);
            this.pendingCard.TabIndex = 1;
            // 
            // Pending
            // 
            this.Pending.AutoSize = true;
            this.Pending.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pending.ForeColor = System.Drawing.Color.White;
            this.Pending.Location = new System.Drawing.Point(130, 70);
            this.Pending.Name = "Pending";
            this.Pending.Size = new System.Drawing.Size(52, 62);
            this.Pending.TabIndex = 1;
            this.Pending.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 32);
            this.label6.TabIndex = 0;
            this.label6.Text = "Pending Orders";
            // 
            // totalOrdersCard
            // 
            this.totalOrdersCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.totalOrdersCard.Controls.Add(this.TotalOrders);
            this.totalOrdersCard.Controls.Add(this.label4);
            this.totalOrdersCard.Location = new System.Drawing.Point(50, 20);
            this.totalOrdersCard.Name = "totalOrdersCard";
            this.totalOrdersCard.Size = new System.Drawing.Size(300, 150);
            this.totalOrdersCard.TabIndex = 0;
            // 
            // TotalOrders
            // 
            this.TotalOrders.AutoSize = true;
            this.TotalOrders.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOrders.ForeColor = System.Drawing.Color.White;
            this.TotalOrders.Location = new System.Drawing.Point(130, 70);
            this.TotalOrders.Name = "TotalOrders";
            this.TotalOrders.Size = new System.Drawing.Size(52, 62);
            this.TotalOrders.TabIndex = 1;
            this.TotalOrders.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(20, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Total Orders";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.welcomeLabel.Location = new System.Drawing.Point(50, 50);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(334, 54);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome, Rider!";
            // 
            // RiderDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 700);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.navigationPanel);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RiderDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FoodHub - Rider Dashboard";
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.navigationPanel.ResumeLayout(false);
            this.navigationPanel.PerformLayout();
            this.contentPanel.ResumeLayout(false);
            this.contentPanel.PerformLayout();
            this.statsPanel.ResumeLayout(false);
            this.distanceCard.ResumeLayout(false);
            this.distanceCard.PerformLayout();
            this.deliveredCard.ResumeLayout(false);
            this.deliveredCard.PerformLayout();
            this.pendingCard.ResumeLayout(false);
            this.pendingCard.PerformLayout();
            this.totalOrdersCard.ResumeLayout(false);
            this.totalOrdersCard.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.Label LogOutLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel navigationPanel;
        private System.Windows.Forms.Label MyOrdersLabel;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Panel statsPanel;
        private System.Windows.Forms.Panel distanceCard;
        private System.Windows.Forms.Label TotalDistance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel deliveredCard;
        private System.Windows.Forms.Label Delivered;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pendingCard;
        private System.Windows.Forms.Label Pending;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel totalOrdersCard;
        private System.Windows.Forms.Label TotalOrders;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label welcomeLabel;
    }
}
