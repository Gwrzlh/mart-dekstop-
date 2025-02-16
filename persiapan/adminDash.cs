using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using persiapan;


namespace persiapan
{
    public partial class adminDash : Form
    {
        string connectionString = "server=localhost;database=lksmart;user=root;password=;";
        //private int userId;

        public adminDash( )
        {

            InitializeComponent();
            //userId = idUser;
            MySqlConnection con = new MySqlConnection(connectionString);
        }

        private void adminDash_Load(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    string show = "SELECT log.id_log, user.nama, log.waktu, log.aktivitas FROM log INNER JOIN user ON log.id_user = user.id_user";
                    MySqlCommand cmd = new MySqlCommand(show, con);
                    MySqlDataAdapter dap = new MySqlDataAdapter(cmd);

                    DataTable dat = new DataTable();
                    dap .Fill(dat);

                    dataGridView1.DataSource = dat;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;



                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
             string dariTanggal = DariTanggal.Value.ToString("yyy-MM-dd");
             string sampaiTanggal = SampaiTanggal.Value.ToString("yyy-MM-dd");
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string filter = "SELECT * FROM log WHERE DATE(waktu) BETWEEN @daritanggal AND @sampaiTanggal";
                    MySqlCommand cmdFilter = new MySqlCommand(filter, con);
                    cmdFilter.Parameters.AddWithValue("@daritanggal", dariTanggal);
                    cmdFilter.Parameters.AddWithValue("@sampaiTanggal", sampaiTanggal);
                    MySqlDataAdapter dapfil = new MySqlDataAdapter(cmdFilter);

                    DataTable fil = new DataTable();
                    dapfil.Fill(fil);

                    dataGridView1.DataSource = fil;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }

        }

        private void DariTanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void SampaiTanggal_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            lougout();
        }
        private void lougout()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                int PrimaryKey = Form1.IdUser ;
                string deep = "SELECT * FROM user WHERE id_user = @PrimaryKey";
                MySqlCommand cmddeep = new MySqlCommand(deep, con);
                cmddeep.Parameters.AddWithValue("@PrimaryKey", PrimaryKey);
                MySqlDataReader reader = cmddeep.ExecuteReader();

                if (reader.Read())
                {

                    int idUser = reader.GetInt32("id_user");
                    reader.Close();

                    string log = "INSERT INTO log (waktu, aktivitas, id_user) VALUES (NOW(), @aktiv, @id_user)";
                    MySqlCommand logcmd = new MySqlCommand(log, con);
                    logcmd.Parameters.AddWithValue("@aktiv", "Logout");
                    logcmd.Parameters.AddWithValue("@id_user", idUser);
                    logcmd.ExecuteNonQuery();

                    this.Hide();
                    Form1 f = new Form1();
                    f.Show();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Laporan lap = new Laporan();
            lap.Show();
        }

        private void KelolaUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 kelolaUser = new Form2();
            kelolaUser.Show();
        }

        private void LogActivity_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
