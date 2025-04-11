using System;
using System.Drawing;
using System.Windows.Forms;
using MuseumTourManagement.Database;
using MuseumTourManagement.Models;

namespace MuseumTourManagement.Forms
{
    public class EarningsForm : Form
    {
        private DashboardForm dashboard;
        private Label lblRevenue;
        private TextBox txtAmount;
        private Button btnAdd;
        private Button btnDelete;
        private ListBox lstEarnings;

        public EarningsForm(DashboardForm parent)
        {
            this.dashboard = parent;
            InitializeLayout();
            LoadEarningsData();
        }

        private void InitializeLayout()
        {
            this.Text = "Earnings Overview";
            this.Size = new Size(600, 450);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Revenue label
            lblRevenue = new Label
            {
                Text = "Today's Revenue: $0.00",
                Font = new Font("Arial", 14F, FontStyle.Bold),
                Dock = DockStyle.Top,
                Height = 50,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(lblRevenue);

            // Layout panel
            var layout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 5,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // Label
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 30)); // Input
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // Add
            layout.RowStyles.Add(new RowStyle(SizeType.Absolute, 40)); // Delete
            layout.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // ListBox

            var lblInput = new Label
            {
                Text = "Enter Today's Earning:",
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 10),
                TextAlign = ContentAlignment.MiddleLeft
            };

            txtAmount = new TextBox { Dock = DockStyle.Fill };

            btnAdd = new Button 
            {
                Text = "Add Earning",
                Dock = DockStyle.Fill
            };
            btnAdd.Click += BtnAdd_Click;

            btnDelete = new Button
            {
                Text = "Delete Selected Earning",
                Dock = DockStyle.Fill
            };
            btnDelete.Click += BtnDelete_Click;

            lstEarnings = new ListBox
            {
                Dock = DockStyle.Fill,
                Font = new Font("Arial", 10)
            };

            layout.Controls.Add(lblInput, 0, 0);
            layout.Controls.Add(txtAmount, 0, 1);
            layout.Controls.Add(btnAdd, 0, 2);
            layout.Controls.Add(btnDelete, 0, 3);
            layout.Controls.Add(lstEarnings, 0, 4);

            this.Controls.Add(layout);
        }

        // This section loads earnings from the sql and also updates it to the dashboard live
        private void LoadEarningsData()
        {
            try
            {
                decimal revenue = Database.Database.GetTodaysEarningsRevenue(); // grabs information from the sql to display 
                lblRevenue.Text = $"Today's Revenue: £{revenue:F2}";

                lstEarnings.Items.Clear();

                var allEarnings = Database.Database.GetAllEarnings();
                foreach (var earning in allEarnings)
                {
                    if (earning.Date.Date == DateTime.Today)
                    {
                        lstEarnings.Items.Add(earning); 
                    }
                }

                dashboard?.RefreshRevenueLabel(); // live updates dashboard
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading earnings data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // error handling 
            }
        }

        // Input for user to add earnings
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtAmount.Text, out decimal amount))
            {
                try
                {
                    Database.Database.AddEarning(amount);
                    txtAmount.Clear();
                    LoadEarningsData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving earning: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        // Pop up warning before deleting an earning 
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lstEarnings.SelectedItem is Earning selected)
            {
                var confirm = MessageBox.Show(
                    $"Delete this earning?\n{selected}",
                    "Confirm",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Database.Database.DeleteEarningById(selected.Id);
                        LoadEarningsData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting earning: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an earning to delete.");
            }
        }
    }
}
