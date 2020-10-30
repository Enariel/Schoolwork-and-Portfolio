using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmFactorial : Form
    {
        /*
            Oliver(Matthew) Conover
            25/9/2020
            Prof Brioso
            C#
         */

        private int num;

        public frmFactorial()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            int fromNum = Convert.ToInt32(intBox.Text);
            long num = Convert.ToInt64(intBox.Text);

            factBox.Text = Factorial(num).ToString();
        }

        private long Factorial(long num)
        {
            long fact = 1;

            for (int i = (int)num; i > 1; i--)
            {
                fact *= i;
            }
            return fact;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
