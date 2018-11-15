using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Madlibs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string color;
            string wordEndEst;
            string animal;
            string bodyPartPlural;
            string noun;
            string nounPlural;
            int num1;
            int num2;
            int num3;

            color = txtColor.Text;
            wordEndEst = txtEst.Text;
            animal = txtAnimal.Text;
            bodyPartPlural = txtBodyPart.Text;
            noun = txtNoun.Text;
            nounPlural = txtNounPlural.Text;
            num1 = Convert.ToInt32(txtNum1);
            num2 = Convert.ToInt32(txtNum2);

            num3 = num1 + num2;

            lblOutput.Text = "The " + color + " Dragon is the " + wordEndEst + " Dragon of all.It has " + num3 + " " + bodyPartPlural + " and a " + animal + " shaped like a " + noun + ". It loves to eat(plural noun), although it will feast on nearly anything."
        }
    }
}
