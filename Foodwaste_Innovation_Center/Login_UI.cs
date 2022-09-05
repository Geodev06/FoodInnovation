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
    public partial class Login_UI : Form
    {
        Database db = new Database();

        public Login_UI()
        {
            InitializeComponent();
            try
            {
                db.Connect();
                db.Disconnect();
            }
            catch (MySqlException)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("server=127.0.0.1; user=root;");
                    con.Open();

                    using (MySqlCommand cmds = new MySqlCommand())
                    {
                        using (MySqlBackup mb = new MySqlBackup(cmds))
                        {
                            cmds.Connection = con;
                            mb.ImportFromFile("Database.sql");
                        }
                    }
                    con.Close();
                }
                catch (MySqlException)
                {
                    MessageBox.Show("Connection in server error, \n make sure you are connected.", "Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Environment.Exit(0);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        public void hasAccount()
        {
            db.Connect();
            db.cmd = new MySqlCommand("select * from Accounts", db.con);
            db.dr = db.cmd.ExecuteReader();

            if (db.dr.Read())
            {
                // Has Account...
                timer1.Enabled = false;
                timer1.Stop();
            }
            else
            {
                this.Hide();
                txtLname acc = new txtLname();
                acc.Show();
                timer1.Enabled = false;
                timer1.Stop();
            }
            db.Disconnect();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hasAccount();
        }

        private void Login_UI_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Start();
        }
        Alert mda = null;
        private void btnProceed_Click(object sender, EventArgs e)
        {
            db.Connect();
            db.cmd = new MySqlCommand("Select * from Accounts where user_id = '" + txtId.Text + "'", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                string type = db.dr[5].ToString();
                switch (type) {
                    case "Faculty":
                        this.Hide();
                        new FacultyView(db.dr[0].ToString()).Show();
                        break;
                    case "Student":
                        this.Hide();
                        new Studentview(db.dr[0].ToString()).Show();
                        break;
                    case "Worker":
                        this.Hide();
                        new Workerview(db.dr[0].ToString()).Show();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                if (mda == null)
                {
                    mda = new Alert("Invalid credentials", "");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
            }
            db.Disconnect();
        }

        void mda_FormClosed(object sender, FormClosedEventArgs e)
        {
            mda = null;
        }
    }
}
