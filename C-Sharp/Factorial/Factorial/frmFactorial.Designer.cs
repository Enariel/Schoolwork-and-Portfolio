namespace WindowsFormsApp1
{
    partial class frmFactorial
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
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.intLabel = new System.Windows.Forms.Label();
            this.factLabel = new System.Windows.Forms.Label();
            this.intBox = new System.Windows.Forms.TextBox();
            this.factBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 149);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(96, 32);
            this.calcButton.TabIndex = 0;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(132, 149);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 32);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(12, 13);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(74, 13);
            this.intLabel.TabIndex = 2;
            this.intLabel.Text = "Enter and Int: ";
            // 
            // factLabel
            // 
            this.factLabel.AutoSize = true;
            this.factLabel.Location = new System.Drawing.Point(12, 78);
            this.factLabel.Name = "factLabel";
            this.factLabel.Size = new System.Drawing.Size(83, 13);
            this.factLabel.TabIndex = 3;
            this.factLabel.Text = "Factorial Result:";
            // 
            // intBox
            // 
            this.intBox.Location = new System.Drawing.Point(128, 10);
            this.intBox.Name = "intBox";
            this.intBox.Size = new System.Drawing.Size(100, 20);
            this.intBox.TabIndex = 4;
            // 
            // factBox
            // 
            this.factBox.Location = new System.Drawing.Point(128, 71);
            this.factBox.Name = "factBox";
            this.factBox.Size = new System.Drawing.Size(100, 20);
            this.factBox.TabIndex = 5;
            // 
            // frmFactorial
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 193);
            this.Controls.Add(this.factBox);
            this.Controls.Add(this.intBox);
            this.Controls.Add(this.factLabel);
            this.Controls.Add(this.intLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Name = "frmFactorial";
            this.Text = "Calculate Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.Label factLabel;
        private System.Windows.Forms.TextBox intBox;
        private System.Windows.Forms.TextBox factBox;
    }
}

