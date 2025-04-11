using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using MuseumTourManagement.Database;

namespace MuseumTourManagement.Forms
{
    public class LoginForm : Form
    {
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;

        // Login box with limited size in the middle of the screen
        public LoginForm()
        {
            this.Text = "Login";
            this.Size = new Size(400, 380);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;

            BuildLayout();
        }

        private void BuildLayout()
        {
            var mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 5,
                ColumnCount = 1,
                Padding = new Padding(20),
                BackColor = Color.White
            };

            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 120)); // Logo
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));  // Username
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));  // Password
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60));  // Button
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100));  // Spacer

            // Adds logo to the login box
            var logo = new PictureBox
            {
                Image = LoadImage("logo.png"),
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Fill
            };

            // Creates input text boxes
            txtUsername = new TextBox { Width = 200 };
            txtPassword = new TextBox { Width = 200, UseSystemPasswordChar = true };

            var usernameRow = CreateLabeledRow("Username:", txtUsername);
            var passwordRow = CreateLabeledRow("Password:", txtPassword);

            // Login button once details are entered
            btnLogin = new Button
            {
                Text = "Login",
                Width = 100,
                Height = 30,
                Anchor = AnchorStyles.None
            };
            btnLogin.Click += BtnLogin_Click;

            // Centers the login button
            var loginPanel = new Panel { Height = 60, Dock = DockStyle.Fill };
            loginPanel.Controls.Add(btnLogin);
            loginPanel.Resize += (s, e) =>
            {
                btnLogin.Left = (loginPanel.Width - btnLogin.Width) / 2;
                btnLogin.Top = (loginPanel.Height - btnLogin.Height) / 2;
            };

            mainLayout.Controls.Add(logo);
            mainLayout.Controls.Add(usernameRow);
            mainLayout.Controls.Add(passwordRow);
            mainLayout.Controls.Add(loginPanel);

            this.Controls.Add(mainLayout);
        }

        // Handles the login button click with popup if successfully logged in or not
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = Services.AuthenticateUser(username, password);

            if (role != null)
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                new DashboardForm(role).Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Panel CreateLabeledRow(string labelText, Control inputControl)
        {
            var row = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                Height = 40,
                Dock = DockStyle.Fill,
                Padding = new Padding(5),
                WrapContents = false
            };

            var label = new Label
            {
                Text = labelText,
                Width = 80,
                TextAlign = ContentAlignment.MiddleRight,
                Anchor = AnchorStyles.Left
            };

            row.Controls.Add(label);
            row.Controls.Add(inputControl);

            return row;
        }

        // Loads images from the folder
        private Image LoadImage(string fileName)
        {
            string solutionRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string projectFolder = Path.Combine(solutionRoot, "MuseumTourManagement");
            string fullPath = Path.Combine(projectFolder, "images", fileName);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show($"IMAGE NOT FOUND:\n{fullPath}", "Missing Image", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return SystemIcons.Warning.ToBitmap();
            }

            return Image.FromFile(fullPath);
        }
    }
}
