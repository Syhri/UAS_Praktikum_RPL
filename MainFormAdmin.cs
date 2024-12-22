using System;
using System.Windows.Forms;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class MainFormAdmin : Form
    {
        public MainFormAdmin()
        {
            InitializeComponent();
        }

        private void MainFormAdmin_Load(object sender, EventArgs e)
        {
            // Set default page
            ShowControl(new DataKereta());
        }

        private void btnManageTrains_Click(object sender, EventArgs e)
        {
            ShowControl(new DataKereta());
        }

        private void btnManageTickets_Click(object sender, EventArgs e)
        {
            ShowControl(new DataTiket());
        }

        private void btnManagePurchases_Click(object sender, EventArgs e)
        {
            ShowControl(new DataPembelian());
        }

        private void btnManagePaidOrders_Click(object sender, EventArgs e)
        {
            ShowControl(new DataPemesananTerbayar());
        }

        private void btnManageIssuedTickets_Click(object sender, EventArgs e)
        {
            ShowControl(new DataTiketTerbit());
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            ShowControl(new DataUsers());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // Log out and return to LoginForm
            this.Hide();
            LoginForm loginForm = new LoginForm();
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