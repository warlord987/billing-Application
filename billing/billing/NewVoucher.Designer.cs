namespace billing
{
    partial class NewVoucher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewVoucher));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ButtonPrint = new System.Windows.Forms.Button();
            this.DateTimePickerIssued = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxDesc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxPaidTo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxVoucherNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PrintDocumentVoucher = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewVoucher = new System.Windows.Forms.PrintPreviewDialog();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.ButtonPrint);
            this.groupBox1.Controls.Add(this.DateTimePickerIssued);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ButtonSave);
            this.groupBox1.Controls.Add(this.TextBoxAmount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxDesc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxPaidTo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxVoucherNo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Voucher";
            // 
            // ButtonPrint
            // 
            this.ButtonPrint.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonPrint.Location = new System.Drawing.Point(253, 157);
            this.ButtonPrint.Name = "ButtonPrint";
            this.ButtonPrint.Size = new System.Drawing.Size(95, 23);
            this.ButtonPrint.TabIndex = 6;
            this.ButtonPrint.Text = "Print";
            this.ButtonPrint.UseVisualStyleBackColor = true;
            this.ButtonPrint.Click += new System.EventHandler(this.ButtonPrint_Click);
            // 
            // DateTimePickerIssued
            // 
            this.DateTimePickerIssued.CustomFormat = "";
            this.DateTimePickerIssued.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.DateTimePickerIssued.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePickerIssued.Location = new System.Drawing.Point(148, 104);
            this.DateTimePickerIssued.Name = "DateTimePickerIssued";
            this.DateTimePickerIssued.Size = new System.Drawing.Size(214, 20);
            this.DateTimePickerIssued.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F);
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Date Issued";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonSave.Location = new System.Drawing.Point(148, 156);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(99, 23);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxAmount
            // 
            this.TextBoxAmount.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxAmount.Location = new System.Drawing.Point(148, 130);
            this.TextBoxAmount.Name = "TextBoxAmount";
            this.TextBoxAmount.Size = new System.Drawing.Size(214, 20);
            this.TextBoxAmount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F);
            this.label4.Location = new System.Drawing.Point(6, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Amount";
            // 
            // TextBoxDesc
            // 
            this.TextBoxDesc.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxDesc.Location = new System.Drawing.Point(148, 78);
            this.TextBoxDesc.Name = "TextBoxDesc";
            this.TextBoxDesc.Size = new System.Drawing.Size(214, 20);
            this.TextBoxDesc.TabIndex = 2;
            this.TextBoxDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewVoucher_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F);
            this.label3.Location = new System.Drawing.Point(6, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // TextBoxPaidTo
            // 
            this.TextBoxPaidTo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxPaidTo.Location = new System.Drawing.Point(148, 52);
            this.TextBoxPaidTo.Name = "TextBoxPaidTo";
            this.TextBoxPaidTo.Size = new System.Drawing.Size(214, 20);
            this.TextBoxPaidTo.TabIndex = 1;
            this.TextBoxPaidTo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewVoucher_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F);
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Paid To";
            // 
            // TextBoxVoucherNo
            // 
            this.TextBoxVoucherNo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxVoucherNo.Location = new System.Drawing.Point(148, 26);
            this.TextBoxVoucherNo.Name = "TextBoxVoucherNo";
            this.TextBoxVoucherNo.ReadOnly = true;
            this.TextBoxVoucherNo.Size = new System.Drawing.Size(214, 20);
            this.TextBoxVoucherNo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "voucher No.";
            // 
            // PrintDocumentVoucher
            // 
            this.PrintDocumentVoucher.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PrintPreviewVoucher
            // 
            this.PrintPreviewVoucher.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewVoucher.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewVoucher.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewVoucher.Enabled = true;
            this.PrintPreviewVoucher.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewVoucher.Icon")));
            this.PrintPreviewVoucher.Name = "PrintPreviewVoucher";
            this.PrintPreviewVoucher.Visible = false;
            // 
            // NewVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(423, 204);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 243);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 243);
            this.Name = "NewVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewVoucher";
            this.Load += new System.EventHandler(this.NewVoucher_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewVoucher_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxDesc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxPaidTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxVoucherNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker DateTimePickerIssued;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonPrint;
        private System.Drawing.Printing.PrintDocument PrintDocumentVoucher;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewVoucher;
    }
}