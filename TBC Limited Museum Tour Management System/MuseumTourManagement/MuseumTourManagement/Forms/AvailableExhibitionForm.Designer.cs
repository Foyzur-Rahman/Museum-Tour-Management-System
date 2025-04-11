namespace MuseumTourManagement.Forms
{
    partial class AvailableExhibitionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvAvailableExhibitions;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAvailableExhibitions = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableExhibitions)).BeginInit();
            this.SuspendLayout();

            // 🔹 DataGridView (Exhibitions)
            this.dgvAvailableExhibitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvailableExhibitions.BackgroundColor = System.Drawing.Color.White;
            this.dgvAvailableExhibitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAvailableExhibitions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // 🔹 Form Settings
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dgvAvailableExhibitions);
            this.Text = "Available Exhibitions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // 🔹 Event Handler
            this.Load += new System.EventHandler(this.AvailableExhibitionsForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableExhibitions)).EndInit();
            this.ResumeLayout(false);
        }
        #endregion
    }
}
