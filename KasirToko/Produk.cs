using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KasirToko
{
    public partial class Produk : Form
    {
        private SqlConnection conn;
        private int idData = 0;

        public Produk()
        {
            InitializeComponent();
        }

        private void Produk_Load(object sender, EventArgs e)
        {
            //Membuat koneksi ke database
            string koneksi = "Data Source=MYBOOKPROK7V;Initial Catalog=tokoonline;Integrated Security=True";
            conn = new SqlConnection(koneksi);

            loadData();
            clearData();

        }

        private void loadData()
        {
            //get data products
            string query = "SELECT product.*, categories.nama as namakategori FROM product LEFT JOIN categories ON product.category_id = categories.id ORDER BY product.nama ASC";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "products");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "products";

            //get data category for set to combobox

            DataTable cateoryTable = new DataTable();

            //create our SQL SELECT statement
            string sqlCategories = "Select * from categories";
            try
            {
                conn.Open();

                SqlDataAdapter categoryAdapter = new SqlDataAdapter(sqlCategories, conn);
                categoryAdapter.Fill(cateoryTable);
                //cateoryTable.Rows.Add("Pilih Kategori");
                cbKategori.DataSource = cateoryTable;
                cbKategori.DisplayMember = "nama";
                cbKategori.ValueMember = "id";
                //cbKategori.SelectedValue = "Pilih Kategori";

                conn.Close();
            }
            catch (Exception ex)
            {
                //this will display some error message if something 
                //went wrong to our code above during execution
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
            loadData();
        }

        private void clearData()
        {
            tbHarga.Text = "0";
            tbStok.Text = "0";
            tbNama.Text = "";
            idData = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string nama = tbNama.Text;
            string harga = tbHarga.Text;
            string stok = tbStok.Text;
            int categoryId = (int)cbKategori.SelectedValue;

            if (nama != "" && harga != "" && stok != "" && categoryId > 0)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO product(nama, harga, stok, category_id) VALUES(@nama, @harga, @stok, @category_id)", conn);
                cmd.Parameters.AddWithValue("@nama", nama);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@stok", stok);
                cmd.Parameters.AddWithValue("@category_id", categoryId);
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
                string nama = tbNama.Text;
                string harga = tbHarga.Text;
                string stok = tbStok.Text;
                int categoryId = (int)cbKategori.SelectedValue;

                if (nama != "" && harga != "" && stok != "" && categoryId > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE product SET nama = @nama, harga = @harga, stok = @stok, category_id = @category_id WHERE id = @id ", conn);
                    cmd.Parameters.AddWithValue("@nama", nama);
                    cmd.Parameters.AddWithValue("@harga", harga);
                    cmd.Parameters.AddWithValue("@stok", stok);
                    cmd.Parameters.AddWithValue("@category_id", categoryId);
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
                string nama = tbNama.Text;

                SqlCommand cmd = new SqlCommand("DELETE FROM product WHERE id = @id ", conn);
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

            tbNama.Text = data.Cells[1].Value.ToString();
            tbStok.Text = data.Cells[3].Value.ToString();
            cbKategori.SelectedValue = data.Cells[4].Value.ToString();
            tbHarga.Text = data.Cells[2].Value.ToString();
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
