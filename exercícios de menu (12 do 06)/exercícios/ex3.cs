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
    public partial class ex3 : Form
    {
        public ex3()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            double valorA = Convert.ToDouble(txbLadoA.Text);
            double valorB = Convert.ToDouble(txbLadoB.Text);
            double valorC = Convert.ToDouble(txbLadoC.Text);
            if (valorA >= 50 && valorB <= 10 || valorB >= 50 && valorC <= 10 || valorC >= 50 && valorA <= 10 || valorB >= 50 && valorA <= 10 || valorC >= 50 && valorB <= 10)
            {
                lblResult.Text = "Os valores não formam um triângulo.";
            }
            else
            {
                if (valorA == valorB && valorB == valorC)
                {
                    lblResult.Text = "Triângulo Equilátero.";
                }
                else
                {
                    if (valorA != valorB && valorB == valorC || valorA == valorB && valorB != valorC || valorB == valorC && valorA != valorC)
                    {
                        lblResult.Text = "Triângulo Isósceles.";
                    }
                    else
                    {
                        lblResult.Text = "Triângulo Escaleno.";
                    }
                }
            }
        }
    }
}
