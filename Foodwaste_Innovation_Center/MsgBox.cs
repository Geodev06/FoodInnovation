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
    public partial class MsgBox : Form
    {
        public MsgBox()
        {
            InitializeComponent();
        }
        static MsgBox msgBox;
        static DialogResult result = DialogResult.No;

        public static DialogResult Show(string text)
        {
            msgBox = new MsgBox();
            msgBox.Message.Text = text;
            msgBox.ShowDialog();
            return result;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            result = DialogResult.Yes; msgBox.Close();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            result = DialogResult.No; msgBox.Close();
        }
    }
}
