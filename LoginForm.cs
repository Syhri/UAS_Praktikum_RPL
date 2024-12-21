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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Validasi input (implementasi sederhana)
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proses autentikasi (logika sederhana)
            if (AuthenticateUser(username, password))
            {
                // Jika autentikasi berhasil, arahkan ke halaman utama atau dashboard
                MessageBox.Show("Login berhasil!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Contoh mengarahkan ke form lain
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
                // this.Hide();
            }
            else
            {
                // Jika autentikasi gagal, tampilkan pesan kesalahan
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            // Implementasi logika autentikasi sederhana
            // Ganti dengan logika autentikasi yang sesuai (misalnya, cek ke database)
            return username == "admin" && password == "password";
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            // Arahkan ke form registrasi
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            this.Hide(); // Sembunyikan form login
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
