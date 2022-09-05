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
    public partial class Workerview : Form
    {
        String getId;
        public Workerview(String id)
        {
            InitializeComponent();
            getId = id;
            psubmenu.Height = 0;
            lblTime.Left = (this.pmain.Width - lblTime.Width) / 2;
            bunifuSeparator1.Left = (this.pmain.Width - bunifuSeparator1.Width) / 2;
            lbld.Left = (this.pmain.Width - lbld.Width) / 2;
            
            disposedkg();
        }
        public void disposedkg()
        {
            db.Connect();
            db.cmd = new MySqlCommand("Select CAST(Sum(kilograms) as DECIMAL(9,2)) from disposed where user_id = '"+getId+"'", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                lbldisposal.Text = db.dr[0].ToString() + "Kg.";
            }
            db.Disconnect();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblDate.Text = "Date today : " + DateTime.Now.ToString("MMMM dd yyyy");
            lblTime.Text = DateTime.Now.ToString("hh : mm : ss | tt");
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

        private void tOpen_Tick(object sender, EventArgs e)
        {
            if (psubmenu.Height < 74)
            {
                psubmenu.Height += 2;
            }
            if (psubmenu.Height == 74)
            {
                tOpen.Enabled = false;
                tOpen.Stop();
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
        Database db = new Database();
        public void getInfo()
        {
            db.Connect();
            db.cmd = new MySqlCommand("Select * from accounts where user_id = '" + getId + "' ", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                lbAvatar.Text = db.dr[1].ToString().ElementAt(0).ToString().ToUpper() + db.dr[2].ToString().ElementAt(0).ToString().ToLower();
                lblname.Text = db.dr[1].ToString() + " " + db.dr[2].ToString();
                lbtype.Text = db.dr[5].ToString();
            }
            db.Disconnect();
        }

        private void Workerview_Load(object sender, EventArgs e)
        {
            getInfo();
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
           if(MsgBox.Show("Logout now?") == DialogResult.Yes)
           {
               this.Hide();
               new Login_UI().Show();
           }
        }

        private void lbAvatar_Click(object sender, EventArgs e)
        {
            Showmenu();
        }

        Disposal dsp = null;
        private void btnThrow_Click(object sender, EventArgs e)
        {
            if(hs != null)
            {
                hs.Hide();
            }
            if(sll != null)
            {
                sll.Hide();
            }
            if (dsp != null)
            {
                dsp.Hide();
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
            disposedkg();
            dsp = null;
            pmain.Visible = true;
        }
        Sell_waste sll = null;
        private void btnSell_Click(object sender, EventArgs e)
        {
            if(hs != null)
            {
                hs.Hide();
            }
            if (sll != null)
            {
                sll.Hide();
            }
            if (dsp != null)
            {
                dsp.Hide();
            }

            if (sll == null)
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
            pmain.Visible = true;
            sll = null;
        }

        User_history hs = null;
        private void btnLogs_Click(object sender, EventArgs e)
        {
            if (hs != null)
            {
                hs.Hide();
            }
            if (sll != null)
            {
                sll.Hide();
            }
            if (dsp != null)
            {
                dsp.Hide();
            }

            if (hs== null)
            {
                hs = new User_history(getId);
                hs.TopLevel = false;
                hs.Parent = this;
                hs.Location = new Point(251, 101);
                hs.Show();
                hs.VisibleChanged += hs_VisibleChanged;
            }

            pmain.Visible = false;
        }

        void hs_VisibleChanged(object sender, EventArgs e)
        {
            pmain.Visible = true;
            hs = null;
        }

        private void lbldisposal_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

    }
}
