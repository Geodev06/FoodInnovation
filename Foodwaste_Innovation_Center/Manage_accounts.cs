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
    public partial class Manage_accounts : Form
    {
        public Manage_accounts()
        {
            InitializeComponent();
        }
        Alert mda = null;

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnManagewaste_Click(object sender, EventArgs e)
        {
            if(Account.show() == DialogResult.Yes)
            {
                getData();
                lb_c.Text = "Total no. of accounts : " + count();
            }
        }
        Database db = new Database();
        public string count()
        {
            string count = "";
            db.Connect();
            db.cmd = new MySqlCommand("Select count(user_id) from Accounts", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                count = db.dr[0].ToString();
            }
            db.Disconnect();
            return count;
        }
        public void getData()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("User_id");
            dt.Columns.Add("Firstname");
            dt.Columns.Add("Lastname");
            dt.Columns.Add("Dept.");
            dt.Columns.Add("Sex.");
            dt.Columns.Add("Account type.");
            db.Connect();
            db.cmd = new MySqlCommand("Select * from Accounts where user_id Like '%" + txtSearch.Text + "%' or fname Like '%" + txtSearch.Text + "%' or lname Like '%" + txtSearch.Text + "%' or department Like '%" + txtSearch.Text + "%' or sex Like '%" + txtSearch.Text + "%' or type Like '%" + txtSearch.Text + "%' ORDER BY user_id DESC", db.con);
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                dt.Rows.Add(new Object[] {
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                    db.dr[3],
                    db.dr[4],
                    db.dr[5]
                });
            }
            data.DataSource = dt;
            db.Disconnect();
        }
        private void Manage_accounts_Load(object sender, EventArgs e)
        {
            getData();
            lb_c.Text = "Total no. of accounts : " + count();
            txtId.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getData();
        }

        private void data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.data.Rows[e.RowIndex];
                txtId.Text = row.Cells[0].Value.ToString();
                txtFn.Text = row.Cells[1].Value.ToString();
                txtLn.Text = row.Cells[2].Value.ToString();
                txtDepart.Text = row.Cells[3].Value.ToString();
                if (row.Cells[4].Value.ToString() == "Male")
                {
                    radioButton1.Checked = true;
                }
                else { radioButton2.Checked = true; }
                if(row.Cells[5].Value.ToString() == "Student")
                {
                    radioButton3.Checked = true;
                }
                if (row.Cells[5].Value.ToString() == "Worker")
                {
                    radioButton4.Checked = true;
                }
                if (row.Cells[5].Value.ToString() == "Faculty")
                {
                    radioButton5.Checked = true;
                }
                pnlEdit.Visible = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }
        public void update(string sex, string type)
        {
            db.Connect();
            db.cmd = new MySqlCommand("update Accounts set fname = @fn, lname = @ln, department = @dept, sex = @sex, type = @type where user_id = '" + txtId.Text + "'", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("fn", txtFn.Text));
            db.cmd.Parameters.Add(new MySqlParameter("ln", txtLn.Text));
            db.cmd.Parameters.Add(new MySqlParameter("dept", txtDepart.Text));
            db.cmd.Parameters.Add(new MySqlParameter("sex", sex));
            db.cmd.Parameters.Add(new MySqlParameter("type", type));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtId.Text) && !string.IsNullOrWhiteSpace(txtFn.Text) && !string.IsNullOrWhiteSpace(txtLn.Text) && !string.IsNullOrWhiteSpace(txtDepart.Text))
            {
                string id = txtId.Text;

                if (id.Length == 8)
                {
                    if (id.ElementAt(2).ToString() == "-")
                    {
                       if(MsgBox.Show("Save changes?") == DialogResult.Yes)
                       {
                           string sex = radioButton1.Checked ? "Male" : "Female";
                           string type = "";
                           if (radioButton3.Checked)
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
                           update(sex, type);
                           if (mda == null)
                           {
                               mda = new Alert("Account updated!", "Information");
                               mda.Show();
                               mda.FormClosed += mda_FormClosed;
                           }
                           pnlEdit.Visible = false;
                           getData();
                       }
                    }
                    else
                    {
                        if (mda == null)
                        {
                            mda = new Alert("Invalid Id format!", "");
                            mda.Show();
                            mda.FormClosed += mda_FormClosed;
                        }
                    }
                }
                else
                {
                    if (mda == null)
                    {
                        mda = new Alert("Invalid Id format!", "");
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

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(MsgBox.Show("Permanentlty delete this one?") == DialogResult.Yes)
            {
                db.Connect();
                db.cmd = new MySqlCommand("Delete from accounts where user_id = '" + txtId.Text + "'", db.con);
                db.cmd.ExecuteNonQuery();
                db.Disconnect();
                if (mda == null)
                {
                    mda = new Alert("Account deleted!", "Information");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
                pnlEdit.Visible = false;
                getData();
                lb_c.Text = "Total no. of accounts : " + count();
            }
        }
    }
}
