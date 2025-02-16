using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace persiapan
{
    public partial class Laporan : Form
    {
        string connectionString = "server=localhost;database=lksmart;user=root;password=;";
        private BindingSource bindingSource1 = new BindingSource();
        public Laporan()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void loadData()
        {
            using (MySqlConnection connect = new MySqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string usershow = "SELECT * FROM transaksi ";
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
        private void filter()
        {
            string dariTanggal = DariTanggal.Value.ToString("yyy-MM-dd");
            string sampaiTanggal = SampaiTanggal.Value.ToString("yyy-MM-dd");
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                try
                {
                    con.Open();

                    string filter = "SELECT * FROM transaksi WHERE DATE(tgl_transaksi) BETWEEN @daritanggal AND @sampaiTanggal";
                    MySqlCommand cmdFilter = new MySqlCommand(filter, con);
                    cmdFilter.Parameters.AddWithValue("@daritanggal", dariTanggal);
                    cmdFilter.Parameters.AddWithValue("@sampaiTanggal", sampaiTanggal);
                    MySqlDataAdapter dapfil = new MySqlDataAdapter(cmdFilter);

                    DataTable fil = new DataTable();
                    dapfil.Fill(fil);

                    dataGridView1.DataSource = fil;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message);
                }
            }
        }
        private void generate()
        {
            if(dataGridView1 == null)
            {
                MessageBox.Show("Data Kosong");
                return;
            }

            chart1.Series.Clear();

            if (chart1.ChartAreas.Count == 0)
            {
                chart1.ChartAreas.Add(new ChartArea("Default"));
            }
            Series seriesChart = new Series("transaksi");
            seriesChart.ChartType = SeriesChartType.Bar;
            seriesChart.XValueType = ChartValueType.DateTime;
            seriesChart.YValueType = ChartValueType.Int32;

            DataTable dt = bindingSource1.DataSource as DataTable;


            foreach (DataRow dr in dt.Rows)
            {
               DateTime tanggal = Convert.ToDateTime(dr["tgl_transaksi"]);
                int total = Convert.ToInt32(dr["total"]);
                seriesChart.Points.AddXY(tanggal, total);

                seriesChart.Points.AddXY(tanggal, total);
            }

          chart1.Series.Add(seriesChart);


        }

        private void generatebutton_Click(object sender, EventArgs e)
        {
            generate();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Laporan_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter();
        }
    }  
}
