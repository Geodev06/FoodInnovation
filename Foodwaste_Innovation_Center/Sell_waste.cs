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
using System.IO;
using System.Reflection;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Drawing.Text;
using System.Diagnostics;

namespace Foodwaste_Innovation_Center
{
    public partial class Sell_waste : Form
    {
        String getId;
        public Sell_waste(String id)
        {
            InitializeComponent();
            getId = id;
        }
        Database db = new Database();

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getdata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id.");
            dt.Columns.Add("Item name.");
            dt.Columns.Add("Cat.");
            dt.Columns.Add("Price per(kg).");
            db.Connect();
            db.cmd = new MySqlCommand("Select * from waste where waste_id Like '%" + txtSearch.Text + "%' or waste_name Like '%" + txtSearch.Text + "%' or category Like '%" + txtSearch.Text + "%' or price Like '%" + txtSearch.Text + "%' ORDER BY waste_id DESC", db.con);
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                dt.Rows.Add(new Object[] {
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                    db.dr[3],
                });
            }
            dtwaste.DataSource = dt;
            db.Disconnect();
            dtwaste.Columns[0].Visible = false;
        }
        private void Sell_waste_Load(object sender, EventArgs e)
        {
            getdata();
            lb.Left = (this.pnlQty.Width - lb.Width) / 2;
            txtKg.Left = (this.pnlQty.Width - txtKg.Width) / 2;
            btnAdd.Left = (this.pnlQty.Width - btnAdd.Width) / 2;
            pnlQty.Left = (this.panel1.Width - pnlQty.Width) / 2;
            //user stash
            loaCart();
        }
        public void loaCart()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id.");
            dt.Columns.Add("Waste.");
            dt.Columns.Add("Category.");
            dt.Columns.Add("Amount.");
            db.Connect();
            db.cmd = new MySqlCommand("Select waste_id, waste_name, category, CAST(Amount as DECIMAL(9,2)) from user_stash where user_id = '" + getId + "'", db.con);
            db.dr = db.cmd.ExecuteReader();
            while(db.dr.Read())
            {
                dt.Rows.Add(new Object[] {
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                    db.dr[3]
                });
            }
            cart.DataSource = dt;
            db.Disconnect();
            cart.Columns[0].Visible = false;

            getTotal();
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getdata();
        }

        private void dtwaste_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dtwaste.Rows[e.RowIndex];
                lbItem.Text = row.Cells[1].Value.ToString();
                lbcat.Text = row.Cells[2].Value.ToString();
                lbPrc.Text = row.Cells[3].Value.ToString();
                lbId.Text = row.Cells[0].Value.ToString();
                pnlQty.Visible = true;
            }
        }

        private void lblclose_Click(object sender, EventArgs e)
        {
            pnlQty.Visible = false;
        }
        public void getTotal()
        {
            double total = 0;
            for (int i = 0; i < cart.Rows.Count; i++ )
            {
                total += Convert.ToDouble(cart.Rows[i].Cells[3].Value.ToString());
            }
            lblTotalPrice.Text = "₱ " + total.ToString("0.00");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            String id = lbId.Text;
            String category = lbcat.Text;
            String name = lbItem.Text;
            Double Prc = Convert.ToDouble(lbPrc.Text);
            if (txtKg.Text != ".")
            {
                if (txtKg.Text != "")
                {
                    if (txtKg.Text != "0")
                    {
                        if (Convert.ToDouble(txtKg.Text) > 0)
                        {
                            if (MsgBox.Show("Add to stash?") == DialogResult.Yes)
                            {
                                if (!isAlreadyinStash(id))
                                {
                                    //insert new

                                    pnlQty.Visible = false;
                                    btnFinish.Visible = true;
                                    Double amount = Prc * Convert.ToDouble(txtKg.Text);
                                    insertoStash(amount);
                                    txtKg.Text = "0";
                                    loaCart();


                                }
                                else
                                {
                                    //update
                                    pnlQty.Visible = false;
                                    btnFinish.Visible = true;
                                    Double NewAmount = getOldAmount(id) + Prc * Convert.ToDouble(txtKg.Text);
                                    updatestash(NewAmount);
                                    txtKg.Text = "0";
                                    loaCart();
                                }
                            }
                        }
                        else
                        {
                            if (mda == null)
                            {
                                mda = new Alert("Kg cannot be zero", "");
                                mda.Show();
                                mda.FormClosed += mda_FormClosed;
                            }
                        }
                    }
                    else
                    {
                        if (mda == null)
                        {
                            mda = new Alert("Kg cannot be zero", "");
                            mda.Show();
                            mda.FormClosed += mda_FormClosed;
                        }
                    }
                }
                else
                {
                    if (mda == null)
                    {
                        mda = new Alert("Kg cannot be zero", "");
                        mda.Show();
                        mda.FormClosed += mda_FormClosed;
                    }
                }
            }
            else
            {
                if(mda == null)
                {
                    mda = new Alert("Kg cannot be zero", "");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
            }
        }

        void mda_FormClosed(object sender, FormClosedEventArgs e)
        {
            mda = null;
        }
        Alert mda = null;
        public bool isAlreadyinStash(string id)
        {
            bool isFound = false;
            db.Connect();
            db.cmd = new MySqlCommand("Select waste_id from user_stash where waste_id = @itemId and user_id = '" + getId + "'", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("itemId", id));
            db.dr = db.cmd.ExecuteReader();
            if(db.dr.Read())
            {
                isFound = true;
            }
            return isFound;
        }
        public string getLastInserted_Id()
        {
            String Id = "";
            db.Connect();
            db.cmd = new MySqlCommand("Select last_insert_id() FROM sales", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                Id = db.dr[0].ToString();
            }
            return Id;
        }
        public void insertoStash(Double amount)
        {
            db.Connect();
            db.cmd = new MySqlCommand("insert into user_stash (user_id, waste_id, waste_name, category, amount) values (@uid, @wid, @wname, @cat, @amount)", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("uid", getId));
            db.cmd.Parameters.Add(new MySqlParameter("wid", lbId.Text));
            db.cmd.Parameters.Add(new MySqlParameter("wname", lbItem.Text));
            db.cmd.Parameters.Add(new MySqlParameter("cat", lbcat.Text));
            db.cmd.Parameters.Add(new MySqlParameter("amount", amount));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();

        }
        public void updatestash(Double NewAmount)
        {
            db.Connect();
            db.cmd = new MySqlCommand("Update user_stash set Amount = @amount where user_id = @uid and waste_id = @wid", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("uid", getId));
            db.cmd.Parameters.Add(new MySqlParameter("wid", lbId.Text));
            db.cmd.Parameters.Add(new MySqlParameter("amount", NewAmount));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();
        }
        public double getOldAmount(string waste_id)
        {
            double getCurrentAmount = 0;
            db.Connect();
            db.cmd = new MySqlCommand("Select Amount from user_stash where user_id = @uid and waste_id = @wid", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("uid", getId));
            db.cmd.Parameters.Add(new MySqlParameter("wid", lbId.Text));
            db.dr = db.cmd.ExecuteReader();
            if(db.dr.Read())
            {
                getCurrentAmount = Convert.ToDouble(db.dr[0].ToString());
            }
            db.Disconnect();

            return getCurrentAmount;
        }

        private void cart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.cart.Rows[e.RowIndex];
                string id = row.Cells[0].Value.ToString();
                if(MsgBox.Show("Void this item?") == DialogResult.Yes)
                {
                    db.Connect();
                    db.cmd = new MySqlCommand("Delete from user_stash where user_id = '" + getId + "' and waste_id = '" + id + "'", db.con);
                    db.cmd.ExecuteNonQuery();
                    db.Disconnect();
                    loaCart();
                    if (cart.Rows.Count <= 0)
                    {
                        btnFinish.Visible = false;
                    }
                }

            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if(cart.Rows.Count >= 0)
            {
                if (txtCustName.Text != "")
                {
                    if(MsgBox.Show("Is that all?") == DialogResult.Yes)
                    {

                        //insert
                        String wastes = "";
                        double amount = 0;

                        for (int i = 0; i < cart.Rows.Count; i++)
                        {
                            wastes += cart.Rows[i].Cells[1].Value.ToString() + ", ";
                            amount += Convert.ToDouble(cart.Rows[i].Cells[3].Value.ToString());
                        }
                        string name = getfullname();
                        if (mda == null)
                        {
                            mda = new Alert("Transaction ended", "Information");
                            mda.Show();
                            mda.FormClosed += mda_FormClosed;
                        }
                        saveTransaction(name, wastes, amount);
                        CreateDoc(getLastInserted_Id());

                        db.Connect();
                        db.cmd = new MySqlCommand("Delete from user_stash where user_id = '" + getId + "'", db.con);
                        db.cmd.ExecuteNonQuery();
                        db.Disconnect();
                        loaCart();
                        txtCustName.Clear();
                        btnFinish.Visible = false;
                    }
                }
                else
                {
                    if (mda == null)
                    {
                        mda = new Alert("Please enter customer name", "");
                        mda.Show();
                        mda.FormClosed += mda_FormClosed;
                    }
                }
            }
        }

        public void saveTransaction(string name, string wastes, double amount)
        {
            db.Connect();
            db.cmd = new MySqlCommand("Insert into sales (wastes, issued_by, issued_to, total_amount, created_at) values (@ws, @is_by, '"+txtCustName.Text+"', @amount, CURRENT_TIMESTAMP())", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("ws", wastes));
            db.cmd.Parameters.Add(new MySqlParameter("is_by", name));
            db.cmd.Parameters.Add(new MySqlParameter("amount", amount));
            db.cmd.ExecuteNonQuery();
            db.Disconnect();
        }
        public string getfullname()
        {
            string fullname = "";
            db.Connect();
            db.cmd = new MySqlCommand("select fname, lname from Accounts where user_id = '" + getId + "'", db.con);
            db.dr = db.cmd.ExecuteReader();
            if(db.dr.Read())
            {
                fullname = db.dr[0].ToString() + " " + db.dr[1].ToString();
            }
            db.Disconnect();
            return fullname;
        }

       
        public void CreateDoc(String Last_id)
        {
            try
            {
                PdfPTable header = new PdfPTable(4);
                PdfPCell headercell = new PdfPCell(new Phrase("Food Innovation\n Center"));
                headercell.Colspan = 4;
                header.DefaultCell.Padding = 10;
                headercell.HorizontalAlignment = Element.ALIGN_CENTER;
                header.AddCell(headercell);

                PdfPCell name = new PdfPCell(new Phrase("Customer name : " + txtCustName.Text));
                name.Colspan = 3;
                header.AddCell(name);
                header.AddCell("Date : " + DateTime.Now.ToString("MM-dd-yyyy"));

                PdfPCell t_id = new PdfPCell(new Phrase("Transaction Id : " + Last_id));
                t_id.Colspan = 3;
                header.AddCell(t_id);
                header.AddCell("Items : " +cart.Rows.Count);
                

                PdfPTable Tb = new PdfPTable(cart.ColumnCount);
                Tb.DefaultCell.Padding = 4;
                //Tb.WidthPercentage = 90;
                Tb.HorizontalAlignment = Element.ALIGN_CENTER;
                Tb.DefaultCell.BorderWidth = 1;

                PdfPTable Footer = new PdfPTable(2);
                Footer.DefaultCell.Padding = 4;
                Footer.WidthPercentage = 90;
                Footer.HorizontalAlignment = Element.ALIGN_CENTER;
                Footer.DefaultCell.BorderWidth = 0;
                double amount = 0;
                for (int i = 0; i < cart.Rows.Count; i++)
                {
                    amount += Convert.ToDouble(cart.Rows[i].Cells[3].Value.ToString());
                }
                PdfPCell footercell = new PdfPCell(new Phrase("------------------------------------------------------------------------------------------------------------------"));
                footercell.Colspan = 3;
                footercell.HorizontalAlignment = Element.ALIGN_CENTER;
                footercell.BorderWidth = 0;
                Footer.AddCell(footercell);

                Footer.AddCell("");
                Footer.AddCell("Total Amount : php. " + amount.ToString("0.00"));
                Footer.AddCell("");
                Footer.AddCell("Issued by : " + getfullname());

               


                foreach (DataGridViewColumn col in cart.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    Tb.AddCell(cell);
                }

                foreach (DataGridViewRow row in cart.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        Tb.AddCell(cell.Value.ToString());
                    }
                }

                string path = @"c:\\FoodwasteReceipt";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                String filename = "Receipt" + Last_id + ".pdf";
                using (FileStream st = new FileStream(path+"\\"+filename, FileMode.Create))
                {
                    Document pdfDoc = new Document(PageSize.LEGAL, 10f, 10f, 10f, 10f);
                    PdfWriter.GetInstance(pdfDoc, st);
                    pdfDoc.Open();
                    pdfDoc.Add(new Paragraph("\n"));
                    pdfDoc.Add(new Paragraph("\n"));
                    pdfDoc.Add(header);
                    pdfDoc.Add(new Paragraph("\n"));
                    pdfDoc.Add(Tb);
                    pdfDoc.Add(new Paragraph("\n"));
                    pdfDoc.Add(Footer);
                    pdfDoc.Close();
                    st.Close();

                    ProcessStartInfo pth = new ProcessStartInfo(path+"\\"+filename);
                    Process.Start(pth);
                    
                    //webBrowser1.Navigate(path + "Receipt.pdf");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong pdf not generated\n please try again.", "Prompt.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtKg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsDigit(e.KeyChar) || txtKg.Text.Length >= 5) && e.KeyChar != 8)
            {
                e.Handled = true;
            }

            if (e.KeyChar == 46 && txtKg.Text.Length != 5)
            {
                e.Handled = false;

                if (txtKg.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
        }
    }
}
