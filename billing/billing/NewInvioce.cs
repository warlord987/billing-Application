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
    public partial class NewInvioce : Form
    {
        private bool CheckedFlag;
        private int i;
        private bool FormLoadFlag = false;
        private decimal UnitPriceTemp = 0;
        private bool EditFormFlag = false;


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        //LinkedList<Decimal> listUnitPrice = new LinkedList<Decimal>();
        public NewInvioce()
        {
            InitializeComponent();
            FormLoadFlag = true;
        }

        public NewInvioce(DataTable dt,String st)
        {
            InitializeComponent();
            FormLoadFlag = true;
            dataGridView1.DataSource = dt;
            EditFormFlag = true;
            ComboBoxClientName.Text = st.Split(',').ElementAt(0).Trim();
            LabelHidden.Text = st.Split(',').ElementAt(1);
            ComboBoxVehicleModel.Text = st.Split(' ').ElementAt(2);
        }

        public void LoadDescCombobox()
        {
            ComboboxDesc.Items.Clear();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT ItemDesc FROM Items WHERE (ItemDesc IS NOT NULL) AND (ItemName = '"+ ComboBoxVehicleModel.Text+"')");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        ComboboxDesc.Items.Add(row["ItemDesc"].ToString().Trim());
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

        private void LoadProductComboBox()
        {
            ComboBoxVehicleModel.Items.Clear();
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
                        ComboBoxVehicleModel.Items.Add(row["ItemName"].ToString().Trim());
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
        
        public void LoadCusCombobox()
        {
            ComboBoxClientName.Items.Clear();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT CustomerName,VehicleNo FROM Customer");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        ComboBoxClientName.Items.Add(row["CustomerName"].ToString().Trim() + " ( " + row["VehicleNo"].ToString().Trim() + " )");
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
        private void NewInvioce_Load(object sender, EventArgs e)
        {
            DateTimePickerIssued.Value = DateTime.Today;
            LoadCusCombobox();
            LoadProductComboBox();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT MAX(InvoiceNo) AS Invoiceno FROM Invoice");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        NumericInvoiceNo.Text = (Convert.ToInt32(row["Invoiceno"].ToString().Trim()) + 1).ToString();
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
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
            if (EditFormFlag == true)
            {
                Decimal TempTotal = 0;
                Decimal TempSubTotal = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    decimal total = (Convert.ToDecimal(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["UnitPrice"].Value));
                    TempSubTotal += total;
                    total = total + (total * (Convert.ToDecimal(row.Cells["Tax"].Value) / 100));
                    row.Cells["Total"].Value = total;
                    TempTotal += total;
                }
                TextBoxTotal.Text = TempTotal.ToString();
                TextBoxSubTotal.Text = TempSubTotal.ToString();
            }
        }

        private void ComboBoxClientName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxClientName.Items.Contains(ComboBoxClientName.Text)) //check if the customer is from database
            {
                try // load hidden textox and check if a message is scheduled aand load the desc combo box
                {
                    String[] substrings = ComboBoxClientName.Text.Split('(');
                    string CustomerName = substrings[0];
                    string vehicleno = substrings[1].Split(')').ElementAt(0).Trim();
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try // load hidden text with customer detail and change product textbox
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Invoice.due FROM Customer INNER JOIN Invoice ON Customer.CustomerId = Invoice.CustomerId WHERE (Customer.VehicleNo = '" + vehicleno + "') AND (Invoice.due > 0)");
                        dt = DatabaseConnectObj.ExecuteQuery();
                        Decimal TempDue = 0;
                        int TempInvoiceCount = 0;
                        foreach (DataRow row in dt.Rows)
                        {
                            TempDue += Convert.ToDecimal(row["due"]);
                            TempInvoiceCount++;
                        }
                        if (TempDue > 0)
                        {
                            MessageBox.Show("this customer has previous due of Rs " + TempDue + " from " + TempInvoiceCount + " invoices");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try // load hidden text with customer detail and change product textbox
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT CustomerNo, VehicleNo, VehicleType FROM Customer WHERE (CustomerName = '" + CustomerName + "') AND (VehicleNo = '" + vehicleno + "')");
                        dt = DatabaseConnectObj.ExecuteQuery();
                        DataRow row = dt.Rows[0];
                        string temp = row["CustomerNo"].ToString() + "\n" + row["VehicleNo"].ToString().Trim() + "\n" + row["VehicleType"].ToString().Trim();
                        vehicleno = row["VehicleNo"].ToString().Trim();
                        ComboBoxVehicleModel.Text = row["VehicleType"].ToString().Trim();
                        ComboBoxVehicleModel.Focus(); // to trigger the leave event
                        ComboboxDesc.Focus();
                        LabelHidden.Text = temp;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try // check if a message is scheduled
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT VehicleNo FROM Schedule WHERE (VehicleNo = '" + vehicleno + "')");
                        dt = DatabaseConnectObj.ExecuteQuery();
                        DataRow row = dt.Rows[0];
                        if (!row["VehicleNo"].Equals(""))
                        {
                            CheckBoxSchedule.Checked = false;
                            CheckedFlag = true;
                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.ToString().Equals("There is no row at position 0."))
                        {
                            CheckBoxSchedule.Checked = true;
                        }
                        else
                        {
                            MessageBox.Show(ex.Message);
                        }
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

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            string itemid1 = "";
            if (ComboboxDesc.Items.Contains(ComboboxDesc.Text))
            {
                try //get item id to fill into datagrid for future use
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT ItemId FROM Items WHERE (ItemName = '" + ComboBoxVehicleModel.Text + "') AND (ItemDesc = '" + ComboboxDesc.Text + "')"); //query to selecte itemid where prdoct name and desc == entered product is and desc
                        dt = DatabaseConnectObj.ExecuteQuery();
                        foreach (DataRow row in dt.Rows)
                        {
                            itemid1 = row["ItemId"].ToString().Trim();
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

                if (EditFormFlag == true)
                {
                    DataTable dataTable = (DataTable)dataGridView1.DataSource;
                    DataRow drToAdd = dataTable.NewRow();
                    drToAdd["ItemDesc"] = ComboboxDesc.Text.ToString();
                    drToAdd["Quantity"] = NumericQuantity.Value.ToString();
                    drToAdd["price"] = NumericUnitPrice.Value.ToString();
                    drToAdd["Tax"] = ComboboxTax.Text;
                    drToAdd["ItemNo"] = itemid1;
                    dataTable.Rows.Add(drToAdd);
                    dataTable.AcceptChanges();
                    TextBoxSubTotal.Text = (Convert.ToInt32(TextBoxSubTotal.Text) + (NumericUnitPrice.Value * NumericQuantity.Value)).ToString();
                    TextBoxTotal.Text = (Convert.ToDecimal(TextBoxTotal.Text) + NumericQuantity.Value * (NumericUnitPrice.Value + (NumericUnitPrice.Value * (Convert.ToDecimal(ComboboxTax.Text) / 100)))).ToString();
                    Decimal TempTotal = 0;
                    Decimal TempSubTotal = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        decimal total = (Convert.ToDecimal(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["UnitPrice"].Value));
                        TempSubTotal += total;
                        total = total + (total * (Convert.ToDecimal(row.Cells["Tax"].Value) / 100));
                        row.Cells["Total"].Value = total;
                        TempTotal += total;
                    }
                    TextBoxTotal.Text = TempTotal.ToString();
                    TextBoxSubTotal.Text = TempSubTotal.ToString();

                }
                else
                {
                    decimal total = (Convert.ToDecimal(NumericQuantity.Value) * Convert.ToDecimal(NumericUnitPrice.Value));
                    total = total + (total * (Convert.ToDecimal(ComboboxTax.Text) / 100));
                    dataGridView1.Rows.Add(ComboboxDesc.Text.ToString(), NumericQuantity.Value.ToString(), NumericUnitPrice.Value.ToString(), ComboboxTax.Text, total.ToString(), itemid1);
                    TextBoxSubTotal.Text = (Convert.ToInt32(TextBoxSubTotal.Text) + (NumericUnitPrice.Value * NumericQuantity.Value)).ToString();
                    TextBoxTotal.Text = (Convert.ToDecimal(TextBoxTotal.Text) + NumericQuantity.Value * (NumericUnitPrice.Value + (NumericUnitPrice.Value * (Convert.ToDecimal(ComboboxTax.Text) / 100)))).ToString();
                }
                ComboboxDesc.Focus();
                ButtonSave.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please add the new item before adding this to the invoice");
                ComboboxDesc.Focus();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            int invoiceid = 0;
            if (ComboBoxClientName.Items.Contains(ComboBoxClientName.Text)) // check if customer is selected
            {
                try // select customer id
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    DataTable dt1 = new DataTable();
                    string cusid1 = "";
                    string vehicleno = "";
                    string[] substrings = ComboBoxClientName.Text.Split('(');
                    vehicleno = substrings[1].Split(')').ElementAt(0).Trim();
                    DatabaseConnectObj.SqlQuery("SELECT CustomerId FROM Customer WHERE (VehicleNo = '" + vehicleno + "')");
                    dt1 = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt1.Rows)
                    {
                        cusid1 = row["CustomerId"].ToString().Trim();
                    }
                    try // insert invoice first
                    {
                        string date = DateTimePickerIssued.Value.Month.ToString() + "/" + DateTimePickerIssued.Value.Day.ToString() + "/" + DateTimePickerIssued.Value.Year.ToString();
                        DataTable dt = new DataTable();
                        decimal TempTotal = 0;
                        for (int i = 0; i < dataGridView1.RowCount; i++)
                        {
                            decimal total = (Convert.ToDecimal(dataGridView1.Rows[i].Cells["Quantity"].Value) * Convert.ToDecimal(dataGridView1.Rows[i].Cells["UnitPrice"].Value));
                            total = total + (total * (Convert.ToDecimal(dataGridView1.Rows[i].Cells["Tax"].Value) / 100));
                            TempTotal += total;
                        }
                        DatabaseConnectObj.SqlQuery("INSERT INTO Invoice (InvoiceNo, CustomerId, Date, total, due, remark) VALUES ('" + NumericInvoiceNo.Text + "','" + cusid1 + "','" + date + "','" + TempTotal + "','" + (Convert.ToDecimal(TextBoxTotal.Text) - Convert.ToDecimal(TextBoxPaid.Text)).ToString() + "','" + TextBoxRemark.Text + "')");
                        DatabaseConnectObj.ExecutNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    try //select invoiceid to insert invoice with multiple invoice no.
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT MAX(invoiceid) AS invoiceid FROM Invoice ORDER BY invoiceid");
                        dt = DatabaseConnectObj.ExecuteQuery();
                        invoiceid = Convert.ToInt32(dt.Rows[0].ItemArray[0]);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    try // insert the bill details
                    {
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            DatabaseConnectObj.SqlQuery("INSERT INTO BillDetailsInvoice (ItemNo, Quantity, price, InvoiceNo, Tax, invoiceid) VALUES ('" + dataGridView1.Rows[i].Cells["Itemid"].Value + "','" + dataGridView1.Rows[i].Cells["Quantity"].Value + "','" + dataGridView1.Rows[i].Cells["UnitPrice"].Value + "','" + NumericInvoiceNo.Text + "','" + dataGridView1.Rows[i].Cells["Tax"].Value + "','"+invoiceid+"')");
                            DatabaseConnectObj.ExecutNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    if (CheckBoxSchedule.Checked.Equals(true)) // if scheduled box is checked schedule the message
                    {
                        if (CheckedFlag == false)
                        {
                            try
                            {
                                string date = dateTimePickerSchedule.Value.Month.ToString() + "/" + dateTimePickerSchedule.Value.Day.ToString() + "/" + dateTimePickerSchedule.Value.Year.ToString();
                                DatabaseConnectObj.SqlQuery("INSERT INTO Schedule (VehicleNo, Date) VALUES ('" + vehicleno + "','" + date + "')");
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
                        else
                        {
                            try
                            {
                                DatabaseConnectObj.SqlQuery("UPDATE Schedule SET Date = '" + dateTimePickerSchedule.Value.ToShortDateString() + "' WHERE (VehicleNo = '" + vehicleno + "')");
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
                    }
                    else
                    {
                        DatabaseConnectObj.DatabaseConnectionClose();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                ButtonSave.Enabled = false;
                ButtonPreview.Enabled = true;
            }
            else
            {
                MessageBox.Show("First add the client name.");
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {
            
        }

        private void label15_Click(object sender, EventArgs e)
        {
            NewService NewServiceObj = new NewService();
            NewServiceObj.ShowDialog();
        }

        private void ButtonPreview_Click(object sender, EventArgs e)
        {
            /*PrintPreviewInvoice.Document = PrintDocumentInvoice;
            PrintPreviewInvoice.Size = new System.Drawing.Size(595, 842); wt,ht
            PrintPreviewInvoice.ShowDialog();*/
            //PrintPreview PrintPreviewForm = new PrintPreview(PrintDocumentInvoice,TextBoxTotal.Text);
            //PrintPreviewForm.ShowDialog();
            using (var dlg = new CoolPrintPreviewDialog(null,TextBoxTotal.Text,LabelHidden.Text))
            {
                dlg.Document = PrintDocumentInvoice;
                dlg.ShowDialog(this);
            }
            
        }

        private void PrintDocumentInvoice_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int Height = 80,Yincrement=20;
            string date = DateTimePickerIssued.Value.Month.ToString() + "/" + DateTimePickerIssued.Value.Day.ToString() + "/" + DateTimePickerIssued.Value.Year.ToString();
            Bitmap bmp = Properties.Resources.tecnocraft;
            Image CompanyLogo = bmp;
            Rectangle rect2 = new Rectangle(25, 400, 800, 50);
            String[] substrings = ComboBoxClientName.Text.Split('(');

            Pen pent = new Pen(Color.Black, 3);
            Point point1 = new Point(25, 375);
            Point point2 = new Point(820, 375);
            Font FontHeading = new Font("Helvetica", 25, FontStyle.Bold);
            Font FontTitle = new Font("Helvetica", 15, FontStyle.Bold);
            Font FontDesc = new Font("Helvetica", 12, FontStyle.Regular);
            Font FontTotal = new Font("Helvetica",12,FontStyle.Bold);

            //company details
            e.Graphics.DrawImage(CompanyLogo, 40, 50, 300, 40);
            e.Graphics.DrawString("INVOICE : "+ NumericInvoiceNo.Value.ToString(), FontHeading, Brushes.Black, new Point(530, 45));
            //print date

            //company address
            e.Graphics.DrawString("From ", FontDesc, Brushes.Gray, new Point(50, Height+Yincrement+10));
            e.Graphics.DrawString("#72, 7th Main, B.O.B Colony,", FontDesc, Brushes.Black, new Point(110, Height += Yincrement + 10));
            e.Graphics.DrawString("J.P.Nagar, 7th Phase, ", FontDesc, Brushes.Black, new Point(110, Height += Yincrement));
            e.Graphics.DrawString("Bangalore-78.", FontDesc, Brushes.Black, new Point(110, Height += Yincrement));
            e.Graphics.DrawString("Ph: 9886254448,9880369118", FontDesc, Brushes.Black, new Point(110, Height += Yincrement));
            // customer details
            e.Graphics.DrawString("To ", FontDesc, Brushes.Gray, new Point(530, (Height + Yincrement) - (Yincrement * 4)));
            e.Graphics.DrawString(substrings[0] +"\n"+LabelHidden.Text, FontDesc, Brushes.Black, new Point(560, Height-(Yincrement*3)));
            //invoice no and date
            e.Graphics.DrawString("Issued ", FontDesc, Brushes.Gray, new Point(50, Height + Yincrement + 5));
            e.Graphics.DrawString(date.ToString(), FontDesc, Brushes.Black, new Point(110, Height += Yincrement+5));
            //table
            e.Graphics.DrawString("#", FontTitle, Brushes.Black, new Point(35, Height+=Yincrement+20));
            e.Graphics.DrawString("Desc", FontTitle, Brushes.Black, new Point(90, Height));
            e.Graphics.DrawString("Qty", FontTitle, Brushes.Black, new Point(335, Height));
            e.Graphics.DrawString("Price", FontTitle, Brushes.Black, new Point(435, Height));
            e.Graphics.DrawString("Tax", FontTitle, Brushes.Black, new Point(530, Height));
            e.Graphics.DrawString("Total", FontTitle, Brushes.Black, new Point(635, Height));
            e.Graphics.DrawLine(pent, new Point(30,Height+=Yincrement+10), new Point(800,Height));
            //table content
            int j;
            for (j = i; j < dataGridView1.RowCount && Height < 920; j++)
            {
                e.Graphics.DrawString((j + 1).ToString(), FontDesc, Brushes.Black, new Point(35, Height+=Yincrement+10));
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
            e.Graphics.DrawLine(pent, new Point(30,960), new Point(800,960));
            e.Graphics.DrawString("Remark", FontTitle, Brushes.Black, new Point(30, 970));
            if (TextBoxRemark.TextLength > 50)
            {
                e.Graphics.DrawString(TextBoxRemark.Text.Substring(0,49), new Font("Calibri", 13, FontStyle.Bold), Brushes.Black, new Point(50, 1000));
                e.Graphics.DrawString(TextBoxRemark.Text.Substring(49, TextBoxRemark.Text.Length-49), new Font("Calibri", 13, FontStyle.Bold), Brushes.Black, new Point(50, 1020));
            }
            else
            {
                e.Graphics.DrawString(TextBoxRemark.Text, new Font("Calibri", 13, FontStyle.Bold), Brushes.Black, new Point(30, 1000));
            }
            e.Graphics.DrawString("SubTotal", FontTitle, Brushes.Black, new Point(550, 970));
            e.Graphics.DrawString(TextBoxSubTotal.Text, FontTitle, Brushes.Black, new Point(670, 970));
            e.Graphics.DrawString("Tax: ", FontTitle, Brushes.Black, new Point(550,1000));
            e.Graphics.DrawString((Convert.ToDecimal(TextBoxTotal.Text) - Convert.ToDecimal(TextBoxSubTotal.Text)).ToString(), FontTitle, Brushes.Black, new Point(670, 1000));
            e.Graphics.DrawString("Total", FontTitle, Brushes.Black, new Point(550, 1030));
            e.Graphics.DrawString(TextBoxTotal.Text, FontTitle, Brushes.Black, new Point(670, 1030));
        }

        private void PrintPreviewInvoice_FormClosed(object sender, FormClosedEventArgs e)
        {
            i = 0;
        }

        private void ComboBoxClientName_Leave(object sender, EventArgs e)
        {

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
                TextBoxSubTotal.Text = tempSubTotal.ToString();
                TextBoxTotal.Text = tempTotal.ToString();
            }
            else if(FormLoadFlag == true && dataGridView1.Columns[e.ColumnIndex].Name == "UnitPrice" && dataGridView1.Rows[e.RowIndex].Cells["UnitPrice"].Value==null)
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = UnitPriceTemp;
            }
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                Decimal subtotal = Convert.ToInt32(e.Row.Cells["UnitPrice"].Value) * Convert.ToInt32(e.Row.Cells["Quantity"].Value);
                Decimal total = Convert.ToDecimal(e.Row.Cells["Total"].Value);
                TextBoxSubTotal.Text = (Convert.ToInt32(TextBoxSubTotal.Text) - subtotal).ToString();
                TextBoxTotal.Text = (Convert.ToDecimal(TextBoxTotal.Text) - total).ToString();
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
                        DatabaseConnectObj.SqlQuery("SELECT ItemPrice FROM Items WHERE (ItemName = '" + ComboBoxVehicleModel.Text + "') AND (ItemDesc = '" + ComboboxDesc.Text + "')");
                        dt = DatabaseConnectObj.ExecuteQuery();
                        foreach (DataRow row in dt.Rows)
                        {
                            NumericUnitPrice.Value = Convert.ToDecimal(row["ItemPrice"].ToString().Trim());
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
        }


        private void TextBoxTotal_TextChanged(object sender, EventArgs e)
        {
            TextBoxPaid.Text = TextBoxTotal.Text;
        }

        private void TextBoxRemark_TextChanged(object sender, EventArgs e)
        {
            if(TextBoxRemark.TextLength>100)
            {
                MessageBox.Show("remark cannot exced 100 characters");
                TextBoxRemark.Text = "";
            }
        }

        private void ComboBoxProduct_TextChanged(object sender, EventArgs e)
        {
            if (ComboBoxVehicleModel.Items.Contains(ComboBoxVehicleModel.Text.Trim()))
            {
                LoadDescCombobox();
                ComboboxDesc.Text = "";
            }
        }


        private void ComboBoxVehicleModel_Leave(object sender, EventArgs e)
        {
            if (!ComboBoxVehicleModel.Items.Contains(ComboBoxVehicleModel.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Selected Model does not exist, Do you want to add it?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string tempProduct = ComboBoxVehicleModel.Text;
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DatabaseConnectObj.SqlQuery("INSERT INTO Items (ItemName, ItemPrice) VALUES ('" + ComboBoxVehicleModel.Text.Trim() + "','0')");
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
                    LoadProductComboBox();
                    ComboBoxVehicleModel.Text = tempProduct;
                    LoadDescCombobox();
                }
                else
                {
                    ComboBoxVehicleModel.Text = "";
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void NewInvioce_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewCustomer NewCustomerObj = new NewCustomer();
            NewCustomerObj.ShowDialog();
            LoadCusCombobox();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewService NewServiceObj = new NewService();
            NewServiceObj.ShowDialog();
            LoadDescCombobox(); 
        }

        private void ComboBoxClientName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label14_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
