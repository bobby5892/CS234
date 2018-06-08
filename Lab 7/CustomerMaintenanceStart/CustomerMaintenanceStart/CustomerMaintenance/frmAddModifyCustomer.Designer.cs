namespace CustomerMaintenance
{
    partial class frmAddModifyCustomer
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
            System.Windows.Forms.Label ZipCodeLabel;
            System.Windows.Forms.Label StateNameLabel;
            System.Windows.Forms.Label CityLabel;
            System.Windows.Forms.Label Address1Label;
            System.Windows.Forms.Label NameLabel;
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cboStates = new System.Windows.Forms.ComboBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ZipCodeLabel = new System.Windows.Forms.Label();
            StateNameLabel = new System.Windows.Forms.Label();
            CityLabel = new System.Windows.Forms.Label();
            Address1Label = new System.Windows.Forms.Label();
            NameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ZipCodeLabel
            // 
            ZipCodeLabel.AutoSize = true;
            ZipCodeLabel.Location = new System.Drawing.Point(382, 152);
            ZipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new System.Drawing.Size(74, 20);
            ZipCodeLabel.TabIndex = 8;
            ZipCodeLabel.Text = "Zip code:";
            // 
            // StateNameLabel
            // 
            StateNameLabel.AutoSize = true;
            StateNameLabel.Location = new System.Drawing.Point(28, 152);
            StateNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StateNameLabel.Name = "StateNameLabel";
            StateNameLabel.Size = new System.Drawing.Size(52, 20);
            StateNameLabel.TabIndex = 6;
            StateNameLabel.Text = "State:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new System.Drawing.Point(28, 112);
            CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new System.Drawing.Size(39, 20);
            CityLabel.TabIndex = 4;
            CityLabel.Text = "City:";
            // 
            // Address1Label
            // 
            Address1Label.AutoSize = true;
            Address1Label.Location = new System.Drawing.Point(28, 72);
            Address1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Address1Label.Name = "Address1Label";
            Address1Label.Size = new System.Drawing.Size(72, 20);
            Address1Label.TabIndex = 2;
            Address1Label.Text = "Address:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(28, 32);
            NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(55, 20);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "Name:";
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(470, 148);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Size = new System.Drawing.Size(118, 26);
            this.txtZipCode.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(140, 108);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(448, 26);
            this.txtCity.TabIndex = 5;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(140, 68);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(448, 26);
            this.txtAddress.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(140, 28);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(448, 26);
            this.txtName.TabIndex = 1;
            // 
            // cboStates
            // 
            this.cboStates.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStates.FormattingEnabled = true;
            this.cboStates.Location = new System.Drawing.Point(140, 149);
            this.cboStates.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboStates.Name = "cboStates";
            this.cboStates.Size = new System.Drawing.Size(223, 28);
            this.cboStates.TabIndex = 7;
            this.cboStates.SelectedIndexChanged += new System.EventHandler(this.cboStates_SelectedIndexChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(33, 232);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(112, 35);
            this.btnAccept.TabIndex = 10;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(476, 231);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 35);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddModifyCustomer
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(618, 292);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.cboStates);
            this.Controls.Add(ZipCodeLabel);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(StateNameLabel);
            this.Controls.Add(CityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(Address1Label);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(NameLabel);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmAddModifyCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.frmAddModifyCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtZipCode;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cboStates;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
    }
}