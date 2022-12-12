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
using Org.BouncyCastle.Utilities.Collections;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rentalmobilsupermudah
{
    public partial class MenuMerk : Form
    {
        public MySqlCommand cmd;
        public string dimsum;
        public MenuMerk()
        {
            InitializeComponent();
        }



        private void MenuMerk_Load(object sender, EventArgs e)
        {
            Koneksi2.conn.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tblmerk`",Koneksi2.conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            apaya1.DataSource = ds.Tables[0];
            Koneksi2.conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Master2 master2 = new Master2();
            master2.ShowDialog(this);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi2.conn.Open();
                cmd = new MySqlCommand("INSERT INTO `tblmerk` (`idmerk`, `namamerk`) VALUES(NULL, '" + textBox2.Text + "');", Koneksi2.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("saya dan kamu");
                Koneksi2.conn.Close();
            }
            catch
            {
                MessageBox.Show("kamu dan dia");
            }
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Koneksi2.conn.Open();
            cmd = new MySqlCommand("DELETE FROM `tblmerk` WHERE `tblmerk`.`idmerk` = '" + dimsum + "';", Koneksi2.conn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Berhasil Hapus Data Siswa");
            Koneksi2.conn.Close();
        }

        private void apaya1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi2.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblmerk` SET `namamerk` = '"+textBox2.Text+"' WHERE `tblmerk`.`idmerk` = '" + dimsum+ "';", Koneksi2.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("pacarnya dimas");
                Koneksi2.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("bukan pacarnya dimas");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi2.conn.Open();
                cmd = new MySqlCommand("UPDATE `tblmerk` SET `namamerk` = '" + textBox2.Text + "' WHERE `tblmerk`.`idmerk` = '" + dimsum + "';", Koneksi2.conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("pacarnya dimas");
                Koneksi2.conn.Close();
            }
            catch (Exception)
            {

                MessageBox.Show("bukan pacarnya dimas");
            }
        }

        private void apaya1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int terserahsaya = apaya1.CurrentCell.RowIndex;
            dimsum = apaya1.Rows[terserahsaya].Cells[0].Value.ToString();
            textBox2.Text = apaya1.Rows[terserahsaya].Cells[1].Value.ToString();
        }
    }
}
