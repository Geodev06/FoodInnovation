namespace Foodwaste_Innovation_Center
{
    partial class Manage_waste
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_c = new System.Windows.Forms.Label();
            this.dd = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.btnManagewaste = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dtwaste = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrc = new System.Windows.Forms.TextBox();
            this.cbCat = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnHide = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lblId = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtwaste)).BeginInit();
            this.pnlEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(544, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search :";
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_c.ForeColor = System.Drawing.Color.White;
            this.lb_c.Location = new System.Drawing.Point(12, 99);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(67, 14);
            this.lb_c.TabIndex = 3;
            this.lb_c.Text = "Total count :";
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.ForeColor = System.Drawing.Color.White;
            this.dd.Location = new System.Drawing.Point(8, 9);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(188, 36);
            this.dd.TabIndex = 10;
            this.dd.Text = "Manage waste";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Foodwaste_Innovation_Center.Properties.Resources.Delete_96px;
            this.btnClose.Location = new System.Drawing.Point(725, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnManagewaste
            // 
            this.btnManagewaste.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnManagewaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnManagewaste.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManagewaste.BorderRadius = 0;
            this.btnManagewaste.ButtonText = "Add new";
            this.btnManagewaste.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManagewaste.DisabledColor = System.Drawing.Color.Gray;
            this.btnManagewaste.Iconcolor = System.Drawing.Color.Transparent;
            this.btnManagewaste.Iconimage = global::Foodwaste_Innovation_Center.Properties.Resources.Plus_Math_96px;
            this.btnManagewaste.Iconimage_right = null;
            this.btnManagewaste.Iconimage_right_Selected = null;
            this.btnManagewaste.Iconimage_Selected = null;
            this.btnManagewaste.IconMarginLeft = 0;
            this.btnManagewaste.IconMarginRight = 0;
            this.btnManagewaste.IconRightVisible = true;
            this.btnManagewaste.IconRightZoom = 0D;
            this.btnManagewaste.IconVisible = true;
            this.btnManagewaste.IconZoom = 60D;
            this.btnManagewaste.IsTab = false;
            this.btnManagewaste.Location = new System.Drawing.Point(594, 478);
            this.btnManagewaste.Name = "btnManagewaste";
            this.btnManagewaste.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnManagewaste.OnHovercolor = System.Drawing.SystemColors.Highlight;
            this.btnManagewaste.OnHoverTextColor = System.Drawing.Color.White;
            this.btnManagewaste.selected = false;
            this.btnManagewaste.Size = new System.Drawing.Size(144, 45);
            this.btnManagewaste.TabIndex = 4;
            this.btnManagewaste.Text = "Add new";
            this.btnManagewaste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnManagewaste.Textcolor = System.Drawing.Color.White;
            this.btnManagewaste.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManagewaste.Click += new System.EventHandler(this.btnManagewaste_Click);
            // 
            // dtwaste
            // 
            this.dtwaste.AllowUserToAddRows = false;
            this.dtwaste.AllowUserToDeleteRows = false;
            this.dtwaste.AllowUserToResizeColumns = false;
            this.dtwaste.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtwaste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtwaste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtwaste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtwaste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtwaste.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dtwaste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtwaste.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtwaste.DoubleBuffered = true;
            this.dtwaste.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtwaste.EnableHeadersVisualStyles = false;
            this.dtwaste.GridColor = System.Drawing.Color.Gainsboro;
            this.dtwaste.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dtwaste.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.dtwaste.Location = new System.Drawing.Point(0, 118);
            this.dtwaste.Name = "dtwaste";
            this.dtwaste.ReadOnly = true;
            this.dtwaste.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtwaste.RowHeadersVisible = false;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtwaste.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtwaste.Size = new System.Drawing.Size(750, 417);
            this.dtwaste.TabIndex = 13;
            this.dtwaste.TabStop = false;
            this.dtwaste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwaste_CellContentClick);
            // 
            // pnlEdit
            // 
            this.pnlEdit.Controls.Add(this.lblId);
            this.pnlEdit.Controls.Add(this.label6);
            this.pnlEdit.Controls.Add(this.btnDel);
            this.pnlEdit.Controls.Add(this.btnSave);
            this.pnlEdit.Controls.Add(this.label4);
            this.pnlEdit.Controls.Add(this.txtPrc);
            this.pnlEdit.Controls.Add(this.cbCat);
            this.pnlEdit.Controls.Add(this.label3);
            this.pnlEdit.Controls.Add(this.btnHide);
            this.pnlEdit.Controls.Add(this.label2);
            this.pnlEdit.Controls.Add(this.txtname);
            this.pnlEdit.Controls.Add(this.label5);
            this.pnlEdit.Location = new System.Drawing.Point(12, 180);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(351, 343);
            this.pnlEdit.TabIndex = 14;
            this.pnlEdit.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 14);
            this.label4.TabIndex = 40;
            this.label4.Text = "Price per kg.  : ( default 0)";
            // 
            // txtPrc
            // 
            this.txtPrc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtPrc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrc.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrc.ForeColor = System.Drawing.Color.White;
            this.txtPrc.Location = new System.Drawing.Point(13, 210);
            this.txtPrc.Name = "txtPrc";
            this.txtPrc.Size = new System.Drawing.Size(113, 26);
            this.txtPrc.TabIndex = 39;
            this.txtPrc.Text = "0";
            this.txtPrc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrc_KeyPress);
            // 
            // cbCat
            // 
            this.cbCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.cbCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCat.ForeColor = System.Drawing.Color.White;
            this.cbCat.FormattingEnabled = true;
            this.cbCat.Items.AddRange(new object[] {
            "Choose one",
            "Coconut",
            "Calamansi",
            "Turmeric",
            "Ice Cream",
            "Tamarind Juice",
            "Sugar cane",
            "Fresh milk",
            "Others? Please Specify."});
            this.cbCat.Location = new System.Drawing.Point(13, 141);
            this.cbCat.Name = "cbCat";
            this.cbCat.Size = new System.Drawing.Size(304, 29);
            this.cbCat.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 14);
            this.label3.TabIndex = 36;
            this.label3.Text = "Category :";
            // 
            // btnHide
            // 
            this.btnHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHide.Image = global::Foodwaste_Innovation_Center.Properties.Resources.Delete_96px;
            this.btnHide.Location = new System.Drawing.Point(328, 10);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(15, 15);
            this.btnHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHide.TabIndex = 35;
            this.btnHide.TabStop = false;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "Waste name :";
            // 
            // txtname
            // 
            this.txtname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.ForeColor = System.Drawing.Color.White;
            this.txtname.Location = new System.Drawing.Point(13, 71);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(304, 26);
            this.txtname.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 36);
            this.label5.TabIndex = 32;
            this.label5.Text = "Edit";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(222, 276);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 42);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.Firebrick;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(121, 276);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(95, 42);
            this.btnDel.TabIndex = 42;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(281, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 14);
            this.label6.TabIndex = 43;
            this.label6.Text = "Id:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId.ForeColor = System.Drawing.Color.White;
            this.lblId.Location = new System.Drawing.Point(298, 50);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(19, 14);
            this.lblId.TabIndex = 44;
            this.lblId.Text = "Id:";
            // 
            // Manage_waste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(750, 535);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.btnManagewaste);
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtwaste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Manage_waste";
            this.Text = "Manage_waste";
            this.Load += new System.EventHandler(this.Manage_waste_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtwaste)).EndInit();
            this.pnlEdit.ResumeLayout(false);
            this.pnlEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHide)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_c;
        private Bunifu.Framework.UI.BunifuFlatButton btnManagewaste;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.PictureBox btnClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtwaste;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrc;
        private System.Windows.Forms.ComboBox cbCat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox btnHide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label6;
    }
}