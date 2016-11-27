using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace billing
{
    public partial class NewVoucher : Form
    {
        public NewVoucher()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private void NewVoucher_Load(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT MAX(Id) AS voucherno FROM Expences");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        TextBoxVoucherNo.Text = (Convert.ToInt32(row["voucherno"].ToString()) + 1).ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    TextBoxVoucherNo.Text = "1";
                }
                finally
                {
                    DatabaseConnectObj.DatabaseConnectionClose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    string date = DateTimePickerIssued.Value.Month.ToString() + "/" + DateTimePickerIssued.Value.Day.ToString() + "/" + DateTimePickerIssued.Value.Year.ToString();
                    DatabaseConnectObj.SqlQuery("INSERT INTO Expences (Name, [Desc], value, DateIssued) VALUES ('"+TextBoxPaidTo.Text+"','"+TextBoxDesc.Text+"','"+TextBoxAmount.Text+"','"+date+"')");
                    DatabaseConnectObj.ExecutNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DatabaseConnectObj.DatabaseConnectionClose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ButtonSave.Enabled = false;
            ButtonPrint.Enabled = true;
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            //PrintPreviewVoucher.Document = PrintDocumentVoucher;
            //PrintPreviewVoucher.Size = new System.Drawing.Size(420, 595);
            //PrintPreviewVoucher.ShowDialog();
            using (var dlg = new CoolPrintPreviewDialog(null))
            {
                dlg.Document = PrintDocumentVoucher;
                dlg.ShowDialog(this);
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string date = DateTimePickerIssued.Value.Month.ToString() + "/" + DateTimePickerIssued.Value.Day.ToString() + "/" + DateTimePickerIssued.Value.Year.ToString();
            Bitmap bmp = Properties.Resources.tecnocraft;
            Image newImage = bmp;
            Rectangle rect1 = new Rectangle(25, 25, 770, 400);

            Pen pent = new Pen(Color.Black, 3);
            Point point1 = new Point(25, 375);
            Point point2 = new Point(820, 375);
            //company details
            e.Graphics.DrawImage(newImage, 250, 50, 300, 50);
            //voucher no
            e.Graphics.DrawRectangle(pent, rect1);
            e.Graphics.DrawString("Voucher " + TextBoxVoucherNo.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(600, 135));
            e.Graphics.DrawString(date, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(650, 50));
            //content
            e.Graphics.DrawString("Paid To: " + TextBoxPaidTo.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(35, 135));
            e.Graphics.DrawString("Description: "+ TextBoxDesc.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(35, 185));
            e.Graphics.DrawString("Amount: "+ TextBoxAmount.Text, new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(35, 235));
            e.Graphics.DrawString("Reciver Signature" ,new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(35, 365));
            e.Graphics.DrawString("Manager", new Font("Arial", 18, FontStyle.Bold), Brushes.Black, new Point(505, 365));
        }

        private void NewVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }
    }
}
