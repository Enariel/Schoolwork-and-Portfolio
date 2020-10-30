using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    /*
     * Oliver Conover
     * 10-2
     * Prof Brioso
     * 30/10/2020
     */
    public partial class frmLunchOrder : Form
    {
        private string[,] mainMenu = new string[,] { {"Hamburger", "6.95"}, {"Pizza" , "5.95"}, {"Salad", "4.95"} };
        private List<RadioButton> radioButtons = new List<RadioButton>();
        private List<CheckBox> addOns = new List<CheckBox>();
        private const decimal addOnPrice = .75m, taxRate = .0775m;
        public frmLunchOrder()
        {
            InitializeComponent();
        }

        private void frmLunchOrder_Load(object sender, EventArgs e)
        {
            LoadBtns();
            ClearTotals();
            ClearAddOns();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            //Do maths
            decimal sub, tax, total;
            sub = CalcSubTotal();
            tax = CalcTax(sub, taxRate);
            total = CalcGrandTotal(sub, tax);

            //Send to output labels
            lblSubtotal.Text = sub.ToString("C");
            lblSalesTax.Text = tax.ToString("C");
            lblOrderTotal.Text = total.ToString("C");
        }

        private decimal CalcGrandTotal(decimal sub, decimal tax)
        {
            return sub + tax;
        }

        private decimal CalcTax(decimal subtotal, decimal taxRate)
        {
            return subtotal * taxRate;
        }

        private decimal CalcSubTotal()
        {
            decimal subtotal = 0, mainCost = 0, addCost = 0;

            int index = 0;

            //Use multidimensional array to add correct price
            foreach (RadioButton button in radioButtons)
            {
                if (button.Checked == true)
                {
                    mainCost += Convert.ToDecimal(mainMenu[index, 1]);
                    index++;
                }
            }

            foreach (CheckBox check in addOns)
            {
                if (check.Checked == true)
                {
                    addCost += addOnPrice;
                }
            }

            subtotal = mainCost + addCost;

            return subtotal;
        }

        private void ClearTotals()
        {
            lblOrderTotal.Text = "";
            lblSalesTax.Text = "";
            lblSubtotal.Text = "";
        }

        private void ClearAddOns()
        {
            foreach(CheckBox box in addOns)
            {
                box.Checked = false;
            }
        }

        //Section to change text on radial button change, not sure how to check
        //an event was changed from a list structure.
        private void rdSalad_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
            addOns[0].Text = "Avocado";
            addOns[1].Text = "Extra Dressing";
            addOns[2].Text = "Croutons";
        }

        private void rdPizza_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
            addOns[0].Text = "Alfredo Sauce";
            addOns[1].Text = "Olives";
            addOns[2].Text = "Mushrooms";
        }

        private void rdHamburger_CheckedChanged(object sender, EventArgs e)
        {
            ClearAddOns();
            ClearTotals();
            addOns[0].Text = "Lettuce, Tomato, and Onions";
            addOns[1].Text = "Ketchup, Mustard, and Mayo";
            addOns[2].Text = "French Fries";
        }

        private void LoadBtns()
        {
            //Add radiobuttons to list
            radioButtons.Add(rdHamburger);
            radioButtons.Add(rdPizza);
            radioButtons.Add(rdSalad);

            //Add checkboxes
            addOns.Add(chkbxLetTomOn);
            addOns.Add(chkbxCond);
            addOns.Add(chkbxFries);

            int index = 0;

            //Use multidimensional array to add correct and updated information to menu
            foreach (RadioButton button in radioButtons)
            {
                button.Text = mainMenu[index, 0] + " - $" + mainMenu[index, 1];
                index++;
            }

            //Set default
            radioButtons[0].Checked = true;
        }
    }
}