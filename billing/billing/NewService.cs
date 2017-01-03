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
    public partial class NewService : Form
    {
        private DataTable customerVehicleData;
        private DataTable CustomerItemData;
        private string p1;
        private string p2;
        private string p3;
        public NewService()
        {
            InitializeComponent();
            ButtonSave.DialogResult = DialogResult.OK;
            customerVehicleData = getCustomerVehicleData();
            CustomerItemData = getCustomerItemData();
            loadComboBoxVehicleModel(customerVehicleData);
            loadComboBoxVehicleName(customerVehicleData, "");
        }

        public NewService(string vehicleModel,string vehicleName)
        {
            InitializeComponent();
            ButtonSave.DialogResult = DialogResult.OK;
            customerVehicleData = getCustomerVehicleData();
            CustomerItemData = getCustomerItemData();
            loadComboBoxVehicleModel(customerVehicleData);
            loadComboBoxVehicleName(customerVehicleData, "");
            ComboBoxVehicleModel.Text = vehicleModel;
            ComboBoxVehicleName.Text = vehicleName;
            loadComboBoxItemName(CustomerItemData, customerVehicleData);
        }

        public NewService(string vehicleModel, string vehicleName, string newItemName)
        {
            InitializeComponent();
            ButtonSave.DialogResult = DialogResult.OK;
            customerVehicleData = getCustomerVehicleData();
            CustomerItemData = getCustomerItemData();
            loadComboBoxVehicleModel(customerVehicleData);
            loadComboBoxVehicleName(customerVehicleData, "");
            ComboBoxVehicleModel.Text = vehicleModel;
            ComboBoxVehicleName.Text = vehicleName;
            loadComboBoxItemName(CustomerItemData, customerVehicleData);
            ComboBoxItemName.Text = newItemName;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ComboBoxVehicleModel.Items.Contains(ComboBoxVehicleModel.Text) && ComboBoxVehicleName.Items.Contains(ComboBoxVehicleName.Text))
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

        private void NewService_Load(object sender, EventArgs e)
        {
           
        }

        private DataTable getCustomerVehicleData()
        {
            DataTable result = new DataTable();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DatabaseConnectObj.SqlQuery("SELECT Id,VehicleName,VehicleType FROM Vehicle");
                    result = DatabaseConnectObj.ExecuteQuery();
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

            return result;
        }

        private DataTable getCustomerItemData()
        {
            DataTable result = new DataTable();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DatabaseConnectObj.SqlQuery("SELECT ItemId, ItemName, ItemDesc, ItemPrice, VehicleId FROM Items");
                    result = DatabaseConnectObj.ExecuteQuery();
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

            return result;
        }

        private void loadComboBoxVehicleModel(DataTable data)
        {
            ComboBoxVehicleModel.Items.Clear();
            try
            {
                try
                {
                    DataTable VehicleTypeTable = data.DefaultView.ToTable(true, "VehicleType");
                    foreach (DataRow row in VehicleTypeTable.Rows)
                    {
                        ComboBoxVehicleModel.Items.Add(row["VehicleType"].ToString().Trim());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadComboBoxVehicleName(DataTable vehicleTable, String selector)
        {
            ComboBoxVehicleName.Text = "";
            ComboBoxVehicleName.Items.Clear();
            try
            {
                DataRow[] VehicleNames = vehicleTable.Select("VehicleType = '" + selector + "' AND VehicleName <> ''");
                foreach (DataRow row in VehicleNames)
                {
                    ComboBoxVehicleName.Items.Add(row["VehicleName"].ToString().Trim());
                }
                if (ComboBoxVehicleName.Items.Count > 0)
                {
                    ComboBoxVehicleName.Text = ComboBoxVehicleName.Items[0].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadComboBoxItemName(DataTable itemTable,DataTable vehicleTable)
        {
            ComboBoxItemName.Text = "";
            ComboBoxItemName.Items.Clear();
            try
            {
                DataRow[] vehicleRowData = vehicleTable.Select("VehicleType='" + ComboBoxVehicleModel.Text.Trim() + "' AND VehicleName='" + ComboBoxVehicleName.Text.Trim() + "'");
                string selectedVehicleId = vehicleRowData[0]["Id"].ToString().Trim();
                DataRow[] vehicleitem = itemTable.Select("VehicleId = '" + selectedVehicleId + "'");
                foreach (DataRow row in vehicleitem)
                {
                    ComboBoxItemName.Items.Add(row["ItemName"].ToString().Trim());
                }
                if (ComboBoxItemName.Items.Count > 0)
                {
                    ComboBoxItemName.Text = ComboBoxItemName.Items[0].ToString().Trim();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void NewService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }

        private void ComboBoxVehicleModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboBoxVehicleName(customerVehicleData, ComboBoxVehicleModel.Text.Trim());
        }

        private void ComboBoxVehicleName_Leave(object sender, EventArgs e)
        {
            if (ComboBoxVehicleName.Text.Trim() == "")
            {
                MessageBox.Show("Vehicle name cannot be empty, please enter a name.");
                ComboBoxVehicleName.Focus();
            }
            else if (!ComboBoxVehicleName.Items.Contains(ComboBoxVehicleName.Text.Trim().Trim()))
            {
                DialogResult result = MessageBox.Show("Selected Name does not exist for the cateegory of models " + ComboBoxVehicleModel.Text.Trim() + ", Do you want to add it?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string tempProduct = ComboBoxVehicleName.Text.Trim();
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DatabaseConnectObj.SqlQuery("INSERT INTO Vehicle (VehicleType, VehicleName) VALUES ('" + ComboBoxVehicleModel.Text.Trim() + "','" + ComboBoxVehicleName.Text.Trim() + "')");
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
                    DataRow newData = customerVehicleData.NewRow();
                    newData["VehicleType"] = ComboBoxVehicleModel.Text.Trim();
                    newData["VehicleName"] = ComboBoxVehicleName.Text.Trim();
                    customerVehicleData.Rows.Add(newData);
                    ComboBoxVehicleName.Items.Add(ComboBoxVehicleName.Text);
                }
                else
                {
                    ComboBoxVehicleName.Text = "";
                }
            }
        }

        private void ComboBoxVehicleModel_Leave(object sender, EventArgs e)
        {
            if (!ComboBoxVehicleModel.Items.Contains(ComboBoxVehicleModel.Text.Trim().Trim()))
            {
                DialogResult result = MessageBox.Show("Selected Model does not exist, Do you want to add it?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string tempProduct = ComboBoxVehicleModel.Text.Trim();
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DatabaseConnectObj.SqlQuery("INSERT INTO Vehicle (VehicleType) VALUES ('" + tempProduct + "')");
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
                    DataRow newData = customerVehicleData.NewRow();
                    newData["VehicleType"] = ComboBoxVehicleModel.Text.Trim();
                    newData["VehicleName"] = "";
                    customerVehicleData.Rows.Add(newData);
                    ComboBoxVehicleModel.Items.Add(ComboBoxVehicleModel.Text.Trim().Trim());
                }
                else
                {
                    ComboBoxVehicleModel.Text = "";
                }
            }
        }

        private void ComboBoxItemName_Enter(object sender, EventArgs e)
        {
            ComboBoxItemName.Items.Clear();
            loadComboBoxItemName(CustomerItemData, customerVehicleData);
        }

        private void ComboBoxVehicleName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxItemName.Items.Clear();
            loadComboBoxItemName(CustomerItemData, customerVehicleData);
        }

        private void ComboBoxItemName_Leave(object sender, EventArgs e)
        {
            if (!ComboBoxItemName.Items.Contains(ComboBoxItemName.Text))
            {
                TextBoxUnitPrice.Text = "";

            }
        }

        private void ComboBoxItemName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxItemName.Items.Contains(ComboBoxItemName.Text))
            {
                DataRow[] vehicleRowData = customerVehicleData.Select("VehicleType='" + ComboBoxVehicleModel.Text.Trim() + "' AND VehicleName='" + ComboBoxVehicleName.Text.Trim() + "'");
                string selectedVehicleId = vehicleRowData[0]["Id"].ToString().Trim();
                DataRow[] itemRowData = CustomerItemData.Select("VehicleId = '" + selectedVehicleId + "' AND ItemName = '" + ComboBoxItemName.Text.Trim() + "'");
                TextBoxUnitPrice.Text = itemRowData[0]["ItemPrice"].ToString().Trim();
            }
            else
            {
                TextBoxUnitPrice.Text = "";
            }
        }
    }
}
