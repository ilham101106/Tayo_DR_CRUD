namespace CRUDMahasiswaADO
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDataMahasiswa = new System.Windows.Forms.Button();
            this.cmbTipe = new System.Windows.Forms.ComboBox();
            this.chartProdi = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(423, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rekap Data Mahasiswa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tahun Masuk";
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(152, 90);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(200, 22);
            this.dtpTanggalMasuk.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.ForestGreen;
            this.btnLoad.ForeColor = System.Drawing.SystemColors.Window;
            this.btnLoad.Location = new System.Drawing.Point(436, 77);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(91, 29);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReset.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnReset.Location = new System.Drawing.Point(533, 77);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(94, 29);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDataMahasiswa
            // 
            this.btnDataMahasiswa.Location = new System.Drawing.Point(766, 616);
            this.btnDataMahasiswa.Name = "btnDataMahasiswa";
            this.btnDataMahasiswa.Size = new System.Drawing.Size(140, 43);
            this.btnDataMahasiswa.TabIndex = 5;
            this.btnDataMahasiswa.Text = "Data Mahasiswa";
            this.btnDataMahasiswa.UseVisualStyleBackColor = true;
            this.btnDataMahasiswa.Click += new System.EventHandler(this.btnDataMahasiswa_Click);
            // 
            // cmbTipe
            // 
            this.cmbTipe.FormattingEnabled = true;
            this.cmbTipe.Location = new System.Drawing.Point(785, 94);
            this.cmbTipe.Name = "cmbTipe";
            this.cmbTipe.Size = new System.Drawing.Size(121, 24);
            this.cmbTipe.TabIndex = 6;
            this.cmbTipe.SelectedIndexChanged += new System.EventHandler(this.cmbTipe_SelectedIndexChanged);
            // 
            // chartProdi
            // 
            chartArea6.Name = "ChartArea1";
            this.chartProdi.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartProdi.Legends.Add(legend6);
            this.chartProdi.Location = new System.Drawing.Point(61, 133);
            this.chartProdi.Name = "chartProdi";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartProdi.Series.Add(series6);
            this.chartProdi.Size = new System.Drawing.Size(845, 477);
            this.chartProdi.TabIndex = 7;
            this.chartProdi.Text = "chart1";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 775);
            this.Controls.Add(this.chartProdi);
            this.Controls.Add(this.cmbTipe);
            this.Controls.Add(this.btnDataMahasiswa);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.dtpTanggalMasuk);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartProdi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDataMahasiswa;
        private System.Windows.Forms.ComboBox cmbTipe;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProdi;
    }
}