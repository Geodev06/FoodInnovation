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
using iTextSharp.text;
using System.Diagnostics;
using iTextSharp.text.pdf;
using System.IO;
using System.Reflection;

namespace Foodwaste_Innovation_Center
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }
        Database db = new Database();
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void getdata()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Transaction Id.");
            dt.Columns.Add("Wastes.");
            dt.Columns.Add("Issued by. ");
            dt.Columns.Add("Client name.");
            dt.Columns.Add("Amount.");
            dt.Columns.Add("Date.");
            db.Connect();
            db.cmd = new MySqlCommand("Select transaction_id, wastes, issued_by, issued_to, CAST(total_amount as DECIMAL(9,2)), DATE_FORMAT(created_at, '%M-%d-%Y %h:%i:%p') from sales where transaction_id Like '%" + txtSearch.Text + "%' or wastes Like '%" + txtSearch.Text + "%' or issued_by Like '%" + txtSearch.Text + "%' or issued_to Like '%" + txtSearch.Text + "%' or total_amount Like '%" + txtSearch.Text + "%' or DATE_FORMAT(created_at, '%M-%d-%Y') Like '%" + txtSearch.Text + "%' ORDER BY transaction_id DESC", db.con);
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                string amount = db.dr[4].ToString();
                dt.Rows.Add(new Object[] {
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                    db.dr[3],
                    db.dr[4],
                    db.dr[5]
                });
            }
            dtTransactions.DataSource = dt;
            db.Disconnect();
        }
        public void earning()
        {
            db.Connect();
            db.cmd = new MySqlCommand("Select CAST(Sum(total_amount) as DECIMAL(9,2)) from sales", db.con);
            db.dr = db.cmd.ExecuteReader();
            if(db.dr.Read())
            {
                lbearn.Text = "₱ " + db.dr[0].ToString();
            }
            db.Disconnect();
        }
        public void loadDataDisposed()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Wastename.");
            dt.Columns.Add("Disposed_by.");
            dt.Columns.Add("Kilograms.");
            dt.Columns.Add("Date.");
            db.Connect();
            db.cmd = new MySqlCommand("select waste_name, disposed_by, CAST(sum(kilograms) as DECIMAL(9,2)), DATE_FORMAT(created_at, '%M-%d-%Y') from disposed where DATE_FORMAT(created_at, '%M-%d-%Y') between @start AND @end    group by created_at", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("start", dateStart.Value.ToString("MMMM-dd-yyyy")));
            db.cmd.Parameters.Add(new MySqlParameter("end", dateEnd.Value.ToString("MMMM-dd-yyyy")));
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                dt.Rows.Add(new Object[] { 
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                    db.dr[3]
                });
            }
            db.Disconnect();

            dtReport.DataSource = dt;
        }
        public void loadDataEarnings()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Transaction Id.");
            dt.Columns.Add("Wastes.");
            dt.Columns.Add("Issued by.");
            dt.Columns.Add("Client name.");
            dt.Columns.Add("Amount.");
            dt.Columns.Add("Date.");
            db.Connect();
            db.cmd = new MySqlCommand("select transaction_id, wastes, issued_by, issued_to, CAST(sum(total_amount) as DECIMAL(9,2)), DATE_FORMAT(created_at, '%M-%d-%Y') from sales where DATE_FORMAT(created_at, '%M-%d-%Y') between @start AND @end group by transaction_id", db.con);
            db.cmd.Parameters.Add(new MySqlParameter("start", dateStart1.Value.ToString("MMMM-dd-yyyy")));
            db.cmd.Parameters.Add(new MySqlParameter("end", dateEnd1.Value.ToString("MMMM-dd-yyyy")));
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                dt.Rows.Add(new Object[] { 
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                    db.dr[3],
                    db.dr[4],
                    db.dr[5],
                });
            }
            db.Disconnect();

            dtEarnigs.DataSource = dt;
        }
        private void Logs_Load(object sender, EventArgs e)
        {
            dateStart.Value = DateTime.Now;
            dateEnd.Value = DateTime.Now;
            dateStart1.Value = DateTime.Now;
            dateEnd1.Value = DateTime.Now;
            loadDataEarnings();
            loadDataDisposed();
            getdata();
            earning();
            getdatadisposed();
            disposedkg();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            getdata();
        }
        public void getdatadisposed()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("User Id.");
            dt.Columns.Add("Waste name.");
            dt.Columns.Add("disposed by");
            dt.Columns.Add("kilograms");
            dt.Columns.Add("Date.");
            db.Connect();
            db.cmd = new MySqlCommand("Select user_id, waste_name, disposed_by, CAST(kilograms as DECIMAL(9,2)), DATE_FORMAT(created_at, '%M-%d-%Y %h:%i:%p') from disposed where user_id Like '%" + txtS1.Text + "%' or waste_name Like '%" + txtS1.Text + "%' or disposed_by Like '%" + txtS1.Text + "%'  or kilograms Like '%" + txtS1.Text + "%' or DATE_FORMAT(created_at, '%M-%d-%Y') Like '%" + txtS1.Text + "%' ORDER BY id DESC", db.con);
            db.dr = db.cmd.ExecuteReader();
            while (db.dr.Read())
            {
                dt.Rows.Add(new Object[] {
                    db.dr[0],
                    db.dr[1],
                    db.dr[2],
                    db.dr[3],
                    db.dr[4],

                });
            }
            dtDispose.DataSource = dt;
            db.Disconnect();
        }
        public void disposedkg()
        {
            db.Connect();
            db.cmd = new MySqlCommand("Select CAST(Sum(kilograms) as DECIMAL(9,2)) from disposed", db.con);
            db.dr = db.cmd.ExecuteReader();
            if (db.dr.Read())
            {
                totalKg.Text = db.dr[0].ToString() +" kg.";
            }
            db.Disconnect();
        }

        private void txtS1_TextChanged(object sender, EventArgs e)
        {
            getdatadisposed();
        }

        private void dateStart_onValueChanged(object sender, EventArgs e)
        {
            loadDataDisposed();
        }

        private void dateEnd_onValueChanged(object sender, EventArgs e)
        {
            loadDataDisposed();
        }
        Alert mda = null;
        private void btnEportD_Click(object sender, EventArgs e)
        {
            if (dtReport.Rows.Count > 0)
            {
                if(MsgBox.Show("Export data now?") == DialogResult.Yes)
                {
                    DisposalReportDoc();
                    if (mda == null)
                    {
                        mda = new Alert("Data exported!", "Information");
                        mda.Show();
                        mda.FormClosed += mda_FormClosed;
                    }

                }
            }
            else
            {
                if(mda == null)
                {
                    mda = new Alert("Nothin to export!", "");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
            }
        }

        void mda_FormClosed(object sender, FormClosedEventArgs e)
        {
            mda = null;
        }
        public void DisposalReportDoc()
        {
            try
            {
                PdfPTable header = new PdfPTable(4);
                PdfPCell headercell = new PdfPCell(new Phrase("Food Innovation\n Center Disposal Report"));
                headercell.Colspan = 4;
                header.DefaultCell.Padding = 10;
                headercell.HorizontalAlignment = Element.ALIGN_CENTER;
                header.AddCell(headercell);
                PdfPCell from = new PdfPCell(new Phrase("From : "+dateStart.Value.ToString("MMMM-dd-yyyy")));
                from.Colspan = 3;
                header.AddCell(from);
                PdfPCell date = new PdfPCell(new Phrase("Date : " + DateTime.Now.ToString("MMMM-dd-yyyy")));
                date.Rowspan = 2;
                header.AddCell(date);
                PdfPCell to = new PdfPCell(new Phrase("To : " + dateEnd.Value.ToString("MMMM-dd-yyyy")));
                to.Colspan = 3;
                header.AddCell(to);
                header.AddCell("Items : " + dtReport.Rows.Count);
                PdfPTable Tb = new PdfPTable(dtReport.ColumnCount);
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
                for (int i = 0; i < dtReport.Rows.Count; i++)
                {
                    amount += Convert.ToDouble(dtReport.Rows[i].Cells[2].Value.ToString());
                }
                PdfPCell footercell = new PdfPCell(new Phrase("------------------------------------------------------------------------------------------------------------------"));
                footercell.Colspan = 3;
                footercell.HorizontalAlignment = Element.ALIGN_CENTER;
                footercell.BorderWidth = 0;
                Footer.AddCell(footercell);
                Footer.AddCell("");
                Footer.AddCell("Total Kilograms. " + amount.ToString("0.00"));
                Footer.AddCell("");
                foreach (DataGridViewColumn col in dtReport.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    Tb.AddCell(cell);
                }

                foreach (DataGridViewRow row in dtReport.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        Tb.AddCell(cell.Value.ToString());
                    }
                }

                string path = @"c:\\FoodwasteReceipt\\Reports";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                Random r = new Random();
                int id = r.Next(11111111, 99999999);
                String filename = "Report" + id.ToString() + ".pdf";
                using (FileStream st = new FileStream(path + "\\" + filename, FileMode.Create))
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

                    ProcessStartInfo pth = new ProcessStartInfo(path + "\\" + filename);
                    Process.Start(pth);

                    //webBrowser1.Navigate(path + "Receipt.pdf");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(""+e, "Prompt.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void EarningsReportDoc()
        {
            try
            {
                PdfPTable header = new PdfPTable(4);
                PdfPCell headercell = new PdfPCell(new Phrase("Food Innovation\n Center Earnings Report"));
                headercell.Colspan = 4;
                header.DefaultCell.Padding = 10;
                headercell.HorizontalAlignment = Element.ALIGN_CENTER;
                header.AddCell(headercell);
                PdfPCell from = new PdfPCell(new Phrase("From : " + dateStart.Value.ToString("MMMM-dd-yyyy")));
                from.Colspan = 3;
                header.AddCell(from);
                PdfPCell date = new PdfPCell(new Phrase("Date : " + DateTime.Now.ToString("MMMM-dd-yyyy")));
                date.Rowspan = 2;
                header.AddCell(date);
                PdfPCell to = new PdfPCell(new Phrase("To : " + dateEnd.Value.ToString("MMMM-dd-yyyy")));
                to.Colspan = 3;
                header.AddCell(to);
                header.AddCell("Items : " + dtEarnigs.Rows.Count);
                PdfPTable Tb = new PdfPTable(dtEarnigs.ColumnCount);
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
                for (int i = 0; i < dtEarnigs.Rows.Count; i++)
                {
                    amount += Convert.ToDouble(dtEarnigs.Rows[i].Cells[4].Value.ToString());
                }
                PdfPCell footercell = new PdfPCell(new Phrase("------------------------------------------------------------------------------------------------------------------"));
                footercell.Colspan = 3;
                footercell.HorizontalAlignment = Element.ALIGN_CENTER;
                footercell.BorderWidth = 0;
                Footer.AddCell(footercell);
                Footer.AddCell("");
                Footer.AddCell("Total Earnings " + amount.ToString("0.00"));
                Footer.AddCell("");
                foreach (DataGridViewColumn col in dtEarnigs.Columns)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(col.HeaderText));
                    cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                    Tb.AddCell(cell);
                }

                foreach (DataGridViewRow row in dtEarnigs.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        Tb.AddCell(cell.Value.ToString());
                    }
                }

                string path = @"c:\\FoodwasteReceipt\\Reports";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                Random r = new Random();
                int id = r.Next(11111111, 99999999);
                String filename = "Report" + id.ToString() + ".pdf";
                using (FileStream st = new FileStream(path + "\\" + filename, FileMode.Create))
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

                    ProcessStartInfo pth = new ProcessStartInfo(path + "\\" + filename);
                    Process.Start(pth);

                    //webBrowser1.Navigate(path + "Receipt.pdf");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("" + e, "Prompt.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dateStart1_onValueChanged(object sender, EventArgs e)
        {
            loadDataEarnings();
        }

        private void dateEnd1_onValueChanged(object sender, EventArgs e)
        {
            loadDataEarnings();
        }

        private void btnEXportEarnings_Click(object sender, EventArgs e)
        {
            if (dtEarnigs.Rows.Count > 0)
            {
                if (MsgBox.Show("Export data now?") == DialogResult.Yes)
                {
                    EarningsReportDoc();
                    if (mda == null)
                    {
                        mda = new Alert("Data exported!", "Information");
                        mda.Show();
                        mda.FormClosed += mda_FormClosed;
                    }

                }
            }
            else
            {
                if (mda == null)
                {
                    mda = new Alert("Nothin to export!", "");
                    mda.Show();
                    mda.FormClosed += mda_FormClosed;
                }
            }
        }
    }
}
