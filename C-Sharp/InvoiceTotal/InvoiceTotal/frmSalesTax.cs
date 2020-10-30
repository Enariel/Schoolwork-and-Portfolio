using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {
        //Reference to other form
        private frmInvoiceTotal mainInvoiceFrm = null;

        public frmSalesTax()
        {
            InitializeComponent();
        }

        public frmSalesTax(Form invoiceFrm)
        {
            mainInvoiceFrm = invoiceFrm as frmInvoiceTotal;
            InitializeComponent();
        }

        //Reference to other form

        private void slsOkBtn_Click(object sender, EventArgs e)
        {
            //Take text on Okay, give it to other form
            mainInvoiceFrm.ChangePercent(Convert.ToDecimal(txtTaxBox.Text));
            //Close this form
            this.Close();
        }

        private void slsCnclBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSalesTax_Load(object sender, EventArgs e)
        {

        }
    }
}
