namespace persiapan
{
    partial class adminDash
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DariTanggal = new System.Windows.Forms.DateTimePicker();
            this.SampaiTanggal = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.KelolaUser = new System.Windows.Forms.Button();
            this.KelolaLaporan = new System.Windows.Forms.Button();
            this.LogActivity = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ADMIN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log Activity";
            // 
            // DariTanggal
            // 
            this.DariTanggal.Location = new System.Drawing.Point(280, 114);
            this.DariTanggal.Name = "DariTanggal";
            this.DariTanggal.Size = new System.Drawing.Size(93, 22);
            this.DariTanggal.TabIndex = 2;
            this.DariTanggal.ValueChanged += new System.EventHandler(this.DariTanggal_ValueChanged);
            // 
            // SampaiTanggal
            // 
            this.SampaiTanggal.Location = new System.Drawing.Point(404, 114);
            this.SampaiTanggal.Name = "SampaiTanggal";
            this.SampaiTanggal.Size = new System.Drawing.Size(93, 22);
            this.SampaiTanggal.TabIndex = 3;
            this.SampaiTanggal.ValueChanged += new System.EventHandler(this.SampaiTanggal_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Dari tanggal";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sampai Tanggal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(267, 172);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(521, 238);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 403);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(75, 35);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // KelolaUser
            // 
            this.KelolaUser.Location = new System.Drawing.Point(57, 214);
            this.KelolaUser.Name = "KelolaUser";
            this.KelolaUser.Size = new System.Drawing.Size(115, 23);
            this.KelolaUser.TabIndex = 10;
            this.KelolaUser.Text = "kelola User";
            this.KelolaUser.UseVisualStyleBackColor = true;
            this.KelolaUser.Click += new System.EventHandler(this.KelolaUser_Click);
            // 
            // KelolaLaporan
            // 
            this.KelolaLaporan.Location = new System.Drawing.Point(57, 264);
            this.KelolaLaporan.Name = "KelolaLaporan";
            this.KelolaLaporan.Size = new System.Drawing.Size(115, 23);
            this.KelolaLaporan.TabIndex = 11;
            this.KelolaLaporan.Text = "kelola laporan";
            this.KelolaLaporan.UseVisualStyleBackColor = true;
            this.KelolaLaporan.Click += new System.EventHandler(this.button3_Click);
            // 
            // LogActivity
            // 
            this.LogActivity.Location = new System.Drawing.Point(57, 316);
            this.LogActivity.Name = "LogActivity";
            this.LogActivity.Size = new System.Drawing.Size(115, 31);
            this.LogActivity.TabIndex = 12;
            this.LogActivity.Text = "Log activity";
            this.LogActivity.UseVisualStyleBackColor = true;
            this.LogActivity.Click += new System.EventHandler(this.LogActivity_Click);
            // 
            // adminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogActivity);
            this.Controls.Add(this.KelolaLaporan);
            this.Controls.Add(this.KelolaUser);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SampaiTanggal);
            this.Controls.Add(this.DariTanggal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "adminDash";
            this.Text = "adminDash";
            this.Load += new System.EventHandler(this.adminDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DariTanggal;
        private System.Windows.Forms.DateTimePicker SampaiTanggal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button KelolaUser;
        private System.Windows.Forms.Button KelolaLaporan;
        private System.Windows.Forms.Button LogActivity;
    }
}