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
    public partial class FacultyView : Form
    {
        String getId;
        public FacultyView(String id)
        {
            InitializeComponent();
            getId = id;
            psubmenu.Height = 0;
            lblTime.Left = (this.pmain.Width - lblTime.Width) / 2;
            bunifuSeparator1.Left = (this.pmain.Width - bunifuSeparator1.Width) / 2;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = "Date today : " + DateTime.Now.ToString("MMMM dd yyyy");
            lblTime.Text =  DateTime.Now.ToString("hh : mm : ss | tt");
        }

        public void getKg()
        {
            db.Connect();
            db.cmd = new MySqlCommand("Select CAST(Sum(kilograms) as DECIMAL(9,2)) from disposed where DATE_FORMAT(created_at, '%M:%Y') = DATE_FORMAT(CURRENT_DATE(), '%M:%Y')", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                lblKg.Text = db.dr[0].ToString() + "kg.";
            }
            db.Disconnect();
        }
        public void getEarning()
        {
            db.Connect();
            db.cmd = new MySqlCommand("Select CAST(Sum(total_amount) as DECIMAL(9,2)) from sales where DATE_FORMAT(created_at, '%M:%Y') = DATE_FORMAT(CURRENT_DATE(), '%M:%Y')", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                lblEarnings.Text = "₱ " + db.dr[0].ToString();
            }
            db.Disconnect();
        }
        private void FacultyView_Load(object sender, EventArgs e)
        {
            getEarning();
            getKg();

            timer1.Enabled = true;
            timer1.Start();
            getInfo();
            lblM.Left = (this.pmain.Width - lblM.Width) / 2;
            lblM.Text = "For the Month of " + DateTime.Now.ToString("MMMM");
            label3.Left = (this.bunifuCards1.Width - label3.Width) / 2;
            label4.Left = (this.bunifuCards2.Width - label4.Width) / 2;
            lblKg.Left = (this.bunifuCards1.Width - lblKg.Width) / 2;
            lblEarnings.Left = (this.bunifuCards2.Width - lblEarnings.Width) / 2;

        }

        private void tOpen_Tick(object sender, EventArgs e)
        {
            if(psubmenu.Height < 74)
            {
                psubmenu.Height += 2;
            }
            if(psubmenu.Height == 74)
            {
                tOpen.Enabled = false;
                tOpen.Stop();
            }
        }

        private void tClose_Tick(object sender, EventArgs e)
        {
            if (psubmenu.Height > 0)
            {
                psubmenu.Height -= 2;
            }
            if (psubmenu.Height == 0)
            {
                tClose.Enabled = false;
                tClose.Stop();
            }
        }

        void Showmenu()
        {
            if (psubmenu.Height < 74)
            {
                tOpen.Enabled = true;
                tOpen.Start();
                tClose.Enabled = false;
                tClose.Start();
            }
            if (psubmenu.Height > 0)
            {
                tClose.Enabled = true;
                tClose.Start();
                tOpen.Enabled = false;
                tOpen.Stop();
            }
        }

        private void lblname_Click(object sender, EventArgs e)
        {
            Showmenu();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Showmenu();
        }

        private void lbAvatar_Click(object sender, EventArgs e)
        {
            Showmenu();
        }

        Manage_waste mngwaste = null;
        private void btnManagewaste_Click(object sender, EventArgs e)
        {
            if (dsp != null)
            {
                dsp.Hide();
            }
            if (lg != null)
            {
                lg.Hide();
            }
            if(sll != null)
            {
                sll.Hide();
            }
            if(acc != null)
            {
                acc.Hide();
            }
            if (mngwaste != null)
            {
                mngwaste.Hide();
            }
            if (mngwaste == null)
            {
                mngwaste = new Manage_waste();
                mngwaste.TopLevel = false;
                mngwaste.Parent = this;
                mngwaste.Location = new Point(251, 101);
                mngwaste.Show();
                mngwaste.VisibleChanged += mng_waste_VisibleChanged;
            }

            pmain.Visible = false;
        }

        void mng_waste_VisibleChanged(object sender, EventArgs e)
        {
            pmain.Visible = true;
            mngwaste = null;
        }
        Manage_accounts acc = null;
        private void btnaccounts_Click(object sender, EventArgs e)
        {
            if (dsp != null)
            {
                dsp.Hide();
            }
            if (lg != null)
            {
                lg.Hide();
            }
            if(sll != null)
            {
                sll.Hide();
            }
            if (acc != null)
            {
                acc.Hide();
            }
            if (mngwaste != null)
            {
                mngwaste.Hide();
            }
            if (acc == null)
            {
                acc = new Manage_accounts();
                acc.TopLevel = false;
                acc.Parent = this;
                acc.Location = new Point(251, 101);
                acc.Show();
                acc.VisibleChanged += acc_VisibleChanged;
            }

            pmain.Visible = false;
        }

        void acc_VisibleChanged(object sender, EventArgs e)
        {
            pmain.Visible = true;
            acc = null;
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            if(MsgBox.Show("Logout now?") == DialogResult.Yes)
            {
                this.Hide();
                new Login_UI().Show();
            }
        }
        Database db = new Database();
        public void getInfo()
        {
            db.Connect();
            db.cmd = new MySqlCommand("Select * from accounts where user_id = '" + getId + "' ", db.con);
            db.dr = db.cmd.ExecuteReader();
            if(db.dr.Read())
            {
                lbAvatar.Text = db.dr[1].ToString().ElementAt(0).ToString().ToUpper() + db.dr[2].ToString().ElementAt(0).ToString().ToLower();
                lblname.Text = db.dr[1].ToString() + " " + db.dr[2].ToString();
                lbtype.Text = db.dr[5].ToString();
            }
            db.Disconnect();
        }

        Sell_waste sll = null;
        private void btnSell_Click(object sender, EventArgs e)
        {
            if (dsp != null)
            {
                dsp.Hide();
            }
            if(lg != null)
            {
                lg.Hide();
            }
            if (sll != null)
            {
                sll.Hide();
            }
            if (acc != null)
            {
                acc.Hide();
            }
            if (mngwaste != null)
            {
                mngwaste.Hide();
            }
            if (sll== null)
            {
                sll = new Sell_waste(getId);
                sll.TopLevel = false;
                sll.Parent = this;
                sll.Location = new Point(251, 101);
                sll.Show();
                sll.VisibleChanged += sll_VisibleChanged;
            }

            pmain.Visible = false;
        }

        void sll_VisibleChanged(object sender, EventArgs e)
        {
            getEarning();
            pmain.Visible = true;
            sll = null;
        }

        Logs lg = null;
        private void btnLogs_Click(object sender, EventArgs e)
        {
            if(dsp !=null)
            {
                dsp.Hide();
            }
            if (lg != null)
            {
                lg.Hide();
            }
            if (sll != null)
            {
                sll.Hide();
            }
            if (acc != null)
            {
                acc.Hide();
            }
            if (mngwaste != null)
            {
                mngwaste.Hide();
            }
            if (lg == null)
            {
                lg = new Logs();
                lg.TopLevel = false;
                lg.Parent = this;
                lg.Location = new Point(251, 101);
                lg.Show();
                lg.VisibleChanged += lg_VisibleChanged;
            }

            pmain.Visible = false;
        }

        void lg_VisibleChanged(object sender, EventArgs e)
        {
            lg = null;
            pmain.Visible = true;
        }

        Disposal dsp = null;
        private void btnThrow_Click(object sender, EventArgs e)
        {
            if (dsp != null)
            {
                dsp.Hide();
            }
            if (lg != null)
            {
                lg.Hide();
            }
            if (sll != null)
            {
                sll.Hide();
            }
            if (acc != null)
            {
                acc.Hide();
            }
            if (mngwaste != null)
            {
                mngwaste.Hide();
            }
            if (dsp == null)
            {
                dsp = new Disposal(getId);
                dsp.TopLevel = false;
                dsp.Parent = this;
                dsp.Location = new Point(251, 101);
                dsp.Show();
                dsp.VisibleChanged += dsp_VisibleChanged;
            }

            pmain.Visible = false;
        }

        void dsp_VisibleChanged(object sender, EventArgs e)
        {
            getKg();
            pmain.Visible = true;
            dsp = null;
        }

        private void lblKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
