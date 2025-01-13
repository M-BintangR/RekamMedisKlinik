namespace RekamMedisKlinik
{
    partial class FormChildRekamMedis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChildRekamMedis));
            panelChildTopRekamMedis = new Panel();
            panelChildTopRightRekamMedis = new Panel();
            panelChildTopLeftRekamMedis = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            previewGambar = new PictureBox();
            label15 = new Label();
            label18 = new Label();
            txtHarga = new TextBox();
            label11 = new Label();
            labeldiagnosa = new Label();
            txtResep = new TextBox();
            label7 = new Label();
            label10 = new Label();
            txtPengobatan = new TextBox();
            label6 = new Label();
            label17 = new Label();
            label16 = new Label();
            label9 = new Label();
            btnReset = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            cmbPasien = new ComboBox();
            label5 = new Label();
            txtDiagnosa = new TextBox();
            btnHapus = new FontAwesome.Sharp.IconButton();
            btnSunting = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            btnTambah = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            txtSearch = new TextBox();
            dtGridRekamMedis = new DataGridView();
            label13 = new Label();
            label14 = new Label();
            panelChildTopRekamMedis.SuspendLayout();
            panelChildTopLeftRekamMedis.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewGambar).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridRekamMedis).BeginInit();
            SuspendLayout();
            // 
            // panelChildTopRekamMedis
            // 
            panelChildTopRekamMedis.Controls.Add(panelChildTopRightRekamMedis);
            panelChildTopRekamMedis.Controls.Add(panelChildTopLeftRekamMedis);
            panelChildTopRekamMedis.Dock = DockStyle.Top;
            panelChildTopRekamMedis.Location = new Point(0, 0);
            panelChildTopRekamMedis.Name = "panelChildTopRekamMedis";
            panelChildTopRekamMedis.Size = new Size(1100, 93);
            panelChildTopRekamMedis.TabIndex = 3;
            // 
            // panelChildTopRightRekamMedis
            // 
            panelChildTopRightRekamMedis.Dock = DockStyle.Right;
            panelChildTopRightRekamMedis.Location = new Point(900, 0);
            panelChildTopRightRekamMedis.Name = "panelChildTopRightRekamMedis";
            panelChildTopRightRekamMedis.Size = new Size(200, 93);
            panelChildTopRightRekamMedis.TabIndex = 1;
            // 
            // panelChildTopLeftRekamMedis
            // 
            panelChildTopLeftRekamMedis.Controls.Add(label2);
            panelChildTopLeftRekamMedis.Controls.Add(label1);
            panelChildTopLeftRekamMedis.Dock = DockStyle.Left;
            panelChildTopLeftRekamMedis.Location = new Point(0, 0);
            panelChildTopLeftRekamMedis.Name = "panelChildTopLeftRekamMedis";
            panelChildTopLeftRekamMedis.Size = new Size(274, 93);
            panelChildTopLeftRekamMedis.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 209, 7);
            label2.Location = new Point(20, 24);
            label2.Name = "label2";
            label2.Size = new Size(148, 15);
            label2.TabIndex = 1;
            label2.Text = "Kelola Data Rekam Medis";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 63, 98);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(189, 37);
            label1.TabIndex = 0;
            label1.Text = "Rekam Medis";
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
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(previewGambar);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(txtHarga);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(labeldiagnosa);
            panel2.Controls.Add(txtResep);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPengobatan);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmbPasien);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtDiagnosa);
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
            // previewGambar
            // 
            previewGambar.Image = (Image)resources.GetObject("previewGambar.Image");
            previewGambar.Location = new Point(416, 86);
            previewGambar.Name = "previewGambar";
            previewGambar.Size = new Size(74, 72);
            previewGambar.SizeMode = PictureBoxSizeMode.Zoom;
            previewGambar.TabIndex = 35;
            previewGambar.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(252, 0, 0);
            label15.Location = new Point(333, 279);
            label15.Name = "label15";
            label15.Size = new Size(13, 13);
            label15.TabIndex = 34;
            label15.Text = "*";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label18.ForeColor = Color.FromArgb(4, 63, 98);
            label18.Location = new Point(290, 274);
            label18.Name = "label18";
            label18.Size = new Size(49, 17);
            label18.TabIndex = 33;
            label18.Text = "Harga ";
            // 
            // txtHarga
            // 
            txtHarga.BackColor = Color.FromArgb(230, 231, 233);
            txtHarga.BorderStyle = BorderStyle.None;
            txtHarga.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtHarga.Location = new Point(291, 301);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(199, 34);
            txtHarga.TabIndex = 32;
            txtHarga.TextChanged += txtHarga_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(252, 0, 0);
            label11.Location = new Point(370, 183);
            label11.Name = "label11";
            label11.Size = new Size(13, 13);
            label11.TabIndex = 31;
            label11.Text = "*";
            // 
            // labeldiagnosa
            // 
            labeldiagnosa.AutoSize = true;
            labeldiagnosa.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            labeldiagnosa.ForeColor = Color.FromArgb(4, 63, 98);
            labeldiagnosa.Location = new Point(290, 179);
            labeldiagnosa.Name = "labeldiagnosa";
            labeldiagnosa.Size = new Size(78, 17);
            labeldiagnosa.TabIndex = 30;
            labeldiagnosa.Text = "Resep Obat";
            // 
            // txtResep
            // 
            txtResep.BackColor = Color.FromArgb(230, 231, 233);
            txtResep.BorderStyle = BorderStyle.None;
            txtResep.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtResep.Location = new Point(291, 206);
            txtResep.Multiline = true;
            txtResep.Name = "txtResep";
            txtResep.Size = new Size(199, 52);
            txtResep.TabIndex = 29;
            txtResep.TextChanged += txtResep_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(252, 0, 0);
            label7.Location = new Point(115, 279);
            label7.Name = "label7";
            label7.Size = new Size(13, 13);
            label7.TabIndex = 28;
            label7.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(4, 63, 98);
            label10.Location = new Point(35, 274);
            label10.Name = "label10";
            label10.Size = new Size(82, 17);
            label10.TabIndex = 27;
            label10.Text = "Pengobatan";
            // 
            // txtPengobatan
            // 
            txtPengobatan.BackColor = Color.FromArgb(230, 231, 233);
            txtPengobatan.BorderStyle = BorderStyle.None;
            txtPengobatan.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPengobatan.Location = new Point(36, 301);
            txtPengobatan.Multiline = true;
            txtPengobatan.Name = "txtPengobatan";
            txtPengobatan.Size = new Size(238, 52);
            txtPengobatan.TabIndex = 26;
            txtPengobatan.TextChanged += txtPengobatan_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(252, 0, 0);
            label6.Location = new Point(34, 145);
            label6.Name = "label6";
            label6.Size = new Size(175, 13);
            label6.TabIndex = 25;
            label6.Text = "Pastikan pasien sudah di pilih!";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(252, 0, 0);
            label17.Location = new Point(98, 184);
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
            label16.Location = new Point(116, 86);
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
            label8.Location = new Point(35, 81);
            label8.Name = "label8";
            label8.Size = new Size(80, 17);
            label8.TabIndex = 13;
            label8.Text = "Pilih Pasien";
            label8.Click += label8_Click;
            // 
            // cmbPasien
            // 
            cmbPasien.BackColor = Color.FromArgb(230, 231, 233);
            cmbPasien.FlatStyle = FlatStyle.Flat;
            cmbPasien.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            cmbPasien.FormattingEnabled = true;
            cmbPasien.Location = new Point(34, 110);
            cmbPasien.Name = "cmbPasien";
            cmbPasien.Size = new Size(349, 24);
            cmbPasien.TabIndex = 12;
            cmbPasien.SelectedIndexChanged += cmbPasien_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 63, 98);
            label5.Location = new Point(33, 179);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 7;
            label5.Text = "Diagnosa";
            // 
            // txtDiagnosa
            // 
            txtDiagnosa.BackColor = Color.FromArgb(230, 231, 233);
            txtDiagnosa.BorderStyle = BorderStyle.None;
            txtDiagnosa.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtDiagnosa.Location = new Point(34, 206);
            txtDiagnosa.Multiline = true;
            txtDiagnosa.Name = "txtDiagnosa";
            txtDiagnosa.Size = new Size(240, 52);
            txtDiagnosa.TabIndex = 6;
            txtDiagnosa.TextChanged += txtDiagnosa_TextChanged;
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
            panel3.Controls.Add(dtGridRekamMedis);
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
            // dtGridRekamMedis
            // 
            dtGridRekamMedis.BackgroundColor = Color.FromArgb(237, 255, 240);
            dtGridRekamMedis.BorderStyle = BorderStyle.Fixed3D;
            dtGridRekamMedis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridRekamMedis.Location = new Point(28, 73);
            dtGridRekamMedis.Name = "dtGridRekamMedis";
            dtGridRekamMedis.Size = new Size(445, 309);
            dtGridRekamMedis.TabIndex = 4;
            dtGridRekamMedis.CellContentClick += dtGridRekamMedis_CellContentClick;
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
            // FormChildRekamMedis
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1100, 630);
            Controls.Add(panel1);
            Controls.Add(panelChildTopRekamMedis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildRekamMedis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Child Rekam Medis";
            panelChildTopRekamMedis.ResumeLayout(false);
            panelChildTopLeftRekamMedis.ResumeLayout(false);
            panelChildTopLeftRekamMedis.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewGambar).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridRekamMedis).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopRekamMedis;
        private Panel panelChildTopRightRekamMedis;
        private Panel panelChildTopLeftRekamMedis;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel3;
        private Label label12;
        private TextBox txtSearch;
        private DataGridView dtGridRekamMedis;
        private Label label13;
        private Label label14;
        private Panel panel2;
        private PictureBox previewGambar;
        private Label label15;
        private Label label18;
        private TextBox txtHarga;
        private Label label11;
        private Label labeldiagnosa;
        private TextBox txtResep;
        private Label label7;
        private Label label10;
        private TextBox txtPengobatan;
        private Label label6;
        private Label label17;
        private Label label16;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnReset;
        private Label label8;
        private ComboBox cmbPasien;
        private Label label5;
        private TextBox txtDiagnosa;
        private FontAwesome.Sharp.IconButton btnHapus;
        private FontAwesome.Sharp.IconButton btnSunting;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnTambah;
        private Label label3;
    }
}