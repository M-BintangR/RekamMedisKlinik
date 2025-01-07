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
            panelChildTopPengguna = new Panel();
            panelChildTopRightPengguna = new Panel();
            panelChildTopLeftPengguna = new Panel();
            label2 = new Label();
            label1 = new Label();
            panelChildTopPengguna.SuspendLayout();
            panelChildTopLeftPengguna.SuspendLayout();
            SuspendLayout();
            // 
            // panelChildTopPengguna
            // 
            panelChildTopPengguna.Controls.Add(panelChildTopRightPengguna);
            panelChildTopPengguna.Controls.Add(panelChildTopLeftPengguna);
            panelChildTopPengguna.Dock = DockStyle.Top;
            panelChildTopPengguna.Location = new Point(0, 0);
            panelChildTopPengguna.Name = "panelChildTopPengguna";
            panelChildTopPengguna.Size = new Size(727, 93);
            panelChildTopPengguna.TabIndex = 1;
            // 
            // panelChildTopRightPengguna
            // 
            panelChildTopRightPengguna.Dock = DockStyle.Right;
            panelChildTopRightPengguna.Location = new Point(527, 0);
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
            // FormChildPengguna
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(727, 505);
            Controls.Add(panelChildTopPengguna);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildPengguna";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Child Pengguna";
            panelChildTopPengguna.ResumeLayout(false);
            panelChildTopLeftPengguna.ResumeLayout(false);
            panelChildTopLeftPengguna.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopPengguna;
        private Panel panelChildTopRightPengguna;
        private Panel panelChildTopLeftPengguna;
        private Label label2;
        private Label label1;
    }
}