using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace rentalmobilsupermudah
{
    class Koneksi2
    {
        public static MySqlConnection conn = new MySqlConnection("Server=localhost;port=3306;UID=root;PWD=;Database=dbrentalmobil");
    }
}
