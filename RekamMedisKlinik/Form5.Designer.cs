namespace RekamMedisKlinik
{
    partial class FormChildDokter
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
            panelChildTopDokter = new Panel();
            panelChildTopRightDokter = new Panel();
            panelChildTopLeftDokter = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label11 = new Label();
            textBox1 = new TextBox();
            label7 = new Label();
            label10 = new Label();
            radioPerempuan = new RadioButton();
            radioLakiLaki = new RadioButton();
            label6 = new Label();
            label17 = new Label();
            label16 = new Label();
            label9 = new Label();
            btnReset = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            cmbAkun = new ComboBox();
            label5 = new Label();
            txtNama = new TextBox();
            btnHapus = new FontAwesome.Sharp.IconButton();
            btnSunting = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            btnTambah = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            txtSearch = new TextBox();
            dtGridDokter = new DataGridView();
            label13 = new Label();
            label14 = new Label();
            panelChildTopDokter.SuspendLayout();
            panelChildTopLeftDokter.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridDokter).BeginInit();
            SuspendLayout();
            // 
            // panelChildTopDokter
            // 
            panelChildTopDokter.Controls.Add(panelChildTopRightDokter);
            panelChildTopDokter.Controls.Add(panelChildTopLeftDokter);
            panelChildTopDokter.Dock = DockStyle.Top;
            panelChildTopDokter.Location = new Point(0, 0);
            panelChildTopDokter.Name = "panelChildTopDokter";
            panelChildTopDokter.Size = new Size(1100, 93);
            panelChildTopDokter.TabIndex = 2;
            // 
            // panelChildTopRightDokter
            // 
            panelChildTopRightDokter.Dock = DockStyle.Right;
            panelChildTopRightDokter.Location = new Point(900, 0);
            panelChildTopRightDokter.Name = "panelChildTopRightDokter";
            panelChildTopRightDokter.Size = new Size(200, 93);
            panelChildTopRightDokter.TabIndex = 1;
            // 
            // panelChildTopLeftDokter
            // 
            panelChildTopLeftDokter.Controls.Add(label2);
            panelChildTopLeftDokter.Controls.Add(label1);
            panelChildTopLeftDokter.Dock = DockStyle.Left;
            panelChildTopLeftDokter.Location = new Point(0, 0);
            panelChildTopLeftDokter.Name = "panelChildTopLeftDokter";
            panelChildTopLeftDokter.Size = new Size(274, 93);
            panelChildTopLeftDokter.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 209, 7);
            label2.Location = new Point(20, 24);
            label2.Name = "label2";
            label2.Size = new Size(113, 15);
            label2.TabIndex = 1;
            label2.Text = "Kelola Data Dokter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 63, 98);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(106, 37);
            label1.TabIndex = 0;
            label1.Text = "Dokter";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 93);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1100, 537);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(radioPerempuan);
            panel2.Controls.Add(radioLakiLaki);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmbAkun);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtNama);
            panel2.Controls.Add(btnHapus);
            panel2.Controls.Add(btnSunting);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnTambah);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(20, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 491);
            panel2.TabIndex = 15;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label11.ForeColor = Color.FromArgb(4, 63, 98);
            label11.Location = new Point(23, 259);
            label11.Name = "label11";
            label11.Size = new Size(52, 17);
            label11.TabIndex = 31;
            label11.Text = "Alamat";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(24, 289);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(478, 80);
            textBox1.TabIndex = 30;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(252, 0, 0);
            label7.Location = new Point(355, 182);
            label7.Name = "label7";
            label7.Size = new Size(13, 13);
            label7.TabIndex = 29;
            label7.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(4, 63, 98);
            label10.Location = new Point(264, 177);
            label10.Name = "label10";
            label10.Size = new Size(93, 17);
            label10.TabIndex = 28;
            label10.Text = "Jenis Kelamin";
            // 
            // radioPerempuan
            // 
            radioPerempuan.AutoSize = true;
            radioPerempuan.Location = new Point(352, 206);
            radioPerempuan.Name = "radioPerempuan";
            radioPerempuan.Size = new Size(86, 19);
            radioPerempuan.TabIndex = 27;
            radioPerempuan.TabStop = true;
            radioPerempuan.Text = "perempuan";
            radioPerempuan.UseVisualStyleBackColor = true;
            radioPerempuan.CheckedChanged += radioPerempuan_CheckedChanged;
            // 
            // radioLakiLaki
            // 
            radioLakiLaki.AutoSize = true;
            radioLakiLaki.Location = new Point(265, 206);
            radioLakiLaki.Name = "radioLakiLaki";
            radioLakiLaki.Size = new Size(66, 19);
            radioLakiLaki.TabIndex = 26;
            radioLakiLaki.TabStop = true;
            radioLakiLaki.Text = "laki-laki";
            radioLakiLaki.UseVisualStyleBackColor = true;
            radioLakiLaki.CheckedChanged += radioLakiLaki_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(252, 0, 0);
            label6.Location = new Point(22, 144);
            label6.Name = "label6";
            label6.Size = new Size(226, 13);
            label6.TabIndex = 25;
            label6.Text = "Pastikan akun pengguna sudah di pilih!";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(252, 0, 0);
            label17.Location = new Point(109, 181);
            label17.Name = "label17";
            label17.Size = new Size(13, 13);
            label17.TabIndex = 24;
            label17.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(252, 0, 0);
            label16.Location = new Point(163, 83);
            label16.Name = "label16";
            label16.Size = new Size(13, 13);
            label16.TabIndex = 23;
            label16.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(252, 0, 0);
            label9.Location = new Point(22, 406);
            label9.Name = "label9";
            label9.Size = new Size(161, 13);
            label9.TabIndex = 15;
            label9.Text = "Pastikan data diisi dengan benar!";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.FromArgb(126, 209, 7);
            btnReset.Cursor = Cursors.Hand;
            btnReset.FlatAppearance.BorderSize = 0;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReset.ForeColor = Color.White;
            btnReset.IconChar = FontAwesome.Sharp.IconChar.RotateRight;
            btnReset.IconColor = SystemColors.Window;
            btnReset.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReset.IconSize = 20;
            btnReset.Location = new Point(456, 439);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(46, 34);
            btnReset.TabIndex = 14;
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label8.ForeColor = Color.FromArgb(4, 63, 98);
            label8.Location = new Point(23, 80);
            label8.Name = "label8";
            label8.Size = new Size(134, 17);
            label8.TabIndex = 13;
            label8.Text = "Cari Akun Pengguna";
            // 
            // cmbAkun
            // 
            cmbAkun.BackColor = Color.FromArgb(230, 231, 233);
            cmbAkun.FlatStyle = FlatStyle.Flat;
            cmbAkun.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            cmbAkun.FormattingEnabled = true;
            cmbAkun.Location = new Point(22, 109);
            cmbAkun.Name = "cmbAkun";
            cmbAkun.Size = new Size(486, 24);
            cmbAkun.TabIndex = 12;
            cmbAkun.SelectedIndexChanged += cmbAkun_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 63, 98);
            label5.Location = new Point(21, 177);
            label5.Name = "label5";
            label5.Size = new Size(90, 17);
            label5.TabIndex = 7;
            label5.Text = "Nama Dokter";
            // 
            // txtNama
            // 
            txtNama.BackColor = Color.FromArgb(230, 231, 233);
            txtNama.BorderStyle = BorderStyle.None;
            txtNama.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNama.Location = new Point(22, 204);
            txtNama.Multiline = true;
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(216, 28);
            txtNama.TabIndex = 6;
            txtNama.TextChanged += txtNama_TextChanged;
            // 
            // btnHapus
            // 
            btnHapus.BackColor = Color.FromArgb(252, 0, 0);
            btnHapus.Cursor = Cursors.Hand;
            btnHapus.FlatAppearance.BorderSize = 0;
            btnHapus.FlatStyle = FlatStyle.Flat;
            btnHapus.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHapus.ForeColor = Color.White;
            btnHapus.IconChar = FontAwesome.Sharp.IconChar.Close;
            btnHapus.IconColor = SystemColors.Window;
            btnHapus.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnHapus.IconSize = 20;
            btnHapus.Location = new Point(24, 435);
            btnHapus.Name = "btnHapus";
            btnHapus.Padding = new Padding(10, 0, 0, 0);
            btnHapus.Size = new Size(134, 34);
            btnHapus.TabIndex = 5;
            btnHapus.Text = "Hapus";
            btnHapus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHapus.UseVisualStyleBackColor = false;
            btnHapus.Click += btnHapus_Click;
            // 
            // btnSunting
            // 
            btnSunting.BackColor = Color.FromArgb(252, 170, 13);
            btnSunting.Cursor = Cursors.Hand;
            btnSunting.FlatAppearance.BorderSize = 0;
            btnSunting.FlatStyle = FlatStyle.Flat;
            btnSunting.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSunting.ForeColor = Color.White;
            btnSunting.IconChar = FontAwesome.Sharp.IconChar.Marker;
            btnSunting.IconColor = SystemColors.Window;
            btnSunting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSunting.IconSize = 20;
            btnSunting.Location = new Point(167, 436);
            btnSunting.Name = "btnSunting";
            btnSunting.Padding = new Padding(10, 0, 0, 0);
            btnSunting.Size = new Size(133, 34);
            btnSunting.TabIndex = 4;
            btnSunting.Text = "Sunting";
            btnSunting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSunting.UseVisualStyleBackColor = false;
            btnSunting.Click += btnSunting_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(126, 209, 7);
            label4.Location = new Point(17, 34);
            label4.Name = "label4";
            label4.Size = new Size(150, 13);
            label4.TabIndex = 2;
            label4.Text = "Tambah Atau Sunting Data.";
            // 
            // btnTambah
            // 
            btnTambah.BackColor = Color.FromArgb(4, 63, 98);
            btnTambah.Cursor = Cursors.Hand;
            btnTambah.FlatAppearance.BorderSize = 0;
            btnTambah.FlatStyle = FlatStyle.Flat;
            btnTambah.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTambah.ForeColor = Color.White;
            btnTambah.IconChar = FontAwesome.Sharp.IconChar.Add;
            btnTambah.IconColor = SystemColors.Window;
            btnTambah.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnTambah.IconSize = 23;
            btnTambah.Location = new Point(309, 438);
            btnTambah.Name = "btnTambah";
            btnTambah.Padding = new Padding(10, 0, 0, 0);
            btnTambah.Size = new Size(135, 34);
            btnTambah.TabIndex = 3;
            btnTambah.Text = "Tambah";
            btnTambah.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnTambah.UseVisualStyleBackColor = false;
            btnTambah.Click += btnTambah_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(4, 63, 98);
            label3.Location = new Point(15, 13);
            label3.Name = "label3";
            label3.Size = new Size(115, 21);
            label3.TabIndex = 2;
            label3.Text = "Formulir Data";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(dtGridDokter);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(574, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 405);
            panel3.TabIndex = 14;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(4, 63, 98);
            label12.Location = new Point(183, 29);
            label12.Name = "label12";
            label12.Size = new Size(65, 17);
            label12.TabIndex = 40;
            label12.Text = "Cari Data";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(230, 231, 233);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(256, 24);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(216, 28);
            txtSearch.TabIndex = 41;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dtGridDokter
            // 
            dtGridDokter.BackgroundColor = Color.FromArgb(237, 255, 240);
            dtGridDokter.BorderStyle = BorderStyle.Fixed3D;
            dtGridDokter.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridDokter.Location = new Point(28, 73);
            dtGridDokter.Name = "dtGridDokter";
            dtGridDokter.Size = new Size(445, 309);
            dtGridDokter.TabIndex = 4;
            dtGridDokter.CellContentClick += dtGridDokter_CellContentClick;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(126, 209, 7);
            label13.Location = new Point(17, 34);
            label13.Name = "label13";
            label13.Size = new Size(100, 13);
            label13.TabIndex = 2;
            label13.Text = "Daftar Data Anda.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(4, 63, 98);
            label14.Location = new Point(15, 13);
            label14.Name = "label14";
            label14.Size = new Size(91, 21);
            label14.TabIndex = 2;
            label14.Text = "Data Tabel";
            // 
            // FormChildDokter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1100, 630);
            Controls.Add(panel1);
            Controls.Add(panelChildTopDokter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildDokter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Child Dokter";
            panelChildTopDokter.ResumeLayout(false);
            panelChildTopLeftDokter.ResumeLayout(false);
            panelChildTopLeftDokter.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridDokter).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopDokter;
        private Panel panelChildTopRightDokter;
        private Panel panelChildTopLeftDokter;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private DataGridView dtGridDokter;
        private Label label13;
        private Label label14;
        private Panel panel2;
        private Label label11;
        private TextBox textBox1;
        private Label label7;
        private Label label10;
        private RadioButton radioPerempuan;
        private RadioButton radioLakiLaki;
        private Label label6;
        private Label label17;
        private Label label16;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnReset;
        private Label label8;
        private ComboBox cmbAkun;
        private Label label5;
        private TextBox txtNama;
        private FontAwesome.Sharp.IconButton btnHapus;
        private FontAwesome.Sharp.IconButton btnSunting;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnTambah;
        private Label label3;
        private Label label12;
        private TextBox txtSearch;
    }
}