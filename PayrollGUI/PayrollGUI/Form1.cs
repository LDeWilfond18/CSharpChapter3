using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PayrollGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string name;
            double ssn;
            double payRate;
            double hours;
            double grossPay;
            double netPay;

            name = txtName.Text;
            ssn = Convert.ToDouble(txtSSN.Text);
            payRate = Convert.ToDouble(txtPayRate.Text);
            hours = Convert.ToDouble(txtHours.Text);

            grossPay = payRate * hours;
            netPay = grossPay - (grossPay * .15) - (grossPay* .05);

            lblResult.Text = "Your gross pay is " + grossPay + "\n Your SSN is " + ssn + "\n Your Net pay is " + netPay;
        }
    }
}
