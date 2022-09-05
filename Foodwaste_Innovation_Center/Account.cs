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
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }
        Database db = new Database();
        Alert mda = null;
        static Account acc;
        static DialogResult res = DialogResult.No;
        public static DialogResult show()
        {
            acc = new Account();
            acc.ShowDialog();
            return res;
        }
        public void save(string sex, string type)
        {
            db.Connect();
            db.cmd = new MySqlCommand("Insert into Accounts (user_id, fname, lname, department, sex, type) values (@id, @fn, @ln, @dept, @sex, @type)", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("id", txtId.Text));
            db.cmd.Parameters.Add(new MySqlParameter("fn", txtFn.Text));
            db.cmd.Parameters.Add(new MySqlParameter("ln", txtLn.Text));
            db.cmd.Parameters.Add(new MySqlParameter("dept", txtDepart.Text));
            db.cmd.Parameters.Add(new MySqlParameter("sex", sex));
            db.cmd.Parameters.Add(new MySqlParameter("type", type));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            res = DialogResult.No;
            this.Close();
        }

        public bool check()
        {
            bool isfound = false;
            db.Connect();
            db.cmd = new MySqlCommand("select user_id from Accounts where user_id = '"+txtId.Text+"'", db.con);
            db.dr = db.cmd.ExecuteReader();
            if(db.dr.Read())
            {
                isfound = true;
            }
            db.Disconnect();

            return isfound;

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text) && !string.IsNullOrWhiteSpace(txtFn.Text) && !string.IsNullOrWhiteSpace(txtLn.Text) && !string.IsNullOrWhiteSpace(txtDepart.Text))
            {
                string id = txtId.Text;

                if (id.Length == 8)
                {
                    if (id.ElementAt(2).ToString() == "-")
                    {
                        if (!check())
                        {
                            if(MsgBox.Show("Create this one now?") == DialogResult.Yes)
                            {
                                string sex = radioButton1.Checked ? "Male" : "Female";
                                string type = "";
                                if(radioButton3.Checked)
                                {
                                    type = "Student";
                                }
                                if (radioButton4.Checked)
                                {
                                    type = "Worker";
                                }
                                if (radioButton5.Checked)
                                {
                                    type = "Faculty";
                                }
                                save(sex, type);
                                if(mda == null)
                                {
                                    mda = new Alert("Account created!", "Information");
                                    mda.Show();
                                    mda.FormClosed += mda_FormClosed;
                                }
                                res = DialogResult.Yes;
                                this.Close();
                            }
                        }
                        else
                        {
                            if (mda == null)
                            {
                                mda = new Alert("Id already exsiting!", "");
                                mda.Show();
                                mda.FormClosed += mda_FormClosed;
                            }
                        }

                    }
                    else
                    {
                        if (mda == null)
                        {
                            mda = new Alert("Invalid Id format", "");
                            mda.Show();
                            mda.FormClosed += mda_FormClosed;
                        }
                    }
                }
                else
                {
                    if (mda == null)
                    {
                        mda = new Alert("Invalid Id format", "");
                        mda.Show();
                        mda.FormClosed += mda_FormClosed;
                    }
                }
            }
            else
            {
                if (mda == null)
                {
                    mda = new Alert("Fill up everthing!", "");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
            }
        }

        void mda_FormClosed(object sender, FormClosedEventArgs e)
        {
            mda = null;
        }
    }
}
