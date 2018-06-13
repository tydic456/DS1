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
    public partial class ex7 : Form
    {
        public ex7()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txbNum.Text);
            double a = 0;
            double m = 0;
            int cont = 0;
            double arlindo = 1.50, manoel = 1.10;

            if (n > 0)
            {
                do
                {
                    a += 0.02;
                    m += 0.03;
                    cont++;

                    arlindo = a + arlindo;
                    manoel = m + manoel;
                    if (n >= 2)
                    {
                        if (arlindo < manoel)
                        {
                            txbResult.Text = "Em " + n + " anos, Manoel será maior que Arlindo.";
                        }
                        else
                        {
                            txbResult.Text = "Em " + n + " anos, Manoel continuará sendo mais baixo que Arlindo.";
                        }
                    }
                    else 
                    {
                        txbResult.Text = "Em " + n + " ano, Manoel continuará sendo mais baixo que Arlindo."; 
                    }
                } while (cont < n);
            }
            else
            {
                txbResult.Text = "INSIRA UM NÚMERO MAIOR QUE 0!";
            }
        }
    }
}
