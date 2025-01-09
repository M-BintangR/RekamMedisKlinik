namespace RekamMedisKlinik
{
    partial class FormChildDashboard
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
            panelChildTopDashboard = new Panel();
            panelChildTopRightDashboard = new Panel();
            panelChildTopLeftDashboard = new Panel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            lblCountRekamMedis = new Label();
            label9 = new Label();
            label10 = new Label();
            panel4 = new Panel();
            lblCountJanjiTemu = new Label();
            label7 = new Label();
            label8 = new Label();
            panel3 = new Panel();
            lblCountDokter = new Label();
            label5 = new Label();
            label6 = new Label();
            panel2 = new Panel();
            lblCountPengguna = new Label();
            label4 = new Label();
            label3 = new Label();
            panel6 = new Panel();
            panel8 = new Panel();
            dtGridRekamMedis = new DataGridView();
            label17 = new Label();
            label18 = new Label();
            panel7 = new Panel();
            dtGridPertemuan = new DataGridView();
            label15 = new Label();
            label16 = new Label();
            btnReload = new FontAwesome.Sharp.IconButton();
            panelChildTopDashboard.SuspendLayout();
            panelChildTopRightDashboard.SuspendLayout();
            panelChildTopLeftDashboard.SuspendLayout();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridRekamMedis).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridPertemuan).BeginInit();
            SuspendLayout();
            // 
            // panelChildTopDashboard
            // 
            panelChildTopDashboard.Controls.Add(panelChildTopRightDashboard);
            panelChildTopDashboard.Controls.Add(panelChildTopLeftDashboard);
            panelChildTopDashboard.Dock = DockStyle.Top;
            panelChildTopDashboard.Location = new Point(0, 0);
            panelChildTopDashboard.Name = "panelChildTopDashboard";
            panelChildTopDashboard.Size = new Size(1100, 88);
            panelChildTopDashboard.TabIndex = 0;
            // 
            // panelChildTopRightDashboard
            // 
            panelChildTopRightDashboard.Controls.Add(btnReload);
            panelChildTopRightDashboard.Dock = DockStyle.Right;
            panelChildTopRightDashboard.Location = new Point(900, 0);
            panelChildTopRightDashboard.Name = "panelChildTopRightDashboard";
            panelChildTopRightDashboard.Size = new Size(200, 88);
            panelChildTopRightDashboard.TabIndex = 1;
            // 
            // panelChildTopLeftDashboard
            // 
            panelChildTopLeftDashboard.Controls.Add(label2);
            panelChildTopLeftDashboard.Controls.Add(label1);
            panelChildTopLeftDashboard.Dock = DockStyle.Left;
            panelChildTopLeftDashboard.Location = new Point(0, 0);
            panelChildTopLeftDashboard.Name = "panelChildTopLeftDashboard";
            panelChildTopLeftDashboard.Size = new Size(282, 88);
            panelChildTopLeftDashboard.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(126, 209, 7);
            label2.Location = new Point(20, 24);
            label2.Name = "label2";
            label2.Size = new Size(214, 15);
            label2.TabIndex = 1;
            label2.Text = "Ringkasan Aplikasi Anda Berada Disini";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 63, 98);
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.Size = new Size(123, 37);
            label1.TabIndex = 0;
            label1.Text = "Beranda";
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(282, 542);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblCountRekamMedis);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label10);
            panel5.Location = new Point(25, 395);
            panel5.Name = "panel5";
            panel5.Size = new Size(231, 100);
            panel5.TabIndex = 3;
            // 
            // lblCountRekamMedis
            // 
            lblCountRekamMedis.AutoSize = true;
            lblCountRekamMedis.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountRekamMedis.Location = new Point(149, 31);
            lblCountRekamMedis.Name = "lblCountRekamMedis";
            lblCountRekamMedis.Size = new Size(49, 37);
            lblCountRekamMedis.TabIndex = 6;
            lblCountRekamMedis.Text = "20";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(126, 209, 7);
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(18, 16);
            label9.Name = "label9";
            label9.Size = new Size(34, 15);
            label9.TabIndex = 4;
            label9.Text = "Total";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label10.Location = new Point(14, 35);
            label10.Name = "label10";
            label10.Size = new Size(103, 20);
            label10.TabIndex = 3;
            label10.Text = "Rekam Medis";
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblCountJanjiTemu);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label8);
            panel4.Location = new Point(25, 271);
            panel4.Name = "panel4";
            panel4.Size = new Size(231, 100);
            panel4.TabIndex = 2;
            // 
            // lblCountJanjiTemu
            // 
            lblCountJanjiTemu.AutoSize = true;
            lblCountJanjiTemu.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountJanjiTemu.Location = new Point(149, 30);
            lblCountJanjiTemu.Name = "lblCountJanjiTemu";
            lblCountJanjiTemu.Size = new Size(49, 37);
            lblCountJanjiTemu.TabIndex = 5;
            lblCountJanjiTemu.Text = "20";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.FromArgb(126, 209, 7);
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(18, 15);
            label7.Name = "label7";
            label7.Size = new Size(34, 15);
            label7.TabIndex = 4;
            label7.Text = "Total";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(14, 34);
            label8.Name = "label8";
            label8.Size = new Size(84, 20);
            label8.TabIndex = 3;
            label8.Text = "Janji Temu";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(lblCountDokter);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label6);
            panel3.Location = new Point(25, 146);
            panel3.Name = "panel3";
            panel3.Size = new Size(231, 100);
            panel3.TabIndex = 1;
            // 
            // lblCountDokter
            // 
            lblCountDokter.AutoSize = true;
            lblCountDokter.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountDokter.Location = new Point(149, 31);
            lblCountDokter.Name = "lblCountDokter";
            lblCountDokter.Size = new Size(49, 37);
            lblCountDokter.TabIndex = 4;
            lblCountDokter.Text = "20";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(126, 209, 7);
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(18, 16);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 4;
            label5.Text = "Total";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 35);
            label6.Name = "label6";
            label6.Size = new Size(57, 20);
            label6.TabIndex = 3;
            label6.Text = "Dokter";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lblCountPengguna);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(25, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(231, 100);
            panel2.TabIndex = 0;
            // 
            // lblCountPengguna
            // 
            lblCountPengguna.AutoSize = true;
            lblCountPengguna.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCountPengguna.Location = new Point(149, 30);
            lblCountPengguna.Name = "lblCountPengguna";
            lblCountPengguna.Size = new Size(49, 37);
            lblCountPengguna.TabIndex = 3;
            lblCountPengguna.Text = "20";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(126, 209, 7);
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(18, 16);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Total";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 35);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 0;
            label3.Text = "Pengguna";
            // 
            // panel6
            // 
            panel6.AutoScroll = true;
            panel6.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel6.BackColor = Color.FromArgb(241, 244, 254);
            panel6.Controls.Add(panel8);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(282, 88);
            panel6.Name = "panel6";
            panel6.Padding = new Padding(20);
            panel6.Size = new Size(818, 350);
            panel6.TabIndex = 2;
            // 
            // panel8
            // 
            panel8.BackColor = Color.White;
            panel8.Controls.Add(dtGridRekamMedis);
            panel8.Controls.Add(label17);
            panel8.Controls.Add(label18);
            panel8.Dock = DockStyle.Right;
            panel8.Location = new Point(374, 20);
            panel8.Name = "panel8";
            panel8.Size = new Size(424, 310);
            panel8.TabIndex = 5;
            // 
            // dtGridRekamMedis
            // 
            dtGridRekamMedis.BackgroundColor = Color.FromArgb(237, 255, 240);
            dtGridRekamMedis.BorderStyle = BorderStyle.Fixed3D;
            dtGridRekamMedis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridRekamMedis.Location = new Point(21, 71);
            dtGridRekamMedis.Name = "dtGridRekamMedis";
            dtGridRekamMedis.Size = new Size(383, 209);
            dtGridRekamMedis.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.FromArgb(4, 63, 98);
            label17.Location = new Point(19, 14);
            label17.Name = "label17";
            label17.Size = new Size(200, 21);
            label17.TabIndex = 2;
            label17.Text = "Rekam Medis Minggu Ini";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.FromArgb(126, 209, 7);
            label18.Location = new Point(21, 36);
            label18.Name = "label18";
            label18.Size = new Size(75, 15);
            label18.TabIndex = 2;
            label18.Text = "Daftar Data ";
            // 
            // panel7
            // 
            panel7.BackColor = Color.White;
            panel7.Controls.Add(dtGridPertemuan);
            panel7.Controls.Add(label15);
            panel7.Controls.Add(label16);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(20, 20);
            panel7.Name = "panel7";
            panel7.Size = new Size(332, 310);
            panel7.TabIndex = 4;
            // 
            // dtGridPertemuan
            // 
            dtGridPertemuan.BackgroundColor = Color.FromArgb(237, 255, 240);
            dtGridPertemuan.BorderStyle = BorderStyle.Fixed3D;
            dtGridPertemuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridPertemuan.Location = new Point(21, 71);
            dtGridPertemuan.Name = "dtGridPertemuan";
            dtGridPertemuan.Size = new Size(291, 209);
            dtGridPertemuan.TabIndex = 3;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.FromArgb(4, 63, 98);
            label15.Location = new Point(19, 14);
            label15.Name = "label15";
            label15.Size = new Size(166, 21);
            label15.TabIndex = 2;
            label15.Text = "Pertemuan Bulan Ini";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.FromArgb(126, 209, 7);
            label16.Location = new Point(21, 36);
            label16.Name = "label16";
            label16.Size = new Size(75, 15);
            label16.TabIndex = 2;
            label16.Text = "Daftar Data ";
            // 
            // btnReload
            // 
            btnReload.BackColor = Color.FromArgb(126, 209, 7);
            btnReload.Cursor = Cursors.Hand;
            btnReload.FlatAppearance.BorderSize = 0;
            btnReload.FlatStyle = FlatStyle.Flat;
            btnReload.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReload.ForeColor = Color.White;
            btnReload.IconChar = FontAwesome.Sharp.IconChar.RotateRight;
            btnReload.IconColor = SystemColors.Window;
            btnReload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnReload.IconSize = 20;
            btnReload.Location = new Point(134, 24);
            btnReload.Name = "btnReload";
            btnReload.Size = new Size(46, 34);
            btnReload.TabIndex = 15;
            btnReload.UseVisualStyleBackColor = false;
            btnReload.Click += btnReload_Click;
            // 
            // FormChildDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(1100, 630);
            Controls.Add(panel6);
            Controls.Add(panel1);
            Controls.Add(panelChildTopDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Beranda";
            panelChildTopDashboard.ResumeLayout(false);
            panelChildTopRightDashboard.ResumeLayout(false);
            panelChildTopLeftDashboard.ResumeLayout(false);
            panelChildTopLeftDashboard.PerformLayout();
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridRekamMedis).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridPertemuan).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopDashboard;
        private Panel panelChildTopRightDashboard;
        private Panel panelChildTopLeftDashboard;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private Panel panel5;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private Label label9;
        private Label label10;
        private Label label7;
        private Label label8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label lblCountPengguna;
        private Label lblCountRekamMedis;
        private Label lblCountJanjiTemu;
        private Label lblCountDokter;
        private Panel panel6;
        private Label label16;
        private Label label15;
        private Panel panel7;
        private DataGridView dtGridPertemuan;
        private Panel panel8;
        private DataGridView dtGridRekamMedis;
        private Label label17;
        private Label label18;
        private FontAwesome.Sharp.IconButton btnReload;
    }
}