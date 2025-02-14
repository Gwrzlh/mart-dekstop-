using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MySql.Data.MySqlClient;
//using persiapan;
using System.Security.Cryptography.X509Certificates;

namespace persiapan
{
    public partial class Form1 : Form
    {

        string connectionString = "server=localhost;database=lksmart;user=root;password=;";
        public static int IdUser { get; set; }



        public Form1()
        {
            InitializeComponent();
            MySqlConnection Connection = new MySqlConnection(connectionString);


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text;
            string password = textBox2.Text;

            login(email, password);

        }
        private void login(string email,string password)
        {

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM user WHERE email = @email AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        //MessageBox.Show("selamat datang login anda berhasil");
                        IdUser = reader.GetInt32("id_user");

                        

                        string tipeuser = reader.GetString("tipe_user");
                        reader.Close();

                        string log = "INSERT INTO log (waktu, aktivitas, id_user) VALUES (NOW(), @aktivitas, @id_user)";
                        using (MySqlCommand logcmd = new MySqlCommand(log, connection))
                        {
                            logcmd.Parameters.AddWithValue("@aktivitas", "Login");
                            logcmd.Parameters.AddWithValue("@id_user", IdUser);
                            logcmd.ExecuteNonQuery();  
                        }
                        
                        
                        if (tipeuser == "admin")
                        {
                            MessageBox.Show("Selamat datang admin");
                            this.Hide();
                            adminDash admin = new adminDash();
                            admin.Show();
                        }
                        else if (tipeuser == "gudang")
                        {
                            MessageBox.Show("Selamat datang gudang");

                        }else if(tipeuser == "kasir")
                        {
                            MessageBox.Show("Selamat datang kasir");
                        }
                        else
                        {
                            MessageBox.Show("Tipe user tidak ditemukan");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sepertinya ada kesalaahan saat anda memasukkan password atau email salah");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            regists reg = new regists();
            reg.Show();
        }
    }
}
