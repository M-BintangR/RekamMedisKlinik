namespace RekamMedisKlinik
{
    partial class FormChildPengguna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChildPengguna));
            panelChildTopPengguna = new Panel();
            panelChildTopRightPengguna = new Panel();
            panelChildTopLeftPengguna = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel3 = new Panel();
            label17 = new Label();
            txtSearch = new TextBox();
            dtGridPengguna = new DataGridView();
            label13 = new Label();
            label14 = new Label();
            panel2 = new Panel();
            label12 = new Label();
            label15 = new Label();
            textBox1 = new TextBox();
            label11 = new Label();
            btnAmbilGambar = new FontAwesome.Sharp.IconButton();
            previewGambar = new PictureBox();
            label6 = new Label();
            label10 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            label16 = new Label();
            label9 = new Label();
            btnReset = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            cmdLevel = new ComboBox();
            label5 = new Label();
            txtUsername = new TextBox();
            btnHapus = new FontAwesome.Sharp.IconButton();
            btnSunting = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            btnTambah = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            panelChildTopPengguna.SuspendLayout();
            panelChildTopLeftPengguna.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridPengguna).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)previewGambar).BeginInit();
            SuspendLayout();
            // 
            // panelChildTopPengguna
            // 
            panelChildTopPengguna.Controls.Add(panelChildTopRightPengguna);
            panelChildTopPengguna.Controls.Add(panelChildTopLeftPengguna);
            panelChildTopPengguna.Dock = DockStyle.Top;
            panelChildTopPengguna.Location = new Point(0, 0);
            panelChildTopPengguna.Name = "panelChildTopPengguna";
            panelChildTopPengguna.Size = new Size(1100, 93);
            panelChildTopPengguna.TabIndex = 1;
            // 
            // panelChildTopRightPengguna
            // 
            panelChildTopRightPengguna.Dock = DockStyle.Right;
            panelChildTopRightPengguna.Location = new Point(900, 0);
            panelChildTopRightPengguna.Name = "panelChildTopRightPengguna";
            panelChildTopRightPengguna.Size = new Size(200, 93);
            panelChildTopRightPengguna.TabIndex = 1;
            // 
            // panelChildTopLeftPengguna
            // 
            panelChildTopLeftPengguna.Controls.Add(label2);
            panelChildTopLeftPengguna.Controls.Add(label1);
            panelChildTopLeftPengguna.Dock = DockStyle.Left;
            panelChildTopLeftPengguna.Location = new Point(0, 0);
            panelChildTopLeftPengguna.Name = "panelChildTopLeftPengguna";
            panelChildTopLeftPengguna.Size = new Size(274, 93);
            panelChildTopLeftPengguna.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 209, 7);
            label2.Location = new Point(20, 24);
            label2.Name = "label2";
            label2.Size = new Size(128, 15);
            label2.TabIndex = 1;
            label2.Text = "Kelola Data Pengguna";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 63, 98);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(145, 37);
            label1.TabIndex = 0;
            label1.Text = "Pengguna";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 93);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(1100, 537);
            panel1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label17);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(dtGridPengguna);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label14);
            panel3.Location = new Point(574, 23);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 405);
            panel3.TabIndex = 14;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label17.ForeColor = Color.FromArgb(4, 63, 98);
            label17.Location = new Point(183, 25);
            label17.Name = "label17";
            label17.Size = new Size(65, 17);
            label17.TabIndex = 39;
            label17.Text = "Cari Data";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(230, 231, 233);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(257, 20);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(216, 28);
            txtSearch.TabIndex = 39;
            // 
            // dtGridPengguna
            // 
            dtGridPengguna.BackgroundColor = Color.FromArgb(237, 255, 240);
            dtGridPengguna.BorderStyle = BorderStyle.Fixed3D;
            dtGridPengguna.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridPengguna.Location = new Point(28, 73);
            dtGridPengguna.Name = "dtGridPengguna";
            dtGridPengguna.Size = new Size(445, 309);
            dtGridPengguna.TabIndex = 4;
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
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(label12);
            panel2.Controls.Add(label15);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(btnAmbilGambar);
            panel2.Controls.Add(previewGambar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label16);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(btnReset);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(cmdLevel);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(btnHapus);
            panel2.Controls.Add(btnSunting);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnTambah);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(23, 23);
            panel2.Name = "panel2";
            panel2.Size = new Size(532, 444);
            panel2.TabIndex = 0;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.FromArgb(252, 0, 0);
            label12.Location = new Point(94, 233);
            label12.Name = "label12";
            label12.Size = new Size(13, 13);
            label12.TabIndex = 38;
            label12.Text = "*";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label15.ForeColor = Color.FromArgb(4, 63, 98);
            label15.Location = new Point(21, 229);
            label15.Name = "label15";
            label15.Size = new Size(66, 17);
            label15.TabIndex = 37;
            label15.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(230, 231, 233);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(22, 256);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(216, 28);
            textBox1.TabIndex = 36;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(252, 0, 0);
            label11.Location = new Point(286, 217);
            label11.Name = "label11";
            label11.Size = new Size(69, 13);
            label11.TabIndex = 35;
            label11.Text = "jpg, jpeg, png";
            // 
            // btnAmbilGambar
            // 
            btnAmbilGambar.BackColor = Color.FromArgb(217, 217, 217);
            btnAmbilGambar.Cursor = Cursors.Hand;
            btnAmbilGambar.FlatAppearance.BorderSize = 0;
            btnAmbilGambar.FlatStyle = FlatStyle.Flat;
            btnAmbilGambar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAmbilGambar.ForeColor = Color.White;
            btnAmbilGambar.IconChar = FontAwesome.Sharp.IconChar.CameraAlt;
            btnAmbilGambar.IconColor = Color.FromArgb(4, 63, 98);
            btnAmbilGambar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAmbilGambar.IconSize = 20;
            btnAmbilGambar.Location = new Point(347, 172);
            btnAmbilGambar.Name = "btnAmbilGambar";
            btnAmbilGambar.Size = new Size(29, 26);
            btnAmbilGambar.TabIndex = 34;
            btnAmbilGambar.UseVisualStyleBackColor = false;
            btnAmbilGambar.Click += btnAmbilGambar_Click;
            // 
            // previewGambar
            // 
            previewGambar.Image = (Image)resources.GetObject("previewGambar.Image");
            previewGambar.Location = new Point(286, 160);
            previewGambar.Name = "previewGambar";
            previewGambar.Size = new Size(49, 50);
            previewGambar.SizeMode = PictureBoxSizeMode.Zoom;
            previewGambar.TabIndex = 33;
            previewGambar.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(252, 0, 0);
            label6.Location = new Point(64, 159);
            label6.Name = "label6";
            label6.Size = new Size(13, 13);
            label6.TabIndex = 32;
            label6.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label10.ForeColor = Color.FromArgb(4, 63, 98);
            label10.Location = new Point(22, 155);
            label10.Name = "label10";
            label10.Size = new Size(42, 17);
            label10.TabIndex = 31;
            label10.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(23, 182);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 28);
            txtEmail.TabIndex = 30;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(252, 0, 0);
            label7.Location = new Point(354, 82);
            label7.Name = "label7";
            label7.Size = new Size(13, 13);
            label7.TabIndex = 29;
            label7.Text = "*";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semilight", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(252, 0, 0);
            label16.Location = new Point(63, 84);
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
            label9.Location = new Point(22, 353);
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
            btnReset.Location = new Point(456, 385);
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
            label8.Size = new Size(40, 17);
            label8.TabIndex = 13;
            label8.Text = "Level";
            // 
            // cmdLevel
            // 
            cmdLevel.BackColor = Color.FromArgb(230, 231, 233);
            cmdLevel.FlatStyle = FlatStyle.Flat;
            cmdLevel.Font = new Font("Arial", 9.75F, FontStyle.Bold);
            cmdLevel.FormattingEnabled = true;
            cmdLevel.Items.AddRange(new object[] { "admin", "dokter" });
            cmdLevel.Location = new Point(22, 109);
            cmdLevel.Name = "cmdLevel";
            cmdLevel.Size = new Size(216, 24);
            cmdLevel.TabIndex = 12;
            cmdLevel.SelectedIndexChanged += cmdLevel_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(4, 63, 98);
            label5.Location = new Point(285, 78);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 7;
            label5.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.FromArgb(230, 231, 233);
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(286, 105);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(216, 28);
            txtUsername.TabIndex = 6;
            txtUsername.TextChanged += txtUsername_TextChanged;
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
            btnHapus.Location = new Point(24, 385);
            btnHapus.Name = "btnHapus";
            btnHapus.Padding = new Padding(10, 0, 0, 0);
            btnHapus.Size = new Size(134, 34);
            btnHapus.TabIndex = 5;
            btnHapus.Text = "Hapus";
            btnHapus.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHapus.UseVisualStyleBackColor = false;
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
            btnSunting.Location = new Point(167, 385);
            btnSunting.Name = "btnSunting";
            btnSunting.Padding = new Padding(10, 0, 0, 0);
            btnSunting.Size = new Size(133, 34);
            btnSunting.TabIndex = 4;
            btnSunting.Text = "Sunting";
            btnSunting.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSunting.UseVisualStyleBackColor = false;
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
            btnTambah.Location = new Point(309, 385);
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
            // FormChildPengguna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1100, 630);
            Controls.Add(panel1);
            Controls.Add(panelChildTopPengguna);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildPengguna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Child Pengguna";
            panelChildTopPengguna.ResumeLayout(false);
            panelChildTopLeftPengguna.ResumeLayout(false);
            panelChildTopLeftPengguna.PerformLayout();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridPengguna).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)previewGambar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopPengguna;
        private Panel panelChildTopRightPengguna;
        private Panel panelChildTopLeftPengguna;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton btnTambah;
        private FontAwesome.Sharp.IconButton btnSunting;
        private FontAwesome.Sharp.IconButton btnHapus;
        private TextBox txtUsername;
        private Label label5;
        private Label label8;
        private ComboBox cmdLevel;
        private Panel panel3;
        private Label label13;
        private Label label14;
        private DataGridView dtGridPengguna;
        private Label label9;
        private FontAwesome.Sharp.IconButton btnReset;
        private Label label16;
        private Label label7;
        private Label label6;
        private Label label10;
        private TextBox txtEmail;
        private Label label12;
        private Label label15;
        private TextBox textBox1;
        private Label label11;
        private FontAwesome.Sharp.IconButton btnAmbilGambar;
        private PictureBox previewGambar;
        private Label label17;
        private TextBox txtSearch;
    }
}