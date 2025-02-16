using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace persiapan
{
    public partial class Form2 : Form
    {

        private BindingSource bindingSource1 = new BindingSource();

        string connectionString = "server=localhost;database=lksmart;user=root;password=;";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            comboTipeuser.Items.Add("admin");
            comboTipeuser.Items.Add("gudang");
            comboTipeuser.Items.Add("kasir");

            loadData();

        }

        private void comboTipeuser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];


                NamaTextBox.Text = row.Cells["nama"].Value.ToString();
                EmailTextBox.Text = row.Cells["email"].Value.ToString();
                PasswordTextBox.Text = row.Cells["password"].Value.ToString();
                comboTipeuser.Text = row.Cells["tipe_user"].Value.ToString();
                NomorTexBox.Text = row.Cells["telepon"].Value.ToString();
                AlamatTextBox.Text = row.Cells["alamat"].Value.ToString();
            }
        }
        private void edit()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string id = dataGridView1.CurrentRow.Cells["id_user"].Value.ToString();

                con.Open();
                string update = "UPDATE user SET nama = @nama, email= @email, telepon = @telepon, alamat = @alamat, tipe_user = @tipeUser, password = @pass WHERE id_user = @id_user";
                MySqlCommand cmd = new MySqlCommand(update, con);
                cmd.Parameters.AddWithValue("@nama", NamaTextBox.Text);
                cmd.Parameters.AddWithValue("@email", EmailTextBox.Text);
                cmd.Parameters.AddWithValue("@telepon", NomorTexBox.Text);
                cmd.Parameters.AddWithValue("@alamat", AlamatTextBox.Text);
                cmd.Parameters.AddWithValue("@tipeUser", comboTipeuser.Text);
                cmd.Parameters.AddWithValue("@pass", PasswordTextBox.Text);
                cmd.Parameters.AddWithValue("@id_user", id);
                cmd.ExecuteNonQuery();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Data Berhasil Diubah");
                    loadData();

                }
                else
                {
                    MessageBox.Show("Data Gagal Diubah");
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            edit();
        }

        private void LogActivity_Click(object sender, EventArgs e)
        {
            this.Hide();
            adminDash log = new adminDash();
            log.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Misal bindingSource adalah instance BindingSource yang menjadi DataSource untuk DataGridView

        }
        private void loadData()
        {

            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string usershow = "SELECT * FROM user";
                    MySqlCommand cmd = new MySqlCommand(usershow, connect);
                    MySqlDataAdapter user = new MySqlDataAdapter(cmd);
                    DataTable tableGrid = new DataTable();
                    user.Fill(tableGrid);

                    bindingSource1.DataSource = tableGrid;
                    dataGridView1.DataSource = bindingSource1;


                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }

            }
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();
                int PrimaryKey = Form1.IdUser;
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

        private void SearchBar_Click(object sender, EventArgs e)
        {
            search();   
        }
        private void search()
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open();

                string keyword = searchTextBox.Text.Trim();
                string search = "SELECT * FROM user WHERE nama LIKE @search";
                MySqlCommand searchcmd = new MySqlCommand(search, con);
                searchcmd.Parameters.AddWithValue("@search", "%" + keyword + "%");
                MySqlDataAdapter dap = new MySqlDataAdapter(searchcmd);
                DataTable dt = new DataTable();
                dap.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
