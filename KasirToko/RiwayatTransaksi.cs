using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KasirToko
{
    public partial class RiwayatTransaksi : Form
    {

        private SqlConnection conn;

        public RiwayatTransaksi()
        {
            InitializeComponent();
        }

        private void RiwayatTransaksi_Load(object sender, EventArgs e)
        {
            //Membuat koneksi ke database
            string koneksi = "Data Source=MYBOOKPROK7V;Initial Catalog=tokoonline;Integrated Security=True";

            conn = new SqlConnection(koneksi);
            loadData();  

        }

        private void loadData()
        {
            string query = "SELECT transactions.*, admins.nama FROM transactions LEFT JOIN admins ON transactions.admin_id = admins.id ORDER BY transactions.id DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "categories");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "categories";
        }

        private void btnKeluar_Click(object sender, EventArgs e)
        {
            MainMenu newMenu = new MainMenu();
            this.Hide();
            newMenu.ShowDialog();
            this.Close();
        }
    }
}
