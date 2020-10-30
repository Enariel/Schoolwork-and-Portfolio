using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleIfStatement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string gender = "";

            gender = tboGender.Text;
            if (gender == "Male")  //conditional statement begins

            {   //a "true" condition runs the statement below
                lblResult.Text = "You must register for selective service";

            }
        }
    }
}
