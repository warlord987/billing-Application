namespace billing
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonInvoice = new System.Windows.Forms.Button();
            this.ButtonEstimate = new System.Windows.Forms.Button();
            this.LabelReports = new System.Windows.Forms.Label();
            this.LabelInvoices = new System.Windows.Forms.Label();
            this.LabelEstimates = new System.Windows.Forms.Label();
            this.LabelClients = new System.Windows.Forms.Label();
            this.LabelServices = new System.Windows.Forms.Label();
            this.LabelTools = new System.Windows.Forms.Label();
            this.LabelBackup = new System.Windows.Forms.Label();
            this.LabelRestore = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuButtonNew = new System.Windows.Forms.ToolStripMenuItem();
            this.newInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEstimateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSmsScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuButtonReporting = new System.Windows.Forms.ToolStripMenuItem();
            this.invoicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estimatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mounthlyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productServicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuButtonTools = new System.Windows.Forms.ToolStripMenuItem();
            this.backupDatabasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restoreDatabasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleSmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuButtonSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.companyDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuButtonHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.labelSchedule = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonInvoice
            // 
            this.ButtonInvoice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonInvoice.AutoSize = true;
            this.ButtonInvoice.BackColor = System.Drawing.Color.Firebrick;
            this.ButtonInvoice.Location = new System.Drawing.Point(488, 276);
            this.ButtonInvoice.Name = "ButtonInvoice";
            this.ButtonInvoice.Size = new System.Drawing.Size(185, 110);
            this.ButtonInvoice.TabIndex = 0;
            this.ButtonInvoice.Text = "New Invoice";
            this.ButtonInvoice.UseVisualStyleBackColor = false;
            this.ButtonInvoice.Click += new System.EventHandler(this.ButtonInvoice_Click);
            // 
            // ButtonEstimate
            // 
            this.ButtonEstimate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonEstimate.BackColor = System.Drawing.Color.Firebrick;
            this.ButtonEstimate.Location = new System.Drawing.Point(488, 431);
            this.ButtonEstimate.Name = "ButtonEstimate";
            this.ButtonEstimate.Size = new System.Drawing.Size(185, 40);
            this.ButtonEstimate.TabIndex = 2;
            this.ButtonEstimate.Text = "New Estimate";
            this.ButtonEstimate.UseVisualStyleBackColor = false;
            this.ButtonEstimate.Click += new System.EventHandler(this.ButtonEstimate_Click);
            // 
            // LabelReports
            // 
            this.LabelReports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelReports.AutoSize = true;
            this.LabelReports.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LabelReports.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelReports.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelReports.Location = new System.Drawing.Point(698, 306);
            this.LabelReports.Name = "LabelReports";
            this.LabelReports.Size = new System.Drawing.Size(82, 23);
            this.LabelReports.TabIndex = 4;
            this.LabelReports.Text = "Reports";
            // 
            // LabelInvoices
            // 
            this.LabelInvoices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelInvoices.AutoSize = true;
            this.LabelInvoices.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LabelInvoices.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelInvoices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelInvoices.Location = new System.Drawing.Point(723, 329);
            this.LabelInvoices.Name = "LabelInvoices";
            this.LabelInvoices.Size = new System.Drawing.Size(57, 16);
            this.LabelInvoices.TabIndex = 5;
            this.LabelInvoices.Text = "invoices";
            this.LabelInvoices.Click += new System.EventHandler(this.LabelInvoices_Click);
            this.LabelInvoices.MouseLeave += new System.EventHandler(this.LabelInvoices_MouseLeave);
            this.LabelInvoices.MouseHover += new System.EventHandler(this.LabelInvoices_MouseHover);
            // 
            // LabelEstimates
            // 
            this.LabelEstimates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelEstimates.AutoSize = true;
            this.LabelEstimates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelEstimates.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelEstimates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelEstimates.Location = new System.Drawing.Point(723, 345);
            this.LabelEstimates.Name = "LabelEstimates";
            this.LabelEstimates.Size = new System.Drawing.Size(68, 16);
            this.LabelEstimates.TabIndex = 6;
            this.LabelEstimates.Text = "Estimates";
            this.LabelEstimates.Click += new System.EventHandler(this.LabelEstimates_Click);
            // 
            // LabelClients
            // 
            this.LabelClients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelClients.AutoSize = true;
            this.LabelClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelClients.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelClients.Location = new System.Drawing.Point(723, 377);
            this.LabelClients.Name = "LabelClients";
            this.LabelClients.Size = new System.Drawing.Size(50, 16);
            this.LabelClients.TabIndex = 8;
            this.LabelClients.Text = "Clients";
            this.LabelClients.Click += new System.EventHandler(this.LabelClients_Click);
            // 
            // LabelServices
            // 
            this.LabelServices.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelServices.AutoSize = true;
            this.LabelServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelServices.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelServices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelServices.Location = new System.Drawing.Point(723, 393);
            this.LabelServices.Name = "LabelServices";
            this.LabelServices.Size = new System.Drawing.Size(119, 16);
            this.LabelServices.TabIndex = 10;
            this.LabelServices.Text = "Products/Services";
            this.LabelServices.Click += new System.EventHandler(this.LabelServices_Click);
            // 
            // LabelTools
            // 
            this.LabelTools.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTools.AutoSize = true;
            this.LabelTools.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LabelTools.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTools.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelTools.Location = new System.Drawing.Point(698, 425);
            this.LabelTools.Name = "LabelTools";
            this.LabelTools.Size = new System.Drawing.Size(58, 23);
            this.LabelTools.TabIndex = 7;
            this.LabelTools.Text = "Tools";
            // 
            // LabelBackup
            // 
            this.LabelBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelBackup.AutoSize = true;
            this.LabelBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelBackup.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelBackup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelBackup.Location = new System.Drawing.Point(723, 448);
            this.LabelBackup.Name = "LabelBackup";
            this.LabelBackup.Size = new System.Drawing.Size(112, 16);
            this.LabelBackup.TabIndex = 12;
            this.LabelBackup.Text = "Backup Database";
            this.LabelBackup.Click += new System.EventHandler(this.LabelBackup_Click);
            // 
            // LabelRestore
            // 
            this.LabelRestore.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelRestore.AutoSize = true;
            this.LabelRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelRestore.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelRestore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelRestore.Location = new System.Drawing.Point(723, 464);
            this.LabelRestore.Name = "LabelRestore";
            this.LabelRestore.Size = new System.Drawing.Size(120, 16);
            this.LabelRestore.TabIndex = 13;
            this.LabelRestore.Text = "Restore Databases";
            this.LabelRestore.Click += new System.EventHandler(this.LabelRestore_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuButtonNew,
            this.MenuButtonReporting,
            this.MenuButtonTools,
            this.scheduleSmsToolStripMenuItem,
            this.MenuButtonSetting,
            this.MenuButtonHelp,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1321, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuButtonNew
            // 
            this.MenuButtonNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newInvoiceToolStripMenuItem,
            this.newEstimateToolStripMenuItem,
            this.newSmsScheduleToolStripMenuItem});
            this.MenuButtonNew.Name = "MenuButtonNew";
            this.MenuButtonNew.Size = new System.Drawing.Size(49, 20);
            this.MenuButtonNew.Text = "+new";
            this.MenuButtonNew.Click += new System.EventHandler(this.MenuButtonNew_Click);
            // 
            // newInvoiceToolStripMenuItem
            // 
            this.newInvoiceToolStripMenuItem.Name = "newInvoiceToolStripMenuItem";
            this.newInvoiceToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newInvoiceToolStripMenuItem.Text = "+New invoice";
            this.newInvoiceToolStripMenuItem.Click += new System.EventHandler(this.newInvoiceToolStripMenuItem_Click);
            // 
            // newEstimateToolStripMenuItem
            // 
            this.newEstimateToolStripMenuItem.Name = "newEstimateToolStripMenuItem";
            this.newEstimateToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newEstimateToolStripMenuItem.Text = "+New Estimate";
            this.newEstimateToolStripMenuItem.Click += new System.EventHandler(this.newEstimateToolStripMenuItem_Click);
            // 
            // newSmsScheduleToolStripMenuItem
            // 
            this.newSmsScheduleToolStripMenuItem.Name = "newSmsScheduleToolStripMenuItem";
            this.newSmsScheduleToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.newSmsScheduleToolStripMenuItem.Text = "+New Sms Schedule";
            this.newSmsScheduleToolStripMenuItem.Click += new System.EventHandler(this.newSmsScheduleToolStripMenuItem_Click);
            // 
            // MenuButtonReporting
            // 
            this.MenuButtonReporting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.invoicesToolStripMenuItem,
            this.estimatesToolStripMenuItem,
            this.mounthlyReportToolStripMenuItem,
            this.clientsToolStripMenuItem,
            this.productServicesToolStripMenuItem});
            this.MenuButtonReporting.Name = "MenuButtonReporting";
            this.MenuButtonReporting.Size = new System.Drawing.Size(71, 20);
            this.MenuButtonReporting.Text = "Reporting";
            // 
            // invoicesToolStripMenuItem
            // 
            this.invoicesToolStripMenuItem.Name = "invoicesToolStripMenuItem";
            this.invoicesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.invoicesToolStripMenuItem.Text = "invoices";
            this.invoicesToolStripMenuItem.Click += new System.EventHandler(this.invoicesToolStripMenuItem_Click);
            // 
            // estimatesToolStripMenuItem
            // 
            this.estimatesToolStripMenuItem.Name = "estimatesToolStripMenuItem";
            this.estimatesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.estimatesToolStripMenuItem.Text = "Estimates";
            this.estimatesToolStripMenuItem.Click += new System.EventHandler(this.estimatesToolStripMenuItem_Click);
            // 
            // mounthlyReportToolStripMenuItem
            // 
            this.mounthlyReportToolStripMenuItem.Name = "mounthlyReportToolStripMenuItem";
            this.mounthlyReportToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.mounthlyReportToolStripMenuItem.Text = "Mounthly Report";
            // 
            // clientsToolStripMenuItem
            // 
            this.clientsToolStripMenuItem.Name = "clientsToolStripMenuItem";
            this.clientsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.clientsToolStripMenuItem.Text = "Clients";
            this.clientsToolStripMenuItem.Click += new System.EventHandler(this.clientsToolStripMenuItem_Click);
            // 
            // productServicesToolStripMenuItem
            // 
            this.productServicesToolStripMenuItem.Name = "productServicesToolStripMenuItem";
            this.productServicesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.productServicesToolStripMenuItem.Text = "Product/Services";
            this.productServicesToolStripMenuItem.Click += new System.EventHandler(this.productServicesToolStripMenuItem_Click);
            // 
            // MenuButtonTools
            // 
            this.MenuButtonTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backupDatabasesToolStripMenuItem,
            this.restoreDatabasesToolStripMenuItem});
            this.MenuButtonTools.Name = "MenuButtonTools";
            this.MenuButtonTools.Size = new System.Drawing.Size(47, 20);
            this.MenuButtonTools.Text = "Tools";
            // 
            // backupDatabasesToolStripMenuItem
            // 
            this.backupDatabasesToolStripMenuItem.Name = "backupDatabasesToolStripMenuItem";
            this.backupDatabasesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.backupDatabasesToolStripMenuItem.Text = "Backup Databases";
            this.backupDatabasesToolStripMenuItem.Click += new System.EventHandler(this.backupDatabasesToolStripMenuItem_Click);
            // 
            // restoreDatabasesToolStripMenuItem
            // 
            this.restoreDatabasesToolStripMenuItem.Name = "restoreDatabasesToolStripMenuItem";
            this.restoreDatabasesToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.restoreDatabasesToolStripMenuItem.Text = "Restore Databases";
            this.restoreDatabasesToolStripMenuItem.Click += new System.EventHandler(this.restoreDatabasesToolStripMenuItem_Click);
            // 
            // scheduleSmsToolStripMenuItem
            // 
            this.scheduleSmsToolStripMenuItem.Name = "scheduleSmsToolStripMenuItem";
            this.scheduleSmsToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.scheduleSmsToolStripMenuItem.Text = "Schedule Sms";
            this.scheduleSmsToolStripMenuItem.Click += new System.EventHandler(this.scheduleSmsToolStripMenuItem_Click);
            // 
            // MenuButtonSetting
            // 
            this.MenuButtonSetting.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.companyDetailsToolStripMenuItem});
            this.MenuButtonSetting.Name = "MenuButtonSetting";
            this.MenuButtonSetting.Size = new System.Drawing.Size(61, 20);
            this.MenuButtonSetting.Text = "Settings";
            // 
            // companyDetailsToolStripMenuItem
            // 
            this.companyDetailsToolStripMenuItem.Name = "companyDetailsToolStripMenuItem";
            this.companyDetailsToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.companyDetailsToolStripMenuItem.Text = "Company Details";
            // 
            // MenuButtonHelp
            // 
            this.MenuButtonHelp.Name = "MenuButtonHelp";
            this.MenuButtonHelp.Size = new System.Drawing.Size(44, 20);
            this.MenuButtonHelp.Text = "Help";
            this.MenuButtonHelp.Click += new System.EventHandler(this.MenuButtonHelp_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(488, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = " New Sms";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelSchedule
            // 
            this.labelSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelSchedule.AutoSize = true;
            this.labelSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSchedule.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelSchedule.Location = new System.Drawing.Point(723, 409);
            this.labelSchedule.Name = "labelSchedule";
            this.labelSchedule.Size = new System.Drawing.Size(99, 16);
            this.labelSchedule.TabIndex = 11;
            this.labelSchedule.Text = "Scheduled Sms";
            this.labelSchedule.Click += new System.EventHandler(this.labelSchedule_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.Location = new System.Drawing.Point(488, 473);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "New Voucher";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(723, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Mounthly Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1321, 825);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.labelSchedule);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LabelInvoices);
            this.Controls.Add(this.LabelRestore);
            this.Controls.Add(this.LabelBackup);
            this.Controls.Add(this.LabelTools);
            this.Controls.Add(this.LabelServices);
            this.Controls.Add(this.LabelClients);
            this.Controls.Add(this.LabelEstimates);
            this.Controls.Add(this.LabelReports);
            this.Controls.Add(this.ButtonEstimate);
            this.Controls.Add(this.ButtonInvoice);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "TecnoKraft";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseEnter += new System.EventHandler(this.LabelInvoices_MouseHover);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonInvoice;
        private System.Windows.Forms.Button ButtonEstimate;
        private System.Windows.Forms.Label LabelReports;
        private System.Windows.Forms.Label LabelInvoices;
        private System.Windows.Forms.Label LabelEstimates;
        private System.Windows.Forms.Label LabelClients;
        private System.Windows.Forms.Label LabelServices;
        private System.Windows.Forms.Label LabelTools;
        private System.Windows.Forms.Label LabelBackup;
        private System.Windows.Forms.Label LabelRestore;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuButtonNew;
        private System.Windows.Forms.ToolStripMenuItem MenuButtonReporting;
        private System.Windows.Forms.ToolStripMenuItem invoicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estimatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productServicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuButtonTools;
        private System.Windows.Forms.ToolStripMenuItem backupDatabasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restoreDatabasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuButtonSetting;
        private System.Windows.Forms.ToolStripMenuItem companyDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleSmsToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem newInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEstimateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newSmsScheduleToolStripMenuItem;
        private System.Windows.Forms.Label labelSchedule;
        private System.Windows.Forms.ToolStripMenuItem mounthlyReportToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

