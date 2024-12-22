using System;
using System.Windows.Forms;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class MainFormUser : Form
    {
        public MainFormUser()
        {
            InitializeComponent();
        }

        private void MainFormUser_Load(object sender, EventArgs e)
        {
            // Set default page
            ShowControl(new DataPencarianTiket());
        }

        private void btnSearchTickets_Click(object sender, EventArgs e)
        {
            ShowControl(new DataPencarianTiket());
        }

        private void btnViewBookings_Click(object sender, EventArgs e)
        {
            ShowControl(new DataPemesananTiket());
        }

        private void btnViewProfile_Click(object sender, EventArgs e)
        {
            ShowControl(new UserProfile());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Log out and return to LoginSelectionForm
            this.Hide();
            LoginSelectionForm loginForm = new LoginSelectionForm();
            loginForm.Show();
        }

        private void ShowControl(UserControl control)
        {
            pnlContent.Controls.Clear();
            control.Dock = DockStyle.Fill;
            pnlContent.Controls.Add(control);
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e) { }

        private void pnlNavbar_Paint(object sender, PaintEventArgs e) { }
    }
}