using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int contestantsThisYear;
            int contestantsLastYear;
            int totalLastYear;
            int totalThisYear;
            int cost = 25;

            contestantsThisYear = Convert.ToInt32(txtThisYear.Text);
            contestantsLastYear = Convert.ToInt32(txtLastYear.Text);

            totalThisYear = cost * contestantsThisYear;
            totalLastYear = cost * contestantsLastYear;

            

            if(contestantsThisYear > contestantsLastYear)
            {
                lblOutput.Text = "The expected revenue is: " + totalThisYear + " It is Greater this year";
            }
            else
            {
                lblOutput.Text = "The expected revenue is: " + totalThisYear + " It is less this year";
            }
        }
    }
}
