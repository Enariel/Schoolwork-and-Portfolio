namespace NestedIfStatement
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
            this.label1 = new System.Windows.Forms.Label();
            this.tboGender = new System.Windows.Forms.TextBox();
            this.tboAge = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Gender:";
            // 
            // tboGender
            // 
            this.tboGender.Location = new System.Drawing.Point(116, 36);
            this.tboGender.Name = "tboGender";
            this.tboGender.Size = new System.Drawing.Size(116, 20);
            this.tboGender.TabIndex = 1;
            // 
            // tboAge
            // 
            this.tboAge.Location = new System.Drawing.Point(116, 84);
            this.tboAge.Name = "tboAge";
            this.tboAge.Size = new System.Drawing.Size(116, 20);
            this.tboAge.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Age:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(103, 125);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(82, 43);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(58, 186);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(174, 57);
            this.lblResult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tboAge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboGender);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Nested If Statement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboGender;
        private System.Windows.Forms.TextBox tboAge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblResult;
    }
}

