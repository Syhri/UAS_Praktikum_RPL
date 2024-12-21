using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class LoginSelectionForm : Form
    {
        public LoginSelectionForm()
        {
            InitializeComponent();
        }

        private void btnLoginUser_Click(object sender, EventArgs e)
        {
            // Arahkan ke form login user
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void btnLoginAdmin_Click(object sender, EventArgs e)
        {
            // Arahkan ke form login admin
            AdminLoginForm adminLoginForm = new AdminLoginForm();
            adminLoginForm.Show();
            this.Hide();
        }

        private void LoginSelectionForm_Load(object sender, EventArgs e)
        {
            // Event handler untuk form load, jika diperlukan
        }
    }
}
