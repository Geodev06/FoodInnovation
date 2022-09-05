namespace Foodwaste_Innovation_Center
{
    partial class Workerview
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlAvatar = new System.Windows.Forms.Panel();
            this.lbAvatar = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSell = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLogs = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThrow = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pmain = new System.Windows.Forms.Panel();
            this.lbldisposal = new System.Windows.Forms.TextBox();
            this.lbld = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lblTime = new System.Windows.Forms.Label();
            this.bunifuDragControl3 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbtype = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.psubmenu = new System.Windows.Forms.Panel();
            this.btnlogout = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.tClose = new System.Windows.Forms.Timer(this.components);
            this.tOpen = new System.Windows.Forms.Timer(this.components);
            this.pnlAvatar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pmain.SuspendLayout();
            this.psubmenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 1;
            this.bunifuElipse1.TargetControl = this.pnlAvatar;
            // 
            // pnlAvatar
            // 
            this.pnlAvatar.BackColor = System.Drawing.Color.MediumAquamarine;
            this.pnlAvatar.Controls.Add(this.lbAvatar);
            this.pnlAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlAvatar.Location = new System.Drawing.Point(741, 31);
            this.pnlAvatar.Name = "pnlAvatar";
            this.pnlAvatar.Size = new System.Drawing.Size(50, 50);
            this.pnlAvatar.TabIndex = 1;
            this.pnlAvatar.Click += new System.EventHandler(this.lbAvatar_Click);
            // 
            // lbAvatar
            // 
            this.lbAvatar.AutoSize = true;
            this.lbAvatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbAvatar.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvatar.ForeColor = System.Drawing.Color.White;
            this.lbAvatar.Location = new System.Drawing.Point(7, 9);
            this.lbAvatar.Name = "lbAvatar";
            this.lbAvatar.Size = new System.Drawing.Size(40, 29);
            this.lbAvatar.TabIndex = 3;
            this.lbAvatar.Text = "Aa";
            this.lbAvatar.Click += new System.EventHandler(this.lbAvatar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.btnSell);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnLogs);
            this.panel2.Controls.Add(this.btnThrow);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(251, 533);
            this.panel2.TabIndex = 7;
            // 
            // btnSell
            // 
            this.btnSell.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnSell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSell.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSell.BorderRadius = 0;
            this.btnSell.ButtonText = "Sell waste";
            this.btnSell.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSell.DisabledColor = System.Drawing.Color.Gray;
            this.btnSell.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSell.Iconimage = global::Foodwaste_Innovation_Center.Properties.Resources.Sell_96px;
            this.btnSell.Iconimage_right = null;
            this.btnSell.Iconimage_right_Selected = null;
            this.btnSell.Iconimage_Selected = null;
            this.btnSell.IconMarginLeft = 0;
            this.btnSell.IconMarginRight = 0;
            this.btnSell.IconRightVisible = true;
            this.btnSell.IconRightZoom = 0D;
            this.btnSell.IconVisible = true;
            this.btnSell.IconZoom = 55D;
            this.btnSell.IsTab = false;
            this.btnSell.Location = new System.Drawing.Point(1, 96);
            this.btnSell.Name = "btnSell";
            this.btnSell.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnSell.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnSell.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSell.selected = false;
            this.btnSell.Size = new System.Drawing.Size(251, 48);
            this.btnSell.TabIndex = 7;
            this.btnSell.Text = "Sell waste";
            this.btnSell.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSell.Textcolor = System.Drawing.Color.Cyan;
            this.btnSell.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.Click += new System.EventHandler(this.btnSell_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dashboard";
            // 
            // btnLogs
            // 
            this.btnLogs.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnLogs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogs.BorderRadius = 0;
            this.btnLogs.ButtonText = "History";
            this.btnLogs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogs.DisabledColor = System.Drawing.Color.Gray;
            this.btnLogs.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLogs.Iconimage = global::Foodwaste_Innovation_Center.Properties.Resources.Combo_Chart_96px;
            this.btnLogs.Iconimage_right = null;
            this.btnLogs.Iconimage_right_Selected = null;
            this.btnLogs.Iconimage_Selected = null;
            this.btnLogs.IconMarginLeft = 0;
            this.btnLogs.IconMarginRight = 0;
            this.btnLogs.IconRightVisible = true;
            this.btnLogs.IconRightZoom = 0D;
            this.btnLogs.IconVisible = true;
            this.btnLogs.IconZoom = 55D;
            this.btnLogs.IsTab = false;
            this.btnLogs.Location = new System.Drawing.Point(1, 150);
            this.btnLogs.Name = "btnLogs";
            this.btnLogs.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnLogs.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnLogs.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogs.selected = false;
            this.btnLogs.Size = new System.Drawing.Size(251, 48);
            this.btnLogs.TabIndex = 3;
            this.btnLogs.Text = "History";
            this.btnLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogs.Textcolor = System.Drawing.Color.Cyan;
            this.btnLogs.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogs.Click += new System.EventHandler(this.btnLogs_Click);
            // 
            // btnThrow
            // 
            this.btnThrow.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnThrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnThrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThrow.BorderRadius = 0;
            this.btnThrow.ButtonText = "Throw waste";
            this.btnThrow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThrow.DisabledColor = System.Drawing.Color.Gray;
            this.btnThrow.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThrow.Iconimage = global::Foodwaste_Innovation_Center.Properties.Resources.Delete_96px;
            this.btnThrow.Iconimage_right = null;
            this.btnThrow.Iconimage_right_Selected = null;
            this.btnThrow.Iconimage_Selected = null;
            this.btnThrow.IconMarginLeft = 0;
            this.btnThrow.IconMarginRight = 0;
            this.btnThrow.IconRightVisible = true;
            this.btnThrow.IconRightZoom = 0D;
            this.btnThrow.IconVisible = true;
            this.btnThrow.IconZoom = 55D;
            this.btnThrow.IsTab = false;
            this.btnThrow.Location = new System.Drawing.Point(1, 42);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.btnThrow.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnThrow.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThrow.selected = false;
            this.btnThrow.Size = new System.Drawing.Size(251, 48);
            this.btnThrow.TabIndex = 1;
            this.btnThrow.Text = "Throw waste";
            this.btnThrow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThrow.Textcolor = System.Drawing.Color.Cyan;
            this.btnThrow.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.panel2;
            this.bunifuDragControl2.Vertical = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pmain
            // 
            this.pmain.Controls.Add(this.lbldisposal);
            this.pmain.Controls.Add(this.lbld);
            this.pmain.Controls.Add(this.bunifuSeparator1);
            this.pmain.Controls.Add(this.lblTime);
            this.pmain.Dock = System.Windows.Forms.DockStyle.Right;
            this.pmain.Location = new System.Drawing.Point(251, 101);
            this.pmain.Name = "pmain";
            this.pmain.Size = new System.Drawing.Size(750, 533);
            this.pmain.TabIndex = 8;
            // 
            // lbldisposal
            // 
            this.lbldisposal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.lbldisposal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbldisposal.Font = new System.Drawing.Font("Segoe UI", 78F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldisposal.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbldisposal.Location = new System.Drawing.Point(64, 202);
            this.lbldisposal.Name = "lbldisposal";
            this.lbldisposal.Size = new System.Drawing.Size(624, 139);
            this.lbldisposal.TabIndex = 28;
            this.lbldisposal.Text = "0.00kg.";
            this.lbldisposal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lbldisposal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lbldisposal_KeyPress);
            // 
            // lbld
            // 
            this.lbld.AutoSize = true;
            this.lbld.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbld.ForeColor = System.Drawing.Color.White;
            this.lbld.Location = new System.Drawing.Point(190, 133);
            this.lbld.Name = "lbld";
            this.lbld.Size = new System.Drawing.Size(359, 42);
            this.lbld.TabIndex = 13;
            this.lbld.Text = "MY OVERALL DISPOSAL";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(222, 95);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(318, 15);
            this.bunifuSeparator1.TabIndex = 10;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(243, 47);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(277, 42);
            this.lblTime.TabIndex = 9;
            this.lblTime.Text = "HH : MM : SS | TT";
            // 
            // bunifuDragControl3
            // 
            this.bunifuDragControl3.Fixed = true;
            this.bunifuDragControl3.Horizontal = true;
            this.bunifuDragControl3.TargetControl = this.pmain;
            this.bunifuDragControl3.Vertical = true;
            // 
            // lbtype
            // 
            this.lbtype.AutoSize = true;
            this.lbtype.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbtype.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtype.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbtype.Location = new System.Drawing.Point(802, 49);
            this.lbtype.Name = "lbtype";
            this.lbtype.Size = new System.Drawing.Size(47, 15);
            this.lbtype.TabIndex = 8;
            this.lbtype.Text = "Faculty";
            this.lbtype.Click += new System.EventHandler(this.lbAvatar_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(17, 72);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(144, 15);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date Today : MM DD YYYY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 36);
            this.label1.TabIndex = 5;
            this.label1.Text = "Food Innovation center";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.ForeColor = System.Drawing.Color.White;
            this.lblname.Location = new System.Drawing.Point(802, 29);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(83, 15);
            this.lblname.TabIndex = 4;
            this.lblname.Text = "Juan Delacruz";
            this.lblname.Click += new System.EventHandler(this.lbAvatar_Click);
            // 
            // psubmenu
            // 
            this.psubmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.psubmenu.Controls.Add(this.btnlogout);
            this.psubmenu.Location = new System.Drawing.Point(803, 29);
            this.psubmenu.Name = "psubmenu";
            this.psubmenu.Size = new System.Drawing.Size(168, 74);
            this.psubmenu.TabIndex = 100;
            // 
            // btnlogout
            // 
            this.btnlogout.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnlogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnlogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnlogout.BorderRadius = 0;
            this.btnlogout.ButtonText = "Logout";
            this.btnlogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlogout.DisabledColor = System.Drawing.Color.Gray;
            this.btnlogout.Iconcolor = System.Drawing.Color.Transparent;
            this.btnlogout.Iconimage = global::Foodwaste_Innovation_Center.Properties.Resources.Shutdown_96px;
            this.btnlogout.Iconimage_right = null;
            this.btnlogout.Iconimage_right_Selected = null;
            this.btnlogout.Iconimage_Selected = null;
            this.btnlogout.IconMarginLeft = 0;
            this.btnlogout.IconMarginRight = 0;
            this.btnlogout.IconRightVisible = true;
            this.btnlogout.IconRightZoom = 0D;
            this.btnlogout.IconVisible = true;
            this.btnlogout.IconZoom = 40D;
            this.btnlogout.IsTab = false;
            this.btnlogout.Location = new System.Drawing.Point(0, 41);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.btnlogout.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnlogout.OnHoverTextColor = System.Drawing.Color.White;
            this.btnlogout.selected = false;
            this.btnlogout.Size = new System.Drawing.Size(168, 32);
            this.btnlogout.TabIndex = 7;
            this.btnlogout.Text = "Logout";
            this.btnlogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnlogout.Textcolor = System.Drawing.Color.White;
            this.btnlogout.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.lbtype);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.pnlAvatar);
            this.panel1.Controls.Add(this.psubmenu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 101);
            this.panel1.TabIndex = 6;
            // 
            // tClose
            // 
            this.tClose.Interval = 10;
            this.tClose.Tick += new System.EventHandler(this.tClose_Tick);
            // 
            // tOpen
            // 
            this.tOpen.Interval = 10;
            this.tOpen.Tick += new System.EventHandler(this.tOpen_Tick);
            // 
            // Workerview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(1001, 634);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pmain);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Workerview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workerview";
            this.Load += new System.EventHandler(this.Workerview_Load);
            this.pnlAvatar.ResumeLayout(false);
            this.pnlAvatar.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pmain.ResumeLayout(false);
            this.pmain.PerformLayout();
            this.psubmenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel pnlAvatar;
        private System.Windows.Forms.Label lbAvatar;
        private Bunifu.Framework.UI.BunifuFlatButton btnLogs;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnThrow;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pmain;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label lblTime;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl3;
        private System.Windows.Forms.Label lbtype;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblname;
        private Bunifu.Framework.UI.BunifuFlatButton btnlogout;
        private System.Windows.Forms.Panel psubmenu;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tClose;
        private System.Windows.Forms.Timer tOpen;
        private Bunifu.Framework.UI.BunifuFlatButton btnSell;
        private System.Windows.Forms.Label lbld;
        private System.Windows.Forms.TextBox lbldisposal;
    }
}