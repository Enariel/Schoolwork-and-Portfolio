namespace ScoreCalculator
{
    partial class frmScoreCalc
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
            this.scoreBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.scoreEntry = new System.Windows.Forms.TextBox();
            this.scoreTotalBox = new System.Windows.Forms.TextBox();
            this.scoreCountBox = new System.Windows.Forms.TextBox();
            this.averageBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.clearScores = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // scoreBox
            // 
            this.scoreBox.AutoSize = true;
            this.scoreBox.Location = new System.Drawing.Point(30, 20);
            this.scoreBox.MaximumSize = new System.Drawing.Size(150, 0);
            this.scoreBox.MinimumSize = new System.Drawing.Size(75, 0);
            this.scoreBox.Name = "scoreBox";
            this.scoreBox.Size = new System.Drawing.Size(75, 13);
            this.scoreBox.TabIndex = 0;
            this.scoreBox.Text = "Score:";
            this.scoreBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 50);
            this.label2.MaximumSize = new System.Drawing.Size(150, 0);
            this.label2.MinimumSize = new System.Drawing.Size(75, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Score Total:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 80);
            this.label3.MaximumSize = new System.Drawing.Size(150, 0);
            this.label3.MinimumSize = new System.Drawing.Size(75, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Score Count:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 110);
            this.label4.MaximumSize = new System.Drawing.Size(150, 0);
            this.label4.MinimumSize = new System.Drawing.Size(75, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Average:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // scoreEntry
            // 
            this.scoreEntry.Location = new System.Drawing.Point(120, 20);
            this.scoreEntry.Name = "scoreEntry";
            this.scoreEntry.Size = new System.Drawing.Size(50, 20);
            this.scoreEntry.TabIndex = 1;
            // 
            // scoreTotalBox
            // 
            this.scoreTotalBox.Location = new System.Drawing.Point(120, 50);
            this.scoreTotalBox.Name = "scoreTotalBox";
            this.scoreTotalBox.Size = new System.Drawing.Size(50, 20);
            this.scoreTotalBox.TabIndex = 3;
            // 
            // scoreCountBox
            // 
            this.scoreCountBox.Location = new System.Drawing.Point(120, 80);
            this.scoreCountBox.Name = "scoreCountBox";
            this.scoreCountBox.Size = new System.Drawing.Size(50, 20);
            this.scoreCountBox.TabIndex = 4;
            // 
            // averageBox
            // 
            this.averageBox.Location = new System.Drawing.Point(120, 110);
            this.averageBox.Name = "averageBox";
            this.averageBox.Size = new System.Drawing.Size(50, 20);
            this.averageBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(190, 20);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 25);
            this.addButton.TabIndex = 2;
            this.addButton.Text = "&Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // clearScores
            // 
            this.clearScores.Location = new System.Drawing.Point(95, 136);
            this.clearScores.Name = "clearScores";
            this.clearScores.Size = new System.Drawing.Size(75, 25);
            this.clearScores.TabIndex = 6;
            this.clearScores.Text = "&Clear Scores";
            this.clearScores.UseVisualStyleBackColor = true;
            this.clearScores.Click += new System.EventHandler(this.clearScores_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(190, 136);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 25);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // frmScoreCalc
            // 
            this.AcceptButton = this.addButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearScores);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.averageBox);
            this.Controls.Add(this.scoreCountBox);
            this.Controls.Add(this.scoreTotalBox);
            this.Controls.Add(this.scoreEntry);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreBox);
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(300, 220);
            this.MinimumSize = new System.Drawing.Size(300, 220);
            this.Name = "frmScoreCalc";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox scoreEntry;
        private System.Windows.Forms.TextBox scoreTotalBox;
        private System.Windows.Forms.TextBox scoreCountBox;
        private System.Windows.Forms.TextBox averageBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearScores;
        private System.Windows.Forms.Button exitButton;
    }
}

