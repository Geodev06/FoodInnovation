using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foodwaste_Innovation_Center
{
    public partial class Alert : Form
    {
        public Alert(String message, String type)
        {
            InitializeComponent();
            Message.Text = message;

            switch (type)
            {
                case "Information":
                    this.BackColor = Color.Gray;
                    pictureBox1.BackgroundImage = Foodwaste_Innovation_Center.Properties.Resources.Ok_96px;
                    Message.ForeColor = Color.FromArgb(251, 251, 251);
                    break;
                default:
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void tOpenForm_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 100)
            {
                this.Opacity = this.Opacity + 0.01;
                tCloseForm.Enabled = true;
                tCloseForm.Start();
            }
            else
            {
                tOpenForm.Stop();
            }
        }

        private void tCloseForm_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Alert_Load(object sender, EventArgs e)
        {
            this.Top = 60;
            this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width - 60;

            tOpenForm.Enabled = true;
            tOpenForm.Start();
        }
    }
}
