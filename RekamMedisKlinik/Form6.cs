using System.Data;

namespace RekamMedisKlinik
{
    public partial class FormChildRekamMedis : Form
    {
        private string diagnosa, resepObat, pengobatan, harga, idAppointment, idPasien, idDokter, idRekamMedis;
        private string fileDefault = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Aseets\\default-picture.png";
        private string fileDestination = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Storage\\";
        public FormChildRekamMedis()
        {
            InitializeComponent();
            LoadDataToGrid();
            LoadChooseJanjiTemu();

            btnHapus.Enabled = false;
            btnSunting.Enabled = false;
            btnTambah.Enabled = true;

            cmbPasien.SelectedValue = "";
        }

        private void LoadChooseJanjiTemu()
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
                    appointments.photo,
                    appointments.id_appointment,
                    doctors.id_doctor, 
                    patients.id_patient
                FROM appointments
                INNER JOIN patients ON appointments.patient_id = patients.id_patient
                INNER JOIN doctors ON appointments.doctor_id = doctors.id_doctor ORDER BY appointments.id_appointment DESC";

                var parameters = new Dictionary<string, object> { };

                var results = connection.ExecuteQuery(query, parameters);

                dataTable.Columns.Add("id_appointment", typeof(string));
                dataTable.Columns.Add("display", typeof(string));

                foreach (var row in results)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["id_appointment"] = row["id_appointment"].ToString();
                    dataRow["display"] = $"Pasien : {row["name_patient"]} Dokter : ({row["name_doctor"]})";
                    dataTable.Rows.Add(dataRow);
                }

