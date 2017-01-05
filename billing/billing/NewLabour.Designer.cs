namespace billing
{
    partial class NewLabour
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
            this.ComboBoxLabourName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelunit = new System.Windows.Forms.Label();
            this.LabelLabourNAme = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.ComboBoxLabourName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonSave);
            this.groupBox1.Controls.Add(this.TextBoxUnitPrice);
            this.groupBox1.Controls.Add(this.labelunit);
            this.groupBox1.Controls.Add(this.LabelLabourNAme);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 109);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Product or Service";
            // 
            // ComboBoxLabourName
            // 
            this.ComboBoxLabourName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxLabourName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxLabourName.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxLabourName.FormattingEnabled = true;
            this.ComboBoxLabourName.Location = new System.Drawing.Point(148, 21);
            this.ComboBoxLabourName.Name = "ComboBoxLabourName";
            this.ComboBoxLabourName.Size = new System.Drawing.Size(223, 20);
            this.ComboBoxLabourName.TabIndex = 0;
            this.ComboBoxLabourName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLabourName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(377, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rs";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonSave.Location = new System.Drawing.Point(148, 73);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(113, 23);
            this.ButtonSave.TabIndex = 2;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxUnitPrice
            // 
            this.TextBoxUnitPrice.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxUnitPrice.Location = new System.Drawing.Point(148, 47);
            this.TextBoxUnitPrice.Name = "TextBoxUnitPrice";
            this.TextBoxUnitPrice.Size = new System.Drawing.Size(223, 20);
            this.TextBoxUnitPrice.TabIndex = 1;
            // 
            // labelunit
            // 
            this.labelunit.AutoSize = true;
            this.labelunit.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelunit.Location = new System.Drawing.Point(6, 48);
            this.labelunit.Name = "labelunit";
            this.labelunit.Size = new System.Drawing.Size(68, 16);
            this.labelunit.TabIndex = 9;
            this.labelunit.Text = "Unit Price";
            // 
            // LabelLabourNAme
            // 
            this.LabelLabourNAme.AutoSize = true;
            this.LabelLabourNAme.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelLabourNAme.Location = new System.Drawing.Point(6, 22);
            this.LabelLabourNAme.Name = "LabelLabourNAme";
            this.LabelLabourNAme.Size = new System.Drawing.Size(91, 16);
            this.LabelLabourNAme.TabIndex = 7;
            this.LabelLabourNAme.Text = "Labour Name";
            // 
            // NewLabour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(431, 126);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(447, 165);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(447, 165);
            this.Name = "NewLabour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewLabour";
            this.Load += new System.EventHandler(this.NewLabour_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxLabourName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.TextBox TextBoxUnitPrice;
        private System.Windows.Forms.Label labelunit;
        private System.Windows.Forms.Label LabelLabourNAme;
    }
}