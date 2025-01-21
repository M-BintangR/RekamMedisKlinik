using Microsoft.VisualBasic.ApplicationServices;
using RekamMedisKlinik.Model;
using RekamMedisKlinik.Session;
using System.Net;

namespace RekamMedisKlinik
{
    public partial class FormAkun : Form
    {
        private string level, username, email, password, namaDokter, jenisKelamin, alamat, idUser, pathFileGambar, nameFile, idDokter;
        private string fileDefault = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Assets\\default-picture.png";
        private string fileDestination = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Storage\\";

        public FormAkun()
        {
            InitializeComponent();

            this.cmdLevel.Items.Clear();
            List<string> levels = new List<string> { "admin", "superadmin", "dokter" };
            this.cmdLevel.Items.AddRange(levels.ToArray());

            if (UserSessions.CurrentUser.Role == "dokter")
            {
                panelDokter.Visible = true;
                GetDataDokter();
            }
            else
            {
                panelDokter.Visible = false;
                int panelHeight = panelDokter.Height;
                this.panelDataAkun.Height = panelDataAkun.Height - panelHeight;
                this.panelDataAkun.AutoScroll = false;
            }

            ProfilePicture();
            LoadInformationAccount();
        }

        private void CopyFileDestination()
        {
            string folderTujuan = this.fileDestination;
            if (!System.IO.Directory.Exists(folderTujuan))
            {
                System.IO.Directory.CreateDirectory(folderTujuan);
            }
            string pathTujuan = System.IO.Path.Combine(folderTujuan, this.nameFile);
            System.IO.File.Copy(this.pathFileGambar, pathTujuan, true);
            this.nameFile = System.IO.Path.GetFileName(pathTujuan);
        }

        private void LoadInformationAccount()
        {
            Users users = UserSessions.CurrentUser;

            this.level = users.Role.ToLower();
            this.username = users.Username;
            this.email = users.Email;
            this.idUser = users.Id.ToString();
            this.password = users.Password;

            lblRole.Text = users.Role;
            lblUsername.Text = users.Username;

            txtEmail.Text = users.Email;
            txtUsername.Text = users.Username;
            cmdLevel.Text = users.Role;
        }

        private void UpdateSessionUser()
        {
            UserSessions.CurrentUser.Username = username;
            UserSessions.CurrentUser.Email = email;
            UserSessions.CurrentUser.Role = level;

            if (!string.IsNullOrEmpty(this.nameFile))
            {
                UserSessions.CurrentUser.Avatar = this.nameFile;
            }
        }

        private void GetDataDokter()
        {
            try
            {
                Connection connection = new Connection();

                string query = @"SELECT * FROM doctors WHERE user_id = @idUser";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idUser", this.idUser }
                };

                var results = connection.ExecuteQuery(query, parameters);

                if (results != null && results.Count > 0)
                {
                    var data = results[0];
                    this.namaDokter = data["name_doctor"].ToString() ?? "";
                    this.alamat = data["address_doctor"].ToString() ?? "";
                    this.jenisKelamin = data["sex_doctor"].ToString() ?? "";

                    if (this.jenisKelamin == "laki-laki")
                    {
                        radioLakiLaki.Checked = true;
                    }
                    else
                    {
                        radioPerempuan.Checked = true;
                    }

                    txtNama.Text = this.namaDokter;
                    txtAlamat.Text = this.alamat;
                }
                else
                {
                    MessageBox.Show("Data dokter tidak ditemukan.");
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error");
            }
        }

        private void ProfilePicture()
        {
            // Cek gambar gravatar
            string gravatar = UserSessions.CurrentUser.Gravatar();
            if (!string.IsNullOrEmpty(gravatar) && Uri.IsWellFormedUriString(gravatar, UriKind.Absolute))
            {
                try
                {
                    using (var webClient = new WebClient())
                    {
                        var imageBytes = webClient.DownloadData(gravatar);
                        using (var stream = new MemoryStream(imageBytes))
                        {
                            previewProfile.Image = Image.FromStream(stream);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error memuat Gravatar: " + ex.Message);
                }
            }
            else
            {
                string avatarPath = UserSessions.CurrentUser.AvatarUrl();
                if (!string.IsNullOrEmpty(avatarPath))
                {
                    try
                    {
                        previewProfile.Image = new Bitmap(avatarPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error memuat gambar lokal: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Avatar tidak ditemukan.");
                }
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Reset()
        {
            ProfilePicture();
            LoadInformationAccount();
        }

        private void btnSunting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idUser))
            {
                MessageBox.Show("User tidak ditemukan", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(level))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (UserSessions.CurrentUser.Role == "dokter")
                {
                    if (string.IsNullOrEmpty(namaDokter) || string.IsNullOrEmpty(jenisKelamin) || string.IsNullOrEmpty(alamat))
                    {
                        MessageBox.Show("Semua data dokter harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query = @"UPDATE users 
                    SET username = @username, 
                        password = @password,
                        role = @role, 
                        email = @email
                    WHERE id_user = @id";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@username", username },
                    { "@role", level },
                    { "@email", email },
                    { "@id", idUser },
                    { "@password", password}
                };

                if (!string.IsNullOrEmpty(this.nameFile) && !string.IsNullOrEmpty(this.pathFileGambar))
                {
                    query = @"UPDATE users 
                        SET username = @username, 
                            role = @role, 
                            email = @email,
                            avatar = @avatar
                        WHERE id_user = @id";

                    parameters.Add("@avatar", this.nameFile);

                    try
                    {
                        CopyFileDestination();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Gagal menyimpan file gambar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                Connection connection = new Connection();
                connection.ExecuteQuery(query, parameters);

                if (UserSessions.CurrentUser.Role == "dokter")
                {
                    query = @"UPDATE doctors 
                        SET name_doctor = @name, 
                            address_doctor = @address, 
                            sex_doctor = @sex
                        WHERE id_doctor = @id";

                    parameters = new Dictionary<string, object>
                    {
                        { "@name", namaDokter },
                        { "@address", alamat },
                        { "@sex", jenisKelamin },
                        { "@id", idDokter }
                    };

                    connection.ExecuteQuery(query, parameters);
                    MessageBox.Show("Data dokter berhasil disunting!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                MessageBox.Show("Data akun berhasil disunting!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UpdateSessionUser();
            Reset();
        }

        private void btnAmbilGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg;*.png;*.jpeg;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                this.previewProfile.Image = new Bitmap(open.FileName);
                this.pathFileGambar = open.FileName;

                if (string.IsNullOrEmpty(this.pathFileGambar))
                {
                    MessageBox.Show("Gambar tidak valid atau tidak dipilih!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string ekstensiFile = System.IO.Path.GetExtension(this.pathFileGambar);
                string namaFileUnik = $"IMG_{DateTime.Now.ToString("yyyyMMddHHmmss")}{ekstensiFile}";
                this.nameFile = namaFileUnik;
            }
        }

        private void cmdLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.level = cmdLevel.Text ?? "";
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.email = txtEmail.Text;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.username = txtUsername.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.password = textBox1.Text;
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            this.namaDokter = txtNama.Text;
        }

        private void radioLakiLaki_CheckedChanged(object sender, EventArgs e)
        {
            if (radioLakiLaki.Checked)
            {
                this.jenisKelamin = "laki-laki";
            }
        }

        private void radioPerempuan_CheckedChanged(object sender, EventArgs e)
        {
            if (radioPerempuan.Checked)
            {
                this.jenisKelamin = "perempuan";
            }
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            this.alamat = txtAlamat.Text;
        }
    }
}
