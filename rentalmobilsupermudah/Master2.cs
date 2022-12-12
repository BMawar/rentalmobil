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
    public partial class Master2 : Form
    {
        public Master2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Identitasbaru identitasbaru = new Identitasbaru();
            identitasbaru.ShowDialog();
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
            MenuPelanggan menuPelanggan = new MenuPelanggan();
            menuPelanggan.ShowDialog(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPegawai menuPegawai = new MenuPegawai();
            menuPegawai.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show(this);
        }
    }
}
