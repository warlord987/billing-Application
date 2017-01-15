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
        private DataTable dataCustomerAndVehicle;
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
            loadCustomerAndVehicleData();
            dataGridClient.DataSource = dataCustomerAndVehicle;
        }

        private void loadComboBoxVehicleSelection()
        {
            ComboBoxVehicleSelection.Text = "";
            ComboBoxVehicleSelection.Items.Clear();
            try
            {
                    if (ComboBoxVehicleOption.Text == "Vehicle Type")
                    {
                        foreach (DataRow row in dataCustomerAndVehicle.Rows)
                        {
                            ComboBoxVehicleSelection.Items.Add(row["VehicleType"].ToString().Trim());
                        }
                    }
                    else
                    {
                        foreach (DataRow row in dataCustomerAndVehicle.Rows)
                        {
                            ComboBoxVehicleSelection.Items.Add(row["VehicleName"].ToString().Trim());
                        }
                    }
            }
            catch(Exception ex)
            {

            }
        }

        private void loadCustomerAndVehicleData()
        {
            ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
            try
            {
                DataTable dt = new DataTable();
                DatabaseConnectObj.SqlQuery("SELECT Customer.CustomerName, Customer.CustomerNo, Customer.VehicleNo, Vehicle.VehicleType, Vehicle.VehicleName FROM Customer INNER JOIN Vehicle ON Customer.VehicleId = Vehicle.Id");
                dt = DatabaseConnectObj.ExecuteQuery();
                dataCustomerAndVehicle = dt;
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

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                string query = "";
                if(TextBoxCusName.Text != "")
                {
                    query = "CustomerName LIKE '%" + TextBoxCusName.Text.Trim()+"%' AND ";
                }
                if(TextBoxCusContact.Text != "")
                {
                    query = query + "CustomerNo LIKE '%" + TextBoxCusContact.Text.Trim() + "%' AND ";
                }
                if(ComboBoxVehicleSelection.Text != "")
                {
                    if(ComboBoxVehicleOption.Text == "Vehicle Type")
                    {
                        query = query + "VehicleType = '" + ComboBoxVehicleSelection.Text.Trim() + "' AND ";
                    }
                    else
                    {
                        query = query + "VehicleName = '" + ComboBoxVehicleSelection.Text.Trim() + "' AND ";
                    }
                }
                if(TextBoxVehicleNo.Text != "")
                {
                    query = query + "VehicleNo LIKE '%" + TextBoxVehicleNo.Text.Trim()+"%'";
                }
                if(query.EndsWith("AND "))
                {
                    query = query.Remove(query.Length - 4);
                }
                DataRow[] result = dataCustomerAndVehicle.Select(query);
                if(result.Length>0)
                {
                    DataTable source = result.CopyToDataTable();
                    dataGridClient.DataSource = source;
                }
                else
                {
                    //expty source created nstead of null because null removes the column properties defined.
                    DataTable emptySource = new DataTable();
                    emptySource.Columns.Add("CustomerName");
                    emptySource.Columns.Add("CustomerNo");
                    emptySource.Columns.Add("VehicleNo");
                    emptySource.Columns.Add("VehicleName");
                    emptySource.Columns.Add("VehicleType");
                    dataGridClient.DataSource = emptySource;
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
            ComboBoxVehicleSelection.Text = "";
            ComboBoxVehicleOption.Text = "";
            dataGridClient.DataSource = dataCustomerAndVehicle;
        }

        private void ComboBoxVehicleOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboBoxVehicleSelection();
        }

        private void ReportingClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }

        private void TextBoxCusName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void TextBoxVehicleNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxVehicleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void TextBoxCusContact_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }
    }
}
