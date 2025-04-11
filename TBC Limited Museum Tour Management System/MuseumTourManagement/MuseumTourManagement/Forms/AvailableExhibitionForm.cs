using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MuseumTourManagement.Database;

namespace MuseumTourManagement.Forms
{
    public partial class AvailableExhibitionsForm : Form
    {
        public AvailableExhibitionsForm()
        {
            InitializeComponent();
        }

        private void AvailableExhibitionsForm_Load(object sender, EventArgs e)
        {
            dgvAvailableExhibitions.DataSource = MuseumTourManagement.Database.Database.GetAvailableExhibitions();
        }
    }
}
