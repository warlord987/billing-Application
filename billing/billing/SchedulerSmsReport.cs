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
    public partial class SchedulerSmsReport : Form
    {
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape) this.Close();
            bool res = base.ProcessCmdKey(ref msg, keyData);
            return res;
        }
        public SchedulerSmsReport()
        {
            InitializeComponent();
        }

        private void SchedulerSmsReport_Load(object sender, EventArgs e)
        {

            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT VehicleNo, Date FROM Schedule");
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
                String DateTo = "";
                String DateFrom = "";
                DateTo = DateTimePickerTo.Value.Month.ToString() + "/" + DateTimePickerTo.Value.Day.ToString() + "/" + DateTimePickerTo.Value.Year.ToString();
                DateFrom = DateTimePickerFrom.Value.Month.ToString() + "/" + DateTimePickerFrom.Value.Day.ToString() + "/" + DateTimePickerFrom.Value.Year.ToString();
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                if (TextBoxVehicleNo.Text != "")
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT VehicleNo, Date FROM Schedule WHERE (VehicleNo = '" + TextBoxVehicleNo.Text + "') AND (Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
                else
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        DatabaseConnectObj.SqlQuery("SELECT VehicleNo, Date FROM Schedule WHERE (Date BETWEEN '" + DateFrom + "' AND '" + DateTo + "')");
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
            TextBoxVehicleNo.Text = "";
            try
            {
                ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                try
                {
                    DataTable dt = new DataTable();
                    DatabaseConnectObj.SqlQuery("SELECT VehicleNo, Date FROM Schedule");
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

        private void TextBoxVehicleNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = char.ToUpper(e.KeyChar);

        }
    }
}

