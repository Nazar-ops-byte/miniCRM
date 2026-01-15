using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniCRMProje.DAL
{
    public  class DbConnection
    {
        private static string connectionString =
           " Server = 172.21.54.253; Database=26_132430111;User ID = 26_132430111; Pwd=İnif123.";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}

