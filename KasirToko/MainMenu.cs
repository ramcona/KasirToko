using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirToko
{
    public partial class MainMenu : Form
    {

        private string role = "";
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            string username = Properties.Settings.Default.Username;
            string role = Properties.Settings.Default.Role; 
            labelUser.Text = "Selamat Datang, " + username + " (" + role + ")";

            role = Properties.Settings.Default.Role;
        }

        private void masterAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (role != "ADMIN")
            {
                MessageBox.Show("Anda tidak diperbolehkan mengkases");
            }
            else {
                Admin newMenu = new Admin();
                this.Hide();
                newMenu.ShowDialog();
                this.Close();
            }
            
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Reset();

            Login newMenu = new Login();
            this.Hide();
            newMenu.ShowDialog();
            this.Close();

        }

        private void masterKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kategori newMenu = new Kategori();
            this.Hide();
            newMenu.ShowDialog();
            this.Close();
        }

        private void masterProdukToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produk newMenu = new Produk();
            this.Hide();
            newMenu.ShowDialog();
            this.Close();
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transaksi newMenu = new Transaksi();
            this.Hide();
            newMenu.ShowDialog();
            this.Close();
        }

        private void riwayatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RiwayatTransaksi newMenu = new RiwayatTransaksi();
            this.Hide();
            newMenu.ShowDialog();
            this.Close();

        }
    }
}
