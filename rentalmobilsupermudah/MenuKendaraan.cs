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
    public partial class MenuKendaraan : Form
    {
        public MySqlCommand cmd;
        public string bebasaja;
        public MenuKendaraan()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuKendaraan_Load(object sender, EventArgs e)
        {
            Koneksi2.conn.Open();
            //MessageBox.Show("Koneksi Sukses"); 
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblkendaraan`", Koneksi2.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            bantalguling.DataSource = ds.Tables[0];
            Koneksi2.conn.Close();
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master2 master2 = new Master2();
            master2.ShowDialog(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int kamuindah = bantalguling.CurrentCell.RowIndex;
            bebasaja = bantalguling.Rows[kamuindah].Cells[0].Value.ToString();
            textBox8.Text = bantalguling.Rows[kamuindah].Cells[1].Value.ToString();
            textBox7.Text = bantalguling.Rows[kamuindah].Cells[2].Value.ToString();
            textBox6.Text = bantalguling.Rows[kamuindah].Cells[3].Value.ToString();
            textBox11.Text = bantalguling.Rows[kamuindah].Cells[4].Value.ToString();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi2.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tblkendaraan` (`idkendaraan`, `idmerk`, `namakendaraan`, `platnomor`, `tahunkeluaran`, `harga`) VALUES (NULL, '" + textBox8.Text + "','" + textBox7.Text + "' ,'" + textBox6.Text + "' ,'" + textBox11.Text + "' ,'" + textBox11.Text + "' );", Koneksi2.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("berdiri");
                Koneksi.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("duduk");

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi2.conn.Open();
                cmd = new MySqlCommand("DELETE FROM `tblkendaraan` WHERE `tblkendaraan`.`idkendaraan` = '"+ bebasaja +"';" , Koneksi2.conn);
                cmd.ExecuteNonQuery ();
                MessageBox.Show("udah di hapus kok");
                Koneksi2.conn.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("ga bisa slur");

            }
        }
    }
}
