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
    public partial class Disposal : Form
    {
        String getId;
        public Disposal(String id)
        {
            InitializeComponent();
            getId = id;
        }
        Database db = new Database();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void Disposal_Load(object sender, EventArgs e)
        {
            getdata();
            lb_c.Text = "Items count : " + count();
            pnlCard.Visible = false;
            pnlCard.Left = (this.Width - pnlCard.Width) / 2;
        }
        public void SaveDisposed(string uname, double kg)
        {
            db.Connect();
            db.cmd = new MySqlCommand("insert into disposed (user_id, waste_name, disposed_by, kilograms, created_at) values (@id, @wname, @uname, @kg, CURRENT_TIMESTAMP())", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("id", getId));
            db.cmd.Parameters.Add(new MySqlParameter("wname", txtItemname.Text));
            db.cmd.Parameters.Add(new MySqlParameter("uname", uname));
            db.cmd.Parameters.Add(new MySqlParameter("kg", kg));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();

        }
        public string count()
        {
            string count = "";
            db.Connect();
            db.cmd = new MySqlCommand("Select count(waste_id) from waste", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                count = db.dr[0].ToString();
            }
            db.Disconnect();
            return count;
        }
        public void getdata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id.");
            dt.Columns.Add("Waste name.");
            dt.Columns.Add("Category.");
            db.Connect();
            db.cmd = new MySqlCommand("Select * from waste where waste_id Like '%" + txtSearch.Text + "%' or waste_name Like '%" + txtSearch.Text + "%' or category Like '%" + txtSearch.Text + "%' ORDER BY waste_id DESC", db.con);
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                dt.Rows.Add(new Object[] {
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                });
            }
            dtwaste.DataSource = dt;
            db.Disconnect();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getdata();
        }
        public string getfullname()
        {
            string fullname = "";
            db.Connect();
            db.cmd = new MySqlCommand("select fname, lname from Accounts where user_id = '" + getId + "'", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                fullname = db.dr[0].ToString() + " " + db.dr[1].ToString();
            }
            db.Disconnect();
            return fullname;
        }

        private void dtwaste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtwaste.Rows[e.RowIndex];
                txtItemname.Text = row.Cells[1].Value.ToString();
                pnlCard.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pnlCard.Visible = false;
        }

        private void txtKg_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((!Char.IsDigit(e.KeyChar) || txtKg.Text.Length >= 5) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 46 && txtKg.Text.Length != 5)
            {
                e.Handled = false;

                if (txtKg.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }

        Alert mda = null;
        private void btnThrow_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtItemname.Text))
            {
                if (!string.IsNullOrWhiteSpace(txtKg.Text))
                {
                    if (txtKg.Text != ".")
                    {
                        if (Convert.ToDouble(txtKg.Text) > 0)
                        {
                           if(MsgBox.Show("Dispose this one now?") == DialogResult.Yes)
                           {
                               double kilo = Convert.ToDouble(txtKg.Text);
                               SaveDisposed(getfullname(), kilo);
                               if (mda == null)
                               {
                                   mda = new Alert(txtItemname.Text+" disposed!", "Information");
                                   mda.Show();
                                   mda.FormClosed += mda_FormClosed;
                               }
                               txtItemname.Clear();
                               txtKg.Text = "0";
                               pnlCard.Visible = false;
                           }
                        }
                        else
                        {
                            if (mda == null)
                            {
                                mda = new Alert("Kg cannot be zero", "");
                                mda.Show();
                                mda.FormClosed += mda_FormClosed;
                            }
                        }
                    }
                    else
                    {
                        if (mda == null)
                        {
                            mda = new Alert("Kg cannot be zero", "");
                            mda.Show();
                            mda.FormClosed += mda_FormClosed;
                        }
                    }
                }
                else
                {
                    if (mda == null)
                    {
                        mda = new Alert("Name cannot be empty", "");
                        mda.Show();
                        mda.FormClosed += mda_FormClosed;
                    }
                }
            }
            else
            {
                if (mda == null)
                {
                    mda = new Alert("Name cannot be empty", "");
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
