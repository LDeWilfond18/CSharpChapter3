using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sum;
            num1 = Convert.ToInt32(txtinputnumber.Text);
            num2 = Convert.ToInt32(txtinputnumber2.Text);

            sum = num1 + num2;
            lblResult.Text = "The sum is " + sum;
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int sub;
            num1 = Convert.ToInt32(txtinputnumber.Text);
            num2 = Convert.ToInt32(txtinputnumber2.Text);

            sub = num1 - num2;
            lblResultSub.Text = "The dif is " + sub;
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mult;
            num1 = Convert.ToInt32(txtinputnumber.Text);
            num2 = Convert.ToInt32(txtinputnumber2.Text);

            mult = num1 * num2;
            lblResultMult.Text = "The product is " + mult;
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int Div;
            num1 = Convert.ToInt32(txtinputnumber.Text);
            num2 = Convert.ToInt32(txtinputnumber2.Text);

            Div = num1 / num2;
            lblResultDiv.Text = "The quotient is " + Div;
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int mod;
            num1 = Convert.ToInt32(txtinputnumber.Text);
            num2 = Convert.ToInt32(txtinputnumber2.Text);

            mod = num1 % num2;
            lblMod.Text = "The answer is " + mod;
        }
    }
}
