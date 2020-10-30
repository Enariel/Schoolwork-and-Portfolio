using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculateChange
{
    public partial class frmCalculateChange : Form
    {
        /*
            Oliver(Matthew) Conover
            25/9/2020
            Prof Brioso
            C#
        */

        private int totalChange;
        private int numQuarters = 0, numDimes = 0, numNickles = 0, numPennies = 0;

        public frmCalculateChange()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //Reset all the integers so that they dont keep adding up
            totalChange = new int();
            numQuarters = new int();
            numDimes = new int();
            numNickles = new int();
            numPennies = new int();
            //Convert to int 32
            totalChange = Convert.ToInt32(centBox.Text);
            //Pass change into function to calculate total change
            CalculateChange(totalChange);
            
        }

        private void CalculateChange(int change)
        {
            //Will loop while total change is > 0
            while (totalChange > 0)
            {
                //Conditions for change
                if (totalChange >= 25)
                {
                    numQuarters += 1;
                    totalChange -= 25;
                }
                else if (totalChange >= 10 && totalChange < 25)
                {
                    numDimes += 1;
                    totalChange -= 10;
                }
                else if (totalChange >= 5 && totalChange < 10)
                {
                    numNickles += 1;
                    totalChange -= 5;
                }
                else if (totalChange >=1 && totalChange < 5)
                {
                    numPennies += 1;
                    totalChange -= 1;
                }

                //There is no else statement as there isn't a default to fall back on
            }


            //Output results to form
            pennyBox.Text = numPennies.ToString();
            nickleBox.Text = numNickles.ToString();
            dimeBox.Text = numDimes.ToString();
            quarterBox.Text = numQuarters.ToString();
        }

        //Close the form
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
