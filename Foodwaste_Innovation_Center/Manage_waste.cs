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
    public partial class Manage_waste : Form
    {
        public Manage_waste()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        Alert mda = null;

        private void btnManagewaste_Click(object sender, EventArgs e)
        {
            if(Addwaste.Add() == DialogResult.Yes)
            {
                getdata();
                lb_c.Text = "Total count : " + count();
            }
        }

        void mda_FormClosed(object sender, FormClosedEventArgs e)
        {
            mda = null;
        }

        private void Manage_waste_Load(object sender, EventArgs e)
        {
            getdata();
            lb_c.Text = "Total count : " + count();
        }
        public string count()
        {
            string count = "";
            db.Connect();
            db.cmd = new MySqlCommand("Select count(waste_id) from waste", db.con);
            db.dr = db.cmd.ExecuteReader();
            if(db.dr.Read())
            {
                count = db.dr[0].ToString();
            }
            db.Disconnect();
            return count;  
        }
        Database db = new Database();
        public void getdata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id.");
            dt.Columns.Add("Waste name.");
            dt.Columns.Add("Category.");
            dt.Columns.Add("Price per kg.");
            db.Connect();
            db.cmd = new MySqlCommand("Select * from waste where waste_id Like '%"+txtSearch.Text+"%' or waste_name Like '%"+txtSearch.Text+"%' or category Like '%"+txtSearch.Text+"%' or price Like '%"+txtSearch.Text+"%' ORDER BY waste_id DESC",db.con);
            db.dr = db.cmd.ExecuteReader();
            while(db.dr.Read())
            {
                dt.Rows.Add(new Object[] {
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                    db.dr[3],
                });
            }
            dtwaste.DataSource = dt;
            db.Disconnect();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getdata();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            pnlEdit.Visible = false;
        }

        private void dtwaste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtwaste.Rows[e.RowIndex];
                pnlEdit.Visible = true;
                txtname.Text = row.Cells[1].Value.ToString();
                cbCat.Text = row.Cells[2].Value.ToString();
                txtPrc.Text = row.Cells[3].Value.ToString();
                lblId.Text = row.Cells[0].Value.ToString();
            }
        }

        private void txtPrc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) || txtPrc.Text.Length >= 5) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 46 && txtPrc.Text.Length != 5)
            {
                e.Handled = false;

                if (txtPrc.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }
        public void update(string price, string cat, string id)
        {
            db.Connect();
            db.cmd = new MySqlCommand("update waste set waste_name = @name, category = @cat, price = @prc where waste_id = @id", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("name", txtname.Text));
            db.cmd.Parameters.Add(new MySqlParameter("cat", cat));
            db.cmd.Parameters.Add(new MySqlParameter("prc", price));
            db.cmd.Parameters.Add(new MySqlParameter("id", id));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtname.Text))
            {
                if (cbCat.SelectedIndex != 0)
                {
                    if (cbCat.Text != "")
                    {
                        if (cbCat.SelectedIndex != cbCat.Items.Count - 1 && cbCat.Text != "")
                        {
                            string price = txtPrc.Text == "" ? "0" : txtPrc.Text;
                            string id = lblId.Text;
                            string cat = cbCat.Text;
                            if(MsgBox.Show("Save changes now?") == DialogResult.Yes)
                            {
                                update(price, cat, id);
                                if (mda == null)
                                {
                                    mda = new Alert("Item updated!", "Information");
                                    mda.Show();
                                    mda.FormClosed += mda_FormClosed;
                                }
                                txtname.Clear();
                                lblId.Text = "";
                                txtPrc.Text = "0";
                                cbCat.SelectedIndex = 0;
                                pnlEdit.Visible = false;
                                getdata();

                            }
                        }
                        else
                        {
                            if (mda == null)
                            {
                                mda = new Alert("Category cannot be empty!", "");
                                mda.Show();
                                mda.FormClosed += mda_FormClosed;
                            }
                        }
                    }
                    else
                    {
                        if (mda == null)
                        {
                            mda = new Alert("Category cannot be empty!", "");
                            mda.Show();
                            mda.FormClosed += mda_FormClosed;
                        }
                    }
                }
                else
                {
                    if (mda == null)
                    {
                        mda = new Alert("Choose category", "");
                        mda.Show();
                        mda.FormClosed += mda_FormClosed;
                    }
                }
            }
            else
            {
                if (mda == null)
                {
                    mda = new Alert("Name cannot be empty!", "");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MsgBox.Show("Delete this one now?") == DialogResult.Yes)
            {
                db.Connect();
                db.cmd = new MySqlCommand("Delete from waste where waste_id = '" + lblId.Text + "' ", db.con);
                db.cmd.ExecuteNonQuery();
                db.Disconnect();
                if (mda == null)
                {
                    mda = new Alert("Item deleted!", "Information");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
                txtname.Clear();
                lblId.Text = "";
                txtPrc.Text = "0";
                cbCat.SelectedIndex = 0;
                pnlEdit.Visible = false;
                getdata();
                lb_c.Text = "Total count : " + count();
            }
        }
    }
}
