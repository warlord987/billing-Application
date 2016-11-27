namespace billing
{
    partial class NewEstimate
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewEstimate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxRemark = new System.Windows.Forms.RichTextBox();
            this.ComboboxDesc = new System.Windows.Forms.ComboBox();
            this.ComboBoxClientName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxSubTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimePickerIssued = new System.Windows.Forms.DateTimePicker();
            this.LabelHidden = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.billDetailsEstimateTableAdapter1 = new billing.BillingDatabaseDataSetTableAdapters.BillDetailsEstimateTableAdapter();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.billingDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonPreview = new System.Windows.Forms.Button();
            this.CheckBoxSchedule = new System.Windows.Forms.CheckBox();
            this.NumericUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimePickerSchedule = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.PrintDocumentEstimate = new System.Drawing.Printing.PrintDocument();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.NumericEstimateNo = new System.Windows.Forms.NumericUpDown();
            this.ComboBoxProduct = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboboxTax = new System.Windows.Forms.ComboBox();
            this.PrintPreviewEstimate = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.billingDatabaseDataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEstimateNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(6, 542);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 16);
            this.label17.TabIndex = 87;
            this.label17.Text = "Remark";
            // 
            // TextBoxRemark
            // 
            this.TextBoxRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxRemark.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.TextBoxRemark.Location = new System.Drawing.Point(6, 561);
            this.TextBoxRemark.Name = "TextBoxRemark";
            this.TextBoxRemark.Size = new System.Drawing.Size(510, 45);
            this.TextBoxRemark.TabIndex = 14;
            this.TextBoxRemark.Text = "";
            this.TextBoxRemark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewEstimate_KeyPress);
            // 
            // ComboboxDesc
            // 
            this.ComboboxDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboboxDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboboxDesc.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboboxDesc.FormattingEnabled = true;
            this.ComboboxDesc.Location = new System.Drawing.Point(160, 132);
            this.ComboboxDesc.Name = "ComboboxDesc";
            this.ComboboxDesc.Size = new System.Drawing.Size(214, 20);
            this.ComboboxDesc.TabIndex = 7;
            this.ComboboxDesc.SelectedIndexChanged += new System.EventHandler(this.ComboboxDesc_SelectedIndexChanged);
            this.ComboboxDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewEstimate_KeyPress);
            // 
            // ComboBoxClientName
            // 
            this.ComboBoxClientName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxClientName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxClientName.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxClientName.FormattingEnabled = true;
            this.ComboBoxClientName.Location = new System.Drawing.Point(105, 26);
            this.ComboBoxClientName.Name = "ComboBoxClientName";
            this.ComboBoxClientName.Size = new System.Drawing.Size(202, 20);
            this.ComboBoxClientName.TabIndex = 0;
            this.ComboBoxClientName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClientName_SelectedIndexChanged_1);
            this.ComboBoxClientName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewEstimate_KeyPress);
            this.ComboBoxClientName.Leave += new System.EventHandler(this.ComboBoxClientName_Leave);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(757, 561);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 66;
            this.label9.Text = "Rs";
            // 
            // TextBoxSubTotal
            // 
            this.TextBoxSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxSubTotal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxSubTotal.Location = new System.Drawing.Point(594, 560);
            this.TextBoxSubTotal.Name = "TextBoxSubTotal";
            this.TextBoxSubTotal.ReadOnly = true;
            this.TextBoxSubTotal.Size = new System.Drawing.Size(159, 20);
            this.TextBoxSubTotal.TabIndex = 15;
            this.TextBoxSubTotal.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(522, 561);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 16);
            this.label11.TabIndex = 64;
            this.label11.Text = "Sub Total";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonAdd.Location = new System.Drawing.Point(687, 133);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(92, 23);
            this.ButtonAdd.TabIndex = 12;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click_1);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(522, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 58;
            this.label8.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(411, 113);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 57;
            this.label7.Text = "Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(160, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 56;
            this.label6.Text = "Desc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(1, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 54;
            this.label5.Text = "Model";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(-22, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(829, 12);
            this.label1.TabIndex = 53;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // DateTimePickerIssued
            // 
            this.DateTimePickerIssued.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerIssued.CalendarFont = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerIssued.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.DateTimePickerIssued.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerIssued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerIssued.Location = new System.Drawing.Point(433, 49);
            this.DateTimePickerIssued.Name = "DateTimePickerIssued";
            this.DateTimePickerIssued.Size = new System.Drawing.Size(93, 20);
            this.DateTimePickerIssued.TabIndex = 4;
            // 
            // LabelHidden
            // 
            this.LabelHidden.AutoSize = true;
            this.LabelHidden.Font = new System.Drawing.Font("Cambria", 8F);
            this.LabelHidden.ForeColor = System.Drawing.Color.DimGray;
            this.LabelHidden.Location = new System.Drawing.Point(112, 48);
            this.LabelHidden.Name = "LabelHidden";
            this.LabelHidden.Size = new System.Drawing.Size(0, 12);
            this.LabelHidden.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(341, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Issued Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(341, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 30;
            this.label3.Text = "Estimate No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(16, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Client Name";
            // 
            // billDetailsEstimateTableAdapter1
            // 
            this.billDetailsEstimateTableAdapter1.ClearBeforeFill = true;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Location = new System.Drawing.Point(564, 625);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(110, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonPreview
            // 
            this.ButtonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPreview.Enabled = false;
            this.ButtonPreview.Location = new System.Drawing.Point(686, 625);
            this.ButtonPreview.Name = "ButtonPreview";
            this.ButtonPreview.Size = new System.Drawing.Size(110, 23);
            this.ButtonPreview.TabIndex = 2;
            this.ButtonPreview.Text = "Preview";
            this.ButtonPreview.UseVisualStyleBackColor = true;
            this.ButtonPreview.Click += new System.EventHandler(this.ButtonPreview_Click);
            // 
            // CheckBoxSchedule
            // 
            this.CheckBoxSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxSchedule.AutoSize = true;
            this.CheckBoxSchedule.Checked = true;
            this.CheckBoxSchedule.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckBoxSchedule.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.CheckBoxSchedule.Location = new System.Drawing.Point(532, 23);
            this.CheckBoxSchedule.Name = "CheckBoxSchedule";
            this.CheckBoxSchedule.Size = new System.Drawing.Size(113, 20);
            this.CheckBoxSchedule.TabIndex = 3;
            this.CheckBoxSchedule.Text = "Schedule Text";
            this.CheckBoxSchedule.UseVisualStyleBackColor = true;
            // 
            // NumericUnitPrice
            // 
            this.NumericUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUnitPrice.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.NumericUnitPrice.Location = new System.Drawing.Point(525, 134);
            this.NumericUnitPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericUnitPrice.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUnitPrice.Name = "NumericUnitPrice";
            this.NumericUnitPrice.Size = new System.Drawing.Size(105, 20);
            this.NumericUnitPrice.TabIndex = 10;
            this.NumericUnitPrice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // NumericQuantity
            // 
            this.NumericQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericQuantity.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.NumericQuantity.Location = new System.Drawing.Point(414, 133);
            this.NumericQuantity.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericQuantity.Name = "NumericQuantity";
            this.NumericQuantity.Size = new System.Drawing.Size(105, 20);
            this.NumericQuantity.TabIndex = 9;
            this.NumericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            // 
            // dateTimePickerSchedule
            // 
            this.dateTimePickerSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerSchedule.CalendarFont = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerSchedule.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.dateTimePickerSchedule.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.dateTimePickerSchedule.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSchedule.Location = new System.Drawing.Point(646, 47);
            this.dateTimePickerSchedule.Name = "dateTimePickerSchedule";
            this.dateTimePickerSchedule.Size = new System.Drawing.Size(93, 20);
            this.dateTimePickerSchedule.TabIndex = 5;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(536, 51);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(104, 16);
            this.label16.TabIndex = 83;
            this.label16.Text = "Scheduled Date";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(757, 587);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 16);
            this.label10.TabIndex = 73;
            this.label10.Text = "Rs";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTotal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxTotal.Location = new System.Drawing.Point(594, 586);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.ReadOnly = true;
            this.TextBoxTotal.Size = new System.Drawing.Size(159, 20);
            this.TextBoxTotal.TabIndex = 16;
            this.TextBoxTotal.Text = "0";
            // 
            // PrintDocumentEstimate
            // 
            this.PrintDocumentEstimate.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentEstimate_PrintPage);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.NumericEstimateNo);
            this.groupBox1.Controls.Add(this.ComboBoxProduct);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TextBoxRemark);
            this.groupBox1.Controls.Add(this.ComboboxDesc);
            this.groupBox1.Controls.Add(this.dateTimePickerSchedule);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.CheckBoxSchedule);
            this.groupBox1.Controls.Add(this.NumericUnitPrice);
            this.groupBox1.Controls.Add(this.NumericQuantity);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.TextBoxTotal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ComboboxTax);
            this.groupBox1.Controls.Add(this.ComboBoxClientName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TextBoxSubTotal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.ButtonAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DateTimePickerIssued);
            this.groupBox1.Controls.Add(this.LabelHidden);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 612);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Invoice";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(377, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(28, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(313, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumericEstimateNo
            // 
            this.NumericEstimateNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericEstimateNo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.NumericEstimateNo.Location = new System.Drawing.Point(433, 23);
            this.NumericEstimateNo.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NumericEstimateNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericEstimateNo.Name = "NumericEstimateNo";
            this.NumericEstimateNo.Size = new System.Drawing.Size(93, 20);
            this.NumericEstimateNo.TabIndex = 2;
            this.NumericEstimateNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxProduct.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxProduct.FormattingEnabled = true;
            this.ComboBoxProduct.Location = new System.Drawing.Point(4, 132);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Size = new System.Drawing.Size(153, 20);
            this.ComboBoxProduct.TabIndex = 6;
            this.ComboBoxProduct.TextChanged += new System.EventHandler(this.ComboBoxProduct_TextChanged);
            this.ComboBoxProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewEstimate_KeyPress);
            this.ComboBoxProduct.Leave += new System.EventHandler(this.ComboBoxProduct_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Desc,
            this.Quantity,
            this.UnitPrice,
            this.Tax,
            this.Total,
            this.Itemid});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(4, 161);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(776, 375);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.FillWeight = 172.9541F;
            this.Desc.HeaderText = "Desc";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.FillWeight = 57.58379F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 89;
            // 
            // UnitPrice
            // 
            this.UnitPrice.FillWeight = 66.09364F;
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 125;
            // 
            // Tax
            // 
            this.Tax.HeaderText = "Tax";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 70;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Itemid
            // 
            this.Itemid.HeaderText = "itemid";
            this.Itemid.Name = "Itemid";
            this.Itemid.ReadOnly = true;
            this.Itemid.Visible = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label12.Location = new System.Drawing.Point(546, 587);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 16);
            this.label12.TabIndex = 71;
            this.label12.Text = "Total";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(633, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 70;
            this.label13.Text = "Tax";
            // 
            // ComboboxTax
            // 
            this.ComboboxTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComboboxTax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboboxTax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboboxTax.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboboxTax.FormattingEnabled = true;
            this.ComboboxTax.Items.AddRange(new object[] {
            "14.5",
            "5.5"});
            this.ComboboxTax.Location = new System.Drawing.Point(636, 134);
            this.ComboboxTax.Name = "ComboboxTax";
            this.ComboboxTax.Size = new System.Drawing.Size(45, 20);
            this.ComboboxTax.TabIndex = 11;
            this.ComboboxTax.Text = "14.5";
            // 
            // PrintPreviewEstimate
            // 
            this.PrintPreviewEstimate.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewEstimate.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewEstimate.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewEstimate.Enabled = true;
            this.PrintPreviewEstimate.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewEstimate.Icon")));
            this.PrintPreviewEstimate.Name = "PrintPreviewInvoice";
            this.PrintPreviewEstimate.Visible = false;
            this.PrintPreviewEstimate.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PrintPreviewEstimate_FormClosed);
            // 
            // NewEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(806, 655);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonPreview);
            this.Controls.Add(this.groupBox1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 694);
            this.Name = "NewEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewEstimate";
            this.Load += new System.EventHandler(this.NewEstimate_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewEstimate_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.billingDatabaseDataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericEstimateNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox TextBoxRemark;
        private System.Windows.Forms.ComboBox ComboboxDesc;
        private System.Windows.Forms.ComboBox ComboBoxClientName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxSubTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePickerIssued;
        private System.Windows.Forms.Label LabelHidden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private BillingDatabaseDataSetTableAdapters.BillDetailsEstimateTableAdapter billDetailsEstimateTableAdapter1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.BindingSource billingDatabaseDataSet2BindingSource;
        private System.Windows.Forms.Button ButtonPreview;
        private System.Windows.Forms.CheckBox CheckBoxSchedule;
        private System.Windows.Forms.NumericUpDown NumericUnitPrice;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.DateTimePicker dateTimePickerSchedule;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TextBoxTotal;
        private System.Drawing.Printing.PrintDocument PrintDocumentEstimate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboboxTax;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewEstimate;
        private System.Windows.Forms.ComboBox ComboBoxProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemid;
        private System.Windows.Forms.NumericUpDown NumericEstimateNo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;

    }
}