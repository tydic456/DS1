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
    public partial class ex1 : Form
    {
        public ex1()
        {
            InitializeComponent();
        }

        private void btnsoma_Click(object sender, EventArgs e)
        {
           int valor1 = Convert.ToInt32(txb1.Text);
           int valor2 = Convert.ToInt32(txb2.Text);
           int soma = valor1 + valor2;

           if (soma >= 20)
           {
               soma = soma + 8;
               lblresult.Text = "Resultado (+8): " + soma;
           }

           else 
           {
               soma = soma - 5;
               lblresult.Text = "Resultado (-5): " + soma;
           }
           
        }
    }
}
