using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace praktikum4_command_query_ado_net
{
    public partial class Form1 : Form
    {
        // Deklarasi variabel koneksi dan command agar bisa diakses semua button
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        // Fungsi koneksi ke database
        private void Koneksi()
        {
            // Data Source sesuai LAPTOP-D3717QUD\USERHAFFI
            conn = new SqlConnection("Data Source=LAPTOP-D3717QUD\\USERHAFFI; Initial Catalog=DBAkademikADO; Integrated Security=True");
        }

        // --- PRAKTIKUM UTAMA ---

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                MessageBox.Show("Koneksi ke database berhasil");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "SELECT COUNT(*) FROM Mahasiswa";
                cmd = new SqlCommand(query, conn);
                int jumlah = (int)cmd.ExecuteScalar(); // Mengambil satu nilai (angka)
                txtHasil.Text = jumlah.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnHitungMK_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "SELECT COUNT(*) FROM MataKuliah";
                cmd = new SqlCommand(query, conn);
                int jumlah = (int)cmd.ExecuteScalar();
                txtHasil.Text = jumlah.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "UPDATE Mahasiswa SET Alamat = 'Yogyakarta' WHERE NIM = '23110100001'";
                cmd = new SqlCommand(query, conn);
                int hasil = cmd.ExecuteNonQuery(); // Menjalankan query update
                MessageBox.Show("Jumlah baris terpengaruh: " + hasil);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // --- SOLUSI LATIHAN PRAKTIKUM ---

        private void btnLatihan1_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM Dosen", conn);
                txtHasil.Text = cmd.ExecuteScalar().ToString();
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLatihan2_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "UPDATE MataKuliah SET SKS = 4 WHERE KodeMK = 'IF210101'";
                cmd = new SqlCommand(query, conn);
                int baris = cmd.ExecuteNonQuery();
                MessageBox.Show("Berhasil update " + baris + " data.");
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnLatihan3_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                string query = "INSERT INTO [ProgramStudi] VALUES ('MI01','Manajemen Informatika')";
                cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Program Studi berhasil ditambahkan!");
                conn.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}