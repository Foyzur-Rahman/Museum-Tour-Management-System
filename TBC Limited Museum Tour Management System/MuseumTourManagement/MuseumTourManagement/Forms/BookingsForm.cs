using System;
using System.Data;
using System.Windows.Forms;
using MuseumTourManagement.Database;

namespace MuseumTourManagement.Forms
{
    // Displays all bookings and filtering by date 
    public partial class BookingsForm : Form
    {
        public BookingsForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(BookingsForm_Load);
        }

        private void BookingsForm_Load(object sender, EventArgs e)
        {
            LoadBookings();
        }

        // Loads booking and creates columns, grabbing information from the sql
        private void LoadBookings()
        {
            try
            {
                DataTable bookingsData = MuseumTourManagement.Database.Database.GetAllBookings();
                dgvBookings.DataSource = bookingsData;

                dgvBookings.Columns["BookingID"].Visible = false;
                dgvBookings.Columns["CustomerName"].HeaderText = "Customer";
                dgvBookings.Columns["ExpeditionName"].HeaderText = "Expedition";
                dgvBookings.Columns["BookingDate"].HeaderText = "Booking Date";
                dgvBookings.Columns["TimeSlot"].HeaderText = "Time Slot";
                dgvBookings.Columns["Status"].HeaderText = "Status";

                // Ensure Time slot is properly displayed
                foreach (DataGridViewRow row in dgvBookings.Rows)
                {
                    if (row.Cells["ExpeditionID"].Value != null)
                    {
                        int expeditionId = Convert.ToInt32(row.Cells["ExpeditionID"].Value);
                        string expeditionTimeSlot = MuseumTourManagement.Database.Database.GetExpeditionTimeSlot(expeditionId);
                        row.Cells["TimeSlot"].Value = expeditionTimeSlot; // Assigns  Time slot correctly
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading bookings: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // Error handling if data can not be recieved
            }
        }

        // Button for filtering dates 
        private void btnFilter_Click(object sender, EventArgs e)
        {
            DateTime startDate = dtpStartDate.Value;
            DateTime endDate = dtpEndDate.Value;

            (dgvBookings.DataSource as DataTable).DefaultView.RowFilter =
                $"BookingDate >= #{startDate:yyyy-MM-dd}# AND BookingDate <= #{endDate:yyyy-MM-dd}#";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Close button to go back to dashboard
        }

    }
}
