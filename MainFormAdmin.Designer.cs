namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class MainFormAdmin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlNavbar = new Panel();
            btnManageTrains = new Button();
            btnManageTickets = new Button();
            btnManageUsers = new Button();
            pnlContent = new Panel();
            pnlNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavbar
            // 
            pnlNavbar.Controls.Add(btnManageTrains);
            pnlNavbar.Controls.Add(btnManageTickets);
            pnlNavbar.Controls.Add(btnManageUsers);
            pnlNavbar.Dock = DockStyle.Left;
            pnlNavbar.Location = new Point(0, 0);
            pnlNavbar.Margin = new Padding(4, 3, 4, 3);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(233, 519);
            pnlNavbar.TabIndex = 0;
            pnlNavbar.Paint += pnlNavbar_Paint;
            // 
            // btnManageTrains
            // 
            btnManageTrains.Location = new Point(14, 14);
            btnManageTrains.Margin = new Padding(4, 3, 4, 3);
            btnManageTrains.Name = "btnManageTrains";
            btnManageTrains.Size = new Size(204, 58);
            btnManageTrains.TabIndex = 0;
            btnManageTrains.Text = "Data Kereta";
            btnManageTrains.UseVisualStyleBackColor = true;
            btnManageTrains.Click += btnManageTrains_Click;
            // 
            // btnManageTickets
            // 
            btnManageTickets.Location = new Point(14, 78);
            btnManageTickets.Margin = new Padding(4, 3, 4, 3);
            btnManageTickets.Name = "btnManageTickets";
            btnManageTickets.Size = new Size(204, 58);
            btnManageTickets.TabIndex = 1;
            btnManageTickets.Text = "Data Tiket";
            btnManageTickets.UseVisualStyleBackColor = true;
            btnManageTickets.Click += btnManageTickets_Click;
            // 
            // btnManageUsers
            // 
            btnManageUsers.Location = new Point(14, 143);
            btnManageUsers.Margin = new Padding(4, 3, 4, 3);
            btnManageUsers.Name = "btnManageUsers";
            btnManageUsers.Size = new Size(204, 58);
            btnManageUsers.TabIndex = 2;
            btnManageUsers.Text = "Data Users";
            btnManageUsers.UseVisualStyleBackColor = true;
            btnManageUsers.Click += btnManageUsers_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(233, 0);
            pnlContent.Margin = new Padding(4, 3, 4, 3);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(700, 519);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // MainFormAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(pnlContent);
            Controls.Add(pnlNavbar);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainFormAdmin";
            Text = "Admin e-Ticketing Travelokal";
            Load += MainFormAdmin_Load;
            pnlNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Button btnManageTrains;
        private System.Windows.Forms.Button btnManageTickets;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.Panel pnlContent;
    }
}