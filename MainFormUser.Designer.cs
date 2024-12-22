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
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.btnSearchTickets = new System.Windows.Forms.Button();
            this.btnViewBookings = new System.Windows.Forms.Button();
            this.btnViewProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.dgvTiket = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnPesan = new System.Windows.Forms.Button();
            this.pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiket)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.Controls.Add(this.btnSearchTickets);
            this.pnlNavbar.Controls.Add(this.btnViewBookings);
            this.pnlNavbar.Controls.Add(this.btnViewProfile);
            this.pnlNavbar.Controls.Add(this.btnLogout);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(200, 450);
            this.pnlNavbar.TabIndex = 0;
            this.pnlNavbar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlNavbar_Paint);
            // 
            // btnSearchTickets
            // 
            this.btnSearchTickets.Location = new System.Drawing.Point(12, 12);
            this.btnSearchTickets.Name = "btnSearchTickets";
            this.btnSearchTickets.Size = new System.Drawing.Size(175, 36);
            this.btnSearchTickets.TabIndex = 0;
            this.btnSearchTickets.Text = "Cari Tiket";
            this.btnSearchTickets.UseVisualStyleBackColor = true;
            this.btnSearchTickets.Click += new System.EventHandler(this.btnSearchTickets_Click);
            // 
            // btnViewBookings
            // 
            this.btnViewBookings.Location = new System.Drawing.Point(12, 63);
            this.btnViewBookings.Name = "btnViewBookings";
            this.btnViewBookings.Size = new System.Drawing.Size(175, 36);
            this.btnViewBookings.TabIndex = 1;
            this.btnViewBookings.Text = "Lihat Bookings";
            this.btnViewBookings.UseVisualStyleBackColor = true;
            this.btnViewBookings.Click += new System.EventHandler(this.btnViewBookings_Click);
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Location = new System.Drawing.Point(12, 116);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(175, 36);
            this.btnViewProfile.TabIndex = 2;
            this.btnViewProfile.Text = "Lihat Profile";
            this.btnViewProfile.UseVisualStyleBackColor = true;
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(12, 400);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(175, 38);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.dgvTiket);
            this.pnlContent.Controls.Add(this.txtSearch);
            this.pnlContent.Controls.Add(this.btnSearch);
            this.pnlContent.Controls.Add(this.btnPesan);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(200, 0);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(600, 450);
            this.pnlContent.TabIndex = 1;
            this.pnlContent.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContent_Paint);
            // 
            // dgvTiket
            // 
            this.dgvTiket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiket.Location = new System.Drawing.Point(12, 51);
            this.dgvTiket.Name = "dgvTiket";
            this.dgvTiket.RowTemplate.Height = 25;
            this.dgvTiket.Size = new System.Drawing.Size(576, 350);
            this.dgvTiket.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(12, 12);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(489, 23);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(507, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Cari";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnPesan
            // 
            this.btnPesan.Location = new System.Drawing.Point(12, 407);
            this.btnPesan.Name = "btnPesan";
            this.btnPesan.Size = new System.Drawing.Size(576, 31);
            this.btnPesan.TabIndex = 3;
            this.btnPesan.Text = "Pesan Tiket";
            this.btnPesan.UseVisualStyleBackColor = true;
            this.btnPesan.Click += new System.EventHandler(this.btnPesan_Click);
            // 
            // MainFormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlNavbar);
            this.Name = "MainFormUser";
            this.Text = "User Dashboard";
            this.Load += new System.EventHandler(this.MainFormUser_Load);
            this.pnlNavbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Button btnSearchTickets;
        private System.Windows.Forms.Button btnViewBookings;
        private System.Windows.Forms.Button btnViewProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.DataGridView dgvTiket;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnPesan;
    }
}