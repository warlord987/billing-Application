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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void LabelInvoices_MouseHover(object sender, EventArgs e)
        {
            LabelInvoices.ForeColor = Color.Gray;
        }

        private void LabelInvoices_MouseLeave(object sender, EventArgs e)
        {
            LabelInvoices.ForeColor = Color.Blue;
        }

        private void LabelInvoices_Click(object sender, EventArgs e)
        {
            ReportingInvoice ReportingInvoiceObj = new ReportingInvoice();
            ReportingInvoiceObj.ShowDialog();
        }

        private void LabelEstimates_Click(object sender, EventArgs e)
        {
            ReportingEstimate ReportingEstimateObj = new ReportingEstimate();
            ReportingEstimateObj.ShowDialog();
        }

        private void LabelClients_Click(object sender, EventArgs e)
        {
            ReportingClient ReportingClientObj = new ReportingClient();
            ReportingClientObj.ShowDialog();
        }

        private void LabelServices_Click(object sender, EventArgs e)
        {
            ReportingService ReportingServiceObj = new ReportingService();
            ReportingServiceObj.ShowDialog();
        }

        private void LabelBackup_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog op = new FolderBrowserDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        DatabaseConnectObj.SqlQuery(@"BACKUP DATABASE [F:\DATA\BILLINGDATABASE.MDF] TO  DISK = '" + op.SelectedPath.ToString() + @"\Backup_" + DateTime.Today.Date.ToShortDateString() + ".bak'");
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
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

        private void LabelRestore_Click(object sender, EventArgs e)
        {
            //RESTORE DATABASE AdventureWorks FROM DISK = 
            SaveFileDialog op = new SaveFileDialog();
            if(op.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    ClassDatabaseConnection DatabaseConnectObj = new ClassDatabaseConnection();
                    try
                    {
                        DatabaseConnectObj.SqlQuery(@"RESTORE DATABASE AdventureWorks FROM DISK = '"+op.FileName+"'");
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
                catch (Exception es)
                {
                    MessageBox.Show(es.Message);
                }
            }
        }

    

        private void MenuButtonNew_Click(object sender, EventArgs e)
        {

        }

        private void invoicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportingInvoice ReportingInvoiceObj = new ReportingInvoice();
            ReportingInvoiceObj.ShowDialog();
        }

        private void estimatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportingEstimate ReportingEstimateObj = new ReportingEstimate();
            ReportingEstimateObj.ShowDialog();
        }

        private void clientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportingClient ReportingClientObj = new ReportingClient();
            ReportingClientObj.ShowDialog();
        }

        private void productServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportingService ReportingServiceObj = new ReportingService();
            ReportingServiceObj.ShowDialog();
        }

        private void backupDatabasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void restoreDatabasesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void MenuButtonHelp_Click(object sender, EventArgs e)
        {
            Help HelpObj = new Help();
            HelpObj.ShowDialog();
        }

        private void ButtonInvoice_Click(object sender, EventArgs e)
        {
                NewInvioce NewInvoiceObj = new NewInvioce();
                NewInvoiceObj.ShowDialog();
            
        }

        private void ButtonEstimate_Click(object sender, EventArgs e)
        {
            NewEstimate NewEstimateObj = new NewEstimate();
            NewEstimateObj.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void scheduleSmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScheduleSms ScheduleSmsObj = new ScheduleSms();
            ScheduleSmsObj.ShowDialog();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            ScheduleSms NewSmsScheduleObj = new ScheduleSms();
            NewSmsScheduleObj.ShowDialog();
        }

        private void newInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewInvioce NewInvoiceObj = new NewInvioce();
            NewInvoiceObj.ShowDialog();
        }

        private void newEstimateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewEstimate NewEstimateObj = new NewEstimate();
            NewEstimateObj.ShowDialog();
        }

        private void newSmsScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SchedulerSmsReport NewSmsScheduleObj = new SchedulerSmsReport();
            NewSmsScheduleObj.ShowDialog();
        }

        private void labelSchedule_Click(object sender, EventArgs e)
        {
            SchedulerSmsReport ScheduledSmsObj = new SchedulerSmsReport();
            ScheduledSmsObj.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MountlyReport MountlyReportObj = new MountlyReport();
            MountlyReportObj.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewVoucher NewVoucherObj = new NewVoucher();
            NewVoucherObj.ShowDialog();
        }
    }
}
