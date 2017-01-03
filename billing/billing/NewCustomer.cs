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
    public partial class NewCustomer : Form
    {
        public NewCustomer()
        {
            InitializeComponent();
            ButtonSave.DialogResult = DialogResult.OK;
            customerVehicleData = getCustomerVehicleData();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private void ButtonSave_Click_1(object sender, EventArgs e)
        {
            Int64 n;
            string temp = TextBoxCusNo.Text.Trim();
            bool flag = Int64.TryParse(temp, out n);
            if(TextBoxVehicleNo.Text.Trim()=="")
            {
                MessageBox.Show("please enter a vehicle number");
                TextBoxVehicleNo.Focus();
                
            }
            else if (flag) //check if the input is number or characters
            {
                try
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        if (ComboBoxVehicleName.Text.Trim() == "")
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Id FROM Vehicle WHERE (VehicleType = '" + ComboBoxVehicleModel.Text.Trim() + "') AND (VehicleName is NULL)");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Id FROM Vehicle WHERE (VehicleType = '" + ComboBoxVehicleModel.Text.Trim() + "') AND (VehicleName = '" + ComboBoxVehicleName.Text.Trim() + "')");
                        }
                        DataTable result = DatabaseConnectObj.ExecuteQuery();
                        DatabaseConnectObj.SqlQuery("INSERT INTO Customer (CustomerName, CustomerNo, VehicleNo, VehicleId) VALUES ('" + TextBoxCusName.Text.Trim() + "','" + TextBoxCusNo.Text.Trim() + "','" + TextBoxVehicleNo.Text.Trim() + "','" + result.Rows[0]["Id"].ToString().Trim() + "')");
                        DatabaseConnectObj.ExecutNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        TextBoxCusName.Text = "";
                        TextBoxCusNo.Text = "";
                        TextBoxVehicleNo.Text = "";
                        ComboBoxVehicleModel.Text = "";
                        ComboBoxVehicleName.Text = "";
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
            else
            {
                MessageBox.Show("enter a valid customer contact number");
                TextBoxVehicleNo.Focus();
            }
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

        private DataTable getCustomerVehicleData()
        {
            DataTable result = new DataTable();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DatabaseConnectObj.SqlQuery("SELECT VehicleName,VehicleType FROM Vehicle");
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

        private void loadComboBoxVehicleName(DataTable data,String selector)
        {
            ComboBoxVehicleName.Text = "";
            ComboBoxVehicleName.Items.Clear();
            try
            {
                try
                {
                    DataRow[] VehicleNames = data.Select("VehicleType = '" + selector+"' AND VehicleName <> ''");
                    foreach (DataRow row in VehicleNames)
                    {
                        ComboBoxVehicleName.Items.Add(row["VehicleName"].ToString().Trim());
                    }
                    if(ComboBoxVehicleName.Items.Count>0)
                    {
                        ComboBoxVehicleName.Text = ComboBoxVehicleName.Items[0].ToString().Trim();
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

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            loadComboBoxVehicleModel(customerVehicleData);
            loadComboBoxVehicleName(customerVehicleData,"");
        }

        private void TextBoxCusNo_Leave(object sender, EventArgs e)
        {
            if(TextBoxCusNo.Text.Trim().Length != 10)
            {
                MessageBox.Show("Please Check the Customer Number again, it has less that 10 numbers");
                TextBoxCusNo.Text = "";
                TextBoxCusNo.Focus();
            }
        }

        private void NewCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
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
                            DatabaseConnectObj.SqlQuery("INSERT INTO Vehicle (VehicleType) VALUES ('"+tempProduct+"')");
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

        private void ComboBoxVehicleName_Leave(object sender, EventArgs e)
        {
            if (ComboBoxVehicleName.Text.Trim() == "")
            {
                MessageBox.Show("Vehicle name cannot be empty, please enter a name.");
                ComboBoxVehicleName.Focus();
            }
            else if (!ComboBoxVehicleName.Items.Contains(ComboBoxVehicleName.Text.Trim().Trim()))
            {
                DialogResult result = MessageBox.Show("Selected Name does not exist for the cateegory of models "+ComboBoxVehicleModel.Text.Trim()+", Do you want to add it?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string tempProduct = ComboBoxVehicleName.Text.Trim();
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DatabaseConnectObj.SqlQuery("INSERT INTO Vehicle (VehicleType, VehicleName) VALUES ('"+ComboBoxVehicleModel.Text.Trim()+"','"+ComboBoxVehicleName.Text.Trim()+"')");
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

        public DataTable customerVehicleData { get; set; }

        private void ComboBoxVehicleModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadComboBoxVehicleName(customerVehicleData, ComboBoxVehicleModel.Text.Trim());
        }

        private void ComboBoxVehicleName_Enter(object sender, EventArgs e)
        {
            loadComboBoxVehicleName(customerVehicleData, ComboBoxVehicleModel.Text.Trim());
        }
    }
}
