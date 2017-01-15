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
    public partial class ReportingEstimate : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public ReportingEstimate()
        {
            InitializeComponent();
        }

        private void ReportingEstimate_Load(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId");
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
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                temp += Convert.ToDecimal(row.Cells["total"].Value);
            }
            TextBoxTotal.Text = temp.ToString();
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
                if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxEstimateNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxEstimateNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxEstimateNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxEstimateNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxEstimateNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxEstimateNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text != "" && TextBoxEstimateNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxEstimateNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxEstimateNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%')  AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxEstimateNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text != "" && TextBoxEstimateNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxEstimateNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxEstimateNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text != "" && TextBoxEstimateNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text != "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text != "" && TextBoxEstimateNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Customer.CustomerName LIKE '%" + TextBoxCusName.Text + "%') AND (Customer.CustomerNo = '" + TextBoxCusContact.Text + "') AND (Estimate.EstimateNo = '" + TextBoxEstimateNo.Text + "') AND (Customer.VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxEstimateNo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo,  Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId WHERE (Estimate.Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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

        private void ButtonNewEstimate_Click_1(object sender, EventArgs e)
        {
            NewEstimate NewEstimateObj = new NewEstimate();
            NewEstimateObj.ShowDialog();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Edit EditObj = new Edit();
            int rowind = e.RowIndex;
            EditObj.passvalue = dataGridView1.Rows[rowind].Cells["EstimateNo"].Value.ToString() + ",Estimate," + " " + dataGridView1.Rows[rowind].Cells["CustomerName"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["Date"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["VehicleNo"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["Estimateid"].Value.ToString();
            if (!(EditObj.ShowDialog() == DialogResult.OK))
            {
                ReportingEstimate_Load(this, null);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxCusName.Text = "";
            TextBoxCusContact.Text = "";
            TextBoxVehicleNo.Text = "";
            TextBoxEstimateNo.Text = "";
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.VehicleNo, Estimate.EstimateNo, Estimate.Date, Estimate.total, Estimate.estimateid FROM Estimate INNER JOIN Customer ON Estimate.CustomerId = Customer.CustomerId");
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
        }

        private void dataGridView1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(dataGridView1.Rows[i].Cells["total"].Value.ToString());
            }
            TextBoxTotal.Text = total.ToString();
        }

        private void dataGridView1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            int total = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(dataGridView1.Rows[i].Cells["total"].Value.ToString());
            }
            TextBoxTotal.Text = total.ToString();
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                PasswordForm testDialog = new PasswordForm();
                // Show testDialog as a modal dialog and determine if DialogResult = OK.
                if (testDialog.ShowDialog() == DialogResult.OK && testDialog.TextBoxPassword.Text == HiddenLabel.Text)
                {
                    string estimateid = dataGridView1.Rows[e.RowIndex].Cells["Estimateid"].Value.ToString();
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DataTable dt = new DataTable();
                            DatabaseConnectObj.SqlQuery("DELETE FROM Estimate WHERE (Estimateid = '" + estimateid + "')");
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

        private void ReportingEstimate_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 'e' || e.KeyChar == 'E')
            {
                Edit EditObj = new Edit();
                int rowind = Convert.ToInt32(dataGridView1.SelectedRows[0].Index);
                EditObj.passvalue = dataGridView1.Rows[rowind].Cells["EstimateNo"].Value.ToString() + ",Estimate," + " " + dataGridView1.Rows[rowind].Cells["CustomerName"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["Date"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["VehicleNo"].Value.ToString().Trim() + "," + dataGridView1.Rows[rowind].Cells["Estimateid"].Value.ToString();
                if (!(EditObj.ShowDialog() == DialogResult.OK))
                {
                    ReportingEstimate_Load(this, null);
                }
            }
        }



    }
}
