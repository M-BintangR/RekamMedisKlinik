namespace RekamMedisKlinik
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            panelMenu = new Panel();
            panel3 = new Panel();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnPembayaran = new FontAwesome.Sharp.IconButton();
            btnRekamMedis = new FontAwesome.Sharp.IconButton();
            btnDokter = new FontAwesome.Sharp.IconButton();
            btnPengguna = new FontAwesome.Sharp.IconButton();
            btnBeranda = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelHeader = new Panel();
            panel2 = new Panel();
            btnClose = new FontAwesome.Sharp.IconButton();
            btnMaximalSize = new FontAwesome.Sharp.IconButton();
            panelInfoUser = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            btnMinimized = new FontAwesome.Sharp.IconButton();
            panelMenu.SuspendLayout();
            panel3.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelHeader.SuspendLayout();
            panel2.SuspendLayout();
            panelInfoUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.White;
            panelMenu.Controls.Add(panel3);
            panelMenu.Controls.Add(btnPembayaran);
            panelMenu.Controls.Add(btnRekamMedis);
            panelMenu.Controls.Add(btnDokter);
            panelMenu.Controls.Add(btnPengguna);
            panelMenu.Controls.Add(btnBeranda);
            panelMenu.Controls.Add(panelLogo);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(257, 600);
            panelMenu.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(iconButton1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 495);
            panel3.Name = "panel3";
            panel3.Size = new Size(257, 105);
            panel3.TabIndex = 8;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(254, 0, 0);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(42, 32);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(10, 0, 0, 0);
            iconButton1.RightToLeft = RightToLeft.No;
            iconButton1.Size = new Size(182, 44);
            iconButton1.TabIndex = 8;
            iconButton1.Text = "Keluar";
            iconButton1.UseVisualStyleBackColor = false;
            // 
            // btnPembayaran
            // 
            btnPembayaran.BackColor = Color.White;
            btnPembayaran.Dock = DockStyle.Top;
            btnPembayaran.FlatAppearance.BorderSize = 0;
            btnPembayaran.FlatStyle = FlatStyle.Flat;
            btnPembayaran.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPembayaran.ForeColor = Color.FromArgb(4, 63, 98);
            btnPembayaran.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWave;
            btnPembayaran.IconColor = Color.FromArgb(4, 63, 98);
            btnPembayaran.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPembayaran.IconSize = 32;
            btnPembayaran.ImageAlign = ContentAlignment.MiddleLeft;
            btnPembayaran.Location = new Point(0, 264);
            btnPembayaran.Name = "btnPembayaran";
            btnPembayaran.Padding = new Padding(10, 0, 0, 0);
            btnPembayaran.Size = new Size(257, 42);
            btnPembayaran.TabIndex = 7;
            btnPembayaran.Text = "Pembayaran";
            btnPembayaran.TextAlign = ContentAlignment.MiddleLeft;
            btnPembayaran.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPembayaran.UseVisualStyleBackColor = false;
            btnPembayaran.Click += btnPembayaran_Click;
            // 
            // btnRekamMedis
            // 
            btnRekamMedis.BackColor = Color.White;
            btnRekamMedis.Dock = DockStyle.Top;
            btnRekamMedis.FlatAppearance.BorderSize = 0;
            btnRekamMedis.FlatStyle = FlatStyle.Flat;
            btnRekamMedis.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRekamMedis.ForeColor = Color.FromArgb(4, 63, 98);
            btnRekamMedis.IconChar = FontAwesome.Sharp.IconChar.HeartCirclePlus;
            btnRekamMedis.IconColor = Color.FromArgb(4, 63, 98);
            btnRekamMedis.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRekamMedis.IconSize = 32;
            btnRekamMedis.ImageAlign = ContentAlignment.MiddleLeft;
            btnRekamMedis.Location = new Point(0, 222);
            btnRekamMedis.Name = "btnRekamMedis";
            btnRekamMedis.Padding = new Padding(10, 0, 0, 0);
            btnRekamMedis.Size = new Size(257, 42);
            btnRekamMedis.TabIndex = 6;
            btnRekamMedis.Text = "Rekam Medis";
            btnRekamMedis.TextAlign = ContentAlignment.MiddleLeft;
            btnRekamMedis.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRekamMedis.UseVisualStyleBackColor = false;
            btnRekamMedis.Click += btnRekamMedis_Click;
            // 
            // btnDokter
            // 
            btnDokter.BackColor = Color.White;
            btnDokter.Dock = DockStyle.Top;
            btnDokter.FlatAppearance.BorderSize = 0;
            btnDokter.FlatStyle = FlatStyle.Flat;
            btnDokter.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDokter.ForeColor = Color.FromArgb(4, 63, 98);
            btnDokter.IconChar = FontAwesome.Sharp.IconChar.UserDoctor;
            btnDokter.IconColor = Color.FromArgb(4, 63, 98);
            btnDokter.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnDokter.IconSize = 32;
            btnDokter.ImageAlign = ContentAlignment.MiddleLeft;
            btnDokter.Location = new Point(0, 180);
            btnDokter.Name = "btnDokter";
            btnDokter.Padding = new Padding(10, 0, 0, 0);
            btnDokter.Size = new Size(257, 42);
            btnDokter.TabIndex = 5;
            btnDokter.Text = "Dokter";
            btnDokter.TextAlign = ContentAlignment.MiddleLeft;
            btnDokter.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDokter.UseVisualStyleBackColor = false;
            btnDokter.Click += btnDokter_Click;
            // 
            // btnPengguna
            // 
            btnPengguna.BackColor = Color.White;
            btnPengguna.Dock = DockStyle.Top;
            btnPengguna.FlatAppearance.BorderSize = 0;
            btnPengguna.FlatStyle = FlatStyle.Flat;
            btnPengguna.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPengguna.ForeColor = Color.FromArgb(4, 63, 98);
            btnPengguna.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            btnPengguna.IconColor = Color.FromArgb(4, 63, 98);
            btnPengguna.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnPengguna.IconSize = 32;
            btnPengguna.ImageAlign = ContentAlignment.MiddleLeft;
            btnPengguna.Location = new Point(0, 138);
            btnPengguna.Name = "btnPengguna";
            btnPengguna.Padding = new Padding(10, 0, 0, 0);
            btnPengguna.Size = new Size(257, 42);
            btnPengguna.TabIndex = 4;
            btnPengguna.Text = "Pengguna";
            btnPengguna.TextAlign = ContentAlignment.MiddleLeft;
            btnPengguna.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnPengguna.UseVisualStyleBackColor = false;
            btnPengguna.Click += btnPengguna_Click;
            // 
            // btnBeranda
            // 
            btnBeranda.BackColor = Color.White;
            btnBeranda.Dock = DockStyle.Top;
            btnBeranda.FlatAppearance.BorderSize = 0;
            btnBeranda.FlatStyle = FlatStyle.Flat;
            btnBeranda.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBeranda.ForeColor = Color.FromArgb(4, 63, 98);
            btnBeranda.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            btnBeranda.IconColor = Color.FromArgb(4, 63, 98);
            btnBeranda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnBeranda.IconSize = 32;
            btnBeranda.ImageAlign = ContentAlignment.MiddleLeft;
            btnBeranda.Location = new Point(0, 96);
            btnBeranda.Name = "btnBeranda";
            btnBeranda.Padding = new Padding(10, 0, 0, 0);
            btnBeranda.Size = new Size(257, 42);
            btnBeranda.TabIndex = 3;
            btnBeranda.Text = "Beranda";
            btnBeranda.TextAlign = ContentAlignment.MiddleLeft;
            btnBeranda.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnBeranda.UseVisualStyleBackColor = false;
            btnBeranda.Click += btnBeranda_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(257, 96);
            panelLogo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LOGO_KLINIK_SMALL_DARK;
            pictureBox1.Location = new Point(14, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(228, 63);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(panel2);
            panelHeader.Controls.Add(panelInfoUser);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(257, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(743, 56);
            panelHeader.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnMinimized);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnMaximalSize);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(210, 56);
            panel2.TabIndex = 2;
            // 
            // btnClose
            // 
            btnClose.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            btnClose.IconColor = Color.FromArgb(254, 0, 0);
            btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnClose.IconSize = 20;
            btnClose.Location = new Point(87, 13);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 1;
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnMaximalSize
            // 
            btnMaximalSize.IconChar = FontAwesome.Sharp.IconChar.Maximize;
            btnMaximalSize.IconColor = Color.FromArgb(254, 0, 0);
            btnMaximalSize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMaximalSize.IconSize = 20;
            btnMaximalSize.Location = new Point(17, 13);
            btnMaximalSize.Name = "btnMaximalSize";
            btnMaximalSize.Size = new Size(30, 30);
            btnMaximalSize.TabIndex = 0;
            btnMaximalSize.UseVisualStyleBackColor = true;
            btnMaximalSize.Click += btnMaximalSize_Click;
            // 
            // panelInfoUser
            // 
            panelInfoUser.Controls.Add(label2);
            panelInfoUser.Controls.Add(pictureBox2);
            panelInfoUser.Controls.Add(label1);
            panelInfoUser.Dock = DockStyle.Right;
            panelInfoUser.Location = new Point(494, 0);
            panelInfoUser.Name = "panelInfoUser";
            panelInfoUser.Size = new Size(249, 56);
            panelInfoUser.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 205, 20);
            label2.Location = new Point(110, 27);
            label2.Name = "label2";
            label2.Size = new Size(44, 16);
            label2.TabIndex = 1;
            label2.Text = "admin";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(4, 63, 98);
            label1.Location = new Point(109, 13);
            label1.Name = "label1";
            label1.Size = new Size(124, 16);
            label1.TabIndex = 0;
            label1.Text = "Muhammad Bintang";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(257, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(743, 544);
            panel1.TabIndex = 2;
            // 
            // btnMinimized
            // 
            btnMinimized.IconChar = FontAwesome.Sharp.IconChar.SquareCaretDown;
            btnMinimized.IconColor = Color.FromArgb(254, 0, 0);
            btnMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMinimized.IconSize = 20;
            btnMinimized.Location = new Point(52, 13);
            btnMinimized.Name = "btnMinimized";
            btnMinimized.Size = new Size(30, 30);
            btnMinimized.TabIndex = 2;
            btnMinimized.UseVisualStyleBackColor = true;
            btnMinimized.Click += btnMinimized_Click;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1000, 600);
            Controls.Add(panel1);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beranda";
            panelMenu.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelHeader.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panelInfoUser.ResumeLayout(false);
            panelInfoUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelHeader;
        private FontAwesome.Sharp.IconButton btnBeranda;
        private FontAwesome.Sharp.IconButton btnRekamMedis;
        private FontAwesome.Sharp.IconButton btnDokter;
        private FontAwesome.Sharp.IconButton btnPengguna;
        private FontAwesome.Sharp.IconButton btnPembayaran;
        private Panel panelInfoUser;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private Label label1;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel panel2;
        private FontAwesome.Sharp.IconButton btnMaximalSize;
        private FontAwesome.Sharp.IconButton btnClose;
        private FontAwesome.Sharp.IconButton btnMinimized;
    }
}