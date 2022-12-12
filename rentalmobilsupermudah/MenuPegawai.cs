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
    public partial class MenuPegawai : Form
    {
        public MenuPegawai()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master2 master2 = new Master2();
            master2.ShowDialog(this);
        }

        private void MenuPegawai_Load(object sender, EventArgs e)
        {
            Koneksi2.conn.Open();
            //MessageBox.Show("Koneksi Sukses"); 
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblpegawai`", Koneksi2.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Koneksi2.conn.Close();
        }
    }
}
