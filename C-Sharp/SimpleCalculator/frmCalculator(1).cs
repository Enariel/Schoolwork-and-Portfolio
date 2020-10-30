using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmCalculator : Form
    {
        // Oliver (Matthew) Conover
        // 6-1, 7-1, 7-2 Simple Calculator
        // C#
        // Brioso
        //The submission of this assignment includes 7-1, 7-2

        private decimal result;
        private string sResult;
        public frmCalculator()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            //7-1 Try/Catch
            try
            {
                decimal num1 = Convert.ToDecimal(firstNumBox.Text);
                decimal num2 = Convert.ToDecimal(secNumBox.Text);
                string operand = opBox.Text;

                if (IsValid(firstNumBox, secNumBox, opBox, num1, num2, operand))
                {
                    DoMath(num1, num2, operand);
                    //Format String
                    sResult = result.ToString("0.####");
                    resultBox.Text = sResult;
                }
            }
            /*catch(FormatException ex)
            {
                MessageBox.Show( "Please enter a valid entry. Numbers cannot contain letters, and operands cannot contain numbers. \n" + ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Error: False Entry" );
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Entry too large for calculations. \n" + ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Error: Number Too Big");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("You have committed the ultimate mathematical sin of dividing by zero. \n" + ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Error: Black Hole");
            }*/
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" + ex.GetType().ToString() + "\n" + ex.StackTrace, "Exception:");
            }
        }

        //Case-Switch to for the operations 
        private void DoMath(decimal x1, decimal x2, string op)
        {
            switch (op)
            {
                case "+":
                    result = Add(x1, x2);
                    break;
                case "-":
                    result = Subtract(x1, x2);
                    break;
                case "*":
                    result = Multiply(x1, x2);
                    break;
                case "/":
                    result = Divide(x1, x2);
                    break;

            }
        }
        //Maths
        private decimal Add(decimal num1, decimal num2)
        {
            decimal x = num1 + num2;
            return x; 
        }

        private decimal Subtract(decimal num1, decimal num2)
        {
            decimal x = num1 - num2;
            return x;
        }
        private decimal Multiply(decimal num1, decimal num2)
        {
            decimal x = num1 * num2;
            return x;
        }
        private decimal Divide(decimal num1, decimal num2)
        {
            decimal x = num1 / num2;
            return x;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //7-2 Data Validation

        private bool IsPresent(TextBox text, string s)
        {
            if(text.Text == "")
            {
                MessageBox.Show( s + " is a required field.", "Error: Entry");
                text.Focus();
                return false;
            }

            return true;
        }

        private bool IsDecimal(TextBox numBox, decimal num)
        {
            if (!Decimal.TryParse(numBox.Text, out num))
            {
                MessageBox.Show("Must be a valid number", "Error: Entry");

                numBox.Focus();

                return false;
            }

            return true;
        }

        private bool IsWithinRange(TextBox numBox, decimal num)
        {
            if (num < -1000000 || num > 1000000)
            {
                MessageBox.Show("Must be a valid number", "Error: Entry");

                numBox.Focus();

                return false;
            }

            return true;
        }

        private bool IsOperator(TextBox opBox)
        {
            string o = opBox.Text;

            if (o == "+" || o == "-" || o == "*" || o == "/")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Must be a valid operator", "Error: Entry");

                opBox.Focus();
            }

            return false;
        }

        private bool IsValid(TextBox numBox1, TextBox numBox2, TextBox opBox, decimal num1, decimal num2, string o)
        {
            return

                //Validate first box
                IsPresent(firstNumBox, "First Number") &&
                IsDecimal(numBox1, num1) &&
                IsWithinRange(numBox1, num1) &&
                //Validate Operator
                IsPresent(opBox, "Operator") &&
                IsOperator(opBox) &&
                //Validate second box
                IsPresent(secNumBox, "Second Number") &&
                IsDecimal(numBox2, num2) &&
                IsWithinRange(numBox2, num2);
        }
    }
}
