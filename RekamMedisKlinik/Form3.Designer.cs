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
            panelChildTopDashboard.SuspendLayout();
            panelChildTopLeftDashboard.SuspendLayout();
            SuspendLayout();
            // 
            // panelChildTopDashboard
            // 
            panelChildTopDashboard.Controls.Add(panelChildTopRightDashboard);
            panelChildTopDashboard.Controls.Add(panelChildTopLeftDashboard);
            panelChildTopDashboard.Dock = DockStyle.Top;
            panelChildTopDashboard.Location = new Point(0, 0);
            panelChildTopDashboard.Name = "panelChildTopDashboard";
            panelChildTopDashboard.Size = new Size(727, 93);
            panelChildTopDashboard.TabIndex = 0;
            // 
            // panelChildTopRightDashboard
            // 
            panelChildTopRightDashboard.Dock = DockStyle.Right;
            panelChildTopRightDashboard.Location = new Point(527, 0);
            panelChildTopRightDashboard.Name = "panelChildTopRightDashboard";
            panelChildTopRightDashboard.Size = new Size(200, 93);
            panelChildTopRightDashboard.TabIndex = 1;
            // 
            // panelChildTopLeftDashboard
            // 
            panelChildTopLeftDashboard.Controls.Add(label2);
            panelChildTopLeftDashboard.Controls.Add(label1);
            panelChildTopLeftDashboard.Dock = DockStyle.Left;
            panelChildTopLeftDashboard.Location = new Point(0, 0);
            panelChildTopLeftDashboard.Name = "panelChildTopLeftDashboard";
            panelChildTopLeftDashboard.Size = new Size(274, 93);
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
            // FormChildDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.FromArgb(241, 244, 254);
            ClientSize = new Size(727, 505);
            Controls.Add(panelChildTopDashboard);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormChildDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Beranda";
            panelChildTopDashboard.ResumeLayout(false);
            panelChildTopLeftDashboard.ResumeLayout(false);
            panelChildTopLeftDashboard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelChildTopDashboard;
        private Panel panelChildTopRightDashboard;
        private Panel panelChildTopLeftDashboard;
        private Label label2;
        private Label label1;
    }
}