
# CRUD Mahasiswa ADO - Activity 11

Ilham Saputra
##20240140118

## Video Instalasi Aplikasi & Video Demo Aplikasi
https://drive.google.com/file/d/1PZulum3DmJvlbrCUIiXzVcpi_7uhstw5/view?usp=sharing

Aplikasi CRUD Data Mahasiswa menggunakan C# WinForms dan ADO.NET, dibuat sebagai tugas praktikum Pengembangan Aplikasi Basisdata.

## Fitur

- CRUD data mahasiswa (Create, Read, Update, Delete)
- Pencarian mahasiswa berdasarkan NIM
- Upload dan tampilkan foto mahasiswa (BLOB)
- Import data dari file Excel
- Dashboard dengan grafik jumlah mahasiswa per program studi
- Rekap data mahasiswa dengan Crystal Report
- Demo SQL Injection untuk edukasi keamanan

## Teknologi

- C# WinForms (.NET Framework)
- ADO.NET (SqlClient)
- SQL Server
- Crystal Reports
- ExcelDataReader

## Cara Setup

1. Clone repository ini
2. Buka `CRUDMahasiswaADO.slnx` di Visual Studio
3. Restore NuGet packages (ExcelDataReader, ExcelDataReader.DataSet)
4. Jalankan script SQL untuk membuat database `DBAkademikADO` beserta stored procedure-nya
5. Sesuaikan connection string di `DAL.cs`
6. Build dan jalankan aplikasi

## Struktur Project

- `DAL.cs` - Data Access Layer, semua query ke database
- `Dashboard.cs` - Form utama dengan grafik rekap mahasiswa
- `DataMahasiswa.cs` - Form CRUD data mahasiswa
- `RekapMahasiswa.cs` - Form filter dan cetak rekap data
- `Report.cs` - Form untuk menampilkan Crystal Report
