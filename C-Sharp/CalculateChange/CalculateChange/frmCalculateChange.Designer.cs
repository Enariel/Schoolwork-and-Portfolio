namespace CalculateChange
{
    partial class frmCalculateChange
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.centBox = new System.Windows.Forms.TextBox();
            this.pennyBox = new System.Windows.Forms.TextBox();
            this.nickleBox = new System.Windows.Forms.TextBox();
            this.dimeBox = new System.Windows.Forms.TextBox();
            this.quarterBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(32, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Cents in Whole Numbers: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(32, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pennies:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(32, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dimes: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(32, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nickles: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(32, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quarters: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // centBox
            // 
            this.centBox.Location = new System.Drawing.Point(234, 32);
            this.centBox.Name = "centBox";
            this.centBox.Size = new System.Drawing.Size(124, 20);
            this.centBox.TabIndex = 5;
            // 
            // pennyBox
            // 
            this.pennyBox.Location = new System.Drawing.Point(234, 63);
            this.pennyBox.Name = "pennyBox";
            this.pennyBox.ReadOnly = true;
            this.pennyBox.Size = new System.Drawing.Size(124, 20);
            this.pennyBox.TabIndex = 6;
            // 
            // nickleBox
            // 
            this.nickleBox.Location = new System.Drawing.Point(234, 95);
            this.nickleBox.Name = "nickleBox";
            this.nickleBox.ReadOnly = true;
            this.nickleBox.Size = new System.Drawing.Size(124, 20);
            this.nickleBox.TabIndex = 7;
            // 
            // dimeBox
            // 
            this.dimeBox.Location = new System.Drawing.Point(234, 127);
            this.dimeBox.Name = "dimeBox";
            this.dimeBox.ReadOnly = true;
            this.dimeBox.Size = new System.Drawing.Size(124, 20);
            this.dimeBox.TabIndex = 8;
            // 
            // quarterBox
            // 
            this.quarterBox.Location = new System.Drawing.Point(234, 159);
            this.quarterBox.Name = "quarterBox";
            this.quarterBox.ReadOnly = true;
            this.quarterBox.Size = new System.Drawing.Size(124, 20);
            this.quarterBox.TabIndex = 9;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(132, 195);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(96, 32);
            this.calcButton.TabIndex = 10;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(254, 195);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(96, 32);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "E&xit";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // frmCalculateChange
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 249);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.quarterBox);
            this.Controls.Add(this.dimeBox);
            this.Controls.Add(this.nickleBox);
            this.Controls.Add(this.pennyBox);
            this.Controls.Add(this.centBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmCalculateChange";
            this.Text = "Calculate Change";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox centBox;
        private System.Windows.Forms.TextBox pennyBox;
        private System.Windows.Forms.TextBox nickleBox;
        private System.Windows.Forms.TextBox dimeBox;
        private System.Windows.Forms.TextBox quarterBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button closeButton;
    }
}

