using iTextSharp.text;
using iTextSharp.text.pdf;
using Mysqlx;
using System.Data;

namespace RekamMedisKlinik
{
    public partial class FormCetak : Form
    {
        private string namePage;
        private DataTable dataGridSource;
        public FormCetak(string namaCetak)
        {
            InitializeComponent();
            namaCetak = namaCetak.ToLower();
            this.namePage = namaCetak;

            // load data 
            LoadDataToGrid();

            // default width pretitle & title
            this.lblTitle.Width = 200;
            this.lblPretitle.Width = 200;

            switch (namaCetak)
            {

                // choose halaman
                case "dokter":
                    this.lblTitle.Text = "Cetak Dokter";
                    this.lblPretitle.Text = "Cetak Laporan Dokter.";
                    break;

                case "riwayat pembayaran":
                    this.lblTitle.Text = "Cetak Riwayat Pembayaran";
                    this.lblPretitle.Text = "Cetak Laporan Riwayat Pembayaran.";
                    break;

                case "rekam medis":
                    this.lblTitle.Text = "Cetak Rekam Medis";
                    this.lblPretitle.Text = "Cetak Laporan Rekam Medis.";
                    break;

                default:
                    MessageBox.Show("Tidak ada menu untuk cetak ini.");
                    break;
            }
        }

        private DataTable GetDataDokter()
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection connection = new Connection();

                string query = @"SELECT name_doctor AS 'Nama Dokter', sex_doctor as 'Jenis Kelamin', address_doctor as 'Alamat' FROM doctors";

                Dictionary<string, object> parameters = new Dictionary<string, object> { };

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

        private DataTable GetDataRiwayatPembayaran()
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection connection = new Connection();
                string query = @"
                    SELECT 
                        payments.status AS 'Status Pembayaran',
                        patients.name_patient AS 'Nama Pasien',
                        doctors.name_doctor AS 'Nama Dokter',
                        medical_records.price AS 'Harga'
                    FROM payments
                    INNER JOIN patients ON payments.patient_id = patients.id_patient
                    INNER JOIN medical_records ON payments.medical_record_id = medical_records.id_medical_record
                    INNER JOIN doctors ON medical_records.doctor_id = doctors.id_doctor";

                Dictionary<string, object> parameters = new Dictionary<string, object> { };

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

        private DataTable GetDataRekamMedis()
        {
            DataTable dataTable = new DataTable();

            try
            {
                Connection connection = new Connection();
                string query = @"
                 SELECT 
                    doctors.name_doctor AS 'Nama Dokter', 
                    patients.name_patient AS 'Nama Pasien', 
                    medical_records.diagnosis AS 'Diagnosis',
                    medical_records.recipe AS 'Resep Obat',
                    medical_records.treatment AS 'Pengobatan'
                FROM medical_records
                INNER JOIN patients ON medical_records.patient_id = patients.id_patient
                INNER JOIN doctors ON medical_records.doctor_id = doctors.id_doctor";

                Dictionary<string, object> parameters = new Dictionary<string, object> { };

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
                switch (this.namePage)
                {
                    case "dokter":
                        dtGridCetak.DataSource = GetDataDokter();
                        this.dataGridSource = GetDataRekamMedis();
                        break;

                    case "riwayat pembayaran":
                        dtGridCetak.DataSource = GetDataRiwayatPembayaran();
                        this.dataGridSource = GetDataRiwayatPembayaran();
                        break;

                    case "rekam medis":
                        dtGridCetak.DataSource = GetDataRekamMedis();
                        this.dataGridSource = GetDataRekamMedis();
                        break;

                    default:
                        MessageBox.Show("Ada yang salah");
                        break;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ada yang salah");
            }
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnCetak_Click(object sender, EventArgs e)
        {
            if (dataGridSource.Rows.Count > 0)
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "PDF (*.pdf)|*.pdf";
                save.FileName = $"laporan-{this.namePage}" + DateTime.Now.ToString("d-M-yyyy") + ".pdf";
                bool ErrorMessage = false;

                if (save.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(save.FileName))
                    {
                        try
                        {
                            File.Delete(save.FileName);
                        }
                        catch (Exception err)
                        {
                            ErrorMessage = true;
                            MessageBox.Show("Ada yang salah : " + err.Message);
                        }
                    }

                    if (!ErrorMessage)
                    {
                        try
                        {
                            PdfPTable pTable = new PdfPTable(dataGridSource.Columns.Count);
                            pTable.DefaultCell.Padding = 2;
                            pTable.WidthPercentage = 100;
                            pTable.HorizontalAlignment = Element.ALIGN_LEFT;

                            // Add headers
                            foreach (DataColumn col in dataGridSource.Columns)
                            {
                                PdfPCell pCell = new PdfPCell(new Phrase(col.ColumnName));
                                pTable.AddCell(pCell);
                            }

                            // Add rows
                            foreach (DataRow row in dataGridSource.Rows)
                            {
                                foreach (var cell in row.ItemArray)
                                {
                                    pTable.AddCell(cell?.ToString() ?? string.Empty);
                                }
                            }

                            using (FileStream fileStream = new FileStream(save.FileName, FileMode.Create))
                            {
                                Document document = new Document(PageSize.A4);
                                PdfWriter.GetInstance(document, fileStream);
                                document.Open();

                                string logoPath = "D:\\PRAKTIKUM C SHARP\\RekamMedisKlinik\\RekamMedisKlinik\\Assets\\LOGO KLINIK SMALL DARK.png"; 
                                if (File.Exists(logoPath))
                                {
                                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(logoPath);
                                    logo.ScaleToFit(200f, 200f);
                                    logo.Alignment = Element.ALIGN_CENTER; 
                                    logo.SpacingAfter = 20; 
                                    document.Add(logo);
                                }

                                // Add title
                                Paragraph title = new Paragraph($"LAPORAN RIWAYAT {this.namePage.ToUpper()}",
                                FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 16));
                                title.Alignment = Element.ALIGN_CENTER;
                                title.SpacingAfter = 20;
                                document.Add(title);

                                // Add table
                                document.Add(pTable);
                                document.Close();

                                fileStream.Close();
                            }

                            MessageBox.Show("Cetak PDF Berhasil!", "Info");
                        }
                        catch (Exception err)
                        {
                            MessageBox.Show("Ada yang salah : " + err.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Baris Data Tidak Ditemukan!");
            }
        }
    }
}
