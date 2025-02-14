using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace persiapan
{    
    public partial class regists : Form
    {
        string connectionString = "server=localhost;database=lksmart;user=root;password=;";

        public regists()
        {
            InitializeComponent();
            MySqlConnection Connection = new MySqlConnection(connectionString);
        }

        private void regists_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("admin");
            comboBox1.Items.Add("gudang");
            comboBox1.Items.Add("kasir");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Nama = NamatextBox.Text;
            string Email = EmailTextBox.Text;
            string Password = passwordTextBox.Text;
            string alamat = AlamatTextBox.Text;
            string telp = TlptextBox.Text;
            string role = comboBox1.SelectedItem.ToString();

            regist(Nama, Email, Password, alamat, telp, role);

        }
        private void regist(string Nama, string Email, string Password,string alamat, string telp, string role)
        {
            using (MySqlConnection Connection = new MySqlConnection(connectionString))
            {
                try
                {
                    Connection.Open();

                    string insert = "INSERT INTO user(tipe_user,nama,alamat,telepon,password,email) VALUES(@role,@Nama,@alamat,@telp,@Password,@Email)";
                    MySqlCommand cmd = new MySqlCommand(insert, Connection);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@Nama", Nama);
                    cmd.Parameters.AddWithValue("@alamat", alamat);
                    cmd.Parameters.AddWithValue("@telp", telp);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@Email", Email);

                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Registrasi Berhasil");
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Registrasi Gagal");
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void NamatextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
