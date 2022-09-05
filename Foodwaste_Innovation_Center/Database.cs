using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Foodwaste_Innovation_Center
{
    class Database
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader dr;

        public void Connect()
        {
            con = new MySqlConnection("server = 127.0.0.1; user = root; database = foodinnovation");
            con.Open();
        }
        public void Disconnect()
        {
            con.Close();
            con.Dispose();
        }
    }
}
