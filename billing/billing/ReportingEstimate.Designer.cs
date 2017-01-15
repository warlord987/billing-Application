namespace billing
{
    partial class ReportingEstimate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.DateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.DateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxEstimateNo = new System.Windows.Forms.TextBox();
            this.TextBoxVehicleNo = new System.Windows.Forms.TextBox();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxCusContact = new System.Windows.Forms.TextBox();
            this.TextBoxCusName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBoxTotal = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VehicleNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstimateNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Estimateid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonNewEstimate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.HiddenLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 10F);
            this.label6.Location = new System.Drawing.Point(363, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "To";
            // 
            // DateTimePickerTo
            // 
            this.DateTimePickerTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DateTimePickerTo.CustomFormat = "";
            this.DateTimePickerTo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerTo.Location = new System.Drawing.Point(453, 83);
            this.DateTimePickerTo.Name = "DateTimePickerTo";
            this.DateTimePickerTo.Size = new System.Drawing.Size(166, 20);
            this.DateTimePickerTo.TabIndex = 5;
            // 
            // DateTimePickerFrom
            // 
            this.DateTimePickerFrom.CustomFormat = "";
            this.DateTimePickerFrom.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerFrom.Location = new System.Drawing.Point(170, 80);
            this.DateTimePickerFrom.Name = "DateTimePickerFrom";
            this.DateTimePickerFrom.Size = new System.Drawing.Size(166, 20);
            this.DateTimePickerFrom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F);
            this.label5.Location = new System.Drawing.Point(48, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Issued Between";
            // 
            // TextBoxEstimateNo
            // 
            this.TextBoxEstimateNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxEstimateNo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxEstimateNo.Location = new System.Drawing.Point(453, 55);
            this.TextBoxEstimateNo.Name = "TextBoxEstimateNo";
            this.TextBoxEstimateNo.Size = new System.Drawing.Size(166, 20);
            this.TextBoxEstimateNo.TabIndex = 3;
            this.TextBoxEstimateNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReportingEstimate_KeyPress);
            // 
            // TextBoxVehicleNo
            // 
            this.TextBoxVehicleNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxVehicleNo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxVehicleNo.Location = new System.Drawing.Point(453, 29);
            this.TextBoxVehicleNo.Name = "TextBoxVehicleNo";
            this.TextBoxVehicleNo.Size = new System.Drawing.Size(166, 20);
            this.TextBoxVehicleNo.TabIndex = 1;
            this.TextBoxVehicleNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReportingEstimate_KeyPress);
            // 
            // ButtonReset
            // 
            this.ButtonReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonReset.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonReset.Location = new System.Drawing.Point(366, 112);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(75, 23);
            this.ButtonReset.TabIndex = 7;
            this.ButtonReset.Text = "Reset";
            this.ButtonReset.UseVisualStyleBackColor = true;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonSearch.Location = new System.Drawing.Point(261, 112);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 6;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxCusContact
            // 
            this.TextBoxCusContact.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxCusContact.Location = new System.Drawing.Point(170, 56);
            this.TextBoxCusContact.Name = "TextBoxCusContact";
            this.TextBoxCusContact.Size = new System.Drawing.Size(166, 20);
            this.TextBoxCusContact.TabIndex = 2;
            this.TextBoxCusContact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReportingEstimate_KeyPress);
            // 
            // TextBoxCusName
            // 
            this.TextBoxCusName.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxCusName.Location = new System.Drawing.Point(170, 30);
            this.TextBoxCusName.Name = "TextBoxCusName";
            this.TextBoxCusName.Size = new System.Drawing.Size(166, 20);
            this.TextBoxCusName.TabIndex = 0;
            this.TextBoxCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReportingEstimate_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F);
            this.label4.Location = new System.Drawing.Point(363, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estimate No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F);
            this.label3.Location = new System.Drawing.Point(48, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Customer Contact";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F);
            this.label2.Location = new System.Drawing.Point(363, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vehicle No.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(48, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(469, 448);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 2;
            this.label7.Text = "total";
            // 
            // TextBoxTotal
            // 
            this.TextBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxTotal.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxTotal.Location = new System.Drawing.Point(512, 447);
            this.TextBoxTotal.Name = "TextBoxTotal";
            this.TextBoxTotal.ReadOnly = true;
            this.TextBoxTotal.Size = new System.Drawing.Size(155, 20);
            this.TextBoxTotal.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TextBoxTotal);
            this.groupBox2.Controls.Add(this.ButtonNewEstimate);
            this.groupBox2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox2.Location = new System.Drawing.Point(5, 159);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 470);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Result";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerName,
            this.VehicleNo,
            this.EstimateNo,
            this.Date,
            this.total,
            this.Delete,
            this.Estimateid});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 49);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cambria", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.DarkRed;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(661, 396);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.FillWeight = 129.8701F;
            this.CustomerName.HeaderText = "Client Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // VehicleNo
            // 
            this.VehicleNo.DataPropertyName = "VehicleNo";
            this.VehicleNo.HeaderText = "Vehicle No";
            this.VehicleNo.Name = "VehicleNo";
            this.VehicleNo.ReadOnly = true;
            this.VehicleNo.Width = 150;
            // 
            // EstimateNo
            // 
            this.EstimateNo.DataPropertyName = "EstimateNo";
            this.EstimateNo.FillWeight = 172.9541F;
            this.EstimateNo.HeaderText = "Estimate No";
            this.EstimateNo.Name = "EstimateNo";
            this.EstimateNo.ReadOnly = true;
            this.EstimateNo.Width = 70;
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.FillWeight = 57.58379F;
            this.Date.HeaderText = "Issued Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 89;
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.FillWeight = 66.09364F;
            this.total.HeaderText = "Amount";
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Width = 70;
            // 
            // Delete
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle12.NullValue = "Detele";
            this.Delete.DefaultCellStyle = dataGridViewCellStyle12;
            this.Delete.HeaderText = "Action";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Delete.Text = "Delete";
            this.Delete.ToolTipText = "Delete";
            this.Delete.Width = 68;
            // 
            // Estimateid
            // 
            this.Estimateid.DataPropertyName = "estimateid";
            this.Estimateid.HeaderText = "Estimateid";
            this.Estimateid.Name = "Estimateid";
            this.Estimateid.ReadOnly = true;
            this.Estimateid.Visible = false;
            // 
            // ButtonNewEstimate
            // 
            this.ButtonNewEstimate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNewEstimate.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonNewEstimate.Location = new System.Drawing.Point(534, 18);
            this.ButtonNewEstimate.Name = "ButtonNewEstimate";
            this.ButtonNewEstimate.Size = new System.Drawing.Size(118, 23);
            this.ButtonNewEstimate.TabIndex = 0;
            this.ButtonNewEstimate.Text = "New Estimate";
            this.ButtonNewEstimate.UseVisualStyleBackColor = true;
            this.ButtonNewEstimate.Click += new System.EventHandler(this.ButtonNewEstimate_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.HiddenLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DateTimePickerTo);
            this.groupBox1.Controls.Add(this.DateTimePickerFrom);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.TextBoxEstimateNo);
            this.groupBox1.Controls.Add(this.TextBoxVehicleNo);
            this.groupBox1.Controls.Add(this.ButtonReset);
            this.groupBox1.Controls.Add(this.ButtonSearch);
            this.groupBox1.Controls.Add(this.TextBoxCusContact);
            this.groupBox1.Controls.Add(this.TextBoxCusName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(5, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 141);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Box";
            // 
            // HiddenLabel
            // 
            this.HiddenLabel.AutoSize = true;
            this.HiddenLabel.Location = new System.Drawing.Point(513, 106);
            this.HiddenLabel.Name = "HiddenLabel";
            this.HiddenLabel.Size = new System.Drawing.Size(106, 23);
            this.HiddenLabel.TabIndex = 16;
            this.HiddenLabel.Text = "tecnokraft";
            this.HiddenLabel.Visible = false;
            // 
            // ReportingEstimate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(699, 641);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(715, 680);
            this.Name = "ReportingEstimate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estimate Reporting";
            this.Load += new System.EventHandler(this.ReportingEstimate_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReportingEstimate_KeyPress);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DateTimePickerTo;
        private System.Windows.Forms.DateTimePicker DateTimePickerFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxEstimateNo;
        private System.Windows.Forms.TextBox TextBoxVehicleNo;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonSearch;
        private System.Windows.Forms.TextBox TextBoxCusContact;
        private System.Windows.Forms.TextBox TextBoxCusName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TextBoxTotal;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ButtonNewEstimate;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label HiddenLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehicleNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstimateNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estimateid;



    }
}