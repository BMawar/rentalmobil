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

namespace rentalmobilsupermudah
{
    public partial class Identitasbaru : Form
    {
        public MySqlCommand cmd;
        public string idIdentitas;
        public Identitasbaru()
        {
            InitializeComponent();
        }
        void Tampil()
        {
            try
            {
                //MessageBox.Show("Ini Muncul Saat FOrm dipanggil");

                Koneksi.conn.Open(); //ini membuka koneksi database

                //ini digunakan untuk mengambil data di tabel siswa
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblidentitas`", Koneksi.conn);
                //membuat objek Dasa Set Baru
                DataSet ds = new DataSet();
                //ini digunakan untuk mengisi dataset dari Data Adapter
                adapter.Fill(ds);

                //Mengisi DataGrid Siswa dengan DataSet
                mawar1.DataSource = ds.Tables[0];
                Koneksi.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("Duh!!, Ada Error Nih");
            }
        }
            private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMerk menuMerk = new MenuMerk();
            menuMerk.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuKendaraan menuKendaraan = new MenuKendaraan();
            menuKendaraan.ShowDialog(this);
        }

            private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pelanggan menuPelanggan = new Pelanggan();
            menuPelanggan.ShowDialog(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pegawai menuPegawai = new Pegawai();
            menuPegawai.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master2 master2 = new Master2();
            master2.ShowDialog(this);
        }

        private void Identitasbaru_Load(object sender, EventArgs e)
        {
            try
            {
                Koneksi2.conn.Open();
                //MessageBox.Show("Koneksi Sukses"); 
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblidentitas`", Koneksi2.conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                mawar1.DataSource = ds.Tables[0];
                Koneksi2.conn.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("terjadi kesalahan");
            }
           
        }

        private void mawar1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sengdiklik = mawar1.CurrentCell.RowIndex;
            idIdentitas = mawar1.Rows[sengdiklik].Cells[0].Value.ToString();
           
             
            MessageBox.Show("ini baris ke:" + sengdiklik.ToString());
            textBox1.Text = mawar1.Rows[sengdiklik].Cells[1].Value.ToString();
            textBox6.Text = mawar1.Rows[sengdiklik].Cells[2].Value.ToString();
            textBox5.Text = mawar1.Rows[sengdiklik].Cells[3].Value.ToString();
            textBox4.Text = mawar1.Rows[sengdiklik].Cells[4].Value.ToString();
            textBox3.Text = mawar1.Rows[sengdiklik].Cells[5].Value.ToString();
            textBox2.Text = mawar1.Rows[sengdiklik].Cells[6].Value.ToString();

        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            Koneksi2.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblidentitas` SET `namarental` = '"+textBox1.Text+"', `alamatrental` = '"+textBox6.Text+"', `notelp` = '"+textBox5.Text+"', `captionpertama` = '"+textBox4.Text+"', `captionkedua` = '"+textBox3.Text+"', `captionketiga` = '"+textBox2.Text+"' WHERE `tblidentitas`.`ididentitas` = '"+idIdentitas+"';", Koneksi2.conn);
            cmd.ExecuteNonQuery();
            Koneksi2.conn.Close();

            Tampil();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Koneksi2.conn.Open();
            cmd = new MySqlCommand("DELETE FROM `tblidentitas` WHERE `tblidentitas`.`ididentitas` = '"+idIdentitas+"';", Koneksi2.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Hapus Data Siswa");
            Koneksi2.conn.Close();

            Tampil();
        }

        private void mawar1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
            Koneksi2.conn.Open();
            cmd = new MySqlCommand("UPDATE `tblidentitas` SET `namarental` = '" + textBox1.Text + "', `alamatrental` = '" + textBox6.Text + "', `notelp` = '" + textBox5.Text + "', `captionpertama` = '" + textBox4.Text + "', `captionkedua` = '" + textBox3.Text + "', `captionketiga` = '" + textBox2.Text + "' WHERE `tblidentitas`.`ididentitas` = '" + idIdentitas + "';", Koneksi2.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("pacarnya dimas");
            Koneksi2.conn.Close();

            }
            catch (Exception)
            {

                MessageBox.Show("bukan pacarnya dimas");
            }
        }

        private void mawar1_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi2.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tblidentitas` (`ididentitas`, `namarental`, `alamatrental`, `notelp`, `captionpertama`, `captionkedua`, `captionketiga`) VALUES (NULL, '"+textBox1.Text+"', '"+textBox6.Text+"', '"+textBox5.Text+"', '"+textBox4.Text+"', '"+textBox3.Text+"', '"+textBox2.Text+"');",Koneksi2.conn);
                cmd.ExecuteNonQuery ();
                MessageBox.Show("berhasil");
                Koneksi2.conn.Close ();

                Tampil();
            }
            catch (Exception)
            {
                MessageBox.Show("gagal");

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
