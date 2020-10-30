namespace TaxCalculator
{
    partial class frmTaxCalculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.taxBox = new System.Windows.Forms.TextBox();
            this.calcTaxButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pre-Tax Amount:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Owed Tax:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(150, 15);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(128, 20);
            this.inputBox.TabIndex = 2;
            // 
            // taxBox
            // 
            this.taxBox.Location = new System.Drawing.Point(150, 47);
            this.taxBox.Name = "taxBox";
            this.taxBox.ReadOnly = true;
            this.taxBox.Size = new System.Drawing.Size(128, 20);
            this.taxBox.TabIndex = 3;
            // 
            // calcTaxButton
            // 
            this.calcTaxButton.Location = new System.Drawing.Point(32, 128);
            this.calcTaxButton.Name = "calcTaxButton";
            this.calcTaxButton.Size = new System.Drawing.Size(96, 32);
            this.calcTaxButton.TabIndex = 4;
            this.calcTaxButton.Text = "&Calculate";
            this.calcTaxButton.UseVisualStyleBackColor = true;
            this.calcTaxButton.Click += new System.EventHandler(this.calcTaxButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(160, 128);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 32);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "E&xit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // frmTaxCalculator
            // 
            this.AcceptButton = this.calcTaxButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(304, 217);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.calcTaxButton);
            this.Controls.Add(this.taxBox);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaxCalculator";
            this.Text = "Tax Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.TextBox taxBox;
        private System.Windows.Forms.Button calcTaxButton;
        private System.Windows.Forms.Button closeButton;
    }
}

