namespace MuseumTourManagement.Forms
{
    partial class DashboardForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnExpeditions;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.Button btnManageManagers;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblRevenue;
        private System.Windows.Forms.Label lblUpcomingBookings;
        private System.Windows.Forms.Button btnEarnings;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnAvailableExhibitions;

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
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnExpeditions = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnManageManagers = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.lblRevenue = new System.Windows.Forms.Label();
            this.lblUpcomingBookings = new System.Windows.Forms.Label();
            this.btnEarnings = new System.Windows.Forms.Button();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnAvailableExhibitions = new System.Windows.Forms.Button();
            this.sidePanel.SuspendLayout();
            this.contentPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.Black;
            this.sidePanel.Controls.Add(this.btnExpeditions);
            this.sidePanel.Controls.Add(this.btnCustomers);
            this.sidePanel.Controls.Add(this.btnBookings);
            this.sidePanel.Controls.Add(this.btnManageManagers);
            this.sidePanel.Controls.Add(this.btnLogout);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 50);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(200, 603);
            this.sidePanel.TabIndex = 1;
            // 
            // btnExpeditions
            // 
            this.btnExpeditions.Location = new System.Drawing.Point(0, 0);
            this.btnExpeditions.Name = "btnExpeditions";
            this.btnExpeditions.Size = new System.Drawing.Size(75, 23);
            this.btnExpeditions.TabIndex = 0;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Location = new System.Drawing.Point(0, 0);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCustomers.TabIndex = 1;
            // 
            // btnBookings
            // 
            this.btnBookings.Location = new System.Drawing.Point(0, 0);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(75, 23);
            this.btnBookings.TabIndex = 2;
            // 
            // btnManageManagers
            // 
            this.btnManageManagers.Location = new System.Drawing.Point(0, 0);
            this.btnManageManagers.Name = "btnManageManagers";
            this.btnManageManagers.Size = new System.Drawing.Size(75, 23);
            this.btnManageManagers.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(0, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 4;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1292, 50);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Museum Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Controls.Add(this.lblRevenue);
            this.contentPanel.Controls.Add(this.lblUpcomingBookings);
            this.contentPanel.Controls.Add(this.btnEarnings);
            this.contentPanel.Controls.Add(this.btnEmployees);
            this.contentPanel.Controls.Add(this.btnAvailableExhibitions);
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(200, 50);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.contentPanel.Size = new System.Drawing.Size(1092, 603);
            this.contentPanel.TabIndex = 0;
            // 
            // lblRevenue
            // 
            this.lblRevenue.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblRevenue.Location = new System.Drawing.Point(250, 50);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(200, 60);
            this.lblRevenue.TabIndex = 0;
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpcomingBookings
            // 
            this.lblUpcomingBookings.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblUpcomingBookings.Location = new System.Drawing.Point(500, 50);
            this.lblUpcomingBookings.Name = "lblUpcomingBookings";
            this.lblUpcomingBookings.Size = new System.Drawing.Size(200, 60);
            this.lblUpcomingBookings.TabIndex = 1;
            this.lblUpcomingBookings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEarnings
            // 
            this.btnEarnings.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnEarnings.Location = new System.Drawing.Point(250, 250);
            this.btnEarnings.Name = "btnEarnings";
            this.btnEarnings.Size = new System.Drawing.Size(220, 110);
            this.btnEarnings.TabIndex = 2;
            this.btnEarnings.Text = "Earnings";
            this.btnEarnings.Click += new System.EventHandler(this.BtnEarnings_Click);
            // 
            // btnEmployees
            // 
            this.btnEmployees.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnEmployees.Location = new System.Drawing.Point(500, 250);
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Size = new System.Drawing.Size(220, 110);
            this.btnEmployees.TabIndex = 3;
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.Click += new System.EventHandler(this.BtnEmployees_Click);
            // 
            // btnAvailableExhibitions
            // 
            this.btnAvailableExhibitions.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.btnAvailableExhibitions.Location = new System.Drawing.Point(750, 250);
            this.btnAvailableExhibitions.Name = "btnAvailableExhibitions";
            this.btnAvailableExhibitions.Size = new System.Drawing.Size(220, 110);
            this.btnAvailableExhibitions.TabIndex = 4;
            this.btnAvailableExhibitions.Text = "Available Exhibitions";
            this.btnAvailableExhibitions.Click += new System.EventHandler(this.BtnAvailableExhibitions_Click);
            // 
            // DashboardForm
            // 
            this.ClientSize = new System.Drawing.Size(1292, 653);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.lblTitle);
            this.Name = "DashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Museum Management Dashboard";
            this.sidePanel.ResumeLayout(false);
            this.contentPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
    }
}
