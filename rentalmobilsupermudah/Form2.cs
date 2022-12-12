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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MenuMerk menuMerk = new MenuMerk();
            menuMerk.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuKendaraan menuKendaraan = new MenuKendaraan();
            menuKendaraan.Show(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPegawai menuPegawai = new MenuPegawai();
            menuPegawai.Show(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Identitasbaru identitasbaru = new Identitasbaru();
            identitasbaru.Show(this);
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MenuPelanggan tambahPelanggan = new MenuPelanggan();
            tambahPelanggan.Show(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuMerk menuMerk = new MenuMerk();
            menuMerk.Show(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuKendaraan menuKendaraan = new MenuKendaraan();
            menuKendaraan.Show(this);
        }
    }
}
