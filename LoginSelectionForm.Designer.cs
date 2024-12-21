namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class LoginSelectionForm
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
            btnLoginUser = new Button();
            label1 = new Label();
            btnLoginAdmin = new Button();
            SuspendLayout();
            // 
            // btnLoginUser
            // 
            btnLoginUser.BackColor = SystemColors.HighlightText;
            btnLoginUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginUser.ForeColor = SystemColors.MenuHighlight;
            btnLoginUser.Location = new Point(106, 97);
            btnLoginUser.Name = "btnLoginUser";
            btnLoginUser.Size = new Size(264, 48);
            btnLoginUser.TabIndex = 8;
            btnLoginUser.Text = "User";
            btnLoginUser.UseVisualStyleBackColor = false;
            btnLoginUser.Click += btnLoginUser_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(485, 57);
            label1.TabIndex = 5;
            label1.Text = "LOGIN SEBAGAI";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnLoginAdmin
            // 
            btnLoginAdmin.BackColor = SystemColors.HighlightText;
            btnLoginAdmin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoginAdmin.ForeColor = SystemColors.MenuHighlight;
            btnLoginAdmin.Location = new Point(106, 157);
            btnLoginAdmin.Name = "btnLoginAdmin";
            btnLoginAdmin.Size = new Size(264, 48);
            btnLoginAdmin.TabIndex = 9;
            btnLoginAdmin.Text = "Admin";
            btnLoginAdmin.UseVisualStyleBackColor = false;
            btnLoginAdmin.Click += btnLoginAdmin_Click;
            // 
            // LoginSelectionForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(484, 281);
            Controls.Add(btnLoginAdmin);
            Controls.Add(btnLoginUser);
            Controls.Add(label1);
            Name = "LoginSelectionForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLoginUser;
        private Label label1;
        private Button btnLoginAdmin;
    }
}