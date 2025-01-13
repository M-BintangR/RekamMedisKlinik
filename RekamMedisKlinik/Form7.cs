using System.Data;

namespace RekamMedisKlinik
{
    public partial class FormChildPembayaran : Form
    {
        private string namaDokter, namaPasien, diagnosa, pengobatan, resep, harga, idPembayaran;
        private string fileDefault = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Aseets\\default-picture.png";
        private string fileDestination = @"D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Storage\\";

        public FormChildPembayaran()
        {
            InitializeComponent();

            btnBayar.Enabled = false;
            lblStatus.Visible = false;

            LoadDataToGrid();
        }

        private void FormChildPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void txtNamaDokter_TextChanged(object sender, EventArgs e)
        {
            this.namaDokter = txtNamaDokter.Text;
        }

        private void txtDiagnosa_TextChanged(object sender, EventArgs e)
        {
            this.diagnosa = txtDiagnosa.Text;
        }

        private void txtPengobatan_TextChanged(object sender, EventArgs e)
        {
            this.pengobatan = txtPengobatan.Text;
        }

        private void txtNamaPasien_TextChanged(object sender, EventArgs e)
        {
            this.namaPasien = txtNamaPasien.Text;
        }

        private void txtResep_TextChanged(object sender, EventArgs e)
        {
            this.resep = txtResep.Text;
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            this.harga = txtHarga.Text;
        }

        private void Reset()
        {
            LoadDataToGrid();
            btnBayar.Enabled = false;

            // clear variable 
            this.namaPasien = "";
            this.namaDokter = "";
            this.harga = "";
            this.diagnosa = "";
            this.pengobatan = "";
            this.resep = "";

            // clear properties 
            txtNamaDokter.Text = "";
            txtNamaPasien.Text = "";
            txtDiagnosa.Text = "";
            txtHarga.Text = "";
            txtResep.Text = "";
            txtPengobatan.Text = "";

            // visible
            lblStatus.Visible = false;
        }

        private DataTable GetDataPembayaran(string searchQuery = "")
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection connection = new Connection();
                string query = @"
                    SELECT 
                        payments.status,
                        patients.name_patient,
                        doctors.name_doctor,
                        medical_records.diagnosis,
                        medical_records.recipe,
                        medical_records.price,
                        medical_records.treatment,
                        appointments.photo,
                        patients.id_patient,
                        doctors.id_doctor,
                        doctors.user_id,
                        users.avatar,
                        payments.id_payment
                    FROM payments
                    INNER JOIN patients ON payments.patient_id = patients.id_patient
                    INNER JOIN medical_records ON payments.medical_record_id = medical_records.id_medical_record
                    INNER JOIN doctors ON medical_records.doctor_id = doctors.id_doctor
                    INNER JOIN appointments ON payments.appointment_id = appointments.id_appointment
                    INNER JOIN users ON doctors.user_id = users.id_user
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
                dtGridPembayaran.DataSource = GetDataPembayaran();

                var tableHead = new Dictionary<string, string>
                {
                    { "status", "Status Pembayaran"},
                    { "name_doctor", "Nama Dokter" },
                    { "name_patient", "Nama Pasien" },
                    { "diagnosis", "Diagnosa" },
                    { "price", "Harga / Jumlah Bayar" },
                    { "recipe", "Resep" },
                    { "treetment", "Pengobatan" },

                    { "id_doctor",  "Id Dokter"},
                    { "id_patient", "Id Pasien"},
                    { "id_appointment", "Id Janji Temu"},
                    { "id_medical_record", "Id Rekam Medis" },
                    { "avatar", "Foto Dokter" },
                    { "photo", "Foto Pasien"},
                    { "user_id", "Id Akun Dokter" }
                };

                foreach (var head in tableHead)
                {
                    if (dtGridPembayaran.Columns.Contains(head.Key))
                    {
                        dtGridPembayaran.Columns[head.Key].HeaderText = head.Value;
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                DataTable filteredData = GetDataPembayaran(searchQuery);
                dtGridPembayaran.DataSource = filteredData;
            }
            else
            {
                LoadDataToGrid();
            }
        }

        private void dtGridPembayaran_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnBayar.Enabled = true;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridPembayaran.Rows[e.RowIndex];

                txtNamaDokter.Text = row.Cells["name_doctor"].Value?.ToString() ?? "";
                txtNamaPasien.Text = row.Cells["name_patient"].Value?.ToString() ?? "";
                txtDiagnosa.Text = row.Cells["diagnosis"].Value?.ToString() ?? "";
                txtHarga.Text = row.Cells["price"].Value?.ToString() ?? "";
                txtPengobatan.Text = row.Cells["treatment"].Value?.ToString() ?? "";
                txtResep.Text = row.Cells["recipe"].Value?.ToString() ?? "";

                string status = row.Cells["status"].Value?.ToString() ?? "";
                this.idPembayaran = row.Cells["id_payment"].Value?.ToString() ?? "";

                if (status == "PAID")
                {
                    btnBayar.Enabled = false;
                    lblStatus.Visible = true;
                    lblStatus.Text = status;
                    lblStatus.BackColor = Color.Lime;
                }
                else
                {
                    btnBayar.Enabled = true;
                    lblStatus.Visible = true;
                    lblStatus.Text = status;
                    lblStatus.BackColor = Color.Red;
                }

                if (!string.IsNullOrEmpty(row.Cells["photo"].Value?.ToString()))
                {
                    string fotoPasien = row.Cells["photo"].Value?.ToString() ?? "";
                    previewPasien.Image = new Bitmap(this.fileDestination + fotoPasien);
                }
                else
                {
                    previewPasien.Image = new Bitmap(this.fileDefault);
                }

                if (!string.IsNullOrEmpty(row.Cells["avatar"].Value?.ToString()))
                {
                    string fotoDokter = row.Cells["avatar"].Value?.ToString() ?? "";
                    previewDokter.Image = new Bitmap(this.fileDestination + fotoDokter);
                }
                else
                {
                    previewDokter.Image = new Bitmap(this.fileDefault);
                }

                LoadDataToGrid();
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idPembayaran))
            {
                MessageBox.Show("Pilih data pembayaran terlebih dahulu, untuk melakukan pembayaran", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmation = MessageBox.Show("Apakah Anda yakin ingin melunasi data rekam medis ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.No)
            {
                return;
            }

            try
            {
                string status = "PAID";
                string query = @"UPDATE payments 
                    SET status = @status, 
                    payment_date = @date
                    WHERE id_payment = @id";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@status", status },
                    { "@date", DateTime.Now.ToString("yyyy-MM-dd") },
                    { "@id", idPembayaran}
                };

                Connection connection = new Connection();
                var result = connection.ExecuteQuery(query, parameters);
                Reset();
                MessageBox.Show("Data berhasil pembayaran telah lunas!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah : {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
