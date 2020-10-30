namespace myFirstCSharpForm
{
    partial class myFirstCSharpForm
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
            this.lblLength = new System.Windows.Forms.Label();
            this.tboLength = new System.Windows.Forms.TextBox();
            this.tboWidth = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(34, 23);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(101, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Please enter length:";
            // 
            // tboLength
            // 
            this.tboLength.Location = new System.Drawing.Point(167, 22);
            this.tboLength.Name = "tboLength";
            this.tboLength.Size = new System.Drawing.Size(69, 20);
            this.tboLength.TabIndex = 1;
            // 
            // tboWidth
            // 
            this.tboWidth.Location = new System.Drawing.Point(167, 67);
            this.tboWidth.Name = "tboWidth";
            this.tboWidth.Size = new System.Drawing.Size(69, 20);
            this.tboWidth.TabIndex = 3;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(34, 68);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(97, 13);
            this.lblWidth.TabIndex = 2;
            this.lblWidth.Text = "Please enter width:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(97, 126);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(95, 35);
            this.btnRun.TabIndex = 4;
            this.btnRun.Text = "Compute Area";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Location = new System.Drawing.Point(66, 188);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(169, 46);
            this.lblResult.TabIndex = 5;
            // 
            // myFirstCSharpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.tboWidth);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.tboLength);
            this.Controls.Add(this.lblLength);
            this.Name = "myFirstCSharpForm";
            this.Text = "Compute Area";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.TextBox tboLength;
        private System.Windows.Forms.TextBox tboWidth;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblResult;
    }
}

