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
        private DataTable laboursdata;
        private DataTable vehicledata;
        private DataTable itemsData;
        private DataTable customerData;
        private decimal Temp;
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

        private void loadTotalAndSubTotal()
        {
            Decimal tempTotal = 0;
            Decimal tempSubTotal = 0;
            foreach (DataGridViewRow row in dataGridItems.Rows)
            {
                decimal total = (Convert.ToDecimal(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["UnitPrice"].Value));
                total = total + (total * (Convert.ToDecimal(row.Cells["Tax"].Value) / 100));
                row.Cells["Total"].Value = total;
                tempTotal += Convert.ToDecimal(row.Cells["total"].Value);
                tempSubTotal += Convert.ToDecimal(row.Cells["Quantity"].Value) * Convert.ToDecimal(row.Cells["UnitPrice"].Value);
            }
            foreach (DataGridViewRow row in DataGridLabour.Rows)
            {
                decimal LabourTotal = (Convert.ToDecimal(row.Cells["LabourCharge"].Value));
                LabourTotal = LabourTotal + (LabourTotal * (Convert.ToDecimal(row.Cells["LabourTax"].Value) / 100));
                row.Cells["LabourTotal"].Value = LabourTotal;
                tempTotal += Convert.ToDecimal(row.Cells["LabourTotal"].Value);
                tempSubTotal += Convert.ToDecimal(row.Cells["LabourCharge"].Value);
            }
            TextBoxSubTotal.Text = tempSubTotal.ToString();
            TextBoxTotal.Text = tempTotal.ToString();
        }

        public void loadComboBoxLabourName(DataTable LabourTable)
        {
            ComboBoxLabourName.Text = "";
            ComboBoxLabourName.Items.Clear();

            try
            {
                foreach (DataRow row in LabourTable.Rows)
                {
                    ComboBoxLabourName.Items.Add(row["LabourName"].ToString().Trim());
                }
                if (ComboBoxLabourName.Items.Count > 0)
                {
                    ComboBoxLabourName.Text = ComboBoxLabourName.Items[0].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                string output = ex.Message + " loadComboBoxLabourName"; MessageBox.Show(output);
            }
        }

        public void loadComboBoxItemName(DataTable customerTable, DataTable vehicleTable, DataTable itemsTable)
        {
            ComboBoxItemName.Text = "";
            ComboBoxItemName.Items.Clear();
            try
            {
                try
                {
                    DataRow[] vehicleRowData = vehicleTable.Select("VehicleType='" + ComboBoxVehicleModel.Text.Trim() + "' AND VehicleName='" + ComboBoxVehicleName.Text.Trim() + "'");
                    string selectedVehicleId = vehicleRowData[0]["Id"].ToString().Trim();
                    DataRow[] itemsData = itemsTable.Select("VehicleId = '" + selectedVehicleId + "'");

                    foreach (DataRow row in itemsData)
                    {
                        ComboBoxItemName.Items.Add(row["ItemName"].ToString().Trim());
                    }
                    if (ComboBoxItemName.Items.Count > 0)
                    {
                        ComboBoxItemName.Text = ComboBoxItemName.Items[0].ToString().Trim();
                    }
                }
                catch (Exception ex)
                {
                    string output = ex.Message + " loadComboBoxItemName"; MessageBox.Show(output);
                }
            }
            catch (Exception ex)
            {
                string output = ex.Message + " loadComboBoxItemName"; MessageBox.Show(output);
            }
        }

        private void getCustomerData()
        {
            ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
            try
            {
                DatabaseConnectObj.SqlQuery("SELECT CustomerId, CustomerName, CustomerNo, VehicleNo, VehicleId FROM dbo.Customer");
                customerData = DatabaseConnectObj.ExecuteQuery();
            }
            catch (Exception ex)
            {
                string output = ex.Message + " getCustomerData"; MessageBox.Show(output);
            }
            finally
            {
                DatabaseConnectObj.DatabaseConnectionClose();
            }
        }

        private void getItemsData()
        {
            ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
            try
            {
                DatabaseConnectObj.SqlQuery("SELECT ItemId, ItemName, ItemDesc, ItemPrice, VehicleId FROM dbo.Items");
                itemsData = DatabaseConnectObj.ExecuteQuery();
            }
            catch (Exception ex)
            {
                string output = ex.Message + " getItemsData"; MessageBox.Show(output);
            }
            finally
            {
                DatabaseConnectObj.DatabaseConnectionClose();
            }
        }

        private void getVehicleData()
        {
            ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
            try
            {
                DatabaseConnectObj.SqlQuery("SELECT Id, VehicleType, VehicleName FROM dbo.Vehicle");
                vehicledata = DatabaseConnectObj.ExecuteQuery();
            }
            catch (Exception ex)
            {
                string output = ex.Message + " getVehicleData"; MessageBox.Show(output);
            }
            finally
            {
                DatabaseConnectObj.DatabaseConnectionClose();
            }
        }

        private void getLaboursData()
        {
            ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
            try
            {
                DatabaseConnectObj.SqlQuery("SELECT LabourId, LabourName, LabourDesc, LabourPrice FROM Labour");
                laboursdata = DatabaseConnectObj.ExecuteQuery();
            }
            catch (Exception ex)
            {
                string output = ex.Message + " getLaboursData"; MessageBox.Show(output);
            }
            finally
            {
                DatabaseConnectObj.DatabaseConnectionClose();
            }
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            //get data and load
            getCustomerData();
            //LoadCusCombobox();
            getVehicleData();
            //loadVehiclefield();
            getItemsData();
            getLaboursData();

            //get invoice detail from reposrt window
            String[] substrings = nm.Split(',');            //get value as a object instead of using pass value
            typeEdit = substrings[1];
            groupBox1.Text = "Edit " + typeEdit;
            if (typeEdit == "Estimate")
            {
                ButtonMakeInvoice.Visible = true;
            }
            NumericInvoiceNo.Value = Convert.ToDecimal(substrings[0].ToString().Trim());
            string vehicleIdOfThisInvoice = customerData.Select("VehicleNo = '" + substrings[4].ToString().Trim() + "'")[0]["VehicleId"].ToString().Trim();
            DataRow vehicleRowOfThisInvoice = vehicledata.Select("Id = '" + vehicleIdOfThisInvoice + "'")[0];
            ComboBoxVehicleModel.Text = vehicleRowOfThisInvoice["VehicleType"].ToString().Trim();
            ComboBoxVehicleName.Text = vehicleRowOfThisInvoice["VehicleName"].ToString().Trim();
            LableInvoiceId.Text = substrings[5];
            ComboBoxClientName.Text = substrings[2] + " ( " + substrings[4] + " )";
            DateTimePickerIssued.Value = Convert.ToDateTime(substrings[3]);
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();

                //get invoice items details
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT Items.ItemName, BillItemDetails" + typeEdit + ".Quantity, BillItemDetails" + typeEdit + ".price, BillItemDetails" + typeEdit + ".Tax, BillItemDetails" + typeEdit + ".ItemNo FROM BillItemDetails" + typeEdit + " INNER JOIN Items ON BillItemDetails" + typeEdit + ".ItemNo = Items.ItemId WHERE (BillItemDetails" + typeEdit + "." + typeEdit + "id = '" + LableInvoiceId.Text + "')");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    dataGridItems.DataSource = dt;
                }
                catch (Exception ex)
                {
                    string output = ex.Message + " load items details"; MessageBox.Show(output);
                }

                //get invoice labour details
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT Labour.LabourName, BillLabourDetail" + typeEdit + ".price, BillLabourDetail" + typeEdit + ".Tax, BillLabourDetail" + typeEdit + ".LabourNo FROM BillLabourDetail" + typeEdit + " INNER JOIN Labour ON BillLabourDetail" + typeEdit + ".LabourNo = Labour.LabourId WHERE (BillLabourDetail" + typeEdit + "." + typeEdit + "id = '" + LableInvoiceId.Text + "')");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    DataGridLabour.DataSource = dt;
                }
                catch (Exception ex)
                {
                    string output = ex.Message + " load labour details"; MessageBox.Show(output);
                }

                //get remark
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

            //load the total and sub total
            loadTotalAndSubTotal();
        }

      /*  private void TextBoxCusName_TextChanged(object sender, EventArgs e)
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
        } */

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
           /* int Height = 80, Yincrement = 20;
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
            for (j = i; j < dataGridItems.RowCount && Height < 920; j++)
            {
                e.Graphics.DrawString((j + 1).ToString(), FontDesc, Brushes.Black, new Point(35, Height += Yincrement + 10));
                e.Graphics.DrawString(dataGridItems.Rows[j].Cells["Desc"].Value.ToString(), FontDesc, Brushes.Black, new Point(90, Height));
                e.Graphics.DrawString(dataGridItems.Rows[j].Cells["Quantity"].Value.ToString(), FontDesc, Brushes.Black, new Point(339, Height));
                e.Graphics.DrawString(dataGridItems.Rows[j].Cells["UnitPrice"].Value.ToString(), FontDesc, Brushes.Black, new Point(435, Height));
                e.Graphics.DrawString(dataGridItems.Rows[j].Cells["Tax"].Value.ToString(), FontDesc, Brushes.Black, new Point(535, Height));
                e.Graphics.DrawString(dataGridItems.Rows[j].Cells["Total"].Value.ToString(), FontTotal, Brushes.Black, new Point(635, Height));
            }
            if (j < dataGridItems.RowCount)
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
            e.Graphics.DrawString(TextBoxTotal.Text, FontTitle, Brushes.Black, new Point(670, 1030)); */
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("DELETE FROM BillItemDetails" + typeEdit + " WHERE (" + typeEdit + "id = " + LableInvoiceId.Text + ")");
                    DatabaseConnectObj.ExecutNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("DELETE FROM BillLabourDetail" + typeEdit + " WHERE (" + typeEdit + "id = " + LableInvoiceId.Text + ")");
                    DatabaseConnectObj.ExecutNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try // insert the bill details
                {
                    for (int i = 0; i < dataGridItems.Rows.Count; i++)
                    {
                        DatabaseConnectObj.SqlQuery("INSERT INTO BillitemDetails" + typeEdit + " (ItemNo, Quantity, price, " + typeEdit + "No,Tax, " + typeEdit.ToLower() + "id) VALUES ('" + dataGridItems.Rows[i].Cells["Itemid"].Value + "','" + dataGridItems.Rows[i].Cells["Quantity"].Value + "','" + dataGridItems.Rows[i].Cells["UnitPrice"].Value + "','" + NumericInvoiceNo.Value + "','" + dataGridItems.Rows[i].Cells["Tax"].Value + "','" + LableInvoiceId.Text + "')");
                        DatabaseConnectObj.ExecutNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try // insert the bill details
                {
                    for (int i = 0; i < DataGridLabour.Rows.Count; i++)
                    {
                        DatabaseConnectObj.SqlQuery("INSERT INTO BillLabourDetail" + typeEdit + " (LabourNo, price, " + typeEdit + "No,Tax, " + typeEdit.ToLower() + "id) VALUES ('" + DataGridLabour.Rows[i].Cells["LabourId"].Value + "','" + DataGridLabour.Rows[i].Cells["LabourCharge"].Value + "','" + NumericInvoiceNo.Value + "','" + DataGridLabour.Rows[i].Cells["LabourTax"].Value + "','" + LableInvoiceId.Text + "')");
                        DatabaseConnectObj.ExecutNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                try // insert the bill details
                {
                    for (int i = 0; i < dataGridItems.Rows.Count; i++)
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
                ButtonUpdate.Enabled = false;
                ButtonPreview.Enabled = true;
                ButtonMakeInvoice.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void ButtonAdd_Click_1(object sender, EventArgs e)
        {
            DataRow[] vehicleRowData = vehicledata.Select("VehicleType='" + ComboBoxVehicleModel.Text.Trim() + "' AND VehicleName='" + ComboBoxVehicleName.Text.Trim() + "'");
            string selectedVehicleId = vehicleRowData[0]["Id"].ToString().Trim();
            DataRow[] itemRowData = itemsData.Select("VehicleId = '" + selectedVehicleId + "' AND ItemName = '" + ComboBoxItemName.Text.Trim() + "'");
            string itemid1 = itemRowData[0]["ItemId"].ToString().Trim();
            if (ComboBoxItemName.Items.Contains(ComboBoxItemName.Text))
            {
                DataTable dataTable = (DataTable)dataGridItems.DataSource;
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["ItemName"] = ComboBoxItemName.Text.ToString();
                drToAdd["Quantity"] = NumericQuantity.Value.ToString();
                drToAdd["price"] = NumericUnitPrice.Value.ToString();
                drToAdd["Tax"] = ComboboxItemTax.Text;
                drToAdd["ItemNo"] = itemid1;
                //calculate total without tax
                decimal total = (Convert.ToDecimal(NumericQuantity.Value) * Convert.ToDecimal(NumericUnitPrice.Value));
                //add tax
                total = total + (total * (Convert.ToDecimal(ComboboxItemTax.Text) / 100));
                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
                loadTotalAndSubTotal();                 //this here is not effecient change this
                ComboBoxItemName.Focus();
            }
            else
            {
                MessageBox.Show("Please add the new item before adding this to the invoice");
                ComboBoxItemName.Focus();
            }
                
        }

        private void ButtonMakeInvoice_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to make this Enstimate a Invoice?", "Confirmation Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataTable dataItemsTable = (DataTable)dataGridItems.DataSource;
                DataTable dataLaborTable = (DataTable)DataGridLabour.DataSource;
                NewInvioce NewInvoiceObj = new NewInvioce(dataItemsTable, dataLaborTable, ComboBoxClientName.Text + "," + LabelHidden.Text);
                NewInvoiceObj.ShowDialog();
                this.Close();
            }
        }

        private void ComboBoxItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxItemName.Items.Contains(ComboBoxItemName.Text.ToString()))
            {
                try
                {
                    DataRow[] vehicleRowData = vehicledata.Select("VehicleType='" + ComboBoxVehicleModel.Text.Trim() + "' AND VehicleName='" + ComboBoxVehicleName.Text.Trim() + "'");
                    string selectedVehicleId = vehicleRowData[0]["Id"].ToString().Trim();
                    DataRow[] itemRowData = itemsData.Select("VehicleId = '" + selectedVehicleId + "' AND ItemName = '" + ComboBoxItemName.Text.Trim() + "'");
                    NumericUnitPrice.Value = Convert.ToDecimal(itemRowData[0]["ItemPrice"].ToString().Trim());
                }
                catch (Exception ex)
                {
                    string output = ex.Message + " ComboBoxItemName_SelectedIndexChanged"; MessageBox.Show(output);
                }
            }
        }

        private void ComboBoxItemName_Enter(object sender, EventArgs e)
        {
            ComboBoxItemName.Items.Clear();
            loadComboBoxItemName(customerData, vehicledata, itemsData);
        }

        private void ComboBoxItemName_Leave(object sender, EventArgs e)
        {
            if (!ComboBoxItemName.Items.Contains(ComboBoxItemName.Text))
            {
                DialogResult result = MessageBox.Show("the item does not exist, would you like to add a new item?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NewService NewServiceObj = new NewService(ComboBoxVehicleModel.Text.Trim(), ComboBoxVehicleName.Text.Trim(), ComboBoxItemName.Text.Trim());
                    NewServiceObj.ShowDialog();
                    getItemsData();
                    ComboBoxItemName.Text = "";
                    ComboBoxItemName.Focus();
                }
                ComboBoxItemName.Text = "";
            }
        }

        private void ComboBoxLabourName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxLabourName.Items.Contains(ComboBoxLabourName.Text))
            {
                try
                {
                    DataRow labourRow = laboursdata.Select("LabourName = '" + ComboBoxLabourName.Text.Trim() + "'")[0];
                    NumericLabourCharge.Value = Convert.ToDecimal(labourRow["LabourPrice"].ToString().Trim());
                }
                catch (Exception ex)
                {
                    string output = ex.Message + " ComboBoxItemName_SelectedIndexChanged"; MessageBox.Show(output);
                }
            }
        }

        private void ComboBoxLabourName_Enter(object sender, EventArgs e)
        {
            ComboBoxLabourName.Items.Clear();
            loadComboBoxLabourName(laboursdata);
        }

        private void ComboBoxLabourName_Leave(object sender, EventArgs e)
        {
            if (!ComboBoxLabourName.Items.Contains(ComboBoxLabourName.Text))
            {
                DialogResult result = MessageBox.Show("the Labour does not exist, would you like to add a new Labour?", "Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    NewLabour NewLabourObj = new NewLabour(ComboBoxLabourName.Text.Trim());
                    NewLabourObj.ShowDialog();
                    getLaboursData();
                    ComboBoxLabourName.Text = "";
                    ComboBoxLabourName.Focus();
                }
                ComboBoxLabourName.Text = "";
            }
        }

        private void ButtonAddLabour_Click(object sender, EventArgs e)
        {
            string labourId = laboursdata.Select("LabourName = '" + ComboBoxLabourName.Text.Trim() + "'")[0]["LabourId"].ToString().Trim();
            if (ComboBoxLabourName.Items.Contains(ComboBoxLabourName.Text.Trim()))
            {
                DataTable dataTable = (DataTable)DataGridLabour.DataSource;
                DataRow drToAdd = dataTable.NewRow();
                drToAdd["LabourName"] = ComboBoxLabourName.Text.ToString();
                drToAdd["price"] = NumericLabourCharge.Value.ToString();
                drToAdd["Tax"] = ComboBoxLabourTax.Text;
                drToAdd["LabourNo"] = labourId;
                dataTable.Rows.Add(drToAdd);
                dataTable.AcceptChanges();
                loadTotalAndSubTotal();
                ComboBoxLabourName.Focus();
            }
            else
            {
                MessageBox.Show("Please add the new labour before adding this to the invoice");
                ComboBoxLabourName.Focus();
            }
        }

        private void dataGridItems_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
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
                string output = ex.Message + " dataGridView1_UserDeletingRow"; MessageBox.Show(output);
            }
        }

        private void dataGridItems_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Temp = Convert.ToDecimal(dataGridItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void dataGridItems_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //after add the value to the grid add to string or array or most probably linked list
            //then this function is called to change the total value in the grid and the total text box
            string columnName = dataGridItems.Columns[e.ColumnIndex].Name.ToString().Trim();

            if (FormLoadFlag == true && dataGridItems.Rows[e.RowIndex].Cells[columnName].Value != null)
            {
                if (Convert.ToDecimal(dataGridItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < Temp)
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        dataGridItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Temp;
                    }
                }
                decimal total = (Convert.ToDecimal(dataGridItems.Rows[e.RowIndex].Cells["Quantity"].Value) * Convert.ToDecimal(dataGridItems.Rows[e.RowIndex].Cells["UnitPrice"].Value));
                total = total + (total * (Convert.ToDecimal(dataGridItems.Rows[e.RowIndex].Cells["Tax"].Value) / 100));
                dataGridItems.Rows[e.RowIndex].Cells["Total"].Value = total;
                loadTotalAndSubTotal();
            }
            else if (FormLoadFlag == true && dataGridItems.Rows[e.RowIndex].Cells["UnitPrice"].Value == null)
            {
                dataGridItems.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Temp;
            }
        }

        private void DataGridLabour_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            try
            {
                Decimal subtotal = Convert.ToInt32(e.Row.Cells["LabourCharge"].Value);
                Decimal total = Convert.ToDecimal(e.Row.Cells["LabourTotal"].Value);
                TextBoxSubTotal.Text = (Convert.ToInt32(TextBoxSubTotal.Text) - subtotal).ToString();
                TextBoxTotal.Text = (Convert.ToDecimal(TextBoxTotal.Text) - total).ToString();
            }
            catch (Exception ex)
            {
                string output = ex.Message + " dataGridView1_UserDeletingRow"; MessageBox.Show(output);
            }
        }

        private void DataGridLabour_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            Temp = Convert.ToDecimal(DataGridLabour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
        }

        private void DataGridLabour_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = DataGridLabour.Columns[e.ColumnIndex].Name.ToString().Trim();

            if (FormLoadFlag == true && DataGridLabour.Rows[e.RowIndex].Cells[columnName].Value != null)
            {
                if (Convert.ToDecimal(DataGridLabour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) < Temp)
                {
                    DialogResult result = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNo);
                    if (result == DialogResult.No)
                    {
                        DataGridLabour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Temp;
                    }
                }
                decimal LabourTotal = (Convert.ToDecimal(DataGridLabour.Rows[e.RowIndex].Cells["LabourCharge"].Value));
                LabourTotal = LabourTotal + (LabourTotal * (Convert.ToDecimal(DataGridLabour.Rows[e.RowIndex].Cells["LabourTax"].Value) / 100));
                DataGridLabour.Rows[e.RowIndex].Cells["LabourTotal"].Value = LabourTotal;
                loadTotalAndSubTotal();
            }
            else if (FormLoadFlag == true && DataGridLabour.Rows[e.RowIndex].Cells[columnName].Value == null)
            {
                DataGridLabour.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = Temp;
            }
        }

    }
}
