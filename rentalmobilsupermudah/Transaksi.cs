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
    public partial class Transaksi : Form
    {
        public Transaksi()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            TransaksiRental transaksi = new TransaksiRental();
            transaksi.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PengambalianKendaraan pengambalianKendaraan = new PengambalianKendaraan();
            pengambalianKendaraan.ShowDialog(this);
        }
    }
}
