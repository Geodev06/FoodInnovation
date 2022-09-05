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
    public partial class txtLname : Form
    {
        Database db = new Database();
        public txtLname()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        public void create(string gender, string type = "Faculty")
        {
            db.Connect();
            db.cmd = new MySqlCommand("Insert into Accounts (user_id, fname, lname, department, sex, type) values (@uid, @fn, @ln, @dept, @sex, @type)", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("uid", txtId.Text));
            db.cmd.Parameters.Add(new MySqlParameter("fn", txtFn.Text));
            db.cmd.Parameters.Add(new MySqlParameter("ln", txtLn.Text));
            db.cmd.Parameters.Add(new MySqlParameter("dept", txtDepart.Text));
            db.cmd.Parameters.Add(new MySqlParameter("sex", gender));
            db.cmd.Parameters.Add(new MySqlParameter("type", type));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();
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
                        var confirm = MessageBox.Show("Register this credentials now?","Prompt",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (confirm == DialogResult.OK)
                        {
                            string sex = radioButton1.Checked ? "Male" : "Female";
                            create(sex);
                            MessageBox.Show("Account created!", "Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Hide();
                            new Login_UI().Show();
                        }
                           
                    }
                    else
                    {
                        MessageBox.Show("Invalid id format", "Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Invalid id format", "Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please fill up everything.", "Message.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
