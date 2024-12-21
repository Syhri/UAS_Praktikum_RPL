using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class LoginForm : Form
    {
        private const string UsernamePlaceholder = "Username";
        private const string PasswordPlaceholder = "Password";

        private string connectionString = "server=localhost;database=uas_rpl;user=root;password=;";
        public LoginForm()
        {
            InitializeComponent();

            SetPlaceholder(txtUsername, UsernamePlaceholder);
            SetPlaceholder(txtPassword, PasswordPlaceholder);
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) => {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;

                    if (textBox == txtPassword)
                        textBox.PasswordChar = '*'; // Set the password character when focused
                }
            };

            textBox.Leave += (sender, e) => {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;

                    if (textBox == txtPassword)
                        textBox.PasswordChar = '\0'; // Clear the password character when not focused
                }
            };
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
                MainFormUser mainForm = new MainFormUser();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                // Jika autentikasi gagal, tampilkan pesan kesalahan
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(1) FROM users WHERE username = @Username AND password = @Password";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
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
            //throw new NotImplementedException();
        }
    }
}
