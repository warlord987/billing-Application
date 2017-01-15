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
            this.ComboBoxItemName = new System.Windows.Forms.ComboBox();
            this.ComboBoxVehicleName = new System.Windows.Forms.ComboBox();
            this.LabelVehicleName = new System.Windows.Forms.Label();
            this.ComboBoxVehicleModel = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.TextBoxUnitPrice = new System.Windows.Forms.TextBox();
            this.labelunit = new System.Windows.Forms.Label();
            this.LabelItemName = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.ComboBoxItemName);
            this.groupBox1.Controls.Add(this.ComboBoxVehicleName);
            this.groupBox1.Controls.Add(this.LabelVehicleName);
            this.groupBox1.Controls.Add(this.ComboBoxVehicleModel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ButtonSave);
            this.groupBox1.Controls.Add(this.TextBoxUnitPrice);
            this.groupBox1.Controls.Add(this.labelunit);
            this.groupBox1.Controls.Add(this.LabelItemName);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "New Product or Service";
            // 
            // ComboBoxItemName
            // 
            this.ComboBoxItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxItemName.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxItemName.FormattingEnabled = true;
            this.ComboBoxItemName.Location = new System.Drawing.Point(148, 78);
            this.ComboBoxItemName.Name = "ComboBoxItemName";
            this.ComboBoxItemName.Size = new System.Drawing.Size(223, 20);
            this.ComboBoxItemName.TabIndex = 2;
            this.ComboBoxItemName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxItemName_SelectedIndexChanged);
            this.ComboBoxItemName.Enter += new System.EventHandler(this.ComboBoxItemName_Enter);
            this.ComboBoxItemName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewService_KeyPress);
            this.ComboBoxItemName.Leave += new System.EventHandler(this.ComboBoxItemName_Leave);
            // 
            // ComboBoxVehicleName
            // 
            this.ComboBoxVehicleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxVehicleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxVehicleName.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxVehicleName.FormattingEnabled = true;
            this.ComboBoxVehicleName.Location = new System.Drawing.Point(148, 52);
            this.ComboBoxVehicleName.Name = "ComboBoxVehicleName";
            this.ComboBoxVehicleName.Size = new System.Drawing.Size(223, 20);
            this.ComboBoxVehicleName.TabIndex = 1;
            this.ComboBoxVehicleName.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVehicleName_SelectedIndexChanged);
            this.ComboBoxVehicleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewService_KeyPress);
            this.ComboBoxVehicleName.Leave += new System.EventHandler(this.ComboBoxVehicleName_Leave);
            // 
            // LabelVehicleName
            // 
            this.LabelVehicleName.AutoSize = true;
            this.LabelVehicleName.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelVehicleName.Location = new System.Drawing.Point(6, 53);
            this.LabelVehicleName.Name = "LabelVehicleName";
            this.LabelVehicleName.Size = new System.Drawing.Size(90, 16);
            this.LabelVehicleName.TabIndex = 16;
            this.LabelVehicleName.Text = "Vehicle Name";
            // 
            // ComboBoxVehicleModel
            // 
            this.ComboBoxVehicleModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxVehicleModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxVehicleModel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxVehicleModel.FormattingEnabled = true;
            this.ComboBoxVehicleModel.Location = new System.Drawing.Point(148, 26);
            this.ComboBoxVehicleModel.Name = "ComboBoxVehicleModel";
            this.ComboBoxVehicleModel.Size = new System.Drawing.Size(223, 20);
            this.ComboBoxVehicleModel.TabIndex = 0;
            this.ComboBoxVehicleModel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVehicleModel_SelectedIndexChanged);
            this.ComboBoxVehicleModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewService_KeyPress);
            this.ComboBoxVehicleModel.Leave += new System.EventHandler(this.ComboBoxVehicleModel_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(376, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Rs";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonSave.Location = new System.Drawing.Point(148, 130);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(113, 23);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextBoxUnitPrice
            // 
            this.TextBoxUnitPrice.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxUnitPrice.Location = new System.Drawing.Point(148, 104);
            this.TextBoxUnitPrice.Name = "TextBoxUnitPrice";
            this.TextBoxUnitPrice.Size = new System.Drawing.Size(223, 20);
            this.TextBoxUnitPrice.TabIndex = 3;
            this.TextBoxUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewService_KeyPress);
            // 
            // labelunit
            // 
            this.labelunit.AutoSize = true;
            this.labelunit.Font = new System.Drawing.Font("Cambria", 10F);
            this.labelunit.Location = new System.Drawing.Point(6, 105);
            this.labelunit.Name = "labelunit";
            this.labelunit.Size = new System.Drawing.Size(68, 16);
            this.labelunit.TabIndex = 9;
            this.labelunit.Text = "Unit Price";
            // 
            // LabelItemName
            // 
            this.LabelItemName.AutoSize = true;
            this.LabelItemName.Font = new System.Drawing.Font("Cambria", 10F);
            this.LabelItemName.Location = new System.Drawing.Point(6, 79);
            this.LabelItemName.Name = "LabelItemName";
            this.LabelItemName.Size = new System.Drawing.Size(76, 16);
            this.LabelItemName.TabIndex = 7;
            this.LabelItemName.Text = "Item Name";
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
            this.ClientSize = new System.Drawing.Size(423, 182);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 221);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(439, 221);
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
        private System.Windows.Forms.Label LabelItemName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComboBoxVehicleModel;
        private System.Windows.Forms.ComboBox ComboBoxVehicleName;
        private System.Windows.Forms.Label LabelVehicleName;
        private System.Windows.Forms.ComboBox ComboBoxItemName;
    }
}