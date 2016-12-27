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
            if (!int.TryParse(TextBoxCusNo.Text, out n))
            {
                try
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        DatabaseConnectObj.SqlQuery("INSERT INTO Customer (CustomerName, CustomerNo, VehicleNo, VehicleType,VehicleName) VALUES ('" + TextBoxCusName.Text.Trim() + "','" + TextBoxCusNo.Text.Trim() + "','" + TextBoxVehicleNo.Text.Trim() + "','" + TextBoxVehicleType.Text.Trim() + "','" + TextBoxVehicleName.Text.Trim() + "')");
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
                        TextBoxVehicleType.Text = "";
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
            }
        }

        private void NewCustomer_Load(object sender, EventArgs e)
        {
        }

        private void TextBoxCusNo_Leave(object sender, EventArgs e)
        {
            if(TextBoxCusNo.Text.Length != 10)
            {
                MessageBox.Show("Check the Customer Number again");
                TextBoxCusNo.Text = "";
                TextBoxCusNo.Focus();
            }
        }

        private void NewCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);
        }
    }
}
