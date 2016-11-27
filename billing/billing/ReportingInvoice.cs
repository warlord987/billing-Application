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
    public partial class ReportingInvoice : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public string BeginEditVariable;

        public ReportingInvoice()
        {
            InitializeComponent();
        }

        private void ButtonNewInvoice_Click(object sender, EventArgs e)
        {
            NewInvioce NewInvoiceObj = new NewInvioce();
            NewInvoiceObj.ShowDialog();
        }

        private void ReportingInvoice_Load(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try //load datagrid
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    dataGridView1.DataSource = dt;
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

            Decimal temp = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows) //calculate total
            {
                temp += Convert.ToDecimal(row.Cells["total"].Value);
            }
            TextBoxTotal.Text = temp.ToString(); //update total
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    dataGridView1.DataSource = dt;
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
            TextBoxCusName.Text = "";
            TextBoxCusContact.Text = "";
            TextBoxVehicleNo.Text = "";
            TextBoxInvoiceNo.Text = "";
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                String DateTo = "";
                String DateFrom = "";
                DateTo = DateTimePickerTo.Value.Month.ToString() + "/" + DateTimePickerTo.Value.Day.ToString() + "/" + DateTimePickerTo.Value.Year.ToString();
                DateFrom = DateTimePickerFrom.Value.Month.ToString() + "/" + DateTimePickerFrom.Value.Day.ToString() + "/" + DateTimePickerFrom.Value.Year.ToString();
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxInvoiceNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if (CheckBoxDue.Checked == true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND  (Invoice.due > 0) AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxInvoiceNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.due > 0) AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxInvoiceNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.due > 0) AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND  (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxInvoiceNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.due > 0) AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");

                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxInvoiceNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.due > 0) AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxInvoiceNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.due > 0) AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text != "" && TextBoxInvoiceNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.due > 0) AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxInvoiceNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.due > 0) AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxInvoiceNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%')  AND (Invoice.due > 0) AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%')  AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxInvoiceNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.due > 0) AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text != "" && TextBoxInvoiceNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.due > 0) AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxInvoiceNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.due > 0) AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxInvoiceNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.due > 0) AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text != "" && TextBoxInvoiceNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if(CheckBoxDue.Checked==true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.due > 0) AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text != "" && TextBoxInvoiceNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if (CheckBoxDue.Checked == true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Invoice.due > 0) AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND  (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Invoice.InvoiceNo = '" + TextBoxInvoiceNo.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                            dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxInvoiceNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        if (CheckBoxDue.Checked == true)
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Invoice.InvoiceNo, Invoice.Date, Invoice.total, Invoice.due, Invoice.invoiceid FROM Invoice INNER JOIN Customer ON Invoice.CustomerId = Customer.CustomerId WHERE  (Invoice.due > 0) AND (Invoice.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
                        }
                        else
                        {
                        }
                            dt = DatabaseConnectObj.ExecuteQuery();
                        dataGridView1.DataSource = dt;
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                PasswordForm testDialog = new PasswordForm();
                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (testDialog.ShowDialog() == DialogResult.OK && testDialog.TextBoxPassword.Text == HiddenLabel.Text)
                {
                    string invoiveid = dataGridView1.Rows[e.RowIndex].Cells["Invoiceid"].Value.ToString();
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DataTable dt = new DataTable();
                            DatabaseConnectObj.SqlQuery("DELETE FROM Invoice WHERE (invoiceid = '" + invoiveid + "')");
                            DatabaseConnectObj.ExecutNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            DatabaseConnectObj.DatabaseConnectionClose();
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Decimal temp = 0;
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        temp += Convert.ToDecimal(row.Cells["total"].Value);
                    }
                    TextBoxTotal.Text = temp.ToString();
                }
                else
                {
                    MessageBox.Show("Enter a valid Password");
                }
            }
        }

        private void dataGridView1_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Edit EditObj = new Edit();
            int rowind = e.RowIndex;
            EditObj.passvalue = dataGridView1.Rows[rowind].Cells["InvoiceNo"].Value.ToString() + ",Invoice," + " " + dataGridView1.Rows[rowind].Cells["CustomerName"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["Date"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["VehicleNo"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["Invoiceid"].Value.ToString();
            if (!(EditObj.ShowDialog() == DialogResult.OK))
            {
                ReportingInvoice_Load(this, null);
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("are you sure you want to update the due of this invoice?", "Confirmation Box", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                int temp = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Invoiceid"].Value.ToString());
                try
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("UPDATE Invoice SET due = '" + dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + "' WHERE (invoiceid = '" + dataGridView1.Rows[e.RowIndex].Cells["Invoiceid"].Value.ToString() + "')");
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
            }
            else
            {
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = BeginEditVariable;
            }
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            BeginEditVariable = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void ReportingInvoice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
                if (e.KeyChar == 'e' || e.KeyChar=='E')
            {
                Edit EditObj = new Edit();
                int rowind = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
                EditObj.passvalue = dataGridView1.Rows[rowind].Cells["InvoiceNo"].Value.ToString() + ",Invoice," + " " + dataGridView1.Rows[rowind].Cells["CustomerName"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["Date"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["VehicleNo"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["Invoiceid"].Value.ToString();
                if (!(EditObj.ShowDialog() == DialogResult.OK))
                {
                    ReportingInvoice_Load(this, null);
                }
            }
        }



    }
}