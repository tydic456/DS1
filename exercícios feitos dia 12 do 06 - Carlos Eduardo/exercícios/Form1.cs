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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tsbtn1_Click(object sender, EventArgs e)
        {
            ex1 exercicio1 = new ex1();
            exercicio1.MdiParent = this;
            exercicio1.Show();
        }

        private void tsbtn2_Click(object sender, EventArgs e)
        {
            ex2 exercicio2 = new ex2();
            exercicio2.MdiParent = this;
            exercicio2.Show();
        }

        private void tsbtn3_Click(object sender, EventArgs e)
        {
            ex3 exercicio3 = new ex3();
            exercicio3.MdiParent = this;
            exercicio3.Show();
        }

        private void tsbtn4_Click(object sender, EventArgs e)
        {
            ex4 exercicio4 = new ex4();
            exercicio4.MdiParent = this;
            exercicio4.Show();
        }

        private void tsBtn5_Click(object sender, EventArgs e)
        {
            ex5 exercicio5 = new ex5();
            exercicio5.MdiParent = this;
            exercicio5.Show();
        }

        private void tsBtn6_Click(object sender, EventArgs e)
        {
            ex6 exercicio6 = new ex6();
            exercicio6.MdiParent = this;
            exercicio6.Show();
        }

        private void tsBtn7_Click(object sender, EventArgs e)
        {
            ex7 exercicio7 = new ex7();
            exercicio7.MdiParent = this;
            exercicio7.Show();
        }
    }
}
