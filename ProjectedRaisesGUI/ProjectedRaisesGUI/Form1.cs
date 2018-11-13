using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectedRaisesGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double salary;
            double raise = 1.04;
            double newSalary;
            salary = Convert.ToDouble(txtEnterSalary.Text);

            newSalary = raise * salary;

            lblNewSalary.Text = "The new salary is $" + newSalary;
        }
    }
}
