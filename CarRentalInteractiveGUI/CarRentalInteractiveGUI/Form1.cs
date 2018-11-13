using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double total;
            double miles;
            double days;
            miles = Convert.ToDouble(txtEnterMiles.Text);
            days = Convert.ToDouble(txtEnterDays.Text);

            total = (miles * .25) + (days * 20);

            lblTotal.Text = "The total cost is $" + total;

        }
    }
}
