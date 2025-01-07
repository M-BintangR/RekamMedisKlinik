namespace RekamMedisKlinik
{
    partial class FormChildPembayaran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChildPembayaran));
            panelChildTopRekamMedis = new Panel();
            panelChildTopRightRekamMedis = new Panel();
            panelChildTopLeftRekamMedis = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label15 = new Label();
            label18 = new Label();
            txtHarga = new TextBox();
            label11 = new Label();
            labeldiagnosa = new Label();
            txtResep = new TextBox();
            label7 = new Label();
            label10 = new Label();
            txtPengobatan = new TextBox();
            label17 = new Label();
            btnReset = new FontAwesome.Sharp.IconButton();
            label5 = new Label();
            txtDiagnosa = new TextBox();
            label4 = new Label();
            btnBayar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panel3 = new Panel();
            label12 = new Label();
            txtSearch = new TextBox();
            dtGridRekamMedis = new DataGridView();
            label13 = new Label();
            label14 = new Label();
            panel4 = new Panel();
            label6 = new Label();
            label8 = new Label();
            label16 = new Label();
            label19 = new Label();
            txtNamaPasien = new TextBox();
            label20 = new Label();
            label21 = new Label();
            textBox1 = new TextBox();
            previewGambar = new PictureBox();
            panelChildTopRekamMedis.SuspendLayout();
            panelChildTopLeftRekamMedis.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridRekamMedis).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewGambar).BeginInit();
            SuspendLayout();
            // 
            // panelChildTopRekamMedis
            // 
            panelChildTopRekamMedis.BackColor = Color.FromArgb(241, 244, 254);
            panelChildTopRekamMedis.Controls.Add(panelChildTopRightRekamMedis);
            panelChildTopRekamMedis.Controls.Add(panelChildTopLeftRekamMedis);
            panelChildTopRekamMedis.Dock = DockStyle.Top;
            panelChildTopRekamMedis.Location = new Point(0, 0);
            panelChildTopRekamMedis.Name = "panelChildTopRekamMedis";
            panelChildTopRekamMedis.Size = new Size(1100, 93);
            panelChildTopRekamMedis.TabIndex = 4;
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
            label2.Size = new Size(141, 15);
            label2.TabIndex = 1;
            label2.Text = "Kelola Data Pembayaran";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 63, 98);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 0;
            label1.Text = "Pembayaran";
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
            panel1.Size = new Size(1100, 607);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(previewGambar);
            panel2.Controls.Add(label20);
            panel2.Controls.Add(label21);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label19);
            panel2.Controls.Add(txtNamaPasien);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(label18);
            panel2.Controls.Add(txtHarga);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(labeldiagnosa);
            panel2.Controls.Add(txtResep);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtPengobatan);
            panel2.Controls.Add(label17);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtDiagnosa);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnBayar);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(545, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 544);
            panel2.TabIndex = 15;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(252, 0, 0);
            label15.Location = new Point(324, 369);
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
            label18.Location = new Point(281, 364);
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
            txtHarga.Location = new Point(282, 391);
            txtHarga.Multiline = true;
            txtHarga.Name = "txtHarga";
            txtHarga.Size = new Size(223, 52);
            txtHarga.TabIndex = 32;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(252, 0, 0);
            label11.Location = new Point(361, 273);
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
            labeldiagnosa.Location = new Point(281, 269);
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
            txtResep.Location = new Point(282, 296);
            txtResep.Multiline = true;
            txtResep.Name = "txtResep";
            txtResep.Size = new Size(223, 52);
            txtResep.TabIndex = 29;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(252, 0, 0);
            label7.Location = new Point(106, 369);
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
            label10.Location = new Point(26, 364);
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
            txtPengobatan.Location = new Point(27, 391);
            txtPengobatan.Multiline = true;
            txtPengobatan.Name = "txtPengobatan";
            txtPengobatan.Size = new Size(224, 52);
            txtPengobatan.TabIndex = 26;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(252, 0, 0);
            label17.Location = new Point(89, 274);
            label17.Name = "label17";
            label17.Size = new Size(13, 13);
            label17.TabIndex = 24;
            label17.Text = "*";
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
            btnReset.Location = new Point(310, 479);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(46, 34);
            btnReset.TabIndex = 14;
            btnReset.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 63, 98);
            label5.Location = new Point(24, 269);
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
            txtDiagnosa.Location = new Point(25, 296);
            txtDiagnosa.Multiline = true;
            txtDiagnosa.Name = "txtDiagnosa";
            txtDiagnosa.Size = new Size(226, 52);
            txtDiagnosa.TabIndex = 6;
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
            // btnBayar
            // 
            btnBayar.BackColor = Color.FromArgb(4, 63, 98);
            btnBayar.Cursor = Cursors.Hand;
            btnBayar.FlatAppearance.BorderSize = 0;
            btnBayar.FlatStyle = FlatStyle.Flat;
            btnBayar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBayar.ForeColor = Color.White;
            btnBayar.IconChar = FontAwesome.Sharp.IconChar.MoneyBill1Wave;
            btnBayar.IconColor = SystemColors.Window;
            btnBayar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBayar.IconSize = 23;
            btnBayar.Location = new Point(370, 477);
            btnBayar.Name = "btnBayar";
            btnBayar.Padding = new Padding(10, 0, 0, 0);
            btnBayar.Size = new Size(135, 34);
            btnBayar.TabIndex = 3;
            btnBayar.Text = "Bayar";
            btnBayar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBayar.UseVisualStyleBackColor = false;
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
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(dtGridRekamMedis);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(23, 23);
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
            // 
            // dtGridRekamMedis
            // 
            dtGridRekamMedis.BackgroundColor = Color.FromArgb(237, 255, 240);
            dtGridRekamMedis.BorderStyle = BorderStyle.Fixed3D;
            dtGridRekamMedis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridRekamMedis.Location = new Point(17, 164);
            dtGridRekamMedis.Name = "dtGridRekamMedis";
            dtGridRekamMedis.Size = new Size(455, 218);
            dtGridRekamMedis.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.ForeColor = Color.FromArgb(126, 209, 7);
            label13.Location = new Point(17, 34);
            label13.Name = "label13";
            label13.Size = new Size(110, 13);
            label13.TabIndex = 2;
            label13.Text = "Daftar Pasien Anda.";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.FromArgb(4, 63, 98);
            label14.Location = new Point(15, 13);
            label14.Name = "label14";
            label14.Size = new Size(99, 21);
            label14.TabIndex = 2;
            label14.Text = "Pilih Pasien";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(126, 209, 7);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label6);
            panel4.Location = new Point(17, 77);
            panel4.Name = "panel4";
            panel4.Size = new Size(455, 67);
            panel4.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(13, 12);
            label6.Name = "label6";
            label6.Size = new Size(46, 21);
            label6.TabIndex = 43;
            label6.Text = "Info!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(15, 33);
            label8.Name = "label8";
            label8.Size = new Size(362, 13);
            label8.TabIndex = 43;
            label8.Text = "Silahkan pilih pasien terlebih dahulu, untuk melakukan pembayaran";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(252, 0, 0);
            label16.Location = new Point(368, 179);
            label16.Name = "label16";
            label16.Size = new Size(13, 13);
            label16.TabIndex = 37;
            label16.Text = "*";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label19.ForeColor = Color.FromArgb(4, 63, 98);
            label19.Location = new Point(280, 174);
            label19.Name = "label19";
            label19.Size = new Size(88, 17);
            label19.TabIndex = 36;
            label19.Text = "Nama Pasien";
            // 
            // txtNamaPasien
            // 
            txtNamaPasien.BackColor = Color.FromArgb(230, 231, 233);
            txtNamaPasien.BorderStyle = BorderStyle.None;
            txtNamaPasien.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtNamaPasien.Location = new Point(281, 203);
            txtNamaPasien.Multiline = true;
            txtNamaPasien.Name = "txtNamaPasien";
            txtNamaPasien.Size = new Size(224, 33);
            txtNamaPasien.TabIndex = 35;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(252, 0, 0);
            label20.Location = new Point(115, 178);
            label20.Name = "label20";
            label20.Size = new Size(13, 13);
            label20.TabIndex = 40;
            label20.Text = "*";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label21.ForeColor = Color.FromArgb(4, 63, 98);
            label21.Location = new Point(26, 174);
            label21.Name = "label21";
            label21.Size = new Size(90, 17);
            label21.TabIndex = 39;
            label21.Text = "Nama Dokter";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(27, 203);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(224, 33);
            textBox1.TabIndex = 38;
            // 
            // previewGambar
            // 
            previewGambar.Image = (Image)resources.GetObject("previewGambar.Image");
            previewGambar.Location = new Point(212, 60);
            previewGambar.Name = "previewGambar";
            previewGambar.Size = new Size(89, 84);
            previewGambar.SizeMode = PictureBoxSizeMode.Zoom;
            previewGambar.TabIndex = 41;
            previewGambar.TabStop = false;
            // 
            // FormChildPembayaran
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1100, 700);
            Controls.Add(panel1);
            Controls.Add(panelChildTopRekamMedis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildPembayaran";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Child Pembayaran";
            panelChildTopRekamMedis.ResumeLayout(false);
            panelChildTopLeftRekamMedis.ResumeLayout(false);
            panelChildTopLeftRekamMedis.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridRekamMedis).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewGambar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopRekamMedis;
        private Panel panelChildTopRightRekamMedis;
        private Panel panelChildTopLeftRekamMedis;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label15;
        private Label label18;
        private TextBox txtHarga;
        private Label label11;
        private Label labeldiagnosa;
        private TextBox txtResep;
        private Label label7;
        private Label label10;
        private TextBox txtPengobatan;
        private Label label17;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnReset;
        private Label label5;
        private TextBox txtDiagnosa;
        private FontAwesome.Sharp.IconButton btnHapus;
        private FontAwesome.Sharp.IconButton btnSunting;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnBayar;
        private Label label3;
        private Panel panel3;
        private Label label12;
        private TextBox txtSearch;
        private DataGridView dtGridRekamMedis;
        private Label label13;
        private Label label14;
        private Label label16;
        private Label label19;
        private TextBox txtNamaPasien;
        private Panel panel4;
        private Label label8;
        private Label label6;
        private Label label20;
        private Label label21;
        private TextBox textBox1;
        private PictureBox previewGambar;
    }
}