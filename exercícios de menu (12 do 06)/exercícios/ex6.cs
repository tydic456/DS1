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
    public partial class ex6 : Form
    {
        public ex6()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txbNum.Text);
            int p = 0;

            if (n > 0)
            {
                do
                {
                    p++;
                    txbResult.Text += "Brasil! ";
                } while (p < n);
            }
            else
            {
                txbResult.Text = "INSIRA UM NÚMERO MAIOR QUE 0!";
            }
        }
    }
}
