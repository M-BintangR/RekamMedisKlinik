using System.Data;

namespace RekamMedisKlinik
{

    public partial class FormChildDokter : Form
    {
        private string idPengguna, idDokter, namaDokter, jenisKelamin, alamat;
        public FormChildDokter()
        {
            InitializeComponent();
            LoadDataToGrid();
            LoadDataPengguna();

            btnHapus.Enabled = false;
            btnSunting.Enabled = false;
            btnTambah.Enabled = true;

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.alamat = textBox1.Text;
        }


        private DataTable GetDataDokter(string searchQuery = "")
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection connection = new Connection();

                string query = @"SELECT doctors.id_doctor AS id_doctor, doctors.name_doctor AS name_doctor, 
                                doctors.address_doctor AS address_doctor, doctors.sex_doctor AS sex_doctor,
                                users.id_user AS id_user FROM doctors INNER JOIN users ON doctors.user_id = users.id_user 
                                WHERE doctors.name_doctor LIKE @searchQuery ORDER BY doctors.id_doctor DESC";

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
            DataTable penggunaTable = GetDataDokter();

            try
            {
                dtGridDokter.DataSource = penggunaTable;

                var tableHead = new Dictionary<string, string>
                {
                    { "name_doctor", "Nama Dokter" },
                    { "address_doctor", "Alamat" },
                    { "sex_doctor", "Jenis Kelamin" },
                    { "id_doctor", "Id Dokter"},
                    { "id_user",  "Id Pengguna"}
                };

                foreach (var head in tableHead)
                {
                    if (dtGridDokter.Columns.Contains(head.Key))
                    {
                        dtGridDokter.Columns[head.Key].HeaderText = head.Value;
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
                DataTable filteredData = GetDataDokter(searchQuery);
                dtGridDokter.DataSource = filteredData;
            }
            else
            {
                LoadDataToGrid();
            }
        }

        private void LoadDataPengguna()
        {
            try
            {
                Connection connection = new Connection();
                string query = @"SELECT users.id_user, users.username, users.email
                                 FROM users 
                                 LEFT JOIN doctors ON users.id_user = doctors.user_id
                                 WHERE users.role = 'dokter'
                                 ORDER BY users.id_user DESC";

                var parameters = new Dictionary<string, object> { };
                var result = connection.ExecuteQuery(query, parameters);

                DataTable dataTable = new DataTable();
                dataTable.Columns.Add("id_user", typeof(string));
                dataTable.Columns.Add("display", typeof(string));

                foreach (var row in result)
                {
                    DataRow dataRow = dataTable.NewRow();
                    dataRow["id_user"] = row["id_user"].ToString();
                    dataRow["display"] = $"{row["username"]} ({row["email"]})";
                    dataTable.Rows.Add(dataRow);
                }

                cmbAkun.DataSource = dataTable;
                cmbAkun.DisplayMember = "display";
                cmbAkun.ValueMember = "id_user";
            }
            catch (Exception err)
            {
                MessageBox.Show($"Ada yang salah: {err.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Reset()
        {
            // load data
            LoadDataToGrid();
            LoadDataPengguna();

            // clear properties form
            txtNama.Text = "";
            txtSearch.Text = "";
            radioLakiLaki.Checked = false;
            radioPerempuan.Checked = false;
            textBox1.Text = "";
            cmbAkun.Text = "";

            // clear variables 
            this.idPengguna = "";
            this.namaDokter = "";
            this.alamat = "";
            this.jenisKelamin = "";

            btnHapus.Enabled = false;
            btnSunting.Enabled = false;
            btnTambah.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void dtGridDokter_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnHapus.Enabled = true;
            btnSunting.Enabled = true;
            btnTambah.Enabled = false;

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtGridDokter.Rows[e.RowIndex];

                txtNama.Text = row.Cells["name_doctor"].Value?.ToString() ?? "";
                textBox1.Text = row.Cells["address_doctor"].Value?.ToString() ?? "";
                this.jenisKelamin = row.Cells["sex_doctor"].Value?.ToString() ?? "";
                this.idDokter = row.Cells["id_doctor"].Value?.ToString() ?? "";

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

                string selectedIdUser = row.Cells["id_user"].Value?.ToString() ?? "";

                LoadDataPengguna();

                if (!string.IsNullOrEmpty(selectedIdUser))
                {
                    this.idPengguna = selectedIdUser;
                    cmbAkun.SelectedValue = selectedIdUser;
                }
            }
        }

        private void cmbAkun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAkun.SelectedValue != null)
            {
                this.idPengguna = cmbAkun.SelectedValue.ToString();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(namaDokter) || string.IsNullOrEmpty(alamat) ||
                    string.IsNullOrEmpty(idPengguna) || string.IsNullOrEmpty(jenisKelamin))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"INSERT INTO doctors (name_doctor, address_doctor, user_id, sex_doctor) 
                         VALUES (@nama, @alamat, @idUser, @jenisKelamin)";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nama", namaDokter },
                    { "@alamat", alamat },
                    { "@idUser", idPengguna },
                    { "@jenisKelamin", jenisKelamin }
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

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idDokter))
            {
                MessageBox.Show("Pilih data yang ingin dihapus terlebih dahulu!", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmation = MessageBox.Show("Apakah Anda yakin ingin menghapus data dokter ini?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmation == DialogResult.Yes)
            {
                try
                {
                    string query = @"DELETE FROM doctors WHERE id_doctor = @id_doctor";
                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                       { "@id_doctor", this.idDokter }
                    };

                    Connection connection = new Connection();
                    connection.ExecuteQuery(query, parameters);
                    Reset();

                    MessageBox.Show("Data dokter berhasil dihapus ", "success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception err)
                {
                    MessageBox.Show($"Ada yang salah : {err.Message}", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSunting_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.idDokter))
            {
                MessageBox.Show("Pilih data yang ingin disunting terlebih dahulu!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(namaDokter) || string.IsNullOrEmpty(alamat) ||
                    string.IsNullOrEmpty(idPengguna) || string.IsNullOrEmpty(jenisKelamin))
                {
                    MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string query = @"UPDATE doctors SET name_doctor = @nama, address_doctor = @alamat, user_id = @idUser, sex_doctor = @jenisKelamin 
                         WHERE id_doctor = @idDokter";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@nama", namaDokter },
                    { "@alamat", alamat },
                    { "@idUser", idPengguna },
                    { "@jenisKelamin", jenisKelamin },
                    { "@idDokter", this.idDokter }
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
    }
}
