using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using MuseumTourManagement.Models;

namespace MuseumTourManagement.Forms
{
    public partial class ExpeditionForm : Form
    {
        public ExpeditionForm()
        {
            InitializeComponent();
            this.Load += new EventHandler(ExpeditionForm_Load); // Ensure event is properly linked
        }

        private void ExpeditionForm_Load(object sender, EventArgs e)
        {
            LoadExpeditions();
        }

        // Loads expeditions from the sql and displays them on a grid
        private void LoadExpeditions()
        {
            try
            {
                List<Expedition> expeditions = MuseumTourManagement.Database.Database.GetAllExpeditions();

                if (expeditions != null && expeditions.Count > 0)
                {
                    foreach (var expedition in expeditions)
                    {
                        if (!string.IsNullOrEmpty(expedition.TimeSlot))
                        {
                            try
                            {
                                TimeSpan timeValue = TimeSpan.Parse(expedition.TimeSlot);
                                expedition.TimeSlot = DateTime.Today.Add(timeValue).ToString("hh:mm tt");
                            }
                            catch
                            {
                                expedition.TimeSlot = "N/A";
                            }
                        }
                        else
                        {
                            expedition.TimeSlot = "N/A";
                        }
                    }

                    dgvExpeditions.DataSource = expeditions;

                    dgvExpeditions.Columns["ExpeditionID"].Visible = false;
                    dgvExpeditions.Columns["ExpeditionName"].HeaderText = "Event Name";
                    dgvExpeditions.Columns["TimeSlot"].HeaderText = "Scheduled Time";
                    dgvExpeditions.Columns["TimeSlot"].DefaultCellStyle.Format = "hh:mm tt";
                }
                else
                {
                    MessageBox.Show("No expeditions found in the database.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); // Error handling if information cant be grabbed from sql
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading expeditions: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // displays customers in an expedition when clicking a row
        private void dgvExpeditions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                try
                {
                    int expeditionID = Convert.ToInt32(dgvExpeditions.Rows[e.RowIndex].Cells["ExpeditionID"].Value);
                    LoadCustomersForExpedition(expeditionID);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error selecting expedition: " + ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // loads the list of customers signed up for a specific expedition
        private void LoadCustomersForExpedition(int expeditionID)
        {
            try
            {
                List<CustomerExpedition> customers = MuseumTourManagement.Database.Database.GetCustomerExpeditions(expeditionID);

                if (customers != null && customers.Count > 0)
                {
                    foreach (var customer in customers)
                    {
                        customer.BookingStatus = "Confirmed";  // Sets status to Confirmed
                    }

                    dgvCustomers.Columns.Clear();
                    dgvCustomers.DataSource = customers;
                    // Grid columns
                    dgvCustomers.Columns["CustomerID"].Visible = false;
                    dgvCustomers.Columns["Name"].HeaderText = "Attendee Name";
                    dgvCustomers.Columns["Email"].HeaderText = "Contact Email";
                    dgvCustomers.Columns["ExpeditionName"].HeaderText = "Event Name";
                    dgvCustomers.Columns["BookingStatus"].HeaderText = "Booking Status";
                }
                else
                {
                    dgvCustomers.DataSource = null;
                    MessageBox.Show("No attendees found for this expedition.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading attendees: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close(); // Back button to go back to dashboard
        }

    }
}
