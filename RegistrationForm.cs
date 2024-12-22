using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Sistem_Pemesanan_Tiket_Kereta
{
    public partial class RegistrationForm : Form
    {
        private const string EmailPlaceholder = "Email";
        private const string UsernamePlaceholder = "Username";
        private const string PasswordPlaceholder = "Password";
        private const string ConfirmPasswordPlaceholder = "Confirm Password";

        public RegistrationForm()
        {
            InitializeComponent();

            // Set placeholder text
            SetPlaceholder(txtEmail, EmailPlaceholder);
            SetPlaceholder(txtUsername, UsernamePlaceholder);
            SetPlaceholder(txtPassword, PasswordPlaceholder);
            SetPlaceholder(txtConfirmPassword, ConfirmPasswordPlaceholder);
        }

        private void SetPlaceholder(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;

                    if (textBox == txtPassword || textBox == txtConfirmPassword)
                        textBox.PasswordChar = '*'; // Set the password character when focused
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;

                    if (textBox == txtPassword || textBox == txtConfirmPassword)
                        textBox.PasswordChar = '\0'; // Clear the password character when not focused
                }
            };
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // Logika yang ingin Anda jalankan saat form dimuat, jika ada
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            // Hapus placeholder sebelum memproses registrasi
            if (email == EmailPlaceholder) email = "";
            if (username == UsernamePlaceholder) username = "";
            if (password == PasswordPlaceholder) password = "";
            if (confirmPassword == ConfirmPasswordPlaceholder) confirmPassword = "";

            // Validasi email harus mengandung '@'
            if (!email.Contains("@"))
            {
                MessageBox.Show("Email harus mengandung '@'.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi password minimal 8 karakter
            if (password.Length < 8)
            {
                MessageBox.Show("Password harus minimal 8 karakter.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validasi konfirmasi password minimal 8 karakter
            if (confirmPassword.Length < 8)
            {
                MessageBox.Show("Konfirmasi password harus minimal 8 karakter.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Implementasi logika registrasi di sini
            if (password == confirmPassword)
            {
                // Simpan data ke database
                if (RegisterUser(email, username, password))
                {
                    MessageBox.Show("Registrasi berhasil! Silakan login.", "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblSignIn_Click(sender, e); // Arahkan ke form login setelah registrasi berhasil
                }
                else
                {
                    MessageBox.Show("Registrasi gagal! Coba lagi.", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Jika password dan konfirmasi password tidak sama, tampilkan pesan kesalahan
                MessageBox.Show("Password dan konfirmasi password tidak sama!", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool RegisterUser(string email, string username, string password)
        {
            string connectionString = "server=localhost;port=3306;username=root;password=;database=uas_rpl;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (email, username, password) VALUES (@Email, @Username, @Password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        int result = cmd.ExecuteNonQuery();
                        return result > 0;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void lblSignIn_Click(object sender, EventArgs e)
        {
            // Arahkan ke form login
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            // Placeholder logic for txtEmail
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            // Placeholder logic for txtUsername
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            // Placeholder logic for txtPassword
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            // Placeholder logic for txtConfirmPassword
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}