namespace Sistem_Pemesanan_Tiket_Kereta
{
    partial class MainFormUser
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
            btnSearchTickets = new Button();
            btnViewBookings = new Button();
            btnViewProfile = new Button();
            btnLogout = new Button();
            pnlContent = new Panel();
            pnlNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // pnlNavbar
            // 
            pnlNavbar.Controls.Add(btnSearchTickets);
            pnlNavbar.Controls.Add(btnViewBookings);
            pnlNavbar.Controls.Add(btnViewProfile);
            pnlNavbar.Controls.Add(btnLogout);
            pnlNavbar.Dock = DockStyle.Left;
            pnlNavbar.Location = new Point(0, 0);
            pnlNavbar.Name = "pnlNavbar";
            pnlNavbar.Size = new Size(200, 450);
            pnlNavbar.TabIndex = 0;
            pnlNavbar.Paint += pnlNavbar_Paint;
            // 
            // btnSearchTickets
            // 
            btnSearchTickets.Location = new Point(12, 12);
            btnSearchTickets.Name = "btnSearchTickets";
            btnSearchTickets.Size = new Size(175, 36);
            btnSearchTickets.TabIndex = 0;
            btnSearchTickets.Text = "Cari Tiket";
            btnSearchTickets.UseVisualStyleBackColor = true;
            btnSearchTickets.Click += btnSearchTickets_Click;
            // 
            // btnViewBookings
            // 
            btnViewBookings.Location = new Point(12, 63);
            btnViewBookings.Name = "btnViewBookings";
            btnViewBookings.Size = new Size(175, 36);
            btnViewBookings.TabIndex = 1;
            btnViewBookings.Text = "Lihat Bookings";
            btnViewBookings.UseVisualStyleBackColor = true;
            btnViewBookings.Click += btnViewBookings_Click;
            // 
            // btnViewProfile
            // 
            btnViewProfile.Location = new Point(12, 116);
            btnViewProfile.Name = "btnViewProfile";
            btnViewProfile.Size = new Size(175, 36);
            btnViewProfile.TabIndex = 2;
            btnViewProfile.Text = "Lihat Profile";
            btnViewProfile.UseVisualStyleBackColor = true;
            btnViewProfile.Click += btnViewProfile_Click;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(12, 400);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(175, 38);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pnlContent
            // 
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(200, 0);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(600, 450);
            pnlContent.TabIndex = 1;
            pnlContent.Paint += pnlContent_Paint;
            // 
            // MainFormUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlContent);
            Controls.Add(pnlNavbar);
            Name = "MainFormUser";
            Text = "User Dashboard";
            Load += MainFormUser_Load;
            pnlNavbar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Button btnSearchTickets;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnLogout; // Tambahkan ini
        private System.Windows.Forms.Panel pnlContent;
    }
}