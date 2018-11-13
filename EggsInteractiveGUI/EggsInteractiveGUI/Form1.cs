using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EggsInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateEggs_Click(object sender, EventArgs e)
        {
            int dozen;
            int extra;
            int total;
            int chick1;
            int chick2;
            int chick3;
            int chick4;
            int chick5;
            chick1 = Convert.ToInt32(txtChick1);
            chick2 = Convert.ToInt32(txtChick2);
            chick3 = Convert.ToInt32(txtChick3);
            chick4 = Convert.ToInt32(txtChick4);
            chick5 = Convert.ToInt32(txtChick5);

            total = chick1 + chick2 + chick3 + chick4 + chick5;
            dozen = total / 12;
            extra = total % 12;

        }
    }
}
