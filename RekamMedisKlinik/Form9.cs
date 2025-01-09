using System;
using System.Windows.Forms;

namespace RekamMedisKlinik
{
    public partial class FormCetak : Form
    {
        private string namePage;
        public FormCetak(string namaCetak)
        {
            InitializeComponent();
            namaCetak = namaCetak.ToLower();
            this.namePage = namaCetak;


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

        private void btnTutup_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
