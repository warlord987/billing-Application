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
    public partial class MountlyReport : Form
    {
        public MountlyReport()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private void MountlyReport_Load(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT  Name, Id, DateIssued, value FROM Expences");
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

        private void ButtonNewVoucher_Click(object sender, EventArgs e)
        {
            NewVoucher NewVoucherObj = new NewVoucher();
            NewVoucherObj.ShowDialog();
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
                if (TextBoxVoucherNo.Text != "" && TextBoxPaidTo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Name, Id, DateIssued, value FROM Expences WHERE (Id = '" + TextBoxVoucherNo.Text + "') AND (DateIssued BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxVoucherNo.Text == "" && TextBoxPaidTo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Name, Id, DateIssued, value FROM Expences WHERE (Name LIKE '%" + TextBoxPaidTo.Text + "%') AND (DateIssued BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxVoucherNo.Text != "" && TextBoxPaidTo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Name, Id, DateIssued, value FROM Expences WHERE (Id = '" + TextBoxVoucherNo.Text + "') AND (Name LIKE '%" + TextBoxPaidTo.Text + "%') AND (DateIssued BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else if (TextBoxVoucherNo.Text == "" && TextBoxPaidTo.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT Name, Id, DateIssued, value FROM Expences WHERE (DateIssued BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                DialogResult result = MessageBox.Show("Are you sure?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string Id = dataGridView1.Rows[e.RowIndex].Cells["VoucherNo"].Value.ToString();
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DataTable dt = new DataTable();
                            DatabaseConnectObj.SqlQuery("DELETE FROM Expences WHERE (Id = '"+Id+"')");
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
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxVoucherNo.Text = "";
            TextBoxPaidTo.Text = "";
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT  Name, Id, DateIssued, value FROM Expences");
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
    }
}
