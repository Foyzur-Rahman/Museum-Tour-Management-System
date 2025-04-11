using System;
using System.Data;
using System.Windows.Forms;

namespace MuseumTourManagement.Forms
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
            btnBack.BringToFront();
        }

        private void LoadCustomerData()
        {
            DataTable customers = MuseumTourManagement.Database.Database.GetAllCustomersDataTable();
            dgvCustomers.DataSource = customers;

            // Hide unwanted columns
            foreach (DataGridViewColumn col in dgvCustomers.Columns)
            {
                if (col.Name != "Name" && col.Name != "Email")
                    col.Visible = false;
            }

            // Rename headers
            dgvCustomers.Columns["Name"].HeaderText = "Customer Name";
            dgvCustomers.Columns["Email"].HeaderText = "Email Address";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
