namespace billing
{
    partial class NewService
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboboxProduct = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelunit = new System.Windows.Forms.Label();
            this.TextBoxDesc = new System.Windows.Forms.TextBox();
            this.labeldesc = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.ComboboxProduct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonSave);
            this.groupBox1.Controls.Add(this.TextBoxUnitPrice);
            this.groupBox1.Controls.Add(this.labelunit);
            this.groupBox1.Controls.Add(this.TextBoxDesc);
            this.groupBox1.Controls.Add(this.labeldesc);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 137);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Product or Service";
            // 
            // ComboboxProduct
            // 
            this.ComboboxProduct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboboxProduct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboboxProduct.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboboxProduct.FormattingEnabled = true;
            this.ComboboxProduct.Location = new System.Drawing.Point(148, 26);
            this.ComboboxProduct.Name = "ComboboxProduct";
            this.ComboboxProduct.Size = new System.Drawing.Size(223, 20);
            this.ComboboxProduct.TabIndex = 0;
            this.ComboboxProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewService_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(246, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rs";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonSave.Location = new System.Drawing.Point(148, 104);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(113, 23);
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxUnitPrice
            // 
            this.TextBoxUnitPrice.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxUnitPrice.Location = new System.Drawing.Point(148, 78);
            this.TextBoxUnitPrice.Name = "TextBoxUnitPrice";
            this.TextBoxUnitPrice.Size = new System.Drawing.Size(93, 20);
            this.TextBoxUnitPrice.TabIndex = 2;
            this.TextBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewService_KeyPress);
            // 
            // labelunit
            // 
            this.labelunit.AutoSize = true;
            this.labelunit.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelunit.Location = new System.Drawing.Point(6, 79);
            this.labelunit.Name = "labelunit";
            this.labelunit.Size = new System.Drawing.Size(68, 16);
            this.labelunit.TabIndex = 9;
            this.labelunit.Text = "Unit Price";
            // 
            // TextBoxDesc
            // 
            this.TextBoxDesc.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxDesc.Location = new System.Drawing.Point(148, 52);
            this.TextBoxDesc.Name = "TextBoxDesc";
            this.TextBoxDesc.Size = new System.Drawing.Size(214, 20);
            this.TextBoxDesc.TabIndex = 1;
            this.TextBoxDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewService_KeyPress);
            // 
            // labeldesc
            // 
            this.labeldesc.AutoSize = true;
            this.labeldesc.Font = new System.Drawing.Font("Cambria", 10F);
            this.labeldesc.Location = new System.Drawing.Point(6, 53);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(36, 16);
            this.labeldesc.TabIndex = 7;
            this.labeldesc.Text = "Desc";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Cambria", 10F);
            this.label.Location = new System.Drawing.Point(6, 27);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(84, 16);
            this.label.TabIndex = 5;
            this.label.Text = "Model Name";
            // 
            // NewService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(423, 154);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 193);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 193);
            this.Name = "NewService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Product or Service";
            this.Load += new System.EventHandler(this.NewService_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewService_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxUnitPrice;
        private System.Windows.Forms.Label labelunit;
        private System.Windows.Forms.TextBox TextBoxDesc;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboboxProduct;
    }
}