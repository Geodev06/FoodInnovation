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

namespace Foodwaste_Innovation_Center
{
    public partial class User_history : Form
    {
        String getId;
        public User_history(String id)
        {
            InitializeComponent();
            getId = id;
        }

        Database db = new Database();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getdatadisposed()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Waste name.");
            dt.Columns.Add("kilograms");
            dt.Columns.Add("Date.");
            db.Connect();
            db.cmd = new MySqlCommand("Select waste_name, CAST(kilograms as DECIMAL(9,2)), DATE_FORMAT(created_at, '%M-%d-%Y %h:%i:%p') from disposed where user_id = '"+getId+"' ORDER BY id DESC", db.con);
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                dt.Rows.Add(new Object[] {
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],

                });
            }
            dtDispose.DataSource = dt;
            db.Disconnect();
        }

        private void User_history_Load(object sender, EventArgs e)
        {
            getdatadisposed();
        }

    }
}