                cmbPasien.DataSource = dataTable;
                cmbPasien.DisplayMember = "display";
                cmbPasien.ValueMember = "id_appointment";
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error");
            }
        }

        private DataTable GetDataRekamMedis(string searchQuery = "")
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection connection = new Connection();
                string query = @"
                 SELECT 
                    doctors.name_doctor, 
                    doctors.id_doctor, 
                    patients.name_patient, 
                    patients.id_patient,
                    medical_records.diagnosis,
                    medical_records.recipe,
                    medical_records.price,
                    medical_records.treatment,
                    medical_records.id_medical_record,
                    appointments.photo,
                    appointments.id_appointment
                FROM medical_records
                INNER JOIN patients ON medical_records.patient_id = patients.id_patient
                INNER JOIN doctors ON medical_records.doctor_id = doctors.id_doctor
                LEFT JOIN appointments ON patients.id_patient = appointments.patient_id
                WHERE patients.name_patient LIKE @searchQuery 
                OR doctors.name_doctor LIKE @searchQuery";

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

        private void LoadDataToGrid()
        {
            try
            {
                dtGridRekamMedis.DataSource = GetDataRekamMedis();

                var tableHead = new Dictionary<string, string>
                {
                    { "name_doctor", "Nama Dokter" },
                    { "name_patient", "Nama Pasien" },
                    { "diagnosis", "Diagnosa" },
                    { "price", "Harga / Jumlah Bayar" },
                    { "recipe", "Resep" },
                    { "treetment", "Pengobatan" },
                    { "id_doctor",  "Id Dokter"},
                    { "id_patient", "Id Pasien"},
                    { "id_appointment", "Id Janji Temu"},
                    { "id_medical_record", "Id Rekam Medis" }
                };

                foreach (var head in tableHead)
                {
                    if (dtGridRekamMedis.Columns.Contains(head.Key))
                    {
                        dtGridRekamMedis.Columns[head.Key].HeaderText = head.Value;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cmbPasien_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.idAppointment = cmbPasien.SelectedValue?.ToString() ?? "";

            GetDetailData();

        }

        private void GetDetailData()
        {
            try
            {
                Connection connection = new Connection();
                string query = @"
                SELECT
                    appointments.photo,
                    appointments.id_appointment,
                    doctors.id_doctor, 
                    patients.id_patient
                FROM appointments
                INNER JOIN patients ON appointments.patient_id = patients.id_patient
                INNER JOIN doctors ON appointments.doctor_id = doctors.id_doctor
                WHERE appointments.id_appointment = @id";

                var parameters = new Dictionary<string, object> {
                    { "@id", this.idAppointment }
                };

                var result = connection.ExecuteQuery(query, parameters);

                if (result != null && result.Count > 0)
                {
                    this.idDokter = result[0]["id_doctor"].ToString() ?? "";
                    this.idPasien = result[0]["id_patient"].ToString() ?? "";

                    if (!string.IsNullOrEmpty(result[0]["photo"].ToString()))
                    {
                        string photo = result[0]["photo"].ToString() ?? "";
                        this.previewGambar.Image = new Bitmap(this.fileDestination + photo);
                    }
                    else
                    {
                        this.previewGambar.Image = new Bitmap(fileDefault);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error");
            }
        }

        private void txtDiagnosa_TextChanged(object sender, EventArgs e)
        {
            this.diagnosa = txtDiagnosa.Text;
        }

        private void txtResep_TextChanged(object sender, EventArgs e)
        {
            this.resepObat = txtResep.Text;
        }

        private void txtPengobatan_TextChanged(object sender, EventArgs e)
        {
            this.pengobatan = txtPengobatan.Text;
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            this.harga = txtHarga.Text;
        }

        private void Reset()
        {
            LoadDataToGrid();
            LoadChooseJanjiTemu();

            // clear variabels
            this.diagnosa = "";
            this.harga = "";
            this.resepObat = "";
            this.pengobatan = "";
            this.idDokter = "";
            this.idPasien = "";
            this.idAppointment = "";
            this.idRekamMedis = "";

            // clear properties;
            txtDiagnosa.Text = "";
            txtHarga.Text = "";
            txtPengobatan.Text = "";
            txtResep.Text = "";
            cmbPasien.SelectedValue = "";

            previewGambar.Image = new Bitmap(this.fileDefault);

            // btn enabled status
            btnHapus.Enabled = false;
            btnSunting.Enabled = false;
            btnTambah.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchQuery))
            {
                DataTable filteredData = GetDataRekamMedis(searchQuery);
                dtGridRekamMedis.DataSource = filteredData;
            }
            else
            {
                LoadDataToGrid();
            }
        }

        private void TambahPembayaran()
        {
            try
            {
                if (string.IsNullOrEmpty(idRekamMedis)|| string.IsNullOrEmpty(idAppointment) 
                   || string.IsNullOrEmpty(idPasien))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO payments (patient_id, medical_record_id, appointment_id, status) 
                 VALUES (@patientId, @medicalRecordId, @appointmentId, @status)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@patientId", this.idPasien },
                    { "@medicalRecordId", this.idRekamMedis },
                    { "@appointmentId", this.idAppointment },
                    { "@status", "UNPAID" }
                };
                Connection connection = new Connection();
                connection.ExecuteQuery(query, parameters);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HapusPembayaran()
        {
            if (string.IsNullOrEmpty(idRekamMedis))
            {
                MessageBox.Show("Semua data yang harus dihapus terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = @"DELETE FROM payments WHERE medical_record_id = @idMedicalRecord";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@idMedicalRecord", this.idRekamMedis }
                };

                Connection connection = new Connection();
                var result = connection.ExecuteQuery(query, parameters);

                if (result != null)
                {
                    MessageBox.Show("Pembayaran berhasil dihapus", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pembayaran gagal dihapus", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SuntingPembayaran()
        {
            try
            {
                if (string.IsNullOrEmpty(idRekamMedis) || string.IsNullOrEmpty(idDokter)
                    || string.IsNullOrEmpty(idAppointment) || string.IsNullOrEmpty(idPasien))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string status = "UNPAID";

                string query = @"
                UPDATE payments 
                SET patient_id = @patientId, 
                    medical_record_id = @medicalRecordId, 
                    appointment_id = @appointmentId, 
                    status = @status
                WHERE medical_record_id = @medicalRecordId";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@patientId", this.idPasien },
                    { "@medicalRecordId", this.idRekamMedis },
                    { "@appointmentId", this.idAppointment },
                    { "@status", status }
                };

                Connection connection = new Connection();
                var result = connection.ExecuteQuery(query, parameters);

                if (result != null && result.Count > 0)
                {
                    MessageBox.Show("Pembayaran berhasil diperbarui!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tidak ada perubahan pada data pembayaran.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(resepObat) || string.IsNullOrEmpty(pengobatan)
                    || string.IsNullOrEmpty(harga) || string.IsNullOrEmpty(idPasien) || string.IsNullOrEmpty(idDokter) ||
                    string.IsNullOrEmpty(diagnosa))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string now = DateTime.Now.ToString("yyyy-MM-dd");

                string query = @" INSERT INTO medical_records (patient_id, doctor_id, diagnosis, recipe, price, treatment, date_medical) 
                            VALUES (@pasienId, @dokterId, @diagnosis, @resep, @harga, @pengobatan, @tanggal);
                            SELECT LAST_INSERT_ID();";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@pasienId", idPasien },
                    { "@dokterId", idDokter },
                    { "@diagnosis", diagnosa },
                    { "@resep", resepObat },
                    { "@harga", harga},
                    { "@pengobatan", pengobatan },
                    { "@tanggal", now}
                };

                Connection connection = new Connection();
                var result = connection.ExecuteQuery(query, parameters);

                if (result != null && result.Count > 0)
                {
                    this.idRekamMedis = result[0].Values.First().ToString() ?? "";
                    TambahPembayaran();  
                }

                Reset();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dtGridRekamMedis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapus.Enabled = true;
            btnSunting.Enabled = true;
            btnTambah.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridRekamMedis.Rows[e.RowIndex];
                txtDiagnosa.Text = row.Cells["diagnosis"].Value?.ToString() ?? "";
                txtHarga.Text = row.Cells["price"].Value?.ToString() ?? "";
                txtPengobatan.Text = row.Cells["treatment"].Value?.ToString() ?? "";
                txtResep.Text = row.Cells["recipe"].Value?.ToString() ?? "";

                this.idDokter = row.Cells["id_doctor"].Value?.ToString() ?? "";
                this.idPasien = row.Cells["id_patient"].Value?.ToString() ?? "";
                this.idAppointment = row.Cells["id_appointment"].Value?.ToString() ?? "";
                this.idRekamMedis = row.Cells["id_medical_record"].Value?.ToString() ?? "";

                cmbPasien.SelectedValue = this.idAppointment;

                if (!string.IsNullOrEmpty(row.Cells["photo"].Value?.ToString()))
                {
                    string avatarPath = row.Cells["photo"].Value?.ToString() ?? "";
                    previewGambar.Image = new Bitmap(this.fileDestination + avatarPath);
                }
                else
                {
                    this.previewGambar.Image = new Bitmap(this.fileDefault);
                }

                LoadDataToGrid();
            }

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idRekamMedis))
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmation = MessageBox.Show("Apakah Anda yakin ingin menghapus data rekam medis ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    string query = @"DELETE FROM medical_records WHERE id_medical_record = @idMedicalRecord";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                       { "@idMedicalRecord", this.idRekamMedis }
                    };

                    Connection connection = new Connection();
                    connection.ExecuteQuery(query, parameters);
                    HapusPembayaran();
                    Reset();

                    MessageBox.Show("Data rekam medis berhasil dihapus ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ada yang salah : {err.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSunting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idRekamMedis))
            {
                MessageBox.Show("Pilih data yang ingin disunting terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(resepObat) || string.IsNullOrEmpty(pengobatan)
                    || string.IsNullOrEmpty(harga) || string.IsNullOrEmpty(idPasien) || string.IsNullOrEmpty(idDokter) ||
                    string.IsNullOrEmpty(diagnosa))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string now = DateTime.Now.ToString("yyyy-MM-dd");

                string query = @"UPDATE medical_records 
                    SET patient_id = @pasienId, 
                    doctor_id = @dokterId, 
                    diagnosis = @diagnosis, 
                    recipe = @resep, 
                    price = @harga, treatment = @pengobatan,
                    date_medical = @tanggal 
                    WHERE id_medical_record = @id";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@pasienId", idPasien },
                    { "@dokterId", idDokter },
                    { "@diagnosis", diagnosa },
                    { "@resep", resepObat },
                    { "@harga", harga},
                    { "@pengobatan", pengobatan },
                    { "@tanggal", now},
                    { "@id", idRekamMedis}
                };

                Connection connection = new Connection();
                var result = connection.ExecuteQuery(query, parameters);
                SuntingPembayaran();
                Reset();
                MessageBox.Show("Data berhasil disunting!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
