namespace RekamMedisKlinik
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            chcBoxShowPassword = new CheckBox();
            btnLogin = new Button();
            btnCloseLogin = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS UI Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(4, 63, 98);
            label1.Location = new Point(25, 134);
            label1.Name = "label1";
            label1.Size = new Size(88, 27);
            label1.TabIndex = 1;
            label1.Text = "Masuk";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(128, 205, 20);
            label2.Location = new Point(29, 167);
            label2.Name = "label2";
            label2.Size = new Size(173, 17);
            label2.TabIndex = 2;
            label2.Text = "Masukkan data akun anda.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 213);
            label3.Name = "label3";
            label3.Size = new Size(42, 17);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(230, 231, 233);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.CharacterCasing = CharacterCasing.Lower;
            txtEmail.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.Location = new Point(36, 238);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(216, 28);
            txtEmail.TabIndex = 4;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(230, 231, 233);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(36, 311);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.ShortcutsEnabled = false;
            txtPassword.Size = new Size(216, 28);
            txtPassword.TabIndex = 6;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 286);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 5;
            label4.Text = "Password";
            // 
            // chcBoxShowPassword
            // 
            chcBoxShowPassword.AutoSize = true;
            chcBoxShowPassword.Cursor = Cursors.Hand;
            chcBoxShowPassword.Location = new Point(131, 347);
            chcBoxShowPassword.Name = "chcBoxShowPassword";
            chcBoxShowPassword.Size = new Size(128, 21);
            chcBoxShowPassword.TabIndex = 7;
            chcBoxShowPassword.Text = "Show Password?";
            chcBoxShowPassword.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 205, 20);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(35, 403);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(216, 35);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Masuk";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCloseLogin
            // 
            btnCloseLogin.BackColor = Color.White;
            btnCloseLogin.Cursor = Cursors.Hand;
            btnCloseLogin.FlatStyle = FlatStyle.Flat;
            btnCloseLogin.ForeColor = Color.FromArgb(128, 205, 20);
            btnCloseLogin.Location = new Point(35, 457);
            btnCloseLogin.Name = "btnCloseLogin";
            btnCloseLogin.Size = new Size(216, 35);
            btnCloseLogin.TabIndex = 9;
            btnCloseLogin.Text = "Keluar";
            btnCloseLogin.UseVisualStyleBackColor = false;
            btnCloseLogin.Click += btnCloseLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(31, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(223, 57);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(285, 544);
            Controls.Add(pictureBox1);
            Controls.Add(btnCloseLogin);
            Controls.Add(btnLogin);
            Controls.Add(chcBoxShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FROM LOGIN";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label4;
        private CheckBox chcBoxShowPassword;
        private Button btnLogin;
        private Button btnCloseLogin;
        private PictureBox pictureBox1;
    }
}
