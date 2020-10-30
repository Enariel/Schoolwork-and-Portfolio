using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class frmTaxCalculator : Form
    {
        /*
            Oliver(Matthew) Conover
            Prof. Brioso
            C#
            Tax Calculator
         */
        private double preTax, totalTax;
        private double taxRate, excess;
        //Create an array of tax brackets to loop through
        public frmTaxCalculator()
        {
            InitializeComponent();
        }

        private void calcTaxButton_Click(object sender, EventArgs e)
        {
            //Reinstantiate new doubles 
            preTax = new double();
            totalTax = new double();

            preTax = Convert.ToDouble(inputBox.Text);
            CalculateTax(preTax);
        }

        private void CalculateTax(double preTax)
        {
            var taxBrackets = new[]
            {
                new { Lower = 0d, Upper = 9225d, rate = 0.1d, flatTax = 0d, excess = 0d },
                new { Lower = 9225d, Upper = 37450d, rate = .15d, flatTax = 922.5d, excess = 9225d },
                new { Lower = 37450d, Upper = 90750d, rate = .25d, flatTax = 5156.25d, excess = 37450d },
                new { Lower = 90750d, Upper = 189300d, rate = .28d, flatTax = 18481d, excess = 90750d },
                new { Lower = 189300d, Upper = 411500d, rate = .33d, flatTax = 46075.25d, excess = 189300d },
                new { Lower = 411500d, Upper = 413200d, rate = .35d, flatTax = 119401.25d, excess = 411500d },
                new { Lower = 413200d, Upper = double.MaxValue, rate = .396d, flatTax = 119996.25d, excess = 413200d }
            };

            foreach (var taxBracket in taxBrackets)
            {
                if (preTax > taxBracket.Lower)
                {
                    var thisBracket = Math.Min(taxBracket.Upper - taxBracket.Lower, preTax - taxBracket.excess);
                    var thisTax = (thisBracket * taxBracket.rate) + taxBracket.flatTax;
                    totalTax += thisTax;
                }
            }
            taxBox.Text = totalTax.ToString();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
