namespace MuseumTourManagement.Forms
{
    partial class ExpeditionForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvExpeditions;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.Label lblExpeditions;
        private System.Windows.Forms.Label lblCustomers;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Button btnBack; // ✅ Declare the Back Button


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
            this.dgvExpeditions = new System.Windows.Forms.DataGridView();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.lblExpeditions = new System.Windows.Forms.Label();
            this.lblCustomers = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();

            // 🔹 Change the label to "All Expeditions"
            this.lblExpeditions.Text = "All Expeditions";
            this.lblExpeditions.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblExpeditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExpeditions.Height = 40;
            this.lblExpeditions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 🔹 Expedition Grid
            this.dgvExpeditions.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvExpeditions.Height = 200;
            this.dgvExpeditions.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpeditions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpeditions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpeditions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpeditions_CellClick);

            // 🔹 Customers Label
            this.lblCustomers.Text = "Customers in Expedition";
            this.lblCustomers.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomers.Height = 40;
            this.lblCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 🔹 Customer Grid
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Columns.Add("BookingStatus", "Booking Status");


            // 🔹 Content Panel
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Padding = new System.Windows.Forms.Padding(20);
            this.contentPanel.Controls.Add(this.dgvCustomers);
            this.contentPanel.Controls.Add(this.lblCustomers);
            this.contentPanel.Controls.Add(this.dgvExpeditions);
            this.contentPanel.Controls.Add(this.lblExpeditions);

            // 🔹 Back Button
            this.btnBack = new System.Windows.Forms.Button();
            this.btnBack.Text = "Back";
            this.btnBack.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnBack.Size = new System.Drawing.Size(100, 30);
            this.btnBack.Location = new System.Drawing.Point(20, 20); // Adjust position
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.Controls.Add(this.btnBack);


            // 🔹 Form Layout
            this.Controls.Add(this.contentPanel);
            this.Text = "Expedition Management";
            this.ClientSize = new System.Drawing.Size(700, 500);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ExpeditionForm_Load);
        }
    }
}
