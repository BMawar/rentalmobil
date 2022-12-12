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
    public partial class MenuPelanggan : Form
    {
        public MenuPelanggan()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master2 master2 = new Master2();
            master2.ShowDialog(this);
        }

        private void MenuPelanggan_Load(object sender, EventArgs e)
        {
            Koneksi2.conn.Open();
            //MessageBox.Show("Koneksi Sukses"); 
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblpelanggan`", Koneksi2.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            Koneksi2.conn.Close();
        }
    }
}
