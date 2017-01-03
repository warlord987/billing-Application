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
    public partial class NewLabour : Form
    {
        private DataTable laboursdata;

        public NewLabour()
        {
            InitializeComponent();
            getLaboursData();
            loadComboBoxLabourName(laboursdata);
        }

        public NewLabour(string labour)
        {
            InitializeComponent();
            getLaboursData();
            loadComboBoxLabourName(laboursdata);
        }

        public void loadComboBoxLabourName(DataTable LabourTable)
        {
            ComboBoxLabourName.Text = "";
            ComboBoxLabourName.Items.Clear();
            try
            {
                try
                {
                    DataRow[] labourRows = LabourTable.Select("LabourName");
                    foreach (DataRow row in labourRows)
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
            catch (Exception ex)
            {
                string output = ex.Message + " loadComboBoxLabourName"; MessageBox.Show(output);
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

        private void NewLabour_Load(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ComboBoxLabourName.Items.Contains(ComboBoxLabourName.Text))
            {
                try
                {
                    DataRow[] vehicleRowData = customerVehicleData.Select("VehicleType='" + ComboBoxVehicleModel.Text.Trim() + "' AND VehicleName='" + ComboBoxVehicleName.Text.Trim() + "'");
                    string selectedVehicleId = vehicleRowData[0]["Id"].ToString().Trim();
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        if (ComboBoxItemName.Items.Contains(ComboBoxItemName.Text))
                        {
                            DatabaseConnectObj.SqlQuery("UPDATE Items SET ItemPrice = '" + TextBoxUnitPrice.Text + "' WHERE (VehicleId = '" + selectedVehicleId + "')");
                            DatabaseConnectObj.ExecutNonQuery();
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("INSERT INTO Items (ItemName, ItemPrice,VehicleId) VALUES ('" + ComboBoxItemName.Text.Trim() + "','" + TextBoxUnitPrice.Text.Trim() + "','" + selectedVehicleId + "')");
                            DatabaseConnectObj.ExecutNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        ComboBoxVehicleModel.Text = "";
                        ComboBoxItemName.Text = "";
                        TextBoxUnitPrice.Text = "";
                        DatabaseConnectObj.DatabaseConnectionClose();
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a model from the drop down list");
            }
        }
    }
}
