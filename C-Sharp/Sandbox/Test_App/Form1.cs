using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Start();
            BirthYear(8);
            BirthYear(7);
        }

        private int age1 = 10;
        private int age2 = 15;

        private int BirthYear(int age)
        {
            int birthyear = 2020 - age;
            return birthyear;
        }

        string outPut = "";

        private void Start()
        {
            outPut = BirthYear(age1).ToString();
            outPut = BirthYear(age2).ToString();

            outPut = BirthYear(age1).ToString() + BirthYear(age2).ToString();
        }

    }
}
