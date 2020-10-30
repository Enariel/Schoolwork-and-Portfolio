using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace myFirstCSharpForm
{
    public partial class myFirstCSharpForm : Form
    {
        public myFirstCSharpForm()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            int length;
            int width;
            int area;

            length = int.Parse(tboLength.Text);
            width = int.Parse(tboWidth.Text);
            area = length * width;
            this.Text = "Area Computed!";
            lblResult.Text = Convert.ToString(area);


            //MessageBox.Show(Convert.ToString(area));

        }

        
    }
}
