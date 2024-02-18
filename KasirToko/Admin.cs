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
using System.Data.SqlClient;

namespace KasirToko
{
    public partial class Admin : Form
    {

        private SqlConnection conn;
        private int idData = 0;
        public Admin()
        {
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //Membuat koneksi ke database
            string koneksi = "Data Source=MYBOOKPROK7V;Initial Catalog=tokoonline;Integrated Security=True";
            conn = new SqlConnection(koneksi);


            //set data to combo box
            cbRole.Items.Clear();
            cbRole.Items.Add("ADMIN");
            cbRole.Items.Add("FINANCE");

            loadData();
        }

        private void loadData()
        {
            string query = "SELECT * FROM admins ORDER BY id DESC";
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            sda.Fill(ds, "admins");

            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "admins";
        }

        private void clearData()
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
            idData = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;
            string role = cbRole.Text;

            if (username != "" && password != "" && role != "")
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO admins(nama, password, role) VALUES(@nama, @password, @role)", conn);
                cmd.Parameters.AddWithValue("@nama", username);
                cmd.Parameters.AddWithValue("@password", password);
                cmd.Parameters.AddWithValue("@role", role);
                conn.Open();

                int i = cmd.ExecuteNonQuery();

                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show("Data " + username + " Berhasil di simpan");
                    clearData();
                    loadData();
                }
                else
                {
                    MessageBox.Show("Data " + username + " gagal di simpan");
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (idData <= 0)
            {
                MessageBox.Show("Tidak ada data yang akan di hapus");
            }
            else
            {
                string nama = tbUsername.Text;

                SqlCommand cmd = new SqlCommand("DELETE FROM admins WHERE id = @id ", conn);
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

            tbUsername.Text = data.Cells[1].Value.ToString();
            tbPassword.Text = data.Cells[2].Value.ToString();
            cbRole.Text = data.Cells[3].Value.ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (idData <= 0)
            {
                MessageBox.Show("Tidak ada data yang di perbarui");
            }
            else
            {
                string username = tbUsername.Text;
                string password = tbPassword.Text;
                string role = cbRole.Text;

                if (username != "" && password != "" && role != "")
                {
                    SqlCommand cmd = new SqlCommand("UPDATE admins SET nama = @nama, password = @password, role = @role WHERE id = @id ", conn);
                    cmd.Parameters.AddWithValue("@nama", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@id", idData);
                    conn.Open();

                    int i = cmd.ExecuteNonQuery();

                    conn.Close();

                    if (i != 0)
                    {
                        MessageBox.Show("Data " + username + " Berhasil diperbarui");
                        clearData();
                        loadData();
                    }
                    else
                    {
                        MessageBox.Show("Data " + username + " gagal diperbarui");
                    }
                }
                else {
                    MessageBox.Show("Lengkapi data anda");
                }
                
            }
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
