using System.Data;

namespace RekamMedisKlinik
{
    public partial class FormChildDashboard : Form
    {
        public FormChildDashboard()
        {
            InitializeComponent();
            LoadDataToGrid();
            LoadCountDataTable();

        }

        public void LoadCountDataTable()
        {
            var connection = new Connection();

            string queryPengguna = @"SELECT COUNT(*) FROM users";
            string queryDokter = @"SELECT COUNT(*) FROM doctors";
            string queryRekamMedis = @"SELECT COUNT(*) FROM medical_records";
            string queryJanjiTemu = @"SELECT COUNT(*) FROM appointments";

            this.lblCountPengguna.Text = connection.ExecuteScalar(queryPengguna)?.ToString() ?? "0";
            this.lblCountDokter.Text = connection.ExecuteScalar(queryDokter)?.ToString() ?? "0";
            this.lblCountRekamMedis.Text = connection.ExecuteScalar(queryRekamMedis)?.ToString() ?? "0";
            this.lblCountJanjiTemu.Text = connection.ExecuteScalar(queryJanjiTemu)?.ToString() ?? "0";
        }

        public DataTable GetJanjiTemu()
        {
            var connection = new Connection();

            int currentYear = DateTime.Now.Year;
            int currentMonth = DateTime.Now.Month;

            string query = @"
                SELECT name_doctor, name_patient, date, room
                FROM appointment
                WHERE YEAR(date) = @currentYear AND MONTH(date) = @currentMonth";

            var parameters = new Dictionary<string, object>
            {
                { "currentYear", currentYear },
                { "currentMonth", currentMonth }
            };

            var results = connection.ExecuteQuery(query, parameters);
            DataTable dataTable = new DataTable();

            if (results != null && results.Count > 0)
            {
                foreach (var key in results[0].Keys)
                {
                    dataTable.Columns.Add(key);
                }

                foreach (var row in results)
                {
                    var dataRow = dataTable.NewRow();
                    foreach (var key in row.Keys)
                    {
                        dataRow[key] = row[key] ?? DBNull.Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        public DataTable GetRekamMedis()
        {
            var connection = new Connection();

            DateTime currentDate = DateTime.Now;
            DayOfWeek dayOfWeek = currentDate.DayOfWeek;
            DateTime startOfWeek = currentDate.AddDays(-((int)dayOfWeek));
            DateTime endOfWeek = startOfWeek.AddDays(6);

            string query = @"
                SELECT price, name_doctor, name_patient, diagnosis, treatment, address_patient, date_medical 
                FROM medical_record
                WHERE DATE(date_medical) BETWEEN @startOfWeek AND @endOfWeek";

            var parameters = new Dictionary<string, object>
            {
                { "startOfWeek", startOfWeek.ToString("yyyy-MM-dd") },
                { "endOfWeek", endOfWeek.ToString("yyyy-MM-dd") }
            };


            var results = connection.ExecuteQuery(query, parameters);
            DataTable dataTable = new DataTable();

            if (results != null && results.Count > 0)
            {
                foreach (var key in results[0].Keys)
                {
                    dataTable.Columns.Add(key);
                }

                foreach (var row in results)
                {
                    var dataRow = dataTable.NewRow();
                    foreach (var key in row.Keys)
                    {
                        dataRow[key] = row[key] ?? DBNull.Value;
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }

            return dataTable;
        }

        private void LoadDataToGrid()
        {
            try
            {
                DataTable janjiTemuTable = GetJanjiTemu();
                DataTable rekamMedisTable = GetRekamMedis();

                dtGridPertemuan.DataSource = janjiTemuTable;
                dtGridRekamMedis.DataSource = rekamMedisTable;

                var janjiTemuHeaders = new Dictionary<string, string>
                {
                    { "name_doctor", "Nama Dokter" },
                    { "name_patient", "Nama Pasien" },
                    { "date", "Tanggal" },
                    { "room", "Ruangan" }
                };

                var rekamMedisHeaders = new Dictionary<string, string>
                {
                    { "price", "Harga" },
                    { "name_doctor", "Nama Dokter" },
                    { "name_patient", "Nama Pasien" },
                    { "diagnosis", "Diagnosa" },
                    { "treatment", "Pengobatan" },
                    { "address_patient", "Alamat Pasien" },
                    { "date_medical", "Tanggal" }
                };

                foreach (var head in janjiTemuHeaders)
                {
                    if (janjiTemuTable.Columns.Contains(head.Key))
                    {
                        dtGridPertemuan.Columns[head.Key].HeaderText = head.Value;
                    }
                }

                foreach (var head in rekamMedisHeaders)
                {
                    if (rekamMedisTable.Columns.Contains(head.Key))
                    {
                        dtGridRekamMedis.Columns[head.Key].HeaderText = head.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
            LoadCountDataTable();
        }
    }
}
