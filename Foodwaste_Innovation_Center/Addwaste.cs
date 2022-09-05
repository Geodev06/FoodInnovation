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
    public partial class Addwaste : Form
    {
        public Addwaste()
        {
            InitializeComponent();
        }
        static Addwaste addwst;
        static DialogResult result = DialogResult.No;
        public static DialogResult Add()
        {
            addwst = new Addwaste();
            addwst.ShowDialog();
            return result;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            result = DialogResult.No;
            this.Close();
        }
        Database db = new Database();
        public void save(string price, string cat)
        {
            db.Connect();
            db.cmd = new MySqlCommand("Insert into waste (waste_name, category, price) values (@name, @cat, @prc)", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("name", txtname.Text));
            db.cmd.Parameters.Add(new MySqlParameter("cat", cat));
            db.cmd.Parameters.Add(new MySqlParameter("prc", price));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();
        }
        Alert mda = null;
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
                            string cat = cbCat.Text;
                            if (MsgBox.Show("Save this one?") == DialogResult.Yes)
                            {
                                save(price, cat);
                                if (mda == null)
                                {
                                    mda = new Alert("Item saved", "Information");
                                    mda.Show();
                                    mda.FormClosed += mda_FormClosed;
                                }
                                result = DialogResult.Yes;
                                this.Close();
                            }
                        }
                        else
                        {
                            if (mda == null)
                            {
                                mda = new Alert("Category cannot be emty.", "");
                                mda.Show();
                                mda.FormClosed += mda_FormClosed;
                            }
                        }
                    }
                    else
                    {
                        if (mda == null)
                        {
                            mda = new Alert("Category cannot be empty", "");
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

        private void txtprice_KeyPress(object sender, KeyPressEventArgs e)
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

        private void Addwaste_Load(object sender, EventArgs e)
        {
            cbCat.SelectedIndex = 0;
        }

        bool cantype = false;
        private void cbCat_KeyPress(object sender, KeyPressEventArgs e)
        {
           if(!cantype)
           {
               e.Handled = true;
           }
        }

        private void cbCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCat.SelectedIndex == cbCat.Items.Count - 1)
            {
                cantype = true;
            }
            else
            {
                cantype = false;
            }
        }
    }
}
