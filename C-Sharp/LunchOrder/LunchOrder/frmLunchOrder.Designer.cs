namespace LunchOrder
{
    partial class frmLunchOrder
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
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblSalesTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.gbxMainCourse = new System.Windows.Forms.GroupBox();
            this.rdSalad = new System.Windows.Forms.RadioButton();
            this.rdPizza = new System.Windows.Forms.RadioButton();
            this.rdHamburger = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbxAddOns = new System.Windows.Forms.GroupBox();
            this.chkbxFries = new System.Windows.Forms.CheckBox();
            this.chkbxCond = new System.Windows.Forms.CheckBox();
            this.chkbxLetTomOn = new System.Windows.Forms.CheckBox();
            this.GroupBox1.SuspendLayout();
            this.gbxMainCourse.SuspendLayout();
            this.gbxAddOns.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPlaceOrder.Location = new System.Drawing.Point(265, 142);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(88, 23);
            this.btnPlaceOrder.TabIndex = 17;
            this.btnPlaceOrder.Text = "Place &Order";
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblOrderTotal);
            this.GroupBox1.Controls.Add(this.lblSalesTax);
            this.GroupBox1.Controls.Add(this.lblSubtotal);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(17, 134);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(224, 104);
            this.GroupBox1.TabIndex = 21;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Order total";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOrderTotal.Location = new System.Drawing.Point(104, 72);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(88, 20);
            this.lblOrderTotal.TabIndex = 5;
            this.lblOrderTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSalesTax
            // 
            this.lblSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalesTax.Location = new System.Drawing.Point(104, 48);
            this.lblSalesTax.Name = "lblSalesTax";
            this.lblSalesTax.Size = new System.Drawing.Size(88, 20);
            this.lblSalesTax.TabIndex = 4;
            this.lblSalesTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSubtotal.Location = new System.Drawing.Point(104, 24);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(88, 20);
            this.lblSubtotal.TabIndex = 3;
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(16, 72);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(80, 16);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Order total:";
            this.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label2
            // 
            this.Label2.Location = new System.Drawing.Point(16, 48);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(80, 16);
            this.Label2.TabIndex = 1;
            this.Label2.Text = "Tax (7.75%):";
            this.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(16, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Subtotal:";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxMainCourse
            // 
            this.gbxMainCourse.Controls.Add(this.rdSalad);
            this.gbxMainCourse.Controls.Add(this.rdPizza);
            this.gbxMainCourse.Controls.Add(this.rdHamburger);
            this.gbxMainCourse.Location = new System.Drawing.Point(17, 14);
            this.gbxMainCourse.Name = "gbxMainCourse";
            this.gbxMainCourse.Size = new System.Drawing.Size(144, 104);
            this.gbxMainCourse.TabIndex = 19;
            this.gbxMainCourse.TabStop = false;
            this.gbxMainCourse.Text = "Main course";
            // 
            // rdSalad
            // 
            this.rdSalad.AutoSize = true;
            this.rdSalad.Location = new System.Drawing.Point(6, 66);
            this.rdSalad.Name = "rdSalad";
            this.rdSalad.Size = new System.Drawing.Size(52, 17);
            this.rdSalad.TabIndex = 2;
            this.rdSalad.Text = "Salad";
            this.rdSalad.UseVisualStyleBackColor = true;
            this.rdSalad.CheckedChanged += new System.EventHandler(this.rdSalad_CheckedChanged);
            // 
            // rdPizza
            // 
            this.rdPizza.AutoSize = true;
            this.rdPizza.Location = new System.Drawing.Point(6, 43);
            this.rdPizza.Name = "rdPizza";
            this.rdPizza.Size = new System.Drawing.Size(50, 17);
            this.rdPizza.TabIndex = 1;
            this.rdPizza.Text = "Pizza";
            this.rdPizza.UseVisualStyleBackColor = true;
            this.rdPizza.CheckedChanged += new System.EventHandler(this.rdPizza_CheckedChanged);
            // 
            // rdHamburger
            // 
            this.rdHamburger.AutoSize = true;
            this.rdHamburger.Checked = true;
            this.rdHamburger.Location = new System.Drawing.Point(7, 20);
            this.rdHamburger.Name = "rdHamburger";
            this.rdHamburger.Size = new System.Drawing.Size(77, 17);
            this.rdHamburger.TabIndex = 0;
            this.rdHamburger.TabStop = true;
            this.rdHamburger.Text = "Hamburger";
            this.rdHamburger.UseVisualStyleBackColor = true;
            this.rdHamburger.CheckedChanged += new System.EventHandler(this.rdHamburger_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(265, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 23);
            this.btnExit.TabIndex = 18;
            this.btnExit.Text = "E&xit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbxAddOns
            // 
            this.gbxAddOns.Controls.Add(this.chkbxFries);
            this.gbxAddOns.Controls.Add(this.chkbxCond);
            this.gbxAddOns.Controls.Add(this.chkbxLetTomOn);
            this.gbxAddOns.Location = new System.Drawing.Point(180, 14);
            this.gbxAddOns.Name = "gbxAddOns";
            this.gbxAddOns.Size = new System.Drawing.Size(172, 103);
            this.gbxAddOns.TabIndex = 22;
            this.gbxAddOns.TabStop = false;
            this.gbxAddOns.Text = "Add-On Items ($.75/each)";
            // 
            // chkbxFries
            // 
            this.chkbxFries.AutoSize = true;
            this.chkbxFries.Location = new System.Drawing.Point(6, 67);
            this.chkbxFries.Name = "chkbxFries";
            this.chkbxFries.Size = new System.Drawing.Size(84, 17);
            this.chkbxFries.TabIndex = 2;
            this.chkbxFries.Text = "French Fries";
            this.chkbxFries.UseVisualStyleBackColor = true;
            // 
            // chkbxCond
            // 
            this.chkbxCond.AutoSize = true;
            this.chkbxCond.Location = new System.Drawing.Point(6, 44);
            this.chkbxCond.Name = "chkbxCond";
            this.chkbxCond.Size = new System.Drawing.Size(163, 17);
            this.chkbxCond.TabIndex = 1;
            this.chkbxCond.Text = "Ketchup, Mustard, and Mayo";
            this.chkbxCond.UseVisualStyleBackColor = true;
            // 
            // chkbxLetTomOn
            // 
            this.chkbxLetTomOn.AutoSize = true;
            this.chkbxLetTomOn.Location = new System.Drawing.Point(6, 21);
            this.chkbxLetTomOn.Name = "chkbxLetTomOn";
            this.chkbxLetTomOn.Size = new System.Drawing.Size(143, 17);
            this.chkbxLetTomOn.TabIndex = 0;
            this.chkbxLetTomOn.Text = "Lettuce, Tomato, Onions";
            this.chkbxLetTomOn.UseVisualStyleBackColor = true;
            // 
            // frmLunchOrder
            // 
            this.AcceptButton = this.btnPlaceOrder;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(377, 251);
            this.Controls.Add(this.gbxAddOns);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.gbxMainCourse);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLunchOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.frmLunchOrder_Load);
            this.GroupBox1.ResumeLayout(false);
            this.gbxMainCourse.ResumeLayout(false);
            this.gbxMainCourse.PerformLayout();
            this.gbxAddOns.ResumeLayout(false);
            this.gbxAddOns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button btnPlaceOrder;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Label lblOrderTotal;
        internal System.Windows.Forms.Label lblSalesTax;
        internal System.Windows.Forms.Label lblSubtotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.GroupBox gbxMainCourse;
        internal System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdSalad;
        private System.Windows.Forms.RadioButton rdPizza;
        private System.Windows.Forms.RadioButton rdHamburger;
        private System.Windows.Forms.GroupBox gbxAddOns;
        private System.Windows.Forms.CheckBox chkbxFries;
        private System.Windows.Forms.CheckBox chkbxCond;
        private System.Windows.Forms.CheckBox chkbxLetTomOn;
    }
}

