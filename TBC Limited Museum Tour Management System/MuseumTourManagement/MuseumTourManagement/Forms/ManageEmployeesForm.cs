using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using MuseumTourManagement.Database;

namespace MuseumTourManagement.Forms
{
    public class ManageEmployeesForm : Form
    {
        private DataGridView dgvEmployees;
        private Button btnBack;
        private Button btnHire;
        private Button btnFire;
        private DashboardForm dashboard; // for live update on dashboard 

        public ManageEmployeesForm(DashboardForm parent)
        {
            this.dashboard = parent;
            InitializeLayout();
            LoadEmployees();
        }

        // Creates the window pop up for employee management
        private void InitializeLayout()
        {
            this.Text = "Employee Management";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            var mainPanel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 3,
                ColumnCount = 1,
                BackColor = Color.White
            };

            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // Title
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // Buttons
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100)); // Data Grid

            var lblTitle = new Label
            {
                Text = "Employee Management",
                Font = new Font("Arial", 16F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                BackColor = Color.FromArgb(30, 60, 90),
                ForeColor = Color.White
            };
            mainPanel.Controls.Add(lblTitle, 0, 0);

            // Creates Buttons
            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                Padding = new Padding(10),
                BackColor = Color.White
            };

            btnBack = new Button { Text = "Back", Width = 100, Height = 30 };
            btnBack.Click += (s, e) => this.Close();

            btnHire = new Button { Text = "Hire Employee", Width = 150, Height = 30 };
            btnHire.Click += BtnHire_Click;

            btnFire = new Button { Text = "Fire Selected", Width = 150, Height = 30 };
            btnFire.Click += BtnFire_Click;

            buttonPanel.Controls.Add(btnBack);
            buttonPanel.Controls.Add(btnHire);
            buttonPanel.Controls.Add(btnFire);

            mainPanel.Controls.Add(buttonPanel, 0, 1);

            // Employee Table
            dgvEmployees = new DataGridView
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToAddRows = false,
                BackgroundColor = Color.White,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false
            };
            mainPanel.Controls.Add(dgvEmployees, 0, 2);

            this.Controls.Add(mainPanel);
        }

        // Loads employees from the sql
        private void LoadEmployees()
        {
            try
            {
                DataTable table = Database.Database.GetAllEmployeesDataTable();
                dgvEmployees.DataSource = table;

                if (dgvEmployees.Columns.Contains("EmployeeID"))
                {
                    dgvEmployees.Columns["EmployeeID"].Visible = false;
                }

                dashboard?.RefreshEmployeeCount(); // live dashboard update
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load employees:\n" + ex.Message);
            }
        }

        // Button and input to add employees, adding them to sql too
        private void BtnHire_Click(object sender, EventArgs e)
        {
            string name = Prompt.Show("Enter new employee's name:", "Hire Employee");
            if (!string.IsNullOrWhiteSpace(name))
            {
                try
                {
                    Database.Database.AddEmployee(name, "Employee");
                    LoadEmployees();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding employee: " + ex.Message);
                }
            }
        }

        // Button to fire employees with popup and removing them from the sql
        private void BtnFire_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.SelectedRows.Count > 0)
            {
                var selectedRow = dgvEmployees.SelectedRows[0];
                var name = selectedRow.Cells["Name"].Value.ToString();
                var id = Convert.ToInt32(selectedRow.Cells["EmployeeID"].Value);

                var confirm = MessageBox.Show($"Are you sure you want to fire {name}?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        Database.Database.DeleteEmployeeById(id);
                        LoadEmployees();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting employee: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select an employee to fire.");
            }
        }

        // Prompt Helper
        public static class Prompt
        {
            public static string Show(string text, string caption)
            {
                Form prompt = new Form
                {
                    Width = 400,
                    Height = 150,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen
                };

                Label lblText = new Label { Left = 20, Top = 20, Text = text, AutoSize = true };
                TextBox inputBox = new TextBox { Left = 20, Top = 45, Width = 340 };
                Button confirmation = new Button { Text = "OK", Left = 280, Width = 80, Top = 75 };
                confirmation.Click += (sender, e) => prompt.Close();

                prompt.Controls.Add(lblText);
                prompt.Controls.Add(inputBox);
                prompt.Controls.Add(confirmation);
                prompt.AcceptButton = confirmation;

                prompt.ShowDialog();
                return inputBox.Text;
            }
        }
    }
}
