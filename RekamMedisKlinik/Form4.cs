using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace RekamMedisKlinik
{
    public partial class FormChildPengguna : Form
    {
        private string nameFile, pathFileGambar, level, email, username, password, fileUrl, idUser;
        private string fileDefault = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Aseets\\default-picture.png";
        private string fileDestination = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Storage\\";

        public FormChildPengguna()
        {
            InitializeComponent();
            this.cmdLevel.Items.Clear();
            List<string> levels = new List<string> { "admin", "superadmin", "dokter" };
            this.cmdLevel.Items.AddRange(levels.ToArray());

            // load data
            LoadDataToGrid();

            // default button
            btnSunting.Enabled = false;
            btnHapus.Enabled = false;
            btnTambah.Enabled = true;
        }

        private void btnAmbilGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg;*.png;*.jpeg;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                this.previewGambar.Image = new Bitmap(open.FileName);
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

        private void cmdLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.level = cmdLevel.Text;
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            this.username = txtUsername.Text;
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            this.email = txtEmail.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.password = textBox1.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            // enabled button
            btnTambah.Enabled = true;
            btnSunting.Enabled = false;
            btnHapus.Enabled = false;

            // load data
            LoadDataToGrid();

            // should to able all text box
            this.txtEmail.Text = "";
            this.txtUsername.Text = "";
            this.textBox1.Text = "";
            this.txtSearch.Text = "";

            // should able reset selected combo box
            cmdLevel.SelectedIndex = -1;

            // should able reset preview image
            previewGambar.Image = new Bitmap(this.fileDefault);

            // should able reset variable 
            this.password = "";
            this.email = "";
            this.username = "";
            this.level = "";
            this.idUser = "";
            this.pathFileGambar = "";

            // should focus to txtUsername 
            txtUsername.Focus();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.pathFileGambar))
            {
                MessageBox.Show("Silakan pilih gambar terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CopyFileDestination();
                CreateData();
                MessageBox.Show("File gambar berhasil di upload", "success");
            }
            catch (Exception err)
            {
                MessageBox.Show("File gagal disimpan,terjadi masalah" + err.Message, "error");
            }
        }

        private DataTable GetDataPengguna(string searchQuery = "")
        {
            DataTable dataTable = new DataTable();
            try
            {
                Connection connection = new Connection();

                string query = @"SELECT username, role, email, avatar, id_user 
                         FROM users 
                         WHERE username LIKE @searchQuery OR email LIKE @searchQuery";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@searchQuery", "%" + searchQuery + "%" }
                };

                var results = connection.ExecuteQuery(query, parameters);
                if (results != null && results.Count > 0)
                {
                    foreach (var key in results[0].Keys)
                    {
                        dataTable.Columns.Add(key);
                    }

                    foreach (var row in results)
                    {
                        DataRow dataRow = dataTable.NewRow();
                        foreach (var item in row)
                        {
                            dataRow[item.Key] = item.Value ?? DBNull.Value;
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }

                return dataTable;
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error");
                return dataTable;
            }
        }


        private void CreateData()
        {
            try
            {
                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) ||
                    string.IsNullOrEmpty(email) || string.IsNullOrEmpty(level))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO users (username, password, email, role, avatar) 
                         VALUES (@username, @password, @email, @role, @avatar)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@username", username },
                    { "@password", password },
                    { "@email", email },
                    { "@role", level },
                    { "@avatar", nameFile }
                };

                Connection connection = new Connection();
                connection.ExecuteQuery(query, parameters);
                Reset();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataToGrid()
        {
            DataTable penggunaTable = GetDataPengguna();

            try
            {
                dtGridPengguna.DataSource = penggunaTable;

                var tableHead = new Dictionary<string, string>
                {
                    { "username", "Username" },
                    { "role", "Level" },
                    { "email", "Alamat Surel (Email)" },
                    { "avatar", "Foto"},
                    { "id_user",  "Id User"}
                };


                foreach (var head in tableHead)
                {
                    if (dtGridPengguna.Columns.Contains(head.Key))
                    {
                        dtGridPengguna.Columns[head.Key].HeaderText = head.Value;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGridPengguna_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSunting.Enabled = true;
            btnHapus.Enabled = true;
            btnTambah.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridPengguna.Rows[e.RowIndex];

                txtEmail.Text = row.Cells["email"].Value?.ToString() ?? "";
                txtUsername.Text = row.Cells["username"].Value?.ToString() ?? "";
                cmdLevel.Text = row.Cells["role"].Value?.ToString() ?? "";

                this.idUser = row.Cells["id_user"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(row.Cells["avatar"].Value?.ToString()))
                {
                    string avatarPath = row.Cells["avatar"].Value?.ToString() ?? "";
                    this.fileUrl = avatarPath;
                    this.previewGambar.Image = new Bitmap(fileDestination + avatarPath);
                }
                else
                {
                    this.previewGambar.Image = new Bitmap(this.fileDefault);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                DataTable filteredData = GetDataPengguna(searchQuery);
                dtGridPengguna.DataSource = filteredData;
            }
            else
            {
                LoadDataToGrid();
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idUser))
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmation = MessageBox.Show("Apakah Anda yakin ingin menghapus data pengguna ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    string query = @"DELETE FROM users WHERE id_user = @id_user";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                       { "@id_user", this.idUser }
                    };

                    Connection connection = new Connection();
                    connection.ExecuteQuery(query, parameters);
                    Reset();

                    MessageBox.Show("Data pengguna berhasil dihapus ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ada yang salah : {err.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSunting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idUser))
            {
                MessageBox.Show("Pilih data yang ingin disunting terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(this.username) || string.IsNullOrEmpty(this.email) || string.IsNullOrEmpty(this.level))
            {
                MessageBox.Show("Username, Email, dan Level harus diisi!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"UPDATE users SET username = @username, email = @email, role = @role WHERE id_user = @id_user";

            Dictionary<string, object> parameters = new Dictionary<string, object>
            {
                { "@username", this.username },
                { "@email", this.email },
                { "@role", this.level },
                { "@id_user", this.idUser }
            };

            if (!string.IsNullOrEmpty(this.password))
            {
                query = @"UPDATE users SET username = @username, password = @password, email = @email, role = @role WHERE id_user = @id_user";
                parameters.Add("@password", this.password);  
            }

            if (!string.IsNullOrEmpty(this.nameFile) && !string.IsNullOrEmpty(this.pathFileGambar))
            {
                query = @"UPDATE users SET username = @username, email = @email, role = @role, avatar = @avatar WHERE id_user = @id_user";
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

            try
            {
                Connection connection = new Connection();
                connection.ExecuteQuery(query, parameters);
                MessageBox.Show("Data pengguna berhasil diperbarui", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset(); 
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
