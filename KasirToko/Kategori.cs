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
    public partial class Kategori : Form
    {

        private SqlConnection conn;
        private int idData = 0;

        public Kategori()
        {
            InitializeComponent();
        }

        private void Kategori_Load(object sender, EventArgs e)
        {
            //Membuat koneksi ke database
            string koneksi = "Data Source=MYBOOKPROK7V;Initial Catalog=tokoonline;Integrated Security=True";
            conn = new SqlConnection(koneksi);

            loadData();

        }

        private void loadData()
        {
            string query = "SELECT * FROM categories ORDER BY id DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "categories");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "categories";
        }

        private void clearData()
        {
            tbName.Text = "";
            idData = 0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nama = tbName.Text;

            if (nama != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO categories(nama) VALUES(@nama)", conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                conn.Open();

                int i = cmd.ExecuteNonQuery();

                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show("Data " + nama + " Berhasil di simpan");
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Data " + nama + " gagal di simpan");
                }

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idData <= 0)
            {
                MessageBox.Show("Tidak ada data yang di perbarui");
            }
            else
            {
                string nama = tbName.Text;

                if (nama != "")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE categories SET nama = @nama WHERE id = @id ", conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@id", idData);
                    conn.Open();

                    int i = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (i != 0)
                    {
                        MessageBox.Show("Data " + nama + " Berhasil diperbarui");
                        clearData();
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Data " + nama + " gagal diperbarui");
                    }
                }
                else
                {
                    MessageBox.Show("Lengkapi data anda");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idData <= 0)
            {
                MessageBox.Show("Tidak ada data yang akan di hapus");
            }
            else
            {
                string nama = tbName.Text;

                SqlCommand cmd = new SqlCommand("DELETE FROM categories WHERE id = @id ", conn);
                cmd.Parameters.AddWithValue("@id", idData);
                conn.Open();

                int i = cmd.ExecuteNonQuery();

                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show("Data " + nama + " Berhasil dihapus");
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Data " + nama + " gagal dihapus");
                }

            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow data = dataGridView1.Rows[index];
            idData = (int)data.Cells[0].Value;

            tbName.Text = data.Cells[1].Value.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            MainMenu newMenu = new MainMenu();
            this.Hide();
            newMenu.ShowDialog();
            this.Close();
        }
    }
}
