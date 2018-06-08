﻿namespace CustomerMaintenance
{
    partial class frmCustomerMaintenance
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.txtZipCode = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
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
            ZipCodeLabel.Location = new System.Drawing.Point(386, 211);
            ZipCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            ZipCodeLabel.Name = "ZipCodeLabel";
            ZipCodeLabel.Size = new System.Drawing.Size(74, 20);
            ZipCodeLabel.TabIndex = 11;
            ZipCodeLabel.Text = "Zip code:";
            // 
            // StateNameLabel
            // 
            StateNameLabel.AutoSize = true;
            StateNameLabel.Location = new System.Drawing.Point(32, 211);
            StateNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            StateNameLabel.Name = "StateNameLabel";
            StateNameLabel.Size = new System.Drawing.Size(52, 20);
            StateNameLabel.TabIndex = 9;
            StateNameLabel.Text = "State:";
            // 
            // CityLabel
            // 
            CityLabel.AutoSize = true;
            CityLabel.Location = new System.Drawing.Point(32, 171);
            CityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            CityLabel.Name = "CityLabel";
            CityLabel.Size = new System.Drawing.Size(39, 20);
            CityLabel.TabIndex = 7;
            CityLabel.Text = "City:";
            // 
            // Address1Label
            // 
            Address1Label.AutoSize = true;
            Address1Label.Location = new System.Drawing.Point(32, 131);
            Address1Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Address1Label.Name = "Address1Label";
            Address1Label.Size = new System.Drawing.Size(72, 20);
            Address1Label.TabIndex = 5;
            Address1Label.Text = "Address:";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new System.Drawing.Point(32, 91);
            NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new System.Drawing.Size(55, 20);
            NameLabel.TabIndex = 3;
            NameLabel.Text = "Name:";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(282, 271);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(112, 35);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(480, 271);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnModify
            // 
            this.btnModify.Enabled = false;
            this.btnModify.Location = new System.Drawing.Point(159, 272);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(112, 35);
            this.btnModify.TabIndex = 14;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(36, 272);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 35);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(226, 25);
            this.btnGetCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(141, 35);
            this.btnGetCustomer.TabIndex = 2;
            this.btnGetCustomer.Text = "Get Customer";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(472, 206);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.ReadOnly = true;
            this.txtZipCode.Size = new System.Drawing.Size(118, 26);
            this.txtZipCode.TabIndex = 12;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(142, 206);
            this.txtState.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtState.Name = "txtState";
            this.txtState.ReadOnly = true;
            this.txtState.Size = new System.Drawing.Size(223, 26);
            this.txtState.TabIndex = 10;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(142, 166);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.Size = new System.Drawing.Size(448, 26);
            this.txtCity.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(142, 126);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(448, 26);
            this.txtAddress.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 86);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(448, 26);
            this.txtName.TabIndex = 4;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(32, 37);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(103, 20);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(142, 28);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(73, 26);
            this.txtCustomerID.TabIndex = 1;
            this.txtCustomerID.Tag = "Customer ID";
            this.txtCustomerID.TextChanged += new System.EventHandler(this.txtCustomerID_TextChanged);
            // 
            // frmCustomerMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(622, 335);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGetCustomer);
            this.Controls.Add(ZipCodeLabel);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(StateNameLabel);
            this.Controls.Add(this.txtState);
            this.Controls.Add(CityLabel);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(Address1Label);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(NameLabel);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.txtCustomerID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCustomerMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Maintenance";
            this.Load += new System.EventHandler(this.frmCustomerMaintenance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnDelete;
        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.Button btnModify;
        internal System.Windows.Forms.Button btnAdd;
        internal System.Windows.Forms.Button btnGetCustomer;
        internal System.Windows.Forms.TextBox txtZipCode;
        internal System.Windows.Forms.TextBox txtState;
        internal System.Windows.Forms.TextBox txtCity;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox txtCustomerID;
    }
}

