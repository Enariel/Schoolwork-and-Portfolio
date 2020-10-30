namespace InvoiceTotal
{
    partial class frmSalesTax
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaxBox = new System.Windows.Forms.TextBox();
            this.slsOkBtn = new System.Windows.Forms.Button();
            this.slsCnclBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sales Tax %";
            // 
            // txtTaxBox
            // 
            this.txtTaxBox.Location = new System.Drawing.Point(97, 24);
            this.txtTaxBox.Name = "txtTaxBox";
            this.txtTaxBox.Size = new System.Drawing.Size(75, 20);
            this.txtTaxBox.TabIndex = 1;
            // 
            // slsOkBtn
            // 
            this.slsOkBtn.Location = new System.Drawing.Point(15, 76);
            this.slsOkBtn.Name = "slsOkBtn";
            this.slsOkBtn.Size = new System.Drawing.Size(75, 23);
            this.slsOkBtn.TabIndex = 2;
            this.slsOkBtn.Text = "Okay";
            this.slsOkBtn.UseVisualStyleBackColor = true;
            this.slsOkBtn.Click += new System.EventHandler(this.slsOkBtn_Click);
            // 
            // slsCnclBtn
            // 
            this.slsCnclBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.slsCnclBtn.Location = new System.Drawing.Point(97, 76);
            this.slsCnclBtn.Name = "slsCnclBtn";
            this.slsCnclBtn.Size = new System.Drawing.Size(75, 23);
            this.slsCnclBtn.TabIndex = 3;
            this.slsCnclBtn.Text = "Cancel";
            this.slsCnclBtn.UseVisualStyleBackColor = true;
            this.slsCnclBtn.Click += new System.EventHandler(this.slsCnclBtn_Click);
            // 
            // frmSalesTax
            // 
            this.AcceptButton = this.slsOkBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.slsCnclBtn;
            this.ClientSize = new System.Drawing.Size(184, 111);
            this.Controls.Add(this.slsCnclBtn);
            this.Controls.Add(this.slsOkBtn);
            this.Controls.Add(this.txtTaxBox);
            this.Controls.Add(this.label1);
            this.Name = "frmSalesTax";
            this.Text = "Sales Tax";
            this.Load += new System.EventHandler(this.frmSalesTax_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaxBox;
        private System.Windows.Forms.Button slsOkBtn;
        private System.Windows.Forms.Button slsCnclBtn;
    }
}