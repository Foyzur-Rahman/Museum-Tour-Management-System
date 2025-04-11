using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MuseumTourManagement.Database;

namespace MuseumTourManagement.Forms
{
    public partial class EmployeesForm : Form
    {
        public EmployeesForm()
        {
            InitializeComponent();
        }

        private void EmployeesForm_Load(object sender, EventArgs e)
        {
            dgvEmployees.DataSource = MuseumTourManagement.Database.Database.GetAllEmployeesDataTable();
        }
    }
}
