namespace persiapan
{
    partial class Form2
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
            this.LogActivity = new System.Windows.Forms.Button();
            this.KelolaLaporan = new System.Windows.Forms.Button();
            this.KelolaUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NamaTextBox = new System.Windows.Forms.TextBox();
            this.NomorTexBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AlamatTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboTipeuser = new System.Windows.Forms.ComboBox();
            this.TambahButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SearchBar = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LogActivity
            // 
            this.LogActivity.Location = new System.Drawing.Point(60, 296);
            this.LogActivity.Name = "LogActivity";
            this.LogActivity.Size = new System.Drawing.Size(115, 31);
            this.LogActivity.TabIndex = 16;
            this.LogActivity.Text = "Log activity";
            this.LogActivity.UseVisualStyleBackColor = true;
            this.LogActivity.Click += new System.EventHandler(this.LogActivity_Click);
            // 
            // KelolaLaporan
            // 
            this.KelolaLaporan.Location = new System.Drawing.Point(60, 244);
            this.KelolaLaporan.Name = "KelolaLaporan";
            this.KelolaLaporan.Size = new System.Drawing.Size(115, 23);
            this.KelolaLaporan.TabIndex = 15;
            this.KelolaLaporan.Text = "kelola laporan";
            this.KelolaLaporan.UseVisualStyleBackColor = true;
            // 
            // KelolaUser
            // 
            this.KelolaUser.Location = new System.Drawing.Point(60, 194);
            this.KelolaUser.Name = "KelolaUser";
            this.KelolaUser.Size = new System.Drawing.Size(115, 23);
            this.KelolaUser.TabIndex = 14;
            this.KelolaUser.Text = "kelola User";
            this.KelolaUser.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "ADMIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Tipe user";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nama";
            // 
            // NamaTextBox
            // 
            this.NamaTextBox.Location = new System.Drawing.Point(270, 95);
            this.NamaTextBox.Name = "NamaTextBox";
            this.NamaTextBox.Size = new System.Drawing.Size(179, 22);
            this.NamaTextBox.TabIndex = 20;
            // 
            // NomorTexBox
            // 
            this.NomorTexBox.Location = new System.Drawing.Point(270, 139);
            this.NomorTexBox.Name = "NomorTexBox";
            this.NomorTexBox.Size = new System.Drawing.Size(179, 22);
            this.NomorTexBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(267, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Nomor telepon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(267, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Alamat";
            // 
            // AlamatTextBox
            // 
            this.AlamatTextBox.Location = new System.Drawing.Point(270, 183);
            this.AlamatTextBox.Name = "AlamatTextBox";
            this.AlamatTextBox.Size = new System.Drawing.Size(179, 22);
            this.AlamatTextBox.TabIndex = 24;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(526, 47);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(179, 22);
            this.EmailTextBox.TabIndex = 25;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(526, 95);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(179, 22);
            this.PasswordTextBox.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Password";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 32;
            this.label9.Text = "Email";
            // 
            // comboTipeuser
            // 
            this.comboTipeuser.FormattingEnabled = true;
            this.comboTipeuser.Location = new System.Drawing.Point(270, 47);
            this.comboTipeuser.Name = "comboTipeuser";
            this.comboTipeuser.Size = new System.Drawing.Size(121, 24);
            this.comboTipeuser.TabIndex = 33;
            this.comboTipeuser.SelectedIndexChanged += new System.EventHandler(this.comboTipeuser_SelectedIndexChanged);
            // 
            // TambahButton
            // 
            this.TambahButton.Location = new System.Drawing.Point(526, 138);
            this.TambahButton.Name = "TambahButton";
            this.TambahButton.Size = new System.Drawing.Size(75, 23);
            this.TambahButton.TabIndex = 34;
            this.TambahButton.Text = "Tambah";
            this.TambahButton.UseVisualStyleBackColor = true;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(607, 139);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 35;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(688, 139);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 36;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(270, 265);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(526, 184);
            this.dataGridView1.TabIndex = 37;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(589, 237);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(126, 22);
            this.searchTextBox.TabIndex = 38;
            this.searchTextBox.TextChanged += new System.EventHandler(this.search_TextChanged);
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(721, 236);
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(75, 23);
            this.SearchBar.TabIndex = 39;
            this.SearchBar.Text = "Search";
            this.SearchBar.UseVisualStyleBackColor = true;
            this.SearchBar.Click += new System.EventHandler(this.SearchBar_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(12, 404);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(85, 34);
            this.LogoutButton.TabIndex = 40;
            this.LogoutButton.Text = "Logout";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.SearchBar);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.TambahButton);
            this.Controls.Add(this.comboTipeuser);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.AlamatTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NomorTexBox);
            this.Controls.Add(this.NamaTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LogActivity);
            this.Controls.Add(this.KelolaLaporan);
            this.Controls.Add(this.KelolaUser);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "KelolaUser";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LogActivity;
        private System.Windows.Forms.Button KelolaLaporan;
        private System.Windows.Forms.Button KelolaUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NamaTextBox;
        private System.Windows.Forms.TextBox NomorTexBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AlamatTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboTipeuser;
        private System.Windows.Forms.Button TambahButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button SearchBar;
        private System.Windows.Forms.Button LogoutButton;
    }
}