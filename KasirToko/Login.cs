using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KasirToko
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text;
            string password = tbPassword.Text;

            //validasi bila form tidak kosong
            if (username != "" && password != "")
            {

                //membuat koneksi ke database
                string koneksi = "Data Source=MYBOOKPROK7V;Initial Catalog=tokoonline;Integrated Security=True";
                SqlConnection conn = new SqlConnection(koneksi);

                //query untuk mengecek adakan nama dan password yang dinputkan user di dabtase
                string query = "SELECT * FROM admins WHERE nama = '" + username + "' AND password = '" + password + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dt = new DataTable();
                sda.Fill(dt);


                //bila row atau data di ambil lebih dari 0, maka asumsinya ada data pada database
                if(dt.Rows.Count > 0)
                {
                    //Berhasil login

                    //Menyimpan data user;
                    //PERHATIKAN : pastikan sudah menampilkan variabel, Username, Role UserId 
                    //pada Properties - Settings.settings
                    Properties.Settings.Default.Username = username;
                    Properties.Settings.Default.Role = dt.Rows[0][3].ToString();
                    Properties.Settings.Default.UserId = (int)dt.Rows[0][0];
                    Properties.Settings.Default.Save();

                    //berpindah form ke main menu
                    MainMenu mainMenu = new MainMenu();
                    this.Hide();
                    mainMenu.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah");
                }
            }
            else
            {
                MessageBox.Show("Username dan password tidak boleh kosong");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
