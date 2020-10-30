using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Oliver Conover
/// Prof. Brioso
/// C# - Area and Perimeter
/// </summary>

namespace AreaAndPerimeter
{
    public partial class frmAreaAndPerimeter : Form
    {
        private float length, width, area, perimeter;
        public frmAreaAndPerimeter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            length = Convert.ToInt32(lengthInput.Text);
            width = Convert.ToInt32(widthInput.Text);

            areaBox.Text = CalculateArea(length, width).ToString();
            perimeterBox.Text = CalculatePerimeter(length, width).ToString();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private float CalculateArea(float l, float w)
        {
            area = l * w;
            return area;
        }

        private float CalculatePerimeter(float l, float w)
        {
            perimeter = (2 * l) + (2 * w);
            return perimeter;
        }
    }
}
