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
    public partial class ReportingClient : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public ReportingClient()
        {
            InitializeComponent();
        }


        private void ButtonNewClient_Click(object sender, EventArgs e)
        {
            NewCustomer NewCustomerObj = new NewCustomer();
            NewCustomerObj.ShowDialog();
        }

        private void ReportingClient_Load(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT CustomerName, CustomerNo, VehicleNo, VehicleType FROM Customer");
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
               ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                if (TextBoxCusName.Text != "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxVehicleType.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT CustomerName, CustomerNo, VehicleNo, VehicleType FROM Customer WHERE (CustomerName LIKE '%"+TextBoxCusName.Text+"%')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text != "" && TextBoxVehicleNo.Text == "" && TextBoxVehicleType.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT CustomerName, CustomerNo, VehicleNo, VehicleType FROM Customer WHERE (CustomerNo = '"+TextBoxCusContact.Text+"')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text != "" && TextBoxVehicleType.Text == "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT CustomerId, CustomerName, CustomerNo, VehicleNo, VehicleType FROM Customer WHERE (VehicleNo = '"+TextBoxVehicleNo.Text+"')");
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
                else if (TextBoxCusName.Text == "" && TextBoxCusContact.Text == "" && TextBoxVehicleNo.Text == "" && TextBoxVehicleType.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT CustomerId, CustomerName, CustomerNo, VehicleNo, VehicleType FROM Customer WHERE (VehicleType = '" + TextBoxVehicleType.Text + "')");
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

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            TextBoxCusName.Text = "";
            TextBoxCusContact.Text = "";
            TextBoxVehicleNo.Text = "";
            TextBoxVehicleType.Text = "";
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT CustomerName, CustomerNo, VehicleNo, VehicleType FROM Customer");
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
