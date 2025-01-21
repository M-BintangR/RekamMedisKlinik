using System.Data;
namespace RekamMedisKlinik
{
    public partial class FormJanjiTemu : Form
    {
        private string nama, alamat, nomorPonsel, jenisKelamin, idPasien, idDokter, idAppointment;
        private string pathFile, nameFile, nomorKamar, pathFileGambar;
        private DateTime tanggalLahir, jadwal;
        private string fileDefault = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Assets\\default-picture.png";
        private string fileDestination = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Storage\\";

        public FormJanjiTemu()
        {
            InitializeComponent();
            LoadDataPasien();
            LoadDataJanjiTemu();
            LoadChoosePatinet();
            LoadChooseDoctor();

            // default datetime 
            dateTanggalLahir.Value = DateTime.Now;
            dateJanjiTemu.Value = DateTime.Now;

            // default btn patient
            btnTambah.Enabled = true;
            btnHapus.Enabled = false;
            btnSunting.Enabled = false;

            // default btn appointment
            btnTambahJanjiTemu.Enabled = true;
            btnHapusJanjiTemu.Enabled = false;
            btnSuntingJanjiTemu.Enabled = false;

            cmbDokter.SelectedValue = "";
            cmbPasien.SelectedValue = "";
        }

        private void txtNamaPasien_TextChanged(object sender, EventArgs e)
        {
            this.nama = txtNamaPasien.Text;
        }

        private void txtNomorPonsel_TextChanged(object sender, EventArgs e)
        {
            this.nomorPonsel = txtNomorPonsel.Text;
        }

        private void txtAlamat_TextChanged(object sender, EventArgs e)
        {
            this.alamat = txtAlamat.Text;
        }

