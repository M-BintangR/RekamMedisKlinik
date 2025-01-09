using FontAwesome.Sharp;
using Microsoft.VisualBasic.ApplicationServices;
using RekamMedisKlinik.Session;
using System.Net;

namespace RekamMedisKlinik
{
    public partial class FormMenu : Form
    {
        private IconButton currentBtn;
        private Panel rightBorderBtn;
        private Color activeColor = Color.FromArgb(231, 246, 255);
        private Color defaultColor = Color.FromArgb(4, 63, 98);
        private int originalPanelWidth;
        private User user = new User();

        public FormMenu()
        {
            InitializeComponent();

            originalPanelWidth = this.panelMenu.Width;
            rightBorderBtn = new Panel();
            rightBorderBtn.Size = new Size(5, 42);
            panelMenu.Controls.Add(rightBorderBtn);

            // default activated button
            ActivateButton(btnBeranda, defaultColor);

            // default child form
            openChildForm(new FormChildDashboard());

            // default close submenus
            this.panelSubmenuLaporan.Visible = false;
            this.panelMenu.HorizontalScroll.Visible = false;

            // change username & role label on top left navbar label
            this.lblUsername.Text = UserSessions.CurrentUser.Username;
            this.lblRole.Text = UserSessions.CurrentUser.Role;

            // run avatar url
            ProfilePicture();
        }

        private void ProfilePicture()
        {
            // get avatar url
            string avatarUrl = UserSessions.CurrentUser.AvatarUrl();
            if (!string.IsNullOrEmpty(avatarUrl) && Uri.IsWellFormedUriString(avatarUrl, UriKind.Absolute))
            {
                try{
                    using (var webClient = new WebClient())
                    {
                        var imageBytes = webClient.DownloadData(avatarUrl);
                        using (var stream = new MemoryStream(imageBytes))
                        {
                            pictureBox2.Image = Image.FromStream(stream);
                        }
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Gagal memuat gambar: " + ex.Message);
                }
            }else{
                MessageBox.Show("Avatar tidak ditemukan atau URL tidak valid.");
            }
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

        //sub menu method system
        private void HideSubMenu()
        {
            if (this.panelSubmenuLaporan.Visible)
            {
                this.panelSubmenuLaporan.Visible = false;
                if (this.WindowState == FormWindowState.Normal)
                    this.panelMenu.AutoScroll = false;
                this.panelMenu.Width = originalPanelWidth;
            }
        }


        // activate system method
        private void ShowSubMenu(Panel subMenu)
        {
            if (!subMenu.Visible)
            {
                HideSubMenu();
                subMenu.Visible = true;
                subMenu.BackColor = Color.FromArgb(242, 255, 222);

                if (this.WindowState == FormWindowState.Normal)
                    this.panelMenu.Width += 18;
                this.panelMenu.AutoScroll = true;

            }
            else
            {
                subMenu.Visible = false;

                if (this.WindowState == FormWindowState.Normal)
                    this.panelMenu.AutoScroll = false;
                this.panelMenu.Width = originalPanelWidth;
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


        // sidebar method handle click
        private void btnBeranda_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildDashboard());
            ActivateButton(sender, defaultColor);

            // should be able to hide sub menus;
            HideSubMenu();
        }

        private void btnPengguna_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildPengguna());
            ActivateButton(sender, defaultColor);

            // should be able to hide sub menus;
            HideSubMenu();
        }

        private void btnDokter_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildDokter());
            ActivateButton(sender, defaultColor);

            // should be able to hide sub menus;
            HideSubMenu();
        }

        private void btnRekamMedis_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildRekamMedis());
            ActivateButton(sender, defaultColor);

            // should be able to hide sub menus;
            HideSubMenu();
        }

        private void btnPembayaran_Click(object sender, EventArgs e)
        {
            openChildForm(new FormChildPembayaran());
            ActivateButton(sender, defaultColor);

            // should be able to hide sub menus;
            HideSubMenu();
        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, defaultColor);
            // showing sub menus report
            ShowSubMenu(this.panelSubmenuLaporan);
        }

        private void btnJanjiTemu_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, defaultColor);
            openChildForm(new FormJanjiTemu());

            // should be able to hide sub menus;
            HideSubMenu();
        }

        private void btnAkunSaya_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, defaultColor);
            openChildForm(new FormAkun());

            // should be able to hide sub menus;
            HideSubMenu();
        }

        // button header system method
        private void btnMaximalSize_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Maximized)
            {
                // should to able maximized if windows state not maximized
                this.WindowState = FormWindowState.Maximized;
                this.panelMenu.Width = originalPanelWidth;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            // exit application run
            Application.Exit();
        }

        private void btnMinimized_Click(object sender, EventArgs e)
        {
            if (this.WindowState != FormWindowState.Minimized)
            {
                // should to able minimized if windows state not minimized
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }


        // rendering component child system method
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // should be able clear session user
            UserSessions.CurrentUser = null;

            // should be able copy form list if form is active 
            var openForms = Application.OpenForms.Cast<Form>().ToList();

            // should be able close form list 
            foreach (Form form in openForms)
            {
                if (form is not FormLogin) // check loop, is login form or not
                {
                    form.Close();
                }
            }

            // should be able show form login before close all form
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }

        private FormCetak formCetakDokter;
        private FormCetak formCetakPembayaran;
        private FormCetak formCetakRekamMedis;

        private void btnLaporanDokter_Click(object sender, EventArgs e)
        {
            if (formCetakDokter == null || formCetakDokter.IsDisposed)
            {
                formCetakDokter = new FormCetak("dokter");
            }
            ToggleForm(formCetakDokter);
        }

        private void btnLaporanPembayaran_Click(object sender, EventArgs e)
        {
            if (formCetakPembayaran == null || formCetakPembayaran.IsDisposed)
            {
                formCetakPembayaran = new FormCetak("riwayat pembayaran");
            }
            ToggleForm(formCetakPembayaran);
        }

        private void btnLaporanRekamMedis_Click(object sender, EventArgs e)
        {
            if (formCetakRekamMedis == null || formCetakRekamMedis.IsDisposed)
            {
                formCetakRekamMedis = new FormCetak("rekam medis");
            }
            ToggleForm(formCetakRekamMedis);
        }

        private void ToggleForm(Form form)
        {
            if (form.Visible)
            {
                form.Hide();
            }
            else
            {
                form.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
