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
            panelChildTopRekamMedis = new Panel();
            panelChildTopRightRekamMedis = new Panel();
            panelChildTopLeftRekamMedis = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelChildTopRekamMedis.SuspendLayout();
            panelChildTopLeftRekamMedis.SuspendLayout();
            SuspendLayout();
            // 
            // panelChildTopRekamMedis
            // 
            panelChildTopRekamMedis.Controls.Add(panelChildTopRightRekamMedis);
            panelChildTopRekamMedis.Controls.Add(panelChildTopLeftRekamMedis);
            panelChildTopRekamMedis.Dock = DockStyle.Top;
            panelChildTopRekamMedis.Location = new Point(0, 0);
            panelChildTopRekamMedis.Name = "panelChildTopRekamMedis";
            panelChildTopRekamMedis.Size = new Size(743, 93);
            panelChildTopRekamMedis.TabIndex = 3;
            // 
            // panelChildTopRightRekamMedis
            // 
            panelChildTopRightRekamMedis.Dock = DockStyle.Right;
            panelChildTopRightRekamMedis.Location = new Point(543, 0);
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
            // FormChildRekamMedis
            // 
            AllowDrop = true;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(743, 544);
            Controls.Add(panelChildTopRekamMedis);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildRekamMedis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Child Rekam Medis";
            panelChildTopRekamMedis.ResumeLayout(false);
            panelChildTopLeftRekamMedis.ResumeLayout(false);
            panelChildTopLeftRekamMedis.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopRekamMedis;
        private Panel panelChildTopRightRekamMedis;
        private Panel panelChildTopLeftRekamMedis;
        private Label label2;
        private Label label1;
    }
}