using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exercícios
{
    public partial class ex2 : Form
    {
        public ex2()
        {
            InitializeComponent();
        }

        private void btnexe_Click(object sender, EventArgs e)
        {
            double valor1 = Convert.ToDouble(txb1.Text);
            double result = valor1 % 10;
            double result2 = valor1 % 5;
            double result3 = valor1 % 2;

            if (result == 0)
            {
                lblresult.Text = "Número divisivel por 10.";
            }
            if (result2 == 0)
            {
                lblresult.Text += " Número divisivel por 5.";
            }
            if (result3 == 0)
            {
                lblresult.Text += " Número divisivel por 2.";
            }
            else
            {
                lblresult.Text = "Número indivisivel por 10, por 5 e por 2.";
            }
        }
    }
}
