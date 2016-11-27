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
    public partial class Edit : Form
    {
        private string nm;
        private int i;
        string typeEdit="";
        private decimal UnitPriceTemp;
        private bool FormLoadFlag=false;
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public Edit()
        {
            InitializeComponent();
            FormLoadFlag = true;
        }
        public string passvalue
        {
            get { return nm; }
            set { nm = value; }
        }
        private void Edit_Load(object sender, EventArgs e)
        {
            String[] substrings = nm.Split(',');
            typeEdit = substrings[1];
            groupBox1.Text = "Edit " + typeEdit;
            LoadProductComboBox();
            if (typeEdit == "Estimate")
            {
                ButtonMakeInvoice.Visible = true;
            }
            TextBoxNo.Text = substrings[0];
            LableInvoiceId.Text = substrings[5];
            Label.Text = typeEdit + " No";
            TextBoxCusName.Text = substrings[2] + " ( " + substrings[4] + " )";
            DateTimePickerIssued.Value = Convert.ToDateTime(substrings[3]);
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT Items.ItemDesc, BillDetails" + typeEdit + ".Quantity, BillDetails" + typeEdit + ".price, BillDetails" + typeEdit + ".Tax, BillDetails" + typeEdit + ".ItemNo FROM BillDetails" + typeEdit + " INNER JOIN Items ON BillDetails" + typeEdit + ".ItemNo = Items.ItemId WHERE (BillDetails" + typeEdit + "." + typeEdit + "id = '" + LableInvoiceId.Text + "')");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT remark FROM " + typeEdit + " WHERE (" + typeEdit + "id = '" + LableInvoiceId.Text + "')");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        TextBoxRemark.Text = row["remark"].ToString();
                    }
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
            Decimal counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Decimal temp = Convert.ToDecimal(row.Cells["Tax"].Value);
                temp = temp / 100;
                Int32 quantitytemp = Convert.ToInt32(row.Cells["Quantity"].Value);
                Decimal unitpricetemp = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                Decimal tempvar = quantitytemp * (unitpricetemp + (unitpricetemp * temp));
                row.Cells["Total"].Value = tempvar;
                counter += tempvar;
                TextBoxTotal.Text = counter.ToString();
            }
        }

        private void TextBoxCusName_TextChanged(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    string[] substring = TextBoxCusName.Text.Split('(');
                    substring = substring[1].Split(')');
                    DatabaseConnectObj.SqlQuery("SELECT CustomerNo, VehicleNo, VehicleType FROM Customer WHERE (VehicleNo = '" + substring[0].Trim() + "')");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    DataRow row = dt.Rows[0];
                    string temp = row["CustomerNo"].ToString() + "\n" + row["VehicleNo"].ToString() + "\n" + row["VehicleType"].ToString();
                    LabelHidden.Text = temp;
                    ComboBoxProduct.Text = row["VehicleType"].ToString();
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
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            /*PrintPreviewInvoice.Document = PrintDocumentInvoice;
            PrintPreviewInvoice.Size = new System.Drawing.Size(595, 842);
            PrintPreviewInvoice.ShowDialog();*/
            //PrintPreview PrintPreviewForm = new PrintPreview(PrintDocumentInvoice1, TextBoxTotal.Text);
            //PrintPreviewForm.ShowDialog();
            using (var dlg = new CoolPrintPreviewDialog(null, TextBoxTotal.Text, LabelHidden.Text))
            {
                dlg.Document = PrintDocumentInvoice1;
                dlg.ShowDialog(this);
            }
        }

        private void PrintDocumentInvoice1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int Height = 80, Yincrement = 20;
            string date = DateTimePickerIssued.Value.Month.ToString() + "/" + DateTimePickerIssued.Value.Day.ToString() + "/" + DateTimePickerIssued.Value.Year.ToString();
            Bitmap bmp = Properties.Resources.tecnocraft;
            Image CompanyLogo = bmp;
            Rectangle rect2 = new Rectangle(25, 400, 800, 50);
            String[] substrings = TextBoxCusName.Text.Split('(');

            Pen pent = new Pen(Color.Black, 3);
            Point point1 = new Point(25, 375);
            Point point2 = new Point(820, 375);
            Font FontHeading = new Font("Helvetica", 25, FontStyle.Bold);
            Font FontTitle = new Font("Helvetica", 15, FontStyle.Bold);
            Font FontDesc = new Font("Helvetica", 12, FontStyle.Regular);
            Font FontTotal = new Font("Helvetica", 12, FontStyle.Bold);

            //company details
            e.Graphics.DrawImage(CompanyLogo, 40, 50, 300, 40);
            e.Graphics.DrawString("INVOICE : " + TextBoxNo.Text.ToString(), FontHeading, Brushes.Black, new Point(530, 45));
            //print date

            //company address
            e.Graphics.DrawString("From ", FontDesc, Brushes.Gray, new Point(50, Height + Yincrement + 10));
            e.Graphics.DrawString("#72, 7th Main, B.O.B Colony,", FontDesc, Brushes.Black, new Point(110, Height += Yincrement + 10));
            e.Graphics.DrawString("J.P.Nagar, 7th Phase, ", FontDesc, Brushes.Black, new Point(110, Height += Yincrement));
            e.Graphics.DrawString("Bangalore-78.", FontDesc, Brushes.Black, new Point(110, Height += Yincrement));
            e.Graphics.DrawString("Ph: 9886254448,9880369118", FontDesc, Brushes.Black, new Point(110, Height += Yincrement));
            // customer details
            e.Graphics.DrawString("To ", FontDesc, Brushes.Gray, new Point(530, (Height + Yincrement) - (Yincrement * 4)));
            e.Graphics.DrawString(substrings[0] + "\n" + LabelHidden.Text, FontDesc, Brushes.Black, new Point(560, Height - (Yincrement * 3)));
            //invoice no and date
            e.Graphics.DrawString("Issued ", FontDesc, Brushes.Gray, new Point(50, Height + Yincrement + 5));
            e.Graphics.DrawString(date.ToString(), FontDesc, Brushes.Black, new Point(110, Height += Yincrement + 5));
            //table
            e.Graphics.DrawString("#", FontTitle, Brushes.Black, new Point(35, Height += Yincrement + 20));
            e.Graphics.DrawString("Desc", FontTitle, Brushes.Black, new Point(90, Height));
            e.Graphics.DrawString("Qty", FontTitle, Brushes.Black, new Point(335, Height));
            e.Graphics.DrawString("Price", FontTitle, Brushes.Black, new Point(435, Height));
            e.Graphics.DrawString("Tax", FontTitle, Brushes.Black, new Point(530, Height));
            e.Graphics.DrawString("Total", FontTitle, Brushes.Black, new Point(635, Height));
            e.Graphics.DrawLine(pent, new Point(30, Height += Yincrement + 10), new Point(800, Height));
            //table content
            int j;
            for (j = i; j < dataGridView1.RowCount && Height < 920; j++)
            {
                e.Graphics.DrawString((j + 1).ToString(), FontDesc, Brushes.Black, new Point(35, Height += Yincrement + 10));
                e.Graphics.DrawString(dataGridView1.Rows[j].Cells["Desc"].Value.ToString(), FontDesc, Brushes.Black, new Point(90, Height));
                e.Graphics.DrawString(dataGridView1.Rows[j].Cells["Quantity"].Value.ToString(), FontDesc, Brushes.Black, new Point(339, Height));
                e.Graphics.DrawString(dataGridView1.Rows[j].Cells["UnitPrice"].Value.ToString(), FontDesc, Brushes.Black, new Point(435, Height));
                e.Graphics.DrawString(dataGridView1.Rows[j].Cells["Tax"].Value.ToString(), FontDesc, Brushes.Black, new Point(535, Height));
                e.Graphics.DrawString(dataGridView1.Rows[j].Cells["Total"].Value.ToString(), FontTotal, Brushes.Black, new Point(635, Height));
            }
            if (j < dataGridView1.RowCount)
            {
                e.HasMorePages = true;
                i = j;
            }
            else
            {
                e.HasMorePages = false;
                j = 0;
                i = 0;
            }
            //invoice total
            e.Graphics.DrawLine(pent, new Point(30, 960), new Point(800, 960));
            e.Graphics.DrawString("Remark", FontTitle, Brushes.Black, new Point(30, 970));
            if (TextBoxRemark.TextLength > 50)
            {
                e.Graphics.DrawString(TextBoxRemark.Text.Substring(0, 49), new Font("Calibri", 13, FontStyle.Bold), Brushes.Black, new Point(50, 1000));
                e.Graphics.DrawString(TextBoxRemark.Text.Substring(49, TextBoxRemark.Text.Length - 49), new Font("Calibri", 13, FontStyle.Bold), Brushes.Black, new Point(50, 1020));
            }
            else
            {
                e.Graphics.DrawString(TextBoxRemark.Text, new Font("Calibri", 13, FontStyle.Bold), Brushes.Black, new Point(30, 1000));
            }
            e.Graphics.DrawString("Total", FontTitle, Brushes.Black, new Point(550, 1030));
            e.Graphics.DrawString(TextBoxTotal.Text, FontTitle, Brushes.Black, new Point(670, 1030));
        }

        private void ButtonEstimate_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure, you want to make this Enstimate a Invoice?","Confirmation Message",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                DataTable dataTable = (DataTable)dataGridView1.DataSource;
                NewInvioce NewInvoiceObj = new NewInvioce(dataTable,TextBoxCusName.Text+","+LabelHidden.Text);
                NewInvoiceObj.ShowDialog();
                this.Close();
            }
        }

        private void TextBoxProductName_TextChanged(object sender, EventArgs e)
        {
            LoadDescComboBox();
        }

        private void LoadDescComboBox()
        {
            ComboboxDesc.Items.Clear();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT ItemDesc FROM Items WHERE (ItemDesc IS NOT NULL) AND (ItemName = '" + ComboBoxProduct.Text + "')");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        ComboboxDesc.Items.Add(row["ItemDesc"].ToString());
                    }
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
        }

        private void ComboboxDesc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboboxDesc.Items.Contains(ComboboxDesc.Text.ToString()))
                {
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DataTable dt = new DataTable();
                            DatabaseConnectObj.SqlQuery("SELECT ItemPrice FROM Items WHERE (ItemName = '" + ComboBoxProduct.Text + "') AND (ItemDesc = '" + ComboboxDesc.Text + "')");
                            dt = DatabaseConnectObj.ExecuteQuery();
                            foreach (DataRow row in dt.Rows)
                            {
                                NumericUnitPrice.Value = Convert.ToDecimal(row["ItemPrice"].ToString());
                            }
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
                }
                else
                {
                    MessageBox.Show("Product Does NotExist create the prooduct first");
                }
        }

        private void ComboboxDesc_Leave(object sender, EventArgs e)
        {
            if (!ComboboxDesc.Items.Contains(ComboboxDesc.Text.ToString()))
            {
                MessageBox.Show("Please Select a Product from the text box or add a new product");
                ComboboxDesc.Text = "";
                ComboboxDesc.Focus();
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string itemid1 = "";
            try //get item id to fill into datagrid for future use
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT ItemId FROM Items WHERE (ItemName = '" + ComboBoxProduct.Text + "') AND (ItemDesc = '" + ComboboxDesc.Text + "')"); //query to selecte itemid where prdoct name and desc == entered product is and desc
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        itemid1 = row["ItemId"].ToString();
                    }
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
            decimal total = (Convert.ToDecimal(NumericQuantity.Value) * Convert.ToDecimal(NumericUnitPrice.Value));
            total = total + (total * (Convert.ToDecimal(ComboboxTax.Text) / 100));
            DataTable dataTable = (DataTable)dataGridView1.DataSource;
            DataRow drToAdd = dataTable.NewRow();
            drToAdd["ItemDesc"] = ComboboxDesc.Text.ToString();
            drToAdd["Quantity"] = NumericQuantity.Value.ToString();
            drToAdd["price"] = NumericUnitPrice.Value.ToString();
            drToAdd["Tax"] = ComboboxTax.Text;
            drToAdd["ItemNo"] = itemid1;
            dataTable.Rows.Add(drToAdd);
            dataTable.AcceptChanges();
            Decimal counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Decimal temp = Convert.ToDecimal(row.Cells["Tax"].Value);
                temp = temp / 100;
                Int32 quantitytemp = Convert.ToInt32(row.Cells["Quantity"].Value);
                Decimal unitpricetemp = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                Decimal tempvar = quantitytemp * (unitpricetemp + (unitpricetemp * temp));
                row.Cells["Total"].Value = tempvar;
                counter += tempvar;
                TextBoxTotal.Text = counter.ToString();
            }
            ComboboxDesc.Focus();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("DELETE FROM BillDetails" + typeEdit + " WHERE (" + typeEdit + "id = " + LableInvoiceId.Text + ")");
                    DatabaseConnectObj.ExecutNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try // insert the bill details
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DatabaseConnectObj.SqlQuery("INSERT INTO BillDetails" + typeEdit + " (ItemNo, Quantity, price, " + typeEdit + "No,Tax, "+typeEdit.ToLower()+"id) VALUES ('" + dataGridView1.Rows[i].Cells["Itemid"].Value + "','" + dataGridView1.Rows[i].Cells["Quantity"].Value + "','" + dataGridView1.Rows[i].Cells["UnitPrice"].Value + "','" + TextBoxNo.Text + "','" + dataGridView1.Rows[i].Cells["Tax"].Value + "','"+LableInvoiceId.Text+"')");
                        DatabaseConnectObj.ExecutNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try // insert the bill details
                {
                    for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        DatabaseConnectObj.SqlQuery("UPDATE "+typeEdit+" SET total = '"+TextBoxTotal.Text+"', remark = '"+TextBoxRemark.Text+"' WHERE ("+typeEdit+"id = '"+ LableInvoiceId.Text+"')");
                        DatabaseConnectObj.ExecutNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    DatabaseConnectObj.DatabaseConnectionClose();
                }
                ButtonSave.Enabled = false;
                ButtonPreview.Enabled = true;
                ButtonMakeInvoice.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            Decimal counter = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                Decimal temp = Convert.ToDecimal(row.Cells["Tax"].Value);
                temp = temp / 100;
                Int32 quantitytemp = Convert.ToInt32(row.Cells["Quantity"].Value);
                Decimal unitpricetemp = Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                Decimal tempvar = quantitytemp * (unitpricetemp + (unitpricetemp * temp));
                row.Cells["Total"].Value = tempvar;
                counter += tempvar;
                TextBoxTotal.Text = counter.ToString();
            }
        }

        private void ComboBoxProduct_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxProduct.Items.Contains(ComboBoxProduct.Text.Trim()))
                LoadDescComboBox();
            else if (ComboBoxProduct.Text == "Add Model")
            {

            }
            else
                MessageBox.Show("Selected Model does not exist");
            ComboboxDesc.Text = "";
        }
        private void LoadProductComboBox()
        {
            ComboBoxProduct.Items.Clear();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT DISTINCT ItemName FROM Items");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        ComboBoxProduct.Items.Add(row["ItemName"].ToString());
                    }
                    ComboboxDesc.Items.Add("Add Model");
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
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            UnitPriceTemp = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //after add the value to the grid add to string or array or most probably linked list
            //then this function is called to change the total value in the grid and the total text box
            if (FormLoadFlag == true && dataGridView1.Columns[e.ColumnIndex].Name == "UnitPrice" && dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value != null)
            {
                if (Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < UnitPriceTemp)
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = UnitPriceTemp;
                    }
                }
                decimal total = (Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value) * Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value));
                total = total + (total * (Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["Tax"].Value) / 100));
                dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = total;
                Decimal tempTotal = 0;
                Decimal tempSubTotal = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    tempTotal += Convert.ToDecimal(row.Cells["total"].Value);
                    tempSubTotal += Convert.ToDecimal(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["UnitPrice"].Value);
                }
                TextBoxTotal.Text = tempTotal.ToString();
            }
            else if (FormLoadFlag == true && dataGridView1.Columns[e.ColumnIndex].Name == "UnitPrice" && dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value == null)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = UnitPriceTemp;
            }
        }

        private void Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

    }
}
