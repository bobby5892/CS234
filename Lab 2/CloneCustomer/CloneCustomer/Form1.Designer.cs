namespace CloneCustomer
{
    partial class Form1
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
            this.btnExit = new System.Windows.Forms.Button();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCopies = new System.Windows.Forms.TextBox();
            this.btnClone = new System.Windows.Forms.Button();
            this.lstCustomers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(438, 309);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 35);
            this.btnExit.TabIndex = 19;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Location = new System.Drawing.Point(18, 14);
            this.lblCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(396, 62);
            this.lblCustomer.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(30, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 35);
            this.label1.TabIndex = 17;
            this.label1.Text = "Copies:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCopies
            // 
            this.txtCopies.Location = new System.Drawing.Point(114, 88);
            this.txtCopies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCopies.Name = "txtCopies";
            this.txtCopies.Size = new System.Drawing.Size(70, 26);
            this.txtCopies.TabIndex = 16;
            this.txtCopies.Tag = "Copies";
            // 
            // btnClone
            // 
            this.btnClone.Location = new System.Drawing.Point(210, 88);
            this.btnClone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClone.Name = "btnClone";
            this.btnClone.Size = new System.Drawing.Size(112, 35);
            this.btnClone.TabIndex = 15;
            this.btnClone.Text = "Clone";
            this.btnClone.Click += new System.EventHandler(this.btnClone_Click);
            // 
            // lstCustomers
            // 
            this.lstCustomers.ItemHeight = 20;
            this.lstCustomers.Location = new System.Drawing.Point(18, 137);
            this.lstCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstCustomers.Name = "lstCustomers";
            this.lstCustomers.Size = new System.Drawing.Size(394, 204);
            this.lstCustomers.TabIndex = 14;
            this.lstCustomers.SelectedIndexChanged += new System.EventHandler(this.lstCustomers_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnClone;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(580, 362);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblCustomer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCopies);
            this.Controls.Add(this.btnClone);
            this.Controls.Add(this.lstCustomers);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clone Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCopies;
        private System.Windows.Forms.Button btnClone;
        private System.Windows.Forms.ListBox lstCustomers;
    }
}

