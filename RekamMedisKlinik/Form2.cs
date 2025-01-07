﻿using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RekamMedisKlinik
{
    public partial class FormMenu : Form
    {
        private IconButton currentBtn;
        private Panel rightBorderBtn;
        private Color activeColor = Color.FromArgb(231, 246, 255);
        private Color defaultColor = Color.FromArgb(4, 63, 98);

        public FormMenu()
        {
            InitializeComponent();

            rightBorderBtn = new Panel();
            rightBorderBtn.Size = new Size(5, 42);
            panelMenu.Controls.Add(rightBorderBtn);

            // default activated button
            ActivateButton(btnBeranda, defaultColor);

            // default child form
            openChildForm(new FormChildDashboard());
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // current button 
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = activeColor;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

                // border right button menu                   
                rightBorderBtn.BackColor = color;
                rightBorderBtn.Location = new Point(panelMenu.Width - 5, currentBtn.Location.Y);
                rightBorderBtn.Visible = true;
                rightBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            // disabled button 
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = defaultColor;
                currentBtn.IconColor = defaultColor;
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildDashboard());
            ActivateButton(sender, defaultColor);
        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildPengguna());
            ActivateButton(sender, defaultColor);
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildDokter());
            ActivateButton(sender, defaultColor);
        }

        private void btnRekamMedis_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildRekamMedis());
            ActivateButton(sender, defaultColor);
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildPembayaran());
            ActivateButton(sender, defaultColor);
        }

        private void btnMaximalSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                // should to able maximized if windows state not maximized
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            if(this.WindowState != FormWindowState.Minimized)
            {
                // should to able minimized if windows state not minimized
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private Form acitiveForm = null;
        private void openChildForm(Form childForm)
        {
            if (acitiveForm != null)
                acitiveForm.Close();
            acitiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
