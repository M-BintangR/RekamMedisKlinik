using System.Data;

namespace RekamMedisKlinik
{
    public partial class FormChildPengguna : Form
    {
        private string nameFile, pathFileGambar, level, email, username, password;
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

            SetButtonState(btnSunting);
            SetButtonState(btnHapus);
            SetButtonState(btnTambah);
        }

        private void SetButtonState(Button button)
        {
            if (!button.Enabled)
            {
                button.BackColor = Color.FromArgb(235,235,235); 
                button.ForeColor = Color.Black;
            }
        }

        private void btnAmbilGambar_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg;*.png;*.jpeg;";

            if (open.ShowDialog() == DialogResult.OK)
            {
                this.previewGambar.Image = new Bitmap(open.FileName);
                this.pathFileGambar = open.FileName;
                string ekstensiFile = System.IO.Path.GetExtension(this.pathFileGambar);
                string namaFileUnik = $"IMG_{DateTime.Now.ToString("yyyyMMddHHmmss")}{ekstensiFile}";
                this.nameFile = namaFileUnik;
            }
        }

        private void CopyFileDestination()
        {
            // destination file
            string folderTujuan = @"D:\PRAKTIKUM C SHARP\RekamMedisKlinik\RekamMedisKlinik\Storage\";

            // created file
            if (!System.IO.Directory.Exists(folderTujuan))
            {
                System.IO.Directory.CreateDirectory(folderTujuan);
            }

            // path combination destination 
            string pathTujuan = System.IO.Path.Combine(folderTujuan, this.nameFile);

            // copy file 
            System.IO.File.Copy(this.pathFileGambar, pathTujuan, true);

            // save name file
            this.nameFile = pathTujuan;
            MessageBox.Show(nameFile);
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
            // load data
            LoadDataToGrid();

            // should to able all text box
            this.txtEmail.Text = "";
            this.txtUsername.Text = "";
            this.textBox1.Text = "";

            // should able reset selected combo box
            cmdLevel.SelectedIndex = -1;

            // should able reset preview image
            previewGambar.Image = null;

            // should able reset variable 
            this.password = "";
            this.email = "";
            this.username = "";
            this.level = "";
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
            }catch(Exception err)
            {
                MessageBox.Show("File gagal disimpan,terjadi masalah" + err.Message, "error");
            }
        }

        private DataTable GetDataPengguna()
        {
            DataTable dataTable = new DataTable();
            try
            {
                Connection connection = new Connection();
                string query = @"SELECT username, role, email FROM users";
                var results = connection.ExecuteQuery(query, new Dictionary<string, object>());
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
                MessageBox.Show($"email : {email} pass : {password} level : {level} username : {username}");
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

            try{
                dtGridPengguna.DataSource = penggunaTable;

                var tableHead = new Dictionary<string, string>
                {
                    { "username", "Username" },
                    { "role", "Level" },
                    { "email", "Alamat Surel (Email)" }
                };

                foreach (var head in tableHead)
                {
                    if (dtGridPengguna.Columns.Contains(head.Key))
                    {
                        dtGridPengguna.Columns[head.Key].HeaderText = head.Value;
                    }
                }
            }catch (Exception err){
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
