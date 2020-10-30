namespace SimpleCalculator
{
    partial class frmCalculator
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
            this.firstNumBox = new System.Windows.Forms.TextBox();
            this.opBox = new System.Windows.Forms.TextBox();
            this.secNumBox = new System.Windows.Forms.TextBox();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // firstNumBox
            // 
            this.firstNumBox.Location = new System.Drawing.Point(92, 12);
            this.firstNumBox.Name = "firstNumBox";
            this.firstNumBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumBox.TabIndex = 0;
            // 
            // opBox
            // 
            this.opBox.Location = new System.Drawing.Point(92, 38);
            this.opBox.Name = "opBox";
            this.opBox.Size = new System.Drawing.Size(24, 20);
            this.opBox.TabIndex = 1;
            // 
            // secNumBox
            // 
            this.secNumBox.Location = new System.Drawing.Point(92, 64);
            this.secNumBox.Name = "secNumBox";
            this.secNumBox.Size = new System.Drawing.Size(100, 20);
            this.secNumBox.TabIndex = 2;
            // 
            // resultBox
            // 
            this.resultBox.Location = new System.Drawing.Point(92, 90);
            this.resultBox.Name = "resultBox";
            this.resultBox.Size = new System.Drawing.Size(100, 20);
            this.resultBox.TabIndex = 3;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(12, 128);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 4;
            this.calcButton.Text = "&Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(117, 128);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "First Num";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Operator";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Second Num";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Result";
            // 
            // frmCalculator
            // 
            this.AcceptButton = this.calcButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 163);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.secNumBox);
            this.Controls.Add(this.opBox);
            this.Controls.Add(this.firstNumBox);
            this.Name = "frmCalculator";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNumBox;
        private System.Windows.Forms.TextBox opBox;
        private System.Windows.Forms.TextBox secNumBox;
        private System.Windows.Forms.TextBox resultBox;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

