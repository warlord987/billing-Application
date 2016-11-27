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
    public partial class SelectCustomer : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }

        public SelectCustomer()
        {
            InitializeComponent();
        }

        private void SelectCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT CustomerName, CustomerNo, VehicleNo FROM Customer");
                    dt = DatabaseConnectObj.ExecuteQuery();
                    foreach (DataRow row in dt.Rows)
                    {
                        CheckBoxListCusList.Items.Add(row["CustomerName"].ToString().Trim() + "     (" + row["VehicleNo"].ToString() + ")");
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

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            String temp = "";
            for (int i = 0; i < CheckBoxListCusList.Items.Count; i++)
            {
                if (CheckBoxListCusList.GetItemChecked(i))
                {
                    String[] sub = CheckBoxListCusList.Items[i].ToString().Split('(');
                    String[] temp2 = sub[1].Split(')');
                    try
                    {
                        ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                        try
                        {
                            DataTable dt = new DataTable();
                            DatabaseConnectObj.SqlQuery("SELECT CustomerNo FROM Customer where VehicleNo = '" + temp2[0].Trim() + "'");
                            dt = DatabaseConnectObj.ExecuteQuery();
                            DataRow row = dt.Rows[0];
                            temp = temp + " " + row["CustomerNo"].ToString()+",";
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
            this.Close();
        }
    }
}
