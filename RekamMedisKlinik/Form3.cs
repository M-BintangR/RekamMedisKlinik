using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RekamMedisKlinik
{
    public partial class FormChildDashboard : Form
    {
        private readonly Connection connection = new Connection();

        public FormChildDashboard()
        {
            InitializeComponent();
            LoadDataToGrid();
            LoadCountDataTable();
        }

        private void LoadCountDataTable()
        {
            try
            {
                lblCountPengguna.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM users");
                lblCountDokter.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM doctors");
                lblCountRekamMedis.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM medical_records");
                lblCountJanjiTemu.Text = ExecuteScalarQuery("SELECT COUNT(*) FROM appointments");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ExecuteScalarQuery(string query)
        {
            return connection.ExecuteScalar(query)?.ToString() ?? "0";
        }

        private DataTable GetJanjiTemu()
        {
            try
            {
                int currentYear = DateTime.Now.Year;
                int currentMonth = DateTime.Now.Month;

                string query = @"
                    SELECT *
                    FROM appointments";

                var parameters = new Dictionary<string, object>
                {
                    { "currentYear", currentYear },
                    { "currentMonth", currentMonth }
                };

                return ExecuteQueryToDataTable(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat mengambil janji temu: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        private DataTable GetRekamMedis()
        {
            try
            {
                DateTime currentDate = DateTime.Now;
                DateTime startOfWeek = currentDate.AddDays(-(int)currentDate.DayOfWeek);
                DateTime endOfWeek = startOfWeek.AddDays(6);

                string query = @"
                    SELECT *
                    FROM medical_records";

                var parameters = new Dictionary<string, object>
                {
                    { "startOfWeek", startOfWeek.ToString("yyyy-MM-dd") },
                    { "endOfWeek", endOfWeek.ToString("yyyy-MM-dd") }
                };

                return ExecuteQueryToDataTable(query, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saat mengambil rekam medis: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        private DataTable ExecuteQueryToDataTable(string query, Dictionary<string, object> parameters)
        {
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
                dtGridPertemuan.DataSource = GetJanjiTemu();
                dtGridRekamMedis.DataSource = GetRekamMedis();

                SetGridHeaders(dtGridPertemuan, new Dictionary<string, string>
                {
                    { "name_doctor", "Nama Dokter" },
                    { "name_patient", "Nama Pasien" },
                    { "date", "Tanggal" },
                    { "room", "Ruangan" }
                });

                SetGridHeaders(dtGridRekamMedis, new Dictionary<string, string>
                {
                    { "price", "Harga" },
                    { "name_doctor", "Nama Dokter" },
                    { "name_patient", "Nama Pasien" },
                    { "diagnosis", "Diagnosa" },
                    { "treatment", "Pengobatan" },
                    { "address_patient", "Alamat Pasien" },
                    { "date_medical", "Tanggal" }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Terjadi kesalahan saat memuat data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetGridHeaders(DataGridView grid, Dictionary<string, string> headers)
        {
            foreach (var header in headers)
            {
                if (grid.Columns.Contains(header.Key))
                {
                    grid.Columns[header.Key].HeaderText = header.Value;
                }
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadDataToGrid();
            LoadCountDataTable();
        }
    }
}
