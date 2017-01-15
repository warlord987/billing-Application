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
                try
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        if (ComboBoxLabourName.Items.Contains(ComboBoxLabourName.Text))
                        {
                            DatabaseConnectObj.SqlQuery("UPDATE Labour SET LabourPrice = '"+TextBoxUnitPrice.Text.Trim()+"' WHERE (LabourName = '"+ComboBoxLabourName.Text.Trim()+"') ");
                            DatabaseConnectObj.ExecutNonQuery();
                        }
                        else
                        {
                            DatabaseConnectObj.SqlQuery("INSERT INTO Labour (LabourName, LabourDesc, LabourPrice) VALUES ('"+ComboBoxLabourName.Text.Trim()+"','','"+TextBoxUnitPrice.Text.Trim()+"')");
                            DatabaseConnectObj.ExecutNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        ComboBoxLabourName.Text = "";
                        TextBoxUnitPrice.Text = "";
                        DatabaseConnectObj.DatabaseConnectionClose();
                    }
                }
                catch (Exception ex)
                {
                    string output = ex.Message + " ButtonSave_Click"; MessageBox.Show(output);
                }
        }

        private void ComboBoxLabourName_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextBoxUnitPrice.Text = laboursdata.Select("LabourName = '" + ComboBoxLabourName.Text + "'")[0]["LabourPrice"].ToString().Trim();
        }

        private void NewLabour_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
