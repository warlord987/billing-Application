namespace billing
{
    partial class Edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PrintDocumentInvoice = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewInvoice = new System.Windows.Forms.PrintPreviewDialog();
            this.ButtonPreview = new System.Windows.Forms.Button();
            this.DateTimePickerIssued = new System.Windows.Forms.DateTimePicker();
            this.LabelHidden = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxNo = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.billingDatabaseDataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LableInvoiceId = new System.Windows.Forms.Label();
            this.ComboBoxProduct = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.NumericUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.NumericQuantity = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.ComboboxTax = new System.Windows.Forms.ComboBox();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ComboboxDesc = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.TextBoxRemark = new System.Windows.Forms.RichTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Itemid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextBoxCusName = new System.Windows.Forms.TextBox();
            this.PrintDocumentInvoice1 = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewInvoice1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ButtonMakeInvoice = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDatabaseDataSet2BindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            // 
            // PrintPreviewInvoice
            // 
            this.PrintPreviewInvoice.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewInvoice.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewInvoice.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewInvoice.Enabled = true;
            this.PrintPreviewInvoice.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewInvoice.Icon")));
            this.PrintPreviewInvoice.Name = "PrintPreviewInvoice";
            this.PrintPreviewInvoice.Visible = false;
            // 
            // ButtonPreview
            // 
            this.ButtonPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonPreview.Enabled = false;
            this.ButtonPreview.Location = new System.Drawing.Point(688, 665);
            this.ButtonPreview.Name = "ButtonPreview";
            this.ButtonPreview.Size = new System.Drawing.Size(110, 23);
            this.ButtonPreview.TabIndex = 2;
            this.ButtonPreview.Text = "Preview";
            this.ButtonPreview.UseVisualStyleBackColor = true;
            this.ButtonPreview.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // DateTimePickerIssued
            // 
            this.DateTimePickerIssued.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerIssued.CalendarFont = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerIssued.CalendarForeColor = System.Drawing.SystemColors.ControlLight;
            this.DateTimePickerIssued.Enabled = false;
            this.DateTimePickerIssued.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerIssued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerIssued.Location = new System.Drawing.Point(542, 57);
            this.DateTimePickerIssued.Name = "DateTimePickerIssued";
            this.DateTimePickerIssued.Size = new System.Drawing.Size(93, 20);
            this.DateTimePickerIssued.TabIndex = 2;
            // 
            // LabelHidden
            // 
            this.LabelHidden.AutoSize = true;
            this.LabelHidden.Font = new System.Drawing.Font("Cambria", 8F);
            this.LabelHidden.ForeColor = System.Drawing.Color.DimGray;
            this.LabelHidden.Location = new System.Drawing.Point(130, 49);
            this.LabelHidden.Name = "LabelHidden";
            this.LabelHidden.Size = new System.Drawing.Size(0, 12);
            this.LabelHidden.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(453, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Issued Date";
            // 
            // TextBoxNo
            // 
            this.TextBoxNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxNo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxNo.Location = new System.Drawing.Point(542, 23);
            this.TextBoxNo.Name = "TextBoxNo";
            this.TextBoxNo.ReadOnly = true;
            this.TextBoxNo.Size = new System.Drawing.Size(167, 20);
            this.TextBoxNo.TabIndex = 1;
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.Label.Location = new System.Drawing.Point(453, 27);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(78, 16);
            this.Label.TabIndex = 8;
            this.Label.Text = "Invoice No.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(33, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Client Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(-4, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(829, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(756, 614);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 16);
            this.label9.TabIndex = 38;
            this.label9.Text = "Rs";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTotal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxTotal.Location = new System.Drawing.Point(591, 613);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.ReadOnly = true;
            this.TextBoxTotal.Size = new System.Drawing.Size(159, 20);
            this.TextBoxTotal.TabIndex = 11;
            this.TextBoxTotal.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(549, 614);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 33;
            this.label11.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(162, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 16);
            this.label6.TabIndex = 18;
            this.label6.Text = "Desc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(3, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Product Name";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.LableInvoiceId);
            this.groupBox1.Controls.Add(this.ComboBoxProduct);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.NumericUnitPrice);
            this.groupBox1.Controls.Add(this.NumericQuantity);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.ComboboxTax);
            this.groupBox1.Controls.Add(this.ButtonAdd);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ComboboxDesc);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.TextBoxRemark);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.TextBoxCusName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.TextBoxTotal);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DateTimePickerIssued);
            this.groupBox1.Controls.Add(this.LabelHidden);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxNo);
            this.groupBox1.Controls.Add(this.Label);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(786, 647);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit";
            // 
            // LableInvoiceId
            // 
            this.LableInvoiceId.AutoSize = true;
            this.LableInvoiceId.Location = new System.Drawing.Point(332, 26);
            this.LableInvoiceId.Name = "LableInvoiceId";
            this.LableInvoiceId.Size = new System.Drawing.Size(78, 19);
            this.LableInvoiceId.TabIndex = 109;
            this.LableInvoiceId.Text = "InvoiceId";
            this.LableInvoiceId.Visible = false;
            // 
            // ComboBoxProduct
            // 
            this.ComboBoxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxProduct.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxProduct.FormattingEnabled = true;
            this.ComboBoxProduct.Location = new System.Drawing.Point(6, 137);
            this.ComboBoxProduct.Name = "ComboBoxProduct";
            this.ComboBoxProduct.Size = new System.Drawing.Size(153, 20);
            this.ComboBoxProduct.TabIndex = 3;
            this.ComboBoxProduct.TextChanged += new System.EventHandler(this.ComboBoxProduct_TextChanged);
            this.ComboBoxProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.BlueViolet;
            this.label15.Location = new System.Drawing.Point(392, 139);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 16);
            this.label15.TabIndex = 107;
            this.label15.Text = "+";
            // 
            // NumericUnitPrice
            // 
            this.NumericUnitPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NumericUnitPrice.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.NumericUnitPrice.Location = new System.Drawing.Point(525, 136);
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
            this.NumericUnitPrice.TabIndex = 6;
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
            this.NumericQuantity.Location = new System.Drawing.Point(414, 136);
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
            this.NumericQuantity.TabIndex = 5;
            this.NumericQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label13.Location = new System.Drawing.Point(633, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 16);
            this.label13.TabIndex = 106;
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
            this.ComboboxTax.Location = new System.Drawing.Point(636, 136);
            this.ComboboxTax.Name = "ComboboxTax";
            this.ComboboxTax.Size = new System.Drawing.Size(45, 20);
            this.ComboboxTax.TabIndex = 7;
            this.ComboboxTax.Text = "14.5";
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAdd.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ButtonAdd.Location = new System.Drawing.Point(687, 135);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(92, 23);
            this.ButtonAdd.TabIndex = 8;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(522, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 16);
            this.label8.TabIndex = 105;
            this.label8.Text = "Unit Price";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(411, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 16);
            this.label7.TabIndex = 104;
            this.label7.Text = "Quantity";
            // 
            // ComboboxDesc
            // 
            this.ComboboxDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboboxDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboboxDesc.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboboxDesc.FormattingEnabled = true;
            this.ComboboxDesc.Location = new System.Drawing.Point(163, 138);
            this.ComboboxDesc.Name = "ComboboxDesc";
            this.ComboboxDesc.Size = new System.Drawing.Size(223, 20);
            this.ComboboxDesc.TabIndex = 4;
            this.ComboboxDesc.SelectedIndexChanged += new System.EventHandler(this.ComboboxDesc_SelectedIndexChanged);
            this.ComboboxDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            this.ComboboxDesc.Leave += new System.EventHandler(this.ComboboxDesc_Leave);
            // 
            // label17
            // 
            this.label17.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label17.Location = new System.Drawing.Point(6, 577);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(57, 16);
            this.label17.TabIndex = 89;
            this.label17.Text = "Remark";
            // 
            // TextBoxRemark
            // 
            this.TextBoxRemark.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TextBoxRemark.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.TextBoxRemark.Location = new System.Drawing.Point(6, 596);
            this.TextBoxRemark.Name = "TextBoxRemark";
            this.TextBoxRemark.Size = new System.Drawing.Size(510, 45);
            this.TextBoxRemark.TabIndex = 10;
            this.TextBoxRemark.Text = "";
            this.TextBoxRemark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
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
            this.dataGridView1.Location = new System.Drawing.Point(6, 163);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.dataGridView1.Size = new System.Drawing.Size(773, 411);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView1_CellBeginEdit);
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            // 
            // Desc
            // 
            this.Desc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Desc.DataPropertyName = "ItemDesc";
            this.Desc.FillWeight = 172.9541F;
            this.Desc.HeaderText = "Desc";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.FillWeight = 57.58379F;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 89;
            // 
            // UnitPrice
            // 
            this.UnitPrice.DataPropertyName = "price";
            this.UnitPrice.FillWeight = 66.09364F;
            this.UnitPrice.HeaderText = "UnitPrice";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.Width = 102;
            // 
            // Tax
            // 
            this.Tax.DataPropertyName = "Tax";
            this.Tax.HeaderText = "Tax";
            this.Tax.Name = "Tax";
            this.Tax.ReadOnly = true;
            this.Tax.Width = 70;
            // 
            // Total
            // 
            this.Total.DataPropertyName = "Total";
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // Itemid
            // 
            this.Itemid.DataPropertyName = "ItemNo";
            this.Itemid.HeaderText = "itemid";
            this.Itemid.Name = "Itemid";
            this.Itemid.ReadOnly = true;
            this.Itemid.Visible = false;
            // 
            // TextBoxCusName
            // 
            this.TextBoxCusName.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxCusName.Location = new System.Drawing.Point(122, 26);
            this.TextBoxCusName.Name = "TextBoxCusName";
            this.TextBoxCusName.ReadOnly = true;
            this.TextBoxCusName.Size = new System.Drawing.Size(167, 20);
            this.TextBoxCusName.TabIndex = 0;
            this.TextBoxCusName.TextChanged += new System.EventHandler(this.TextBoxCusName_TextChanged);
            this.TextBoxCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            // 
            // PrintDocumentInvoice1
            // 
            this.PrintDocumentInvoice1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentInvoice1_PrintPage);
            // 
            // PrintPreviewInvoice1
            // 
            this.PrintPreviewInvoice1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewInvoice1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewInvoice1.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewInvoice1.Enabled = true;
            this.PrintPreviewInvoice1.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewInvoice1.Icon")));
            this.PrintPreviewInvoice1.Name = "printPreviewDialog1";
            this.PrintPreviewInvoice1.Visible = false;
            // 
            // ButtonMakeInvoice
            // 
            this.ButtonMakeInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMakeInvoice.Enabled = false;
            this.ButtonMakeInvoice.Location = new System.Drawing.Point(572, 665);
            this.ButtonMakeInvoice.Name = "ButtonMakeInvoice";
            this.ButtonMakeInvoice.Size = new System.Drawing.Size(110, 23);
            this.ButtonMakeInvoice.TabIndex = 1;
            this.ButtonMakeInvoice.Text = "Make Invoice";
            this.ButtonMakeInvoice.UseVisualStyleBackColor = true;
            this.ButtonMakeInvoice.Visible = false;
            this.ButtonMakeInvoice.Click += new System.EventHandler(this.ButtonEstimate_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.Location = new System.Drawing.Point(456, 665);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(110, 23);
            this.ButtonSave.TabIndex = 0;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(801, 691);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonMakeInvoice);
            this.Controls.Add(this.ButtonPreview);
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(817, 730);
            this.Name = "Edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.Edit_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Edit_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billingDatabaseDataSet2BindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Drawing.Printing.PrintDocument PrintDocumentInvoice;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewInvoice;
        private System.Windows.Forms.Button ButtonPreview;
        private System.Windows.Forms.DateTimePicker DateTimePickerIssued;
        private System.Windows.Forms.Label LabelHidden;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxNo;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TextBoxTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource billingDatabaseDataSet2BindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBoxCusName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument PrintDocumentInvoice1;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewInvoice1;
        private System.Windows.Forms.Button ButtonMakeInvoice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox TextBoxRemark;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ComboBox ComboboxDesc;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown NumericUnitPrice;
        private System.Windows.Forms.NumericUpDown NumericQuantity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox ComboboxTax;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ComboBoxProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tax;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn Itemid;
        private System.Windows.Forms.Label LableInvoiceId;
    }
}