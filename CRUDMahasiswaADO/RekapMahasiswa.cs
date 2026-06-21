using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CRUDMahasiswaADO
{
    public partial class RekapMahasiswa : Form
    {
        // String koneksi ke database SQL Server kamu
        static string connectionString = "Data Source=GOHAMSS\\ILHAM;Initial Catalog=DBAkademikADO;User ID=sa;Password=is101106";

        SqlConnection conn = new SqlConnection(connectionString);
        SqlDataAdapter da;
        DataTable dtMahasiswa;
        DataTable dtProdi;

        public RekapMahasiswa()
        {
            InitializeComponent();
        }

        // Event saat Form Rekap pertama kali dibuka
        private void RekapMahasiswacs_Load(object sender, EventArgs e)
        {
            // Mengatur format DateTimePicker agar hanya menampilkan Tahun saja
            dtpTanggalMasuk.Format = DateTimePickerFormat.Custom;
            dtpTanggalMasuk.CustomFormat = "yyyy";
            dtpTanggalMasuk.ShowUpDown = true;
            dtpTanggalMasuk.MinDate = new DateTime(2000, 1, 1);
            dtpTanggalMasuk.MaxDate = DateTime.Now;

            // Mengunci ComboBox agar user tidak bisa mengetik manual
            cmbProdi.DropDownStyle = ComboBoxStyle.DropDownList;

            // Tombol cetak dimatikan dulu sampai data berhasil di-load
            btnCetak.Enabled = false;

            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Mengambil daftar prodi untuk mengisi ComboBox Filter
                SqlCommand cmd = new SqlCommand("select namaprodi from programstudi", conn);
                cmd.CommandType = CommandType.Text;
                dtProdi = new DataTable();
                da = new SqlDataAdapter(cmd);
                da.Fill(dtProdi);

                cmbProdi.DataSource = dtProdi;
                cmbProdi.DisplayMember = "namaprodi";
                cmbProdi.ValueMember = "namaprodi";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data prodi: " + ex.Message);
            }
        }

        // Tombol LOAD: Digunakan untuk mengambil data dari DB dan menampilkan ke DataGridView
        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                // Memanggil Stored Procedure sp_Report
                SqlCommand cmd = new SqlCommand("sp_Report", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                // Mengirimkan parameter berdasarkan filter yang dipilih user
                cmd.Parameters.Add("@inProdi", SqlDbType.VarChar, 50).Value = cmbProdi.SelectedValue;
                cmd.Parameters.Add("@inTglMsuk", SqlDbType.VarChar, 4).Value = dtpTanggalMasuk.Value.Year.ToString();

                da = new SqlDataAdapter(cmd);
                dtMahasiswa = new DataTable();
                da.Fill(dtMahasiswa);

                // Memasukkan data hasil query ke dalam DataGridView (Area Abu-abu)
                dataGridView1.DataSource = dtMahasiswa;

                // Validasi: Jika data ditemukan, tombol cetak aktif. Jika kosong, tombol cetak mati.
                if (dtMahasiswa.Rows.Count > 0)
                {
                    btnCetak.Enabled = true;
                }
                else
                {
                    btnCetak.Enabled = false;
                    MessageBox.Show("Data tidak ditemukan untuk prodi dan tahun tersebut.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data mahasiswa: " + ex.Message);
            }
        }

        // Tombol CETAK: Membuka Form Report (Crystal Report) setelah data dipastikan ada
        private void btnCetak_Click(object sender, EventArgs e)
        {
            try
            {
                // Membuka Form Report sambil mengoper parameter Prodi dan Tahun
                Report frm2 = new Report(cmbProdi.SelectedValue.ToString(), dtpTanggalMasuk.Value);
                frm2.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal membuka laporan: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Diabaikan saja jika tidak digunakan
        }
    }
}