using FontAwesome.Sharp;
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

            // Default Activate Button
            ActivateButton(btnBeranda, defaultColor);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Current Button 
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = activeColor;
                currentBtn.ForeColor = color;
                currentBtn.IconColor = color;

                // Border Rigth Button Menu                    
                rightBorderBtn.BackColor = color;
                rightBorderBtn.Location = new Point(panelMenu.Width - 5, currentBtn.Location.Y);
                rightBorderBtn.Visible = true;
                rightBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            // Disabled Button 
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.Transparent;
                currentBtn.ForeColor = defaultColor;
                currentBtn.IconColor = defaultColor;
            }
        }

        private void btnBeranda_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, defaultColor);
        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, defaultColor);
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, defaultColor);
        }

        private void btnRekamMedis_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, defaultColor);
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, defaultColor);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximalSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                // Jika form dalam keadaan normal, maka ubah menjadi maksimal
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
    }
}
