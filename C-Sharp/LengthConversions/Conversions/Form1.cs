using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{

    /*
     * Oliver Conover
     * 10-1
     * Prof Brioso
     * 30/10/2020
     * 
     * **/
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[,] conversionTable = {
			{"Miles to kilometers", "Miles", "Kilometers", "1.6093"},
			{"Kilometers to miles", "Kilometers", "Miles", "0.6214"},
			{"Feet to meters", "Feet", "Meters", "0.3048"},
			{"Meters to feet", "Meters", "Feet", "3.2808"},
			{"Inches to centimeters", "Inches", "Centimeters", "2.54"},
			{"Centimeters to inches", "Centimeters", "Inches", "0.3937"}
		};

        //On load, set the combo box values using method.
        private void Form1_Load(object sender, EventArgs e)
        {
            SetComboBoxValues();
        }

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        public bool IsDecimal(TextBox textBox, string name)
        {
            try
            {
                Convert.ToDecimal(textBox.Text);
                return true;
            }
            catch (FormatException)
            {
                MessageBox.Show(name + " must be a decimal number.", "Entry Error");
                textBox.Focus();
                return false;
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (OnValidate(txtLength, "Entry") == true)
            {
                decimal num = Convert.ToDecimal(txtLength.Text);
                lblCalculatedLength.Text = OnConvert(num).ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool OnValidate(TextBox textBox, string name)
        {
            return
                IsPresent(textBox, name) &&
                IsDecimal(textBox, name);
        }
        private void SetComboBoxValues()
        {
            //Loop through x value
            for (int i = 0; i < conversionTable.GetLength(0); i++)
            {
                //Loop through y value
                for (int j = 0; j < conversionTable.GetLength(1); j++)
                {
                    //Everytime J is 0, add conversionTable at i, 0 to comboBox
                    string s = conversionTable[i, j];

                    if (j == 0)
                    {
                        cboConversions.Items.Add(s);
                    }
                }
            }
            //Set default and focus
            cboConversions.SelectedIndex = 0;
            txtLength.Focus();

        }

        //On comboBox change
        private void cboConversions_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get index of selection
            int index = cboConversions.SelectedIndex;

            //Change text by using the changed index
            if (index <= conversionTable.Length && index <= 5)
            {
                switch (index)
                {
                    case 0:
                        lblFromLength.Text = conversionTable[index, 1] + ":";
                        lblToLength.Text = conversionTable[index, 2] + ":";
                        break;
                    case 1:
                        lblFromLength.Text = conversionTable[index, 1] + ":";
                        lblToLength.Text = conversionTable[index, 2] + ":";
                        break;
                    case 2:
                        lblFromLength.Text = conversionTable[index, 1] + ":";
                        lblToLength.Text = conversionTable[index, 2] + ":";
                        break;
                    case 3:
                        lblFromLength.Text = conversionTable[index, 1] + ":";
                        lblToLength.Text = conversionTable[index, 2] + ":";
                        break;
                    case 4:
                        lblFromLength.Text = conversionTable[index, 1] + ":";
                        lblToLength.Text = conversionTable[index, 2] + ":";
                        break;
                    case 5:
                        lblFromLength.Text = conversionTable[index, 1] + ":";
                        lblToLength.Text = conversionTable[index, 2] + ":";
                        break;
                }
            }
            Console.WriteLine(index);
            //Focus text box
            txtLength.Focus();
            //Clear calculated label
            lblCalculatedLength.Text = "";
        }

        private decimal OnConvert(decimal num)
        {
            decimal conversionNum = Convert.ToDecimal(conversionTable[cboConversions.SelectedIndex, 3]);

            return num * conversionNum;
        }
    }
}