using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rentalmobilsupermudah
{
    internal class Koneksi
    {
        string conectionstring = "Server=localhost;Port=3306;UID=root;PWD=;Database=dbrentalmobil";
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;Port=3306;UID=root;PWD=;Database=dbrentalmobil");

        public void OpenConnection()
        {
            conn = new MySqlConnection(conectionstring);
            conn.Open();
        }

        public void CloseConnection()
        {
            conn.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, conn);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object bebas = data.Tables[0];
            return bebas;
        }
    }
}
