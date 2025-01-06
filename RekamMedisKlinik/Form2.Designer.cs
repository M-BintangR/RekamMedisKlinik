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
            panelMenu = new Panel();
            btnPembayaran = new FontAwesome.Sharp.IconButton();
            btnRekamMedis = new FontAwesome.Sharp.IconButton();
            btnDokter = new FontAwesome.Sharp.IconButton();
            btnPengguna = new FontAwesome.Sharp.IconButton();
            btnBeranda = new FontAwesome.Sharp.IconButton();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelHeader = new Panel();
            panelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.AutoScroll = true;
            panelMenu.BackColor = Color.White;
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
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(257, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(743, 48);
            panelHeader.TabIndex = 0;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1000, 600);
            Controls.Add(panelHeader);
            Controls.Add(panelMenu);
            Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Beranda";
            panelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}