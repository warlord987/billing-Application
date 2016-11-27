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
        public NewService()
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if (ComboboxProduct.Items.Contains(ComboboxProduct.Text))
            {
                try
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        DatabaseConnectObj.SqlQuery("INSERT INTO Items (ItemName, ItemDesc, ItemPrice) VALUES ('" + ComboboxProduct.Text.Trim() + "','" + TextBoxDesc.Text.Trim() + "','" + TextBoxUnitPrice.Text.Trim() + "')");
                        DatabaseConnectObj.ExecutNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {

                        ComboboxProduct.Text = "";
                        TextBoxDesc.Text = "";
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
            ButtonSave.Focus();
            LoadComboModel();
        }

        private void LoadComboModel()
        {
            ComboboxProduct.Items.Clear();
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT DISTINCT ItemName FROM Items"); //select distinct product from items
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        ComboboxProduct.Items.Add(row["ItemName"].ToString());
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

        private void NewService_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }
    }
}
