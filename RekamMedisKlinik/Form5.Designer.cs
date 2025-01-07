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
            panelChildTopDokter.SuspendLayout();
            panelChildTopLeftDokter.SuspendLayout();
            SuspendLayout();
            // 
            // panelChildTopDokter
            // 
            panelChildTopDokter.Controls.Add(panelChildTopRightDokter);
            panelChildTopDokter.Controls.Add(panelChildTopLeftDokter);
            panelChildTopDokter.Dock = DockStyle.Top;
            panelChildTopDokter.Location = new Point(0, 0);
            panelChildTopDokter.Name = "panelChildTopDokter";
            panelChildTopDokter.Size = new Size(743, 93);
            panelChildTopDokter.TabIndex = 2;
            // 
            // panelChildTopRightDokter
            // 
            panelChildTopRightDokter.Dock = DockStyle.Right;
            panelChildTopRightDokter.Location = new Point(543, 0);
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
            // FormChildDokter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(743, 544);
            Controls.Add(panelChildTopDokter);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildDokter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Child Dokter";
            panelChildTopDokter.ResumeLayout(false);
            panelChildTopLeftDokter.ResumeLayout(false);
            panelChildTopLeftDokter.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopDokter;
        private Panel panelChildTopRightDokter;
        private Panel panelChildTopLeftDokter;
        private Label label2;
        private Label label1;
    }
}