using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace CRUDMahasiswaADO
{
    public partial class Dashboard : Form
    {
        DAL dbLogic = new DAL();
        bool isInitializing = true;
        DataTable dt;
        int button = 0;

        public Dashboard()
        {
            InitializeComponent();

            dtpTanggalMasuk.MinDate = new DateTime(2000, 1, 1);

            dtpTanggalMasuk.Format = DateTimePickerFormat.Custom;

            dtpTanggalMasuk.CustomFormat = "yyyy";

            dtpTanggalMasuk.MaxDate = DateTime.Now;

            cmbTipe.DropDownStyle = ComboBoxStyle.DropDownList;

                var items = new List<KeyValuePair<string, SeriesChartType>>
        {
            new KeyValuePair<string, SeriesChartType>("Kolom", SeriesChartType.Column),
            new KeyValuePair<string, SeriesChartType>("Pie", SeriesChartType.Pie)
        };
            isInitializing = true;

            cmbTipe.DataSource = items;
            cmbTipe.DisplayMember = "Key";   // yang tampil di layar
            cmbTipe.ValueMember = "Value";   // nilai sesungguhnya
            cmbTipe.SelectedIndex = 0;       // pilih item pertama

            isInitializing = false;

            loadDataChart();

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
                
        }

        public void loadDataChart()
        {
            
            chartProdi.Series.Clear();    
            chartProdi.Titles.Clear();    
            chartProdi.Legends.Clear();     
            chartProdi.ChartAreas.Clear(); 

            
            ChartArea ca = new ChartArea("MainArea");
            ca.AxisX.Title = "Program Studi";       
            ca.AxisY.Title = "Jumlah Mahasiswa";    
            ca.AxisX.LabelStyle.Angle = -45;        
            ca.BackColor = Color.Transparent;       
            chartProdi.ChartAreas.Add(ca);
            try
            {

                if (button == 1)
                {
                    // Filter by tahun yang dipilih
                    dt = dbLogic.getDataChartByTahun(dtpTanggalMasuk.Value);
                }
                else
                {
                    // Tampilkan semua data
                    dt = dbLogic.getAllDataChart();
                }

                // Ambil tipe chart yang dipilih di ComboBox
                SeriesChartType tipe = (SeriesChartType)cmbTipe.SelectedValue;


                if (tipe == SeriesChartType.Column)
                {

                    Series s = new Series("Mahasiswa");
                    s.ChartType = SeriesChartType.Column;
                    foreach (DataRow row in dt.Rows)
                    {
                        string prodi = row["NamaProdi"].ToString();
                        int jumlah = Convert.ToInt32((long)row["JmlhMhs"]);
                        s.Points.AddXY(prodi, jumlah); // tambah titik data
                    }

                    chartProdi.Series.Add(s);
                }
                else
                {
                    Series s = new Series("Jumlah Mahasiswa");
                    s.ChartType = tipe;


                    s.IsValueShownAsLabel = true;
                    s.Label = "#VAL";
                    s.LegendText = "#VALX";

                    foreach (DataRow row in dt.Rows)
                    {
                        string prodi = row["NamaProdi"].ToString();
                        int jumlah = Convert.ToInt32((long)row["JmlhMhs"]);
                        s.Points.AddXY(prodi, jumlah);
                    }

                    chartProdi.Series.Add(s);
                }

            

                // === TAMBAHKAN JUDUL GRAFIK ===
                Title title = new Title(
                    "Jumlah Mahasiswa per Program Studi",
                    Docking.Top,
                    new Font("Arial", 14, FontStyle.Bold),
                    Color.DarkBlue);
                chartProdi.Titles.Add(title);

                // === TAMBAHKAN LEGENDA ===
                Legend legend = new Legend("MainLegend");
                legend.Docking = Docking.Right; // posisi di kanan
                chartProdi.Legends.Add(legend);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal load data: " + ex.Message);
            }
        }

        private void cmbTipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (isInitializing)
                return;
            if (button == 1)
            {

            }
            else
            {
                loadDataChart();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            button = 1;
            loadDataChart();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            button = 0; loadDataChart();
        }

        private void btnDataMahasiswa_Click(object sender, EventArgs e)
        {
            DataMahasiswa frm1 = new DataMahasiswa();
            frm1.Show();
            this.Hide();
        }
    }
}
