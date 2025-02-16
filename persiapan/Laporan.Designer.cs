namespace persiapan
{
    partial class Laporan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.LogActivity = new System.Windows.Forms.Button();
            this.KelolaLaporan = new System.Windows.Forms.Button();
            this.KelolaUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SampaiTanggal = new System.Windows.Forms.DateTimePicker();
            this.DariTanggal = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.generatebutton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(13, 400);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(85, 34);
            this.LogoutButton.TabIndex = 45;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            // 
            // LogActivity
            // 
            this.LogActivity.Location = new System.Drawing.Point(61, 292);
            this.LogActivity.Name = "LogActivity";
            this.LogActivity.Size = new System.Drawing.Size(115, 31);
            this.LogActivity.TabIndex = 44;
            this.LogActivity.Text = "Log activity";
            this.LogActivity.UseVisualStyleBackColor = true;
            // 
            // KelolaLaporan
            // 
            this.KelolaLaporan.Location = new System.Drawing.Point(61, 240);
            this.KelolaLaporan.Name = "KelolaLaporan";
            this.KelolaLaporan.Size = new System.Drawing.Size(115, 23);
            this.KelolaLaporan.TabIndex = 43;
            this.KelolaLaporan.Text = "kelola laporan";
            this.KelolaLaporan.UseVisualStyleBackColor = true;
            // 
            // KelolaUser
            // 
            this.KelolaUser.Location = new System.Drawing.Point(61, 190);
            this.KelolaUser.Name = "KelolaUser";
            this.KelolaUser.Size = new System.Drawing.Size(115, 23);
            this.KelolaUser.TabIndex = 42;
            this.KelolaUser.Text = "kelola User";
            this.KelolaUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 41;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 46;
            this.label2.Text = "Laporan";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "Table Transaksi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 52;
            this.label4.Text = "Sampai Tanggal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(463, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Dari tanggal";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 82);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SampaiTanggal
            // 
            this.SampaiTanggal.Location = new System.Drawing.Point(590, 83);
            this.SampaiTanggal.Name = "SampaiTanggal";
            this.SampaiTanggal.Size = new System.Drawing.Size(93, 22);
            this.SampaiTanggal.TabIndex = 49;
            // 
            // DariTanggal
            // 
            this.DariTanggal.Location = new System.Drawing.Point(466, 83);
            this.DariTanggal.Name = "DariTanggal";
            this.DariTanggal.Size = new System.Drawing.Size(93, 22);
            this.DariTanggal.TabIndex = 48;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(260, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(542, 181);
            this.dataGridView1.TabIndex = 53;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // generatebutton
            // 
            this.generatebutton.Location = new System.Drawing.Point(484, 289);
            this.generatebutton.Name = "generatebutton";
            this.generatebutton.Size = new System.Drawing.Size(85, 31);
            this.generatebutton.TabIndex = 54;
            this.generatebutton.Text = "Generate";
            this.generatebutton.UseVisualStyleBackColor = true;
            this.generatebutton.Click += new System.EventHandler(this.generatebutton_Click);
            // 
            // chart1
            // 
            chartArea5.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart1.Legends.Add(legend5);
            this.chart1.Location = new System.Drawing.Point(260, 326);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart1.Series.Add(series5);
            this.chart1.Size = new System.Drawing.Size(542, 134);
            this.chart1.TabIndex = 55;
            this.chart1.Text = "chart1";
            // 
            // Laporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.generatebutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SampaiTanggal);
            this.Controls.Add(this.DariTanggal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.LogActivity);
            this.Controls.Add(this.KelolaLaporan);
            this.Controls.Add(this.KelolaUser);
            this.Controls.Add(this.label1);
            this.Name = "Laporan";
            this.Text = "Laporan";
            this.Load += new System.EventHandler(this.Laporan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button LogActivity;
        private System.Windows.Forms.Button KelolaLaporan;
        private System.Windows.Forms.Button KelolaUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker SampaiTanggal;
        private System.Windows.Forms.DateTimePicker DariTanggal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button generatebutton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}