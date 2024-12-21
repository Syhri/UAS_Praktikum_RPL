namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            lblSignIn = new Label();
            btnRegister = new Button();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            label1 = new Label();
            txtPassword = new TextBox();
            txtConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // lblSignIn
            // 
            lblSignIn.AutoSize = true;
            lblSignIn.Cursor = Cursors.Hand;
            lblSignIn.Location = new Point(152, 357);
            lblSignIn.Name = "lblSignIn";
            lblSignIn.Size = new Size(181, 15);
            lblSignIn.TabIndex = 9;
            lblSignIn.Text = "Already have an account? Sign In";
            lblSignIn.Click += lblSignIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = SystemColors.HighlightText;
            btnRegister.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = SystemColors.MenuHighlight;
            btnRegister.Location = new Point(170, 290);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(147, 48);
            btnRegister.TabIndex = 8;
            btnRegister.Text = "Registrasi";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(107, 144);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(275, 29);
            txtUsername.TabIndex = 7;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(108, 98);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(275, 29);
            txtEmail.TabIndex = 6;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, -1);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(485, 57);
            label1.TabIndex = 5;
            label1.Text = "HALAMAN REGISTRASI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(108, 188);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(275, 29);
            txtPassword.TabIndex = 10;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtConfirmPassword.Location = new Point(108, 232);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.Size = new Size(275, 29);
            txtConfirmPassword.TabIndex = 11;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(485, 398);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblSignIn);
            Controls.Add(btnRegister);
            Controls.Add(txtUsername);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "RegistrationForm";
            Text = "Registrasi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSignIn;
        private Button btnRegister;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtConfirmPassword;
    }
}