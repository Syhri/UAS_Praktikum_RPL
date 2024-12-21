using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class AdminLoginForm : Form
    {
        private const string UsernamePlaceholder = "Username";
        private const string PasswordPlaceholder = "Password";

        public AdminLoginForm()
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

        private void AdminLoginForm_Load(object sender, EventArgs e)
        {
            // Event handler untuk form load, jika diperlukan
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Event handler untuk perubahan teks username, jika diperlukan
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Event handler untuk perubahan teks password, jika diperlukan
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Hapus placeholder sebelum memproses login
            if (username == UsernamePlaceholder) username = "";
            if (password == PasswordPlaceholder) password = "";

            // Validasi input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password harus diisi!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proses autentikasi
            if (AuthenticateAdmin(username, password))
            {
                MessageBox.Show("Login berhasil!", "Login Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainFormAdmin adminForm = new MainFormAdmin();
                adminForm.Show();
                this.Hide(); // Sembunyikan form login
            }
            else
            {
                MessageBox.Show("Username atau password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateAdmin(string username, string password)
        {
            // Logika autentikasi sederhana
            return username == "Admin" && password == "admin1234";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Event handler untuk label yang tidak digunakan
        }
    }
}