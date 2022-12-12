using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentalmobilsupermudah
{
    public partial class TransaksiRental : Form
    {
        Koneksi koneksi = new Koneksi();

        public void Tampil()
        {
            //Query Database
            DataTable1.DataSource = koneksi.ShowData("SELECT * FROM tblidentitas");
        }
        public TransaksiRental()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TransaksiRental_Load(object sender, EventArgs e)
        {
            Tampil();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Transaksi transaksi = new Transaksi();
            transaksi.ShowDialog(this);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
