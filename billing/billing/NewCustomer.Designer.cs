namespace billing
{
    partial class NewCustomer
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
            this.ComboBoxVehicleName = new System.Windows.Forms.ComboBox();
            this.ComboBoxVehicleModel = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TextBoxVehicleNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxCusNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TextBoxCusName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.ComboBoxVehicleName);
            this.groupBox1.Controls.Add(this.ComboBoxVehicleModel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ButtonSave);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TextBoxVehicleNo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TextBoxCusNo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TextBoxCusName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Detail";
            // 
            // ComboBoxVehicleName
            // 
            this.ComboBoxVehicleName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxVehicleName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxVehicleName.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxVehicleName.FormattingEnabled = true;
            this.ComboBoxVehicleName.Location = new System.Drawing.Point(157, 131);
            this.ComboBoxVehicleName.Name = "ComboBoxVehicleName";
            this.ComboBoxVehicleName.Size = new System.Drawing.Size(214, 20);
            this.ComboBoxVehicleName.TabIndex = 4;
            this.ComboBoxVehicleName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCustomer_KeyPress);
            this.ComboBoxVehicleName.Leave += new System.EventHandler(this.ComboBoxVehicleName_Leave);
            // 
            // ComboBoxVehicleModel
            // 
            this.ComboBoxVehicleModel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboBoxVehicleModel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxVehicleModel.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.ComboBoxVehicleModel.FormattingEnabled = true;
            this.ComboBoxVehicleModel.Location = new System.Drawing.Point(157, 105);
            this.ComboBoxVehicleModel.Name = "ComboBoxVehicleModel";
            this.ComboBoxVehicleModel.Size = new System.Drawing.Size(214, 20);
            this.ComboBoxVehicleModel.TabIndex = 3;
            this.ComboBoxVehicleModel.SelectedIndexChanged += new System.EventHandler(this.ComboBoxVehicleModel_SelectedIndexChanged);
            this.ComboBoxVehicleModel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCustomer_KeyPress);
            this.ComboBoxVehicleModel.Leave += new System.EventHandler(this.ComboBoxVehicleModel_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 10F);
            this.label5.Location = new System.Drawing.Point(15, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Vehicle Name";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold);
            this.ButtonSave.Location = new System.Drawing.Point(157, 156);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(113, 23);
            this.ButtonSave.TabIndex = 5;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 10F);
            this.label4.Location = new System.Drawing.Point(15, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Vehicle Model";
            // 
            // TextBoxVehicleNo
            // 
            this.TextBoxVehicleNo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxVehicleNo.Location = new System.Drawing.Point(157, 78);
            this.TextBoxVehicleNo.Name = "TextBoxVehicleNo";
            this.TextBoxVehicleNo.Size = new System.Drawing.Size(214, 20);
            this.TextBoxVehicleNo.TabIndex = 2;
            this.TextBoxVehicleNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCustomer_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 10F);
            this.label3.Location = new System.Drawing.Point(15, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vehicle Number";
            // 
            // TextBoxCusNo
            // 
            this.TextBoxCusNo.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxCusNo.Location = new System.Drawing.Point(157, 52);
            this.TextBoxCusNo.Name = "TextBoxCusNo";
            this.TextBoxCusNo.Size = new System.Drawing.Size(214, 20);
            this.TextBoxCusNo.TabIndex = 1;
            this.TextBoxCusNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCustomer_KeyPress);
            this.TextBoxCusNo.Leave += new System.EventHandler(this.TextBoxCusNo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 10F);
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Customer Number";
            // 
            // TextBoxCusName
            // 
            this.TextBoxCusName.Font = new System.Drawing.Font("Cambria", 8F, System.Drawing.FontStyle.Bold);
            this.TextBoxCusName.Location = new System.Drawing.Point(157, 26);
            this.TextBoxCusName.Name = "TextBoxCusName";
            this.TextBoxCusName.Size = new System.Drawing.Size(214, 20);
            this.TextBoxCusName.TabIndex = 0;
            this.TextBoxCusName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCustomer_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 10F);
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Customer Name";
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(423, 215);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewCustomer";
            this.Load += new System.EventHandler(this.NewCustomer_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NewCustomer_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TextBoxVehicleNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxCusNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TextBoxCusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboBoxVehicleModel;
        private System.Windows.Forms.ComboBox ComboBoxVehicleName;

    }
}