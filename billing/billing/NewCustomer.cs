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
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        private void ButtonSave_Click_1(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(TextBoxCusNo.Text, out n)) //check if the input is number or characters
            {
                try
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        if (ComboBoxVehicleName.Text == "")
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Id FROM Vehicle WHERE (VehicleType = '" + ComboBoxVehicleModel.Text + "') AND (VehicleName is NULL)");
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("SELECT Id FROM Vehicle WHERE (VehicleType = '" + ComboBoxVehicleModel.Text + "') AND (VehicleName = '" + ComboBoxVehicleName.Text + "')");
                        }
                        DataTable result = DatabaseConnectObj.ExecuteQuery();
                        DatabaseConnectObj.SqlQuery("INSERT INTO Customer (CustomerName, CustomerNo, VehicleNo, VehicleId) VALUES ('" + TextBoxCusName.Text + "','" + TextBoxCusNo.Text + "','" + TextBoxVehicleNo.Text + "','" + result.Rows[0]["Id"].ToString().Trim() + "')");
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

        private void loadComboBoxVehicleModel()
        {
            ComboBoxVehicleModel.Items.Clear();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT DISTINCT VehicleType FROM Vehicle");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        ComboBoxVehicleModel.Items.Add(row["VehicleType"].ToString().Trim());
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

        private void loadComboBoxVehicleName()
        {
            ComboBoxVehicleName.Items.Clear();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT DISTINCT VehicleName FROM Vehicle");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        ComboBoxVehicleName.Items.Add(row["VehicleName"].ToString().Trim());
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

        private void NewCustomer_Load(object sender, EventArgs e)
        {
            loadComboBoxVehicleModel();
            loadComboBoxVehicleName();
        }

        private void TextBoxCusNo_Leave(object sender, EventArgs e)
        {
            if(TextBoxCusNo.Text.Length != 10)
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
                    ComboBoxVehicleModel.Items.Add(tempProduct);
                    loadComboBoxVehicleName();
                }
                else
                {
                    ComboBoxVehicleModel.Text = "";
                }
            }
        }

        private void ComboBoxVehicleName_Leave(object sender, EventArgs e)
        {
            if (!ComboBoxVehicleName.Items.Contains(ComboBoxVehicleName.Text.Trim()))
            {
                DialogResult result = MessageBox.Show("Selected Name does not exist for the cateegory of models "+ComboBoxVehicleModel.Text+", Do you want to add it?", "Delete Confirmation", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string tempProduct = ComboBoxVehicleName.Text;
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DatabaseConnectObj.SqlQuery("INSERT INTO Vehicle (VehicleType, VehicleName) VALUES ('"+ComboBoxVehicleModel.Text+"','"+ComboBoxVehicleName.Text+"')");
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
                    ComboBoxVehicleName.Items.Add(tempProduct);
                }
                else
                {
                    ComboBoxVehicleName.Text = "";
                }
            }
        }
    }
}
