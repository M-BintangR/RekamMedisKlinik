namespace RekamMedisKlinik
{
    partial class FormCetak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCetak));
            label12 = new Label();
            panel1 = new Panel();
            panel5 = new Panel();
            dateEnd = new DateTimePicker();
            dateStart = new DateTimePicker();
            dtGridCetak = new DataGridView();
            panel2 = new Panel();
            panel4 = new Panel();
            lblTitle = new Label();
            lblPretitle = new Label();
            panel3 = new Panel();
            btnCetak = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtGridCetak).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold);
            label12.ForeColor = Color.FromArgb(4, 63, 98);
            label12.Location = new Point(34, 105);
            label12.Name = "label12";
            label12.Size = new Size(0, 17);
            label12.TabIndex = 42;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(10);
            panel1.Size = new Size(719, 374);
            panel1.TabIndex = 45;
            // 
            // panel5
            // 
            panel5.Controls.Add(dateEnd);
            panel5.Controls.Add(dateStart);
            panel5.Controls.Add(dtGridCetak);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(10, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(699, 296);
            panel5.TabIndex = 53;
            // 
            // dateEnd
            // 
            dateEnd.Location = new Point(239, 30);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(200, 23);
            dateEnd.TabIndex = 54;
            dateEnd.Value = new DateTime(2022, 1, 9, 0, 0, 0, 0);
            // 
            // dateStart
            // 
            dateStart.Location = new Point(22, 30);
            dateStart.Name = "dateStart";
            dateStart.Size = new Size(200, 23);
            dateStart.TabIndex = 53;
            dateStart.Value = new DateTime(2025, 1, 9, 0, 0, 0, 0);
            // 
            // dtGridCetak
            // 
            dtGridCetak.BackgroundColor = Color.FromArgb(237, 255, 240);
            dtGridCetak.BorderStyle = BorderStyle.Fixed3D;
            dtGridCetak.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtGridCetak.Location = new Point(22, 69);
            dtGridCetak.Name = "dtGridCetak";
            dtGridCetak.Size = new Size(654, 198);
            dtGridCetak.TabIndex = 52;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(10, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 58);
            panel2.TabIndex = 52;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblTitle);
            panel4.Controls.Add(lblPretitle);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(334, 58);
            panel4.TabIndex = 54;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(4, 63, 98);
            lblTitle.Location = new Point(10, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(109, 21);
            lblTitle.TabIndex = 52;
            lblTitle.Text = "Cetak Dokter";
            // 
            // lblPretitle
            // 
            lblPretitle.AutoSize = true;
            lblPretitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPretitle.ForeColor = Color.FromArgb(126, 209, 7);
            lblPretitle.Location = new Point(12, 31);
            lblPretitle.Name = "lblPretitle";
            lblPretitle.Size = new Size(122, 13);
            lblPretitle.TabIndex = 51;
            lblPretitle.Text = "Cetak Laporan Dokter.";
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCetak);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(569, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(130, 58);
            panel3.TabIndex = 53;
            // 
            // btnCetak
            // 
            btnCetak.BackColor = Color.FromArgb(252, 0, 0);
            btnCetak.Cursor = Cursors.Hand;
            btnCetak.FlatAppearance.BorderSize = 0;
            btnCetak.FlatStyle = FlatStyle.Flat;
            btnCetak.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCetak.ForeColor = Color.White;
            btnCetak.IconChar = FontAwesome.Sharp.IconChar.Print;
            btnCetak.IconColor = SystemColors.Window;
            btnCetak.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCetak.IconSize = 20;
            btnCetak.Location = new Point(24, 10);
            btnCetak.Name = "btnCetak";
            btnCetak.Padding = new Padding(10, 0, 0, 0);
            btnCetak.Size = new Size(94, 34);
            btnCetak.TabIndex = 50;
            btnCetak.Text = "Cetak ";
            btnCetak.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCetak.UseVisualStyleBackColor = false;
            // 
            // FormCetak
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(719, 374);
            Controls.Add(panel1);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormCetak";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Text = "Cetak Dokter";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtGridCetak).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Panel panel1;
        private Panel panel5;
        private DateTimePicker dateEnd;
        private DateTimePicker dateStart;
        private DataGridView dtGridCetak;
        private Panel panel2;
        private Panel panel4;
        private Label lblTitle;
        private Label lblPretitle;
        private Panel panel3;
        private FontAwesome.Sharp.IconButton btnCetak;
    }
}