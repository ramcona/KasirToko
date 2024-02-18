namespace KasirToko
{
    partial class MainMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.produkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterProdukToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterKategoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masterAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transkasiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tambahToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.riwayatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.akunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUser = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produkToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.transkasiToolStripMenuItem,
            this.akunToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // produkToolStripMenuItem
            // 
            this.produkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterProdukToolStripMenuItem,
            this.masterKategoriToolStripMenuItem});
            this.produkToolStripMenuItem.Name = "produkToolStripMenuItem";
            this.produkToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.produkToolStripMenuItem.Text = "Produk";
            // 
            // masterProdukToolStripMenuItem
            // 
            this.masterProdukToolStripMenuItem.Name = "masterProdukToolStripMenuItem";
            this.masterProdukToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.masterProdukToolStripMenuItem.Text = "Master Produk";
            this.masterProdukToolStripMenuItem.Click += new System.EventHandler(this.masterProdukToolStripMenuItem_Click);
            // 
            // masterKategoriToolStripMenuItem
            // 
            this.masterKategoriToolStripMenuItem.Name = "masterKategoriToolStripMenuItem";
            this.masterKategoriToolStripMenuItem.Size = new System.Drawing.Size(239, 34);
            this.masterKategoriToolStripMenuItem.Text = "Master Kategori";
            this.masterKategoriToolStripMenuItem.Click += new System.EventHandler(this.masterKategoriToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.masterAdminToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(81, 29);
            this.adminToolStripMenuItem.Text = "Admin";
            // 
            // masterAdminToolStripMenuItem
            // 
            this.masterAdminToolStripMenuItem.Name = "masterAdminToolStripMenuItem";
            this.masterAdminToolStripMenuItem.Size = new System.Drawing.Size(226, 34);
            this.masterAdminToolStripMenuItem.Text = "Master Admin";
            this.masterAdminToolStripMenuItem.Click += new System.EventHandler(this.masterAdminToolStripMenuItem_Click);
            // 
            // transkasiToolStripMenuItem
            // 
            this.transkasiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tambahToolStripMenuItem,
            this.riwayatToolStripMenuItem});
            this.transkasiToolStripMenuItem.Name = "transkasiToolStripMenuItem";
            this.transkasiToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.transkasiToolStripMenuItem.Text = "Transkasi";
            // 
            // tambahToolStripMenuItem
            // 
            this.tambahToolStripMenuItem.Name = "tambahToolStripMenuItem";
            this.tambahToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.tambahToolStripMenuItem.Text = "Tambah";
            this.tambahToolStripMenuItem.Click += new System.EventHandler(this.tambahToolStripMenuItem_Click);
            // 
            // riwayatToolStripMenuItem
            // 
            this.riwayatToolStripMenuItem.Name = "riwayatToolStripMenuItem";
            this.riwayatToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.riwayatToolStripMenuItem.Text = "Riwayat";
            this.riwayatToolStripMenuItem.Click += new System.EventHandler(this.riwayatToolStripMenuItem_Click);
            // 
            // akunToolStripMenuItem
            // 
            this.akunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            this.akunToolStripMenuItem.Size = new System.Drawing.Size(69, 29);
            this.akunToolStripMenuItem.Text = "Akun";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(171, 34);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(13, 56);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(214, 31);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "Selamat Datang,";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem produkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterProdukToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterKategoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masterAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transkasiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tambahToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem riwayatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem akunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Label labelUser;
    }
}