        private void dateTanggalLahir_ValueChanged(object sender, EventArgs e)
        {
            this.tanggalLahir = dateTanggalLahir.Value;
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

        private void Reset()
        {
            LoadDataPasien();

            // properties clear
            txtNamaPasien.Text = "";
            radioLakiLaki.Checked = false;
            radioPerempuan.Checked = false;
            txtAlamat.Text = "";
            txtNomorPonsel.Text = "";
            dateTanggalLahir.Value = DateTime.Now;

            // variable clear
            this.tanggalLahir = DateTime.Now;
            this.jenisKelamin = "";
            this.nama = "";
            this.nomorPonsel = "";
            this.alamat = "";
            this.idPasien = "";

            btnHapus.Enabled = false;
            btnSunting.Enabled = false;
            btnTambah.Enabled = true;

            // load data
            LoadDataJanjiTemu();
            LoadChoosePatinet();
            LoadChooseDoctor();

            // clear variabel
            this.pathFile = "";
            this.nameFile = "";
            this.jadwal = DateTime.Now;
            this.nomorKamar = "";
            this.pathFileGambar = "";

            // btn default
            btnTambahJanjiTemu.Enabled = true;
            btnHapusJanjiTemu.Enabled = false;
            btnSuntingJanjiTemu.Enabled = false;

            // clear properties
            txtRuangan.Text = "";
            dateJanjiTemu.Value = DateTime.Now;
            cmbDokter.Text = "";
            cmbPasien.Text = "";

            // should able reset preview image
            previewGambar.Image = new Bitmap(this.fileDefault);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void LoadChooseDoctor()
        {
            try
            {
                Connection connection = new Connection();

                string query = @"SELECT name_doctor, id_doctor 
                            FROM doctors ORDER BY id_doctor DESC";

                Dictionary<string, object> parameters = new Dictionary<string, object> { };

                var results = connection.ExecuteQuery(query, parameters);

                DataTable chooseDoctor = new DataTable();
                chooseDoctor.Columns.Add("id_doctor", typeof(string));
                chooseDoctor.Columns.Add("display", typeof(string));

                foreach (var row in results)
                {
                    DataRow dataRow = chooseDoctor.NewRow();
                    dataRow["id_doctor"] = row["id_doctor"].ToString();
                    dataRow["display"] = $"Dokter. {row["name_doctor"]}";
                    chooseDoctor.Rows.Add(dataRow);
                }

                cmbDokter.DataSource = chooseDoctor;
                cmbDokter.DisplayMember = "display";
                cmbDokter.ValueMember = "id_doctor";
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error");
            }
        }

        private void LoadChoosePatinet()
        {
            try
            {
                Connection connection = new Connection();

                string query = @"SELECT name_patient, address_patient, birth_date, sex_patient, 
                            phone_number, id_patient 
                            FROM patients ORDER BY id_patient DESC";

                Dictionary<string, object> parameters = new Dictionary<string, object> { };

                var results = connection.ExecuteQuery(query, parameters);

                DataTable choosePatient = new DataTable();
                choosePatient.Columns.Add("id_patient", typeof(string));
                choosePatient.Columns.Add("display", typeof(string));

                foreach (var row in results)
                {
                    DataRow dataRow = choosePatient.NewRow();
                    dataRow["id_patient"] = row["id_patient"].ToString();
                    dataRow["display"] = $"{(row["sex_patient"].ToString() == "laki-laki" ? "Pak. " : "Ibu. ")} {row["name_patient"]}";
                    choosePatient.Rows.Add(dataRow);
                }

                cmbPasien.DataSource = choosePatient;
                cmbPasien.DisplayMember = "display";
                cmbPasien.ValueMember = "id_patient";
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error");
            }
        }

        private DataTable GetDataPasien(string searchQuery = "")
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection connection = new Connection();

                string query = @"SELECT name_patient, address_patient, birth_date, sex_patient, 
                            phone_number, id_patient 
                            FROM patients WHERE name_patient LIKE @searchQuery OR 
                            phone_number LIKE @searchQuery ORDER BY id_patient DESC";

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

        private DataTable GetDataJanjiTemu(string searchQuery = "")
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection connection = new Connection();
                string query = @"
                SELECT 
                    doctors.name_doctor, 
                    patients.name_patient, 
                    appointments.room,  
                    appointments.date, 
                    appointments.id_appointment,
                    doctors.id_doctor, 
                    patients.id_patient,
                    appointments.photo
                FROM appointments
                INNER JOIN patients ON appointments.patient_id = patients.id_patient
                INNER JOIN doctors ON appointments.doctor_id = doctors.id_doctor
                WHERE patients.name_patient LIKE @searchQuery OR doctors.name_doctor LIKE @searchQuery";

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

        private void LoadDataJanjiTemu()
        {
            try
            {
                dtGridJanjiTemu.DataSource = GetDataJanjiTemu();

                var tableHead = new Dictionary<string, string>
                {
                    { "name_doctor", "Nama Dokter" },
                    { "name_patient", "Nama Pasien" },
                    { "room", "Ruangan" },
                    { "date", "Tanggal"},
                    { "id_doctor",  "Id Dokter"},
                    { "id_appointment",  "Id Janji Temu"},
                    { "id_patient", "Id Pasien"},
                    { "photo", "Gambar" }
                };

                foreach (var head in tableHead)
                {
                    if (dtGridJanjiTemu.Columns.Contains(head.Key))
                    {
                        dtGridJanjiTemu.Columns[head.Key].HeaderText = head.Value;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDataPasien()
        {
            DataTable pasienTable = new DataTable();

            try
            {
                dtGridPasien.DataSource = GetDataPasien();

                var tableHead = new Dictionary<string, string>
                {
                    { "name_patient", "Nama Pasien" },
                    { "address_patient", "Alamat" },
                    { "birth_date", "Tanggal Lahir" },
                    { "sex_patient", "Jenis Kelamin"},
                    { "phone_number",  "Nomor Ponsel"},
                    { "id_patient",  "Id"}
                };

                foreach (var head in tableHead)
                {
                    if (dtGridPasien.Columns.Contains(head.Key))
                    {
                        dtGridPasien.Columns[head.Key].HeaderText = head.Value;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                DataTable filteredData = GetDataPasien(searchQuery);
                dtGridPasien.DataSource = filteredData;
            }
            else
            {
                LoadDataPasien();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(nomorPonsel)
                    || string.IsNullOrEmpty(jenisKelamin) ||
                    string.IsNullOrEmpty(tanggalLahir.ToString()))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string formattedTanggalLahir = tanggalLahir.ToString("yyyy-MM-dd");

                string query = @"INSERT INTO patients (name_patient, address_patient, sex_patient, birth_date, phone_number) 
                         VALUES (@nama, @alamat, @jenisKelamin, @tanggalLahir, @nomorPonsel)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nama", nama },
                    { "@alamat", alamat },
                    { "@jenisKelamin", jenisKelamin },
                    { "@tanggalLahir", formattedTanggalLahir },
                    { "@nomorPonsel", nomorPonsel },
                };

                Connection connection = new Connection();
                connection.ExecuteQuery(query, parameters);
                Reset();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idPasien))
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmation = MessageBox.Show("Apakah Anda yakin ingin menghapus data pasien ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    string query = @"DELETE FROM patients WHERE id_patient = @id_patient";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                       { "@id_patient", this.idPasien }
                    };

                    Connection connection = new Connection();
                    connection.ExecuteQuery(query, parameters);
                    Reset();

                    MessageBox.Show("Data pasien berhasil dihapus ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ada yang salah : {err.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSunting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idPasien))
            {
                MessageBox.Show("Pilih data yang ingin disunting terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(nama) || string.IsNullOrEmpty(nomorPonsel)
                      || string.IsNullOrEmpty(jenisKelamin) ||
                      string.IsNullOrEmpty(tanggalLahir.ToString()))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string formattedTanggalLahir = tanggalLahir.ToString("yyyy-MM-dd");

                string query = @"UPDATE patients SET name_patient = @nama,
                                address_patient = @alamat, sex_patient = @jenisKelamin,
                                birth_date = @tanggalLahir, phone_number = @nomorPonsel
                                WHERE id_patient = @idPatient";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nama", nama },
                    { "@alamat", alamat },
                    { "@jenisKelamin", jenisKelamin },
                    { "@tanggalLahir", formattedTanggalLahir },
                    { "@nomorPonsel", nomorPonsel },
                    { "@idPatient", idPasien}
                };

                Connection connection = new Connection();
                connection.ExecuteQuery(query, parameters);
                Reset();

                MessageBox.Show("Data dokter berhasil disunting.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGridPasien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapus.Enabled = true;
            btnSunting.Enabled = true;
            btnTambah.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridPasien.Rows[e.RowIndex];
                txtNamaPasien.Text = row.Cells["name_patient"].Value?.ToString() ?? "";
                txtNomorPonsel.Text = row.Cells["phone_number"].Value?.ToString() ?? "";
                txtAlamat.Text = row.Cells["address_patient"].Value?.ToString() ?? "";
                if (row.Cells["birth_date"].Value != null)
                {
                    DateTime birthDate;
                    if (DateTime.TryParse(row.Cells["birth_date"].Value.ToString(), out birthDate))
                    {
                        dateTanggalLahir.Value = birthDate;
                    }
                    else
                    {
                        MessageBox.Show("Tanggal lahir tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.jenisKelamin = row.Cells["sex_patient"].Value?.ToString() ?? "";
                this.idPasien = row.Cells["id_patient"].Value?.ToString() ?? "";

                if (jenisKelamin == "laki-laki")
                {
                    radioLakiLaki.Checked = true;
                }
                else if (jenisKelamin == "perempuan")
                {
                    radioPerempuan.Checked = true;
                }
                else
                {
                    radioPerempuan.Checked = false;
                    radioLakiLaki.Checked = false;
                }

                LoadDataPasien();
            }
        }


        private void btnResetJanjiTemu_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dateJanjiTemu_ValueChanged(object sender, EventArgs e)
        {
            this.jadwal = dateJanjiTemu.Value;
        }

        private void txtRuangan_TextChanged(object sender, EventArgs e)
        {
            this.nomorKamar = txtRuangan.Text;
        }

        private void cmbDokter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idDokter = cmbDokter.SelectedValue?.ToString() ?? "";
        }

        private void cmbPasien_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idPasien = cmbPasien.SelectedValue?.ToString() ?? "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = textBox4.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                DataTable filteredData = GetDataJanjiTemu(searchQuery);
                dtGridJanjiTemu.DataSource = filteredData;
            }
            else
            {
                LoadDataJanjiTemu();
            }
        }

        private void CreateDataJanjiTemu()
        {
            try
            {
                if (string.IsNullOrEmpty(idPasien) || string.IsNullOrEmpty(idDokter) ||
                    string.IsNullOrEmpty(nomorKamar) || string.IsNullOrEmpty(jadwal.ToString()))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO appointments (
                        doctor_id, patient_id, date, photo, room) 
                         VALUES (@doctorId, @patientId, @date, @photo, @room)";

                string formatTanggal = jadwal.ToString("yyyy-MM-dd");

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@doctorId", idDokter },
                    { "@patientId", idPasien },
                    { "@date", jadwal },
                    { "@photo", nameFile},
                    { "@room", nomorKamar},
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


        private void btnTambahJanjiTemu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.pathFileGambar))
            {
                MessageBox.Show("Silakan pilih gambar terlebih dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                CopyFileDestination();
                CreateDataJanjiTemu();
                MessageBox.Show("File gambar berhasil di upload", "success");
            }
            catch (Exception err)
            {
                MessageBox.Show("File gagal disimpan,terjadi masalah" + err.Message, "error");
            }
        }

        private void dtGridJanjiTemu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapusJanjiTemu.Enabled = true;
            btnSuntingJanjiTemu.Enabled = true;
            btnTambahJanjiTemu.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridJanjiTemu.Rows[e.RowIndex];
                txtRuangan.Text = row.Cells["room"].Value?.ToString() ?? "";

                if (row.Cells["date"].Value != null)
                {
                    DateTime date;
                    if (DateTime.TryParse(row.Cells["date"].Value.ToString(), out date))
                    {
                        dateJanjiTemu.Value = date;
                    }
                    else
                    {
                        MessageBox.Show("Jadwal janji temu tidak valid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                this.idDokter = row.Cells["id_doctor"].Value?.ToString() ?? "";
                this.idPasien = row.Cells["id_patient"].Value?.ToString() ?? "";
                this.idAppointment = row.Cells["id_appointment"].Value?.ToString() ?? "";

                if (!string.IsNullOrEmpty(row.Cells["photo"].Value?.ToString()))
                {
                    string avatarPath = row.Cells["photo"].Value?.ToString() ?? "";
                    previewGambar.Image = new Bitmap(this.fileDestination + avatarPath);
                }
                else
                {
                    this.previewGambar.Image = new Bitmap(this.fileDefault);
                }

                cmbPasien.SelectedValue = this.idPasien;
                cmbDokter.SelectedValue = this.idDokter;
            }
        }

        private void btnHapusJanjiTemu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idAppointment))
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmation = MessageBox.Show("Apakah Anda yakin ingin menghapus data janji temu ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    string query = @"DELETE FROM appointments WHERE id_appointment = @id_appointment";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                       { "@id_appointment", this.idAppointment }
                    };

                    Connection connection = new Connection();
                    connection.ExecuteQuery(query, parameters);
                    Reset();

                    MessageBox.Show("Data janji temu berhasil dihapus ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ada yang salah : {err.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuntingJanjiTemu_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(idPasien) || string.IsNullOrEmpty(idDokter) ||
                    string.IsNullOrEmpty(nomorKamar) || string.IsNullOrEmpty(jadwal.ToString()))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"UPDATE appointments set doctor_id = @doctorId, 
                            patient_id = @patientId, 
                            date = @date, room = @room 
                            WHERE id_appointment = @idAppointment";

                string formatTanggal = jadwal.ToString("yyyy-MM-dd");

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@doctorId", idDokter },
                    { "@patientId", idPasien },
                    { "@date", jadwal },
                    { "@room", nomorKamar},
                    { "@idAppointment", idAppointment}
                };

                if (!string.IsNullOrEmpty(this.nameFile) && !string.IsNullOrEmpty(this.pathFileGambar))
                {
                    query = @"UPDATE appointments set doctor_id = @doctorId, 
                            patient_id = @patientId, 
                            date = @date, 
                            photo = @photo, room = @room 
                            WHERE id_appointment = @idAppointment";

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
                Reset();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
