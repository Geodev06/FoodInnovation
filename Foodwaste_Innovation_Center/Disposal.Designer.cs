namespace Foodwaste_Innovation_Center
{
    partial class Disposal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.dd = new System.Windows.Forms.Label();
            this.lb_c = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtwaste = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemname = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.txtKg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThrow = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtwaste)).BeginInit();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = global::Foodwaste_Innovation_Center.Properties.Resources.Delete_96px;
            this.btnClose.Location = new System.Drawing.Point(729, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(15, 15);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 12;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dd
            // 
            this.dd.AutoSize = true;
            this.dd.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dd.ForeColor = System.Drawing.Color.White;
            this.dd.Location = new System.Drawing.Point(8, 4);
            this.dd.Name = "dd";
            this.dd.Size = new System.Drawing.Size(183, 36);
            this.dd.TabIndex = 17;
            this.dd.Text = "Dispose waste";
            // 
            // lb_c
            // 
            this.lb_c.AutoSize = true;
            this.lb_c.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_c.ForeColor = System.Drawing.Color.White;
            this.lb_c.Location = new System.Drawing.Point(10, 94);
            this.lb_c.Name = "lb_c";
            this.lb_c.Size = new System.Drawing.Size(67, 14);
            this.lb_c.TabIndex = 16;
            this.lb_c.Text = "Total count :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(544, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 14);
            this.label1.TabIndex = 15;
            this.label1.Text = "Search :";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.Location = new System.Drawing.Point(544, 81);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(198, 26);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dtwaste
            // 
            this.dtwaste.AllowUserToAddRows = false;
            this.dtwaste.AllowUserToDeleteRows = false;
            this.dtwaste.AllowUserToResizeColumns = false;
            this.dtwaste.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dtwaste.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtwaste.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dtwaste.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dtwaste.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtwaste.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
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
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtwaste.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtwaste.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtwaste.Size = new System.Drawing.Size(750, 417);
            this.dtwaste.TabIndex = 18;
            this.dtwaste.TabStop = false;
            this.dtwaste.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtwaste_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(481, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 19;
            this.label2.Text = "Waste list :";
            // 
            // pnlCard
            // 
            this.pnlCard.Controls.Add(this.pictureBox1);
            this.pnlCard.Controls.Add(this.btnThrow);
            this.pnlCard.Controls.Add(this.label4);
            this.pnlCard.Controls.Add(this.lb);
            this.pnlCard.Controls.Add(this.txtKg);
            this.pnlCard.Controls.Add(this.label3);
            this.pnlCard.Controls.Add(this.txtItemname);
            this.pnlCard.ForeColor = System.Drawing.Color.White;
            this.pnlCard.Location = new System.Drawing.Point(208, 147);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(347, 376);
            this.pnlCard.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(139, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 14);
            this.label3.TabIndex = 22;
            this.label3.Text = "Waste name :";
            // 
            // txtItemname
            // 
            this.txtItemname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtItemname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtItemname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemname.ForeColor = System.Drawing.Color.White;
            this.txtItemname.Location = new System.Drawing.Point(34, 86);
            this.txtItemname.Name = "txtItemname";
            this.txtItemname.Size = new System.Drawing.Size(286, 26);
            this.txtItemname.TabIndex = 21;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Calibri Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.ForeColor = System.Drawing.Color.White;
            this.lb.Location = new System.Drawing.Point(128, 168);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(98, 14);
            this.lb.TabIndex = 24;
            this.lb.Text = "Enter Amount(Kg.)";
            // 
            // txtKg
            // 
            this.txtKg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtKg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKg.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKg.ForeColor = System.Drawing.Color.White;
            this.txtKg.Location = new System.Drawing.Point(122, 185);
            this.txtKg.Name = "txtKg";
            this.txtKg.Size = new System.Drawing.Size(110, 64);
            this.txtKg.TabIndex = 23;
            this.txtKg.Text = "0";
            this.txtKg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKg_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(17, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 36);
            this.label4.TabIndex = 21;
            this.label4.Text = "Dispose?";
            // 
            // btnThrow
            // 
            this.btnThrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btnThrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThrow.ForeColor = System.Drawing.Color.Cyan;
            this.btnThrow.Location = new System.Drawing.Point(97, 284);
            this.btnThrow.Name = "btnThrow";
            this.btnThrow.Size = new System.Drawing.Size(150, 56);
            this.btnThrow.TabIndex = 25;
            this.btnThrow.Text = "Go";
            this.btnThrow.UseVisualStyleBackColor = false;
            this.btnThrow.Click += new System.EventHandler(this.btnThrow_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Foodwaste_Innovation_Center.Properties.Resources.Delete_96px;
            this.pictureBox1.Location = new System.Drawing.Point(321, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 15);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Disposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ClientSize = new System.Drawing.Size(750, 535);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dd);
            this.Controls.Add(this.lb_c);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtwaste);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Disposal";
            this.Text = "Disposal";
            this.Load += new System.EventHandler(this.Disposal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtwaste)).EndInit();
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.Label dd;
        private System.Windows.Forms.Label lb_c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dtwaste;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.Button btnThrow;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.TextBox txtKg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}