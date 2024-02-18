using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace KasirToko
{
    public partial class Transaksi : Form
    {
        private SqlConnection conn;
        private int rowCartIndex = -1;
        private int idProduct = 0;
        private int diskon = 0;

        public Transaksi()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Transaksi_Load(object sender, EventArgs e)
        {
            //Membuat koneksi ke database
            string koneksi = "Data Source=MYBOOKPROK7V;Initial Catalog=tokoonline;Integrated Security=True";
            conn = new SqlConnection(koneksi);

            setupDataGridCart();
        }


        //fungsi ini digunakan untuk set kolom yang akan tampil di data grid
        private void setupDataGridCart() {
            dataGridView1.Columns.Add("idProduk", "Kode Produk");
            dataGridView1.Columns.Add("namaProduk", "Nama");
            dataGridView1.Columns.Add("stokProduk", "Stok");
            dataGridView1.Columns.Add("hargaProduk", "Harga");
            dataGridView1.Columns.Add("qty", "Jml Beli");
        }

        private void clearProduk()
        {
            rowCartIndex = -1;
            tbKodeProduk.Text = "";
            tbQty.Text = "";
            labelNamaProduk.Text = "Tidak ada produk";
            labelHargaProduk.Text = "0";
            labelStokProduk.Text = "0";
            idProduct = 0;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            string kode = tbKodeProduk.Text;
            if (kode != "") {

                //membuka koneksi
                conn.Open();

                //query mencari produk berdasrkan id/kode yang di inputkan
                string query = "SELECT * FROM product WHERE id = '" + kode + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);
                conn.Close();

                DataTable dt = new DataTable();
                sda.Fill(dt);


                //mengecek ketersediaan data
                if (dt.Rows.Count > 0)
                {
                    //jika ada menmapilkan data pada label
                    idProduct = (int)dt.Rows[0][0];
                    labelNamaProduk.Text = dt.Rows[0][1].ToString();
                    labelHargaProduk.Text = dt.Rows[0][2].ToString();
                    labelStokProduk.Text = dt.Rows[0][3].ToString();
                }
                else
                {
                    //jika tidak tersedia, menampilkan pesan tidak tersedia
                    MessageBox.Show("Produk tidak ditemukan");
                }

            }
            else { 
            }
        }

        //menghitung total bayar + diston + sub total
        private void hitungTotal() {
            int subTotal = 0;

            //melakukan looping untuk mendapatkan data pada keranjang / datagrid
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                //memvalidasi data tidak null agar tidak error
                if (dataGridView1.Rows[i].Cells["qty"].Value != null)
                {

                    //mengambil data qty dan harga produk
                    string qty = dataGridView1.Rows[i].Cells["qty"].Value.ToString();
                    string harga = dataGridView1.Rows[i].Cells["hargaProduk"].Value.ToString();

                    //melakukan penjumlahan
                    int produkTotal = Convert.ToInt32(qty) * Convert.ToInt32(harga);
                    subTotal += produkTotal;
                }

            }

            //melakukan penjumlahan dengan diskon bila ada
            int total = subTotal - diskon;

            //update view
            labelSubTotal.Text = subTotal.ToString();
            labelTotalBayar.Text = total.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string qty = tbQty.Text;

            //validasi data tidak kosong dan qtynya
            if (idProduct > 0 && qty != "")
            {
                //menyimpan data ke variable
                int qtyInt = Convert.ToInt32(qty);
                string nama = labelNamaProduk.Text;
                string stok = labelStokProduk.Text;
                int stokInt = Convert.ToInt32(stok);
                string harga = labelHargaProduk.Text;

                //memvalidasi stok apakah tersedia dengan jumlah yang dibeli
                if (stokInt >= qtyInt)
                {

                    //menambahkan prpduk dan qty pada keranjang
                    dataGridView1.Rows.Add(idProduct, nama, stok, harga, qty);

                    //memanggil fungsi produk
                    clearProduk();

                    //memanggil fugnsi hitung
                    hitungTotal();
                }
                else 
                {
                    //menampilkan pesan stok tidak mencukupi
                    MessageBox.Show("Stok tidak mencukupi");
                }
            }
            else 
            {
                //menampilkan pesan tidak ada produk yang dipilih
                MessageBox.Show("Pilih produk dan masukan jumlah yang dibeli !!!");
            }
        }

        private void btnClearProduk_Click(object sender, EventArgs e)
        {
            clearProduk();
        }

        //fungsi ini di panggil ketika cell pada datagrid di klik
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //memvalidasi urutan data row yang dipilih harus lebih dari -1, karena data dimulai dari 0
            //bila sistem memberikan data di bawah 0, maka akan dilewati
            if(e.RowIndex > -1)
            {
                //mengecek data normal atau tidak ada data null
                //menghindari null exption / error
                if (dataGridView1.Rows[e.RowIndex].Cells["qty"].Value != null)
                {
                    //mengambil data pada keranjang kemudian ditampilkan ke view produk
                    //untuk dimodifikasi
                    string qty = dataGridView1.Rows[e.RowIndex].Cells["qty"].Value.ToString();
                    string harga = dataGridView1.Rows[e.RowIndex].Cells["hargaProduk"].Value.ToString();
                    string stok = dataGridView1.Rows[e.RowIndex].Cells["stokProduk"].Value.ToString();
                    string nama = dataGridView1.Rows[e.RowIndex].Cells["namaProduk"].Value.ToString();
                    string id = dataGridView1.Rows[e.RowIndex].Cells["idProduk"].Value.ToString();

                    //menampilkan pada view
                    tbKodeProduk.Text = id;
                    labelNamaProduk.Text = nama;
                    labelHargaProduk.Text = harga;
                    labelStokProduk.Text = stok;
                    tbQty.Text = qty;
                    idProduct = Convert.ToInt32(id);
                    rowCartIndex = e.RowIndex;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //mengambil data jummlah beli kemudian di simpan ke variable qty
            string qty = tbQty.Text;

            //validasi data tidak kosong dan qtynya
            if (idProduct > 0 && qty != "" && rowCartIndex > -1)
            {
                //convert type data dari string ke int agar bisa dilakukan penjumlahan
                int qtyInt = Convert.ToInt32(qty);
                string nama = labelNamaProduk.Text;
                string harga = labelHargaProduk.Text;
                string stok = labelStokProduk.Text;

                //convert type data dari string ke int agar bisa dilakukan penjumlahan
                int stokInt = Convert.ToInt32(stok);

                if (stokInt >= qtyInt)
                {

                    //memperbarui prpduk dan qty pada keranjang
                    dataGridView1.Rows[rowCartIndex].Cells["qty"].Value = qty;
                    dataGridView1.Rows[rowCartIndex].Cells["hargaProduk"].Value = harga;
                    dataGridView1.Rows[rowCartIndex].Cells["stokProduk"].Value = stok;
                    dataGridView1.Rows[rowCartIndex].Cells["namaProduk"].Value = nama;
                    dataGridView1.Rows[rowCartIndex].Cells["idProduk"].Value = idProduct;

                    //memanggil fungsi produk
                    clearProduk();

                    //memanggil fugnsi hitung
                    hitungTotal();
                }
                else
                {
                    MessageBox.Show("Stok tidak mencukupi");
                }
            }
            else
            {
                MessageBox.Show("Pilih produk dan masukan jumlah yang dibeli !!!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //validasi data tidak kosong dan qtynya
            if (idProduct > 0 && rowCartIndex > -1)
            {
                //menghapus data
                dataGridView1.Rows.RemoveAt(rowCartIndex);

                //memanggil fungsi memperbarui data
                clearProduk();
            }
            else
            {
                MessageBox.Show("Tidak ada data untuk dihapus");
            }
        }

        private void btnAddDiskon_Click(object sender, EventArgs e)
        {
            string sDiskon = tbDiskon.Text;

            //validasi data diskon tidak kosong
            if (!string.IsNullOrEmpty(sDiskon))
            {
                //convert type data dari string ke int agar bisa dilakukan penjumlahan
                diskon = Convert.ToInt32((string)sDiskon);
                int subTotal = Convert.ToInt32((string)labelSubTotal.Text);

                //memvalidasi total belanja dan diskon
                //bila total belanja lebih kecil maka akan ditampilkan pesan
                //bawah distkon tidak dapat dipakai
                if(subTotal < diskon) {
                    MessageBox.Show("Diskon tidak boleh lebih dari total belanja");
                    tbDiskon.Text = "0";
                    diskon = 0;
                }
            }
            else {
                diskon = 0;
            }

            hitungTotal();
        }

        //fungsi ini di panggil ketika tombol simpan diklik
        private void btnSimpanTransaksi_Click(object sender, EventArgs e)
        {
            //mengambil data dan menyimpan pada variable
            DateTime selectedDateTime = dateTimePicker.Value;
            int cartSize = dataGridView1.Rows.Count;
            string subTotal = labelSubTotal.Text;
            string total = labelTotalBayar.Text;

            //data admin
            int UserId = Properties.Settings.Default.UserId;

            try {

                //memvalidasi bahwa data keranjang lebih dari 0
                //bila kurang makan kode di dalamnya tidak akan di proses
                if (cartSize > 0)
                {
                    //insert data to table transaction
                    //command untuk memasukan data ke tabel tranksactions
                    //nama table bisa di sesuaikan dengan table yang dibuat.
                    //kolom juga dapat di sesuain. namun pasktikan keynya sama
                    //OUTPUT INSERTED.id adalah perintah sql untuk setelah data disimpan sql harus memberikan output berupa id yang disimpan
                    SqlCommand cmd = new SqlCommand("INSERT INTO transactions(tanggal, sub_total, diskon, total, admin_id) OUTPUT INSERTED.id VALUES(@tanggal, @sub_total, @diskon, @total, @admin_id)", conn);
                    cmd.Parameters.AddWithValue("@tanggal", selectedDateTime);
                    cmd.Parameters.AddWithValue("@sub_total", subTotal);
                    cmd.Parameters.AddWithValue("@diskon", diskon);
                    cmd.Parameters.AddWithValue("@total", total);
                    cmd.Parameters.AddWithValue("@admin_id", UserId);
                    conn.Open();

                    //mengambil id setelah menambahkan data transaksi
                    object result = cmd.ExecuteScalar();
                    int transactionId = Convert.ToInt32(result);

                    //loop cart
                    //melakukan perulangan pada data keranjang
                    //untuk menambahkan data pada detail transaksi
                    //dan memperbarui stok produk
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        if (dataGridView1.Rows[i].Cells["qty"].Value != null)
                        {

                            //menyimpan data pada variable
                            string qty = dataGridView1.Rows[i].Cells["qty"].Value.ToString();
                            string harga = dataGridView1.Rows[i].Cells["hargaProduk"].Value.ToString();
                            string stok = dataGridView1.Rows[i].Cells["stokProduk"].Value.ToString();
                            string idProduk = dataGridView1.Rows[i].Cells["idProduk"].Value.ToString();

                            //insert data to table transaction detail
                            SqlCommand sqlCommand = new SqlCommand("INSERT INTO transaction_details(transaction_id, product_id, qty, price) VALUES(@transaction_id, @product_id, @qty, @price)", conn);
                            sqlCommand.Parameters.AddWithValue("@transaction_id", transactionId);
                            sqlCommand.Parameters.AddWithValue("@product_id", idProduk);
                            sqlCommand.Parameters.AddWithValue("@qty", qty);
                            sqlCommand.Parameters.AddWithValue("@price", harga);

                            //mengeksekusi perintah insert data ke table detail transasksi
                            sqlCommand.ExecuteNonQuery();

                            //update stok pada produk
                            int currentStok = Convert.ToInt32(stok) - Convert.ToInt32(qty);
                            SqlCommand sqlCommandUpdateStock = new SqlCommand("UPDATE product SET stok = @stok WHERE id = @id ", conn);
                            sqlCommandUpdateStock.Parameters.AddWithValue("@stok", currentStok);
                            sqlCommandUpdateStock.Parameters.AddWithValue("@id", idProduk);

                            //mengkesekusi perintah
                            sqlCommandUpdateStock.ExecuteNonQuery();
                        }
                    }

                    //menutup koneksi ke database kembali
                    conn.Close();

                    //jika tranksasi Id yang tersimpan lebih dari 0
                    //asumsi data berhasil tersimpan
                    //dan menampilkan pesan tranksasi tersimpan
                    //dan membersihkan data inputan user
                    if (transactionId > 0)
                    {
                        MessageBox.Show("Transaksi telah tersimpan");
                        clearProduk();
                        diskon = 0;
                        tbDiskon.Text = "0";
                        dataGridView1.Rows.Clear();
                        labelSubTotal.Text = "0";
                        labelTotalBayar.Text = "0";

                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan transaksi");

                    }

                }
                else
                {
                    MessageBox.Show("Tidak ada transaksi untuk di proses");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

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
