using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace praktikum
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        string koneksi = "server=localhost;username=root;database=db_apotek_gudang;password=;";


        private void Form1_Load(object sender, EventArgs e)
        {

            MySqlConnection conn = new MySqlConnection(koneksi);
            try
            {
                conn.Open();
                string query = "SELECT * FROM tb_suplemen";
                MySqlDataAdapter data = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                data.Fill(dt);
                dataGridView1.DataSource = dt;
                MessageBox.Show("Data berhasil ditampilkan");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error: " + ex.Message);
                conn.Close();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >=0)
            {
                txtbarang.Text =
                    dataGridView1.Rows[e.RowIndex].Cells["kode_barang"].Value.ToString();

                txtnamabrng.Text =
                    dataGridView1.Rows[e.RowIndex].Cells["nama_barang"].Value.ToString();

                txtstok.Text = 
                    dataGridView1.Rows[e.RowIndex].Cells["stok"].Value.ToString();

                txtsatuan.Text =
                    dataGridView1.Rows[e.RowIndex].Cells["satuan"].Value.ToString();

                txtharga.Text =
                    dataGridView1.Rows[e.RowIndex].Cells["harga_satuan"].Value.ToString();

                txtbatas.Text =
                    dataGridView1.Rows[e.RowIndex].Cells["batas_minimum"].Value.ToString();

                comboBox1.Text =
                    dataGridView1.Rows[e.RowIndex].Cells["kategori"].Value.ToString();
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(koneksi);
            try
            {
                conn.Open();
                string query = "insert into tb_suplemen (Kode_Barang, Nama_Barang, Stok, Satuan, Harga_Satuan, batas_minimum, kategori) values " +
                    "(@Kode_Barang, @Nama_Barang, @Stok, @Satuan, @Harga_Satuan, @Batas_minimum, @kategori)";
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Kode_Barang", txtbarang.Text);
                cmd.Parameters.AddWithValue("@Nama_Barang", txtnamabrng.Text);
                cmd.Parameters.AddWithValue("@Stok", txtstok.Text);
                cmd.Parameters.AddWithValue("@Satuan", txtsatuan.Text);
                cmd.Parameters.AddWithValue("@Harga_Satuan", txtharga.Text);
                cmd.Parameters.AddWithValue("@Batas_minimum", txtbatas.Text);
                cmd.Parameters.AddWithValue("@kategori", comboBox1.Text);
                if (string.IsNullOrWhiteSpace(txtbarang.Text) || string.IsNullOrWhiteSpace(txtnamabrng.Text) || string.IsNullOrWhiteSpace(txtstok.Text) || string.IsNullOrWhiteSpace(txtsatuan.Text) || string.IsNullOrWhiteSpace(txtharga.Text) || string.IsNullOrWhiteSpace(txtbatas.Text) || string.IsNullOrWhiteSpace(comboBox1.Text)) 
                {
                    MessageBox.Show("Harap isi semua field sebelum menambahkan data.");
                    return;
                }
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil di tambahkan");
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error:" + ex.Message);

            }
            conn.Close();
        } 
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(koneksi);
            try
            {
                conn.Open();
                string query = "UPDATE tb_suplemen SET nama_barang = @nama_barang,kategori = @kategori, stok = @stok, satuan =@satuan, harga_satuan = @harga_satuan, batas_minumum = @batas_minimum WHERE kode_barang = @kode_barang"; 
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kode_barang", txtbarang.Text);
                cmd.Parameters.AddWithValue("@nama_barang", txtnamabrng.Text);
                cmd.Parameters.AddWithValue("@stok",txtstok.Text);
                cmd.Parameters.AddWithValue("@satuan", txtsatuan.Text);
                cmd.Parameters.AddWithValue("@harga_satuan", txtharga.Text);
                cmd.Parameters.AddWithValue("@batas_minimum", txtbatas.Text);
                cmd.Parameters.AddWithValue("@kategori",comboBox1.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data produk apotek berhasil diperbarui!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                conn.Close();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnhps_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection(koneksi);
            try
            {
                conn.Open();
                string query = "DELETE from tb_suplemen WHERE kode_barang = @kode_barang";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@kode_barang", txtbarang.Text);
                cmd.Parameters.AddWithValue("@nama_barang", txtnamabrng.Text);
                cmd.Parameters.AddWithValue("@stok", txtstok.Text);
                cmd.Parameters.AddWithValue("@satuan", txtsatuan.Text);
                cmd.Parameters.AddWithValue("@harga_satuan", txtharga.Text);
                cmd.Parameters.AddWithValue("@batas_minimum", txtbatas.Text);
                cmd.Parameters.AddWithValue("@kategori", comboBox1.SelectedItem.ToString());
                cmd.ExecuteNonQuery();

                if (string.IsNullOrWhiteSpace(txtbarang.Text) || string.IsNullOrWhiteSpace(txtnamabrng.Text) || string.IsNullOrWhiteSpace(txtstok.Text) || string.IsNullOrWhiteSpace(txtsatuan.Text) || string.IsNullOrWhiteSpace(txtharga.Text) || string.IsNullOrWhiteSpace(txtbatas.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))

                    MessageBox.Show("Pilih data terlebih dahul yang ingin di hapus!");
                return;
            }
            
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                conn.Close();
            }
        }

        private void btnbersih_Click(object sender, EventArgs e)
        {
            MySqlConnection con = new MySqlConnection(koneksi);

            
        }
    }
}
