using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Am_I_Positive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {

            int number = Convert.ToInt32(numberInput.Text);


            if (number > 0)
            {
                positiveNegativeOutput.Text = $"{number} is a positive number";
            }
            else
            {
                positiveNegativeOutput.Text = $"{number} is a negative number";
            }
           


            if (number %7 == 0)
            {
                divisableBy7Output.Text = $"{number} is divisble by 7";
            }
            else
            {
                divisableBy7Output.Text = $"{number} is not divisble by 7";
            }


        }
    }

}
