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

            textBox.Enter += (sender, e) => {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;

                    if (textBox == txtPassword || textBox == txtConfirmPassword)
                        textBox.PasswordChar = '*'; // Set the password character when focused
                }
            };

            textBox.Leave += (sender, e) => {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;

                    if (textBox == txtPassword || textBox == txtConfirmPassword)
                        textBox.PasswordChar = '\0'; // Clear the password character when not focused
                }
            };
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

            // Implementasi logika registrasi di sini
            if (password == confirmPassword)
            {
                // Lakukan proses registrasi, misalnya simpan data ke database
                MessageBox.Show("Registrasi berhasil! Silakan login.", "Registrasi Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lblSignIn_Click(sender, e); // Arahkan ke form login setelah registrasi berhasil
            }
            else
            {
                // Jika password dan konfirmasi password tidak sama, tampilkan pesan kesalahan
                MessageBox.Show("Password dan konfirmasi password tidak sama!", "Registrasi Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
