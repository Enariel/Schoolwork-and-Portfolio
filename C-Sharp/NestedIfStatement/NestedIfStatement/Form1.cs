using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NestedIfStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string gender;  //declare gender variable
            int age;        //decare age variable

            gender = tboGender.Text;
            age = Convert.ToInt16(tboAge.Text);

            {
                if (gender == "Male")

                {
                    if (age > 17)

                    {
                        //a "true" condition runs the statement below
                        lblResult.Text = " You must register for selective service";
                    }

                    else
                    {
                        //a false condition runs the statement below
                        lblResult.Text = " You are not required to register for selective service";
                    }
                }
                else
                {
                    //a false condition runs the statement below
                    lblResult.Text = " You are not required to register for selective service";
                }
            }
        }
    }
}
