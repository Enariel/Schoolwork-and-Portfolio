using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{

/*
Oliver Conover
Reservations.zip
Prof Brioso
*/
    public partial class frmDateTime : Form
    {

        private DateTime arrivalDate, departureDate, todayDate;
        private float nightRate = 120.00f, dayRate = 150.00f;
        private float cost;
        private DateTime minDate = DateTime.Today, maxDate = DateTime.Today.AddYears(5);
        public frmDateTime()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmDateTime_Load(object sender, EventArgs e)
        {
            //Get current date
            todayDate = DateTime.Today;
            //Make it a short date string
            txtArrivalDate.Text = todayDate.ToShortDateString();
            //Add three days to arrival date to estimate departure
            txtDepartureDate.Text = todayDate.AddDays(3).ToShortDateString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            cost = 0f;

            DateTime.TryParse(txtArrivalDate.Text, out arrivalDate);
            DateTime.TryParse(txtDepartureDate.Text, out departureDate);

            var nights = departureDate - arrivalDate;

            for (int i = 0; i <= nights.TotalDays; i++)
            {
                if (arrivalDate.AddDays(i).DayOfWeek == DayOfWeek.Friday || arrivalDate.AddDays(i).DayOfWeek == DayOfWeek.Saturday)
                {
                    cost += dayRate;
                }
                else
                {
                    cost += nightRate;
                }
            }

            txtNights.Text = nights.TotalDays.ToString();
            txtTotalPrice.Text = cost.ToString();
        }



        public bool IsValidData()
        {
            return
                IsPresent(txtArrivalDate, "Arrival Date") &&
                IsDateTime(txtArrivalDate, "Arrival Date") &&
                IsWithinRange(txtArrivalDate, "Arrival Date", minDate, maxDate) &&
                IsPresent(txtDepartureDate, "Departure Date") &&
                IsDateTime(txtDepartureDate, "Departure Date") &&
                IsWithinRange(txtDepartureDate, "Departure Date", minDate, maxDate);
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

        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime tempDate;
            if (!DateTime.TryParse(textBox.Text, out tempDate))
            {
                MessageBox.Show(name + " is not a valid date", "Date Error");
                textBox.Focus();
                return false;
            }

            return true;
        }

        public bool IsWithinRange(TextBox textBox, string name,
            DateTime min, DateTime max)
        {
            if (DateTime.Parse(textBox.Text) < minDate ||DateTime.Parse(textBox.Text) > maxDate)
            {
                MessageBox.Show(name + " is not a valid date", "Date Error");
                textBox.Focus();
                return false;
            }

            return true;
        }
    }
}