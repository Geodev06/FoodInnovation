namespace Foodwaste_Innovation_Center
{
    partial class Sell_waste
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sell_waste));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlQty = new System.Windows.Forms.Panel();
            this.lbId = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.lbcat = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbPrc = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbItem = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.lblclose = new System.Windows.Forms.PictureBox();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.lb2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dtwaste = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFinish = new System.Windows.Forms.Button();
            this.cart = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnVoidItem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lblTotalPrice = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnEnd = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCustName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlQty.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblclose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtwaste)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 13;
            this.label1.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(12, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 26);
            this.txtSearch.TabIndex = 12;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(338, 14);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 14;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.pnlQty);
            this.panel1.Controls.Add(this.dtwaste);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 535);
            this.panel1.TabIndex = 15;
            // 
            // pnlQty
            // 
            this.pnlQty.Controls.Add(this.lbId);
            this.pnlQty.Controls.Add(this.bunifuSeparator1);
            this.pnlQty.Controls.Add(this.lbcat);
            this.pnlQty.Controls.Add(this.bunifuCustomLabel2);
            this.pnlQty.Controls.Add(this.lbPrc);
            this.pnlQty.Controls.Add(this.lbItem);
            this.pnlQty.Controls.Add(this.btnAdd);
            this.pnlQty.Controls.Add(this.lb);
            this.pnlQty.Controls.Add(this.lblclose);
            this.pnlQty.Controls.Add(this.txtKg);
            this.pnlQty.Controls.Add(this.lb2);
            this.pnlQty.Controls.Add(this.lb1);
            this.pnlQty.Location = new System.Drawing.Point(207, 141);
            this.pnlQty.Name = "pnlQty";
            this.pnlQty.Size = new System.Drawing.Size(367, 324);
            this.pnlQty.TabIndex = 14;
            this.pnlQty.Visible = false;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbId.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbId.Location = new System.Drawing.Point(8, 278);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(15, 17);
            this.lbId.TabIndex = 33;
            this.lbId.Text = "0";
            this.lbId.Visible = false;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 113);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(368, 10);
            this.bunifuSeparator1.TabIndex = 32;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // lbcat
            // 
            this.lbcat.AutoSize = true;
            this.lbcat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbcat.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcat.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbcat.Location = new System.Drawing.Point(149, 45);
            this.lbcat.Name = "lbcat";
            this.lbcat.Size = new System.Drawing.Size(35, 17);
            this.lbcat.TabIndex = 31;
            this.lbcat.Text = "Price";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(22, 45);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(65, 17);
            this.bunifuCustomLabel2.TabIndex = 30;
            this.bunifuCustomLabel2.Text = "Category :";
            // 
            // lbPrc
            // 
            this.lbPrc.AutoSize = true;
            this.lbPrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbPrc.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrc.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbPrc.Location = new System.Drawing.Point(149, 65);
            this.lbPrc.Name = "lbPrc";
            this.lbPrc.Size = new System.Drawing.Size(35, 17);
            this.lbPrc.TabIndex = 29;
            this.lbPrc.Text = "Price";
            // 
            // lbItem
            // 
            this.lbItem.AutoSize = true;
            this.lbItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lbItem.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbItem.ForeColor = System.Drawing.Color.Gainsboro;
            this.lbItem.Location = new System.Drawing.Point(149, 17);
            this.lbItem.Name = "lbItem";
            this.lbItem.Size = new System.Drawing.Size(115, 25);
            this.lbItem.TabIndex = 28;
            this.lbItem.Text = "Waste name";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(133, 212);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 52);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add to stash";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(137, 139);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(99, 14);
            this.lb.TabIndex = 15;
            this.lb.Text = "Enter amount (kg.)";
            // 
            // lblclose
            // 
            this.lblclose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblclose.Image = ((System.Drawing.Image)(resources.GetObject("lblclose.Image")));
            this.lblclose.Location = new System.Drawing.Point(345, 8);
            this.lblclose.Name = "lblclose";
            this.lblclose.Size = new System.Drawing.Size(15, 15);
            this.lblclose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.lblclose.TabIndex = 25;
            this.lblclose.TabStop = false;
            this.lblclose.Click += new System.EventHandler(this.lblclose_Click);
            // 
            // txtKg
            // 
            this.txtKg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtKg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKg.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKg.ForeColor = System.Drawing.Color.White;
            this.txtKg.Location = new System.Drawing.Point(136, 161);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(97, 32);
            this.txtKg.TabIndex = 15;
            this.txtKg.Text = "0";
            this.txtKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKg_KeyPress);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lb2.Font = new System.Drawing.Font("Segoe UI Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb2.Location = new System.Drawing.Point(22, 65);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(129, 17);
            this.lb2.TabIndex = 26;
            this.lb2.Text = "Price :                    ₱";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lb1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb1.ForeColor = System.Drawing.Color.Gainsboro;
            this.lb1.Location = new System.Drawing.Point(22, 17);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(124, 25);
            this.lb1.TabIndex = 25;
            this.lb1.Text = "Waste name :";
            // 
            // dtwaste
            // 
            this.dtwaste.AllowUserToAddRows = false;
            this.dtwaste.AllowUserToDeleteRows = false;
            this.dtwaste.AllowUserToResizeColumns = false;
            this.dtwaste.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtwaste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtwaste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtwaste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.dtwaste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtwaste.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtwaste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwaste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtwaste.DoubleBuffered = true;
            this.dtwaste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtwaste.EnableHeadersVisualStyles = false;
            this.dtwaste.GridColor = System.Drawing.Color.Gainsboro;
            this.dtwaste.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtwaste.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dtwaste.Location = new System.Drawing.Point(0, 125);
            this.dtwaste.Name = "dtwaste";
            this.dtwaste.ReadOnly = true;
            this.dtwaste.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtwaste.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dtwaste.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtwaste.Size = new System.Drawing.Size(385, 410);
            this.dtwaste.TabIndex = 13;
            this.dtwaste.TabStop = false;
            this.dtwaste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwaste_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panel3.Controls.Add(this.btnFinish);
            this.panel3.Controls.Add(this.cart);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Controls.Add(this.btnVoidItem);
            this.panel3.Controls.Add(this.lblTotalPrice);
            this.panel3.Controls.Add(this.btnEnd);
            this.panel3.Controls.Add(this.bunifuCustomLabel6);
            this.panel3.Controls.Add(this.txtCustName);
            this.panel3.Controls.Add(this.bunifuCustomLabel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(385, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(365, 535);
            this.panel3.TabIndex = 1;
            // 
            // btnFinish
            // 
            this.btnFinish.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFinish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinish.ForeColor = System.Drawing.Color.White;
            this.btnFinish.Location = new System.Drawing.Point(231, 496);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(123, 31);
            this.btnFinish.TabIndex = 35;
            this.btnFinish.Text = "Release item";
            this.btnFinish.UseVisualStyleBackColor = false;
            this.btnFinish.Visible = false;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // cart
            // 
            this.cart.AllowUserToAddRows = false;
            this.cart.AllowUserToDeleteRows = false;
            this.cart.AllowUserToResizeColumns = false;
            this.cart.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.cart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cart.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.cart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cart.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.cart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cart.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cart.DoubleBuffered = true;
            this.cart.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cart.EnableHeadersVisualStyles = false;
            this.cart.GridColor = System.Drawing.Color.Gainsboro;
            this.cart.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.cart.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.cart.Location = new System.Drawing.Point(0, 125);
            this.cart.Name = "cart";
            this.cart.ReadOnly = true;
            this.cart.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.cart.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cart.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.cart.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cart.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cart.Size = new System.Drawing.Size(365, 410);
            this.cart.TabIndex = 24;
            this.cart.TabStop = false;
            this.cart.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cart_CellContentClick);
            // 
            // btnVoidItem
            // 
            this.btnVoidItem.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnVoidItem.BackColor = System.Drawing.Color.Transparent;
            this.btnVoidItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVoidItem.BorderRadius = 4;
            this.btnVoidItem.ButtonText = "Void Item";
            this.btnVoidItem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoidItem.DisabledColor = System.Drawing.Color.Transparent;
            this.btnVoidItem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnVoidItem.Iconimage = null;
            this.btnVoidItem.Iconimage_right = null;
            this.btnVoidItem.Iconimage_right_Selected = null;
            this.btnVoidItem.Iconimage_Selected = null;
            this.btnVoidItem.IconMarginLeft = 0;
            this.btnVoidItem.IconMarginRight = 0;
            this.btnVoidItem.IconRightVisible = true;
            this.btnVoidItem.IconRightZoom = 0D;
            this.btnVoidItem.IconVisible = true;
            this.btnVoidItem.IconZoom = 90D;
            this.btnVoidItem.IsTab = false;
            this.btnVoidItem.Location = new System.Drawing.Point(237, 461);
            this.btnVoidItem.Name = "btnVoidItem";
            this.btnVoidItem.Normalcolor = System.Drawing.Color.Transparent;
            this.btnVoidItem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnVoidItem.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.btnVoidItem.selected = false;
            this.btnVoidItem.Size = new System.Drawing.Size(66, 32);
            this.btnVoidItem.TabIndex = 23;
            this.btnVoidItem.TabStop = false;
            this.btnVoidItem.Text = "Void Item";
            this.btnVoidItem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnVoidItem.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnVoidItem.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.lblTotalPrice.Font = new System.Drawing.Font("Segoe UI Light", 14.25F);
            this.lblTotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.lblTotalPrice.Location = new System.Drawing.Point(279, 86);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(72, 25);
            this.lblTotalPrice.TabIndex = 21;
            this.lblTotalPrice.Text = "₱ 00.00";
            // 
            // btnEnd
            // 
            this.btnEnd.Activecolor = System.Drawing.Color.SeaGreen;
            this.btnEnd.BackColor = System.Drawing.Color.Transparent;
            this.btnEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnd.BorderRadius = 4;
            this.btnEnd.ButtonText = "Done";
            this.btnEnd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnd.DisabledColor = System.Drawing.Color.Transparent;
            this.btnEnd.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEnd.Iconimage = null;
            this.btnEnd.Iconimage_right = null;
            this.btnEnd.Iconimage_right_Selected = null;
            this.btnEnd.Iconimage_Selected = null;
            this.btnEnd.IconMarginLeft = 0;
            this.btnEnd.IconMarginRight = 0;
            this.btnEnd.IconRightVisible = true;
            this.btnEnd.IconRightZoom = 0D;
            this.btnEnd.IconVisible = true;
            this.btnEnd.IconZoom = 90D;
            this.btnEnd.IsTab = false;
            this.btnEnd.Location = new System.Drawing.Point(309, 461);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEnd.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnEnd.OnHoverTextColor = System.Drawing.Color.Cyan;
            this.btnEnd.selected = false;
            this.btnEnd.Size = new System.Drawing.Size(56, 32);
            this.btnEnd.TabIndex = 22;
            this.btnEnd.TabStop = false;
            this.btnEnd.Text = "Done";
            this.btnEnd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEnd.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnEnd.TextFont = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Segoe UI Light", 11.25F);
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(261, 66);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(90, 20);
            this.bunifuCustomLabel6.TabIndex = 20;
            this.bunifuCustomLabel6.Text = "Total Amount";
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.txtCustName.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtCustName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCustName.Font = new System.Drawing.Font("Segoe UI Light", 14F);
            this.txtCustName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.txtCustName.Location = new System.Drawing.Point(13, 62);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(167, 25);
            this.txtCustName.TabIndex = 16;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(9, 26);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 20);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Issued to";
            // 
            // Sell_waste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(750, 535);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sell_waste";
            this.Text = "Sell_waste";
            this.Load += new System.EventHandler(this.Sell_waste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlQty.ResumeLayout(false);
            this.pnlQty.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lblclose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtwaste)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtwaste;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuCustomDataGrid cart;
        private Bunifu.Framework.UI.BunifuFlatButton btnVoidItem;
        private Bunifu.Framework.UI.BunifuCustomLabel lblTotalPrice;
        private Bunifu.Framework.UI.BunifuFlatButton btnEnd;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtCustName;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.Panel pnlQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.PictureBox lblclose;
        private System.Windows.Forms.TextBox txtKg;
        private Bunifu.Framework.UI.BunifuCustomLabel lb2;
        private Bunifu.Framework.UI.BunifuCustomLabel lb1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbPrc;
        private Bunifu.Framework.UI.BunifuCustomLabel lbItem;
        private Bunifu.Framework.UI.BunifuCustomLabel lbcat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbId;
        private System.Windows.Forms.Button btnFinish;
    }
}