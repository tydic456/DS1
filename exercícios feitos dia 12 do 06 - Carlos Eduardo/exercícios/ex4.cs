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
    public partial class ex4 : Form
    {
        public ex4()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int mes = Convert.ToInt32(txbMes.Text);

            if (mes == 1)
            {
                lblResult.Text = "Mês de Janeiro.";
            }
            else
            {
                if (mes == 2)
                {
                    lblResult.Text = "Mês de Fevereiro.";
                }
                else
                {
                    if (mes == 3)
                    {
                        lblResult.Text = "Mês de Março.";
                    }
                    else
                    {
                        if (mes == 4)
                        {
                            lblResult.Text = "Mês de Abril.";
                        }
                        else
                        {
                            if (mes == 5)
                            {
                                lblResult.Text = "Mês de Maio.";
                            }
                            else
                            {
                                if (mes == 6)
                                {
                                    lblResult.Text = "Mês de Junho.";
                                }
                                else
                                {
                                    if (mes == 7)
                                    {
                                        lblResult.Text = "Mês de Julho.";
                                    }
                                    else
                                    {
                                        if (mes == 8)
                                        {
                                            lblResult.Text = "Mês de Agosto.";
                                        }
                                        else
                                        {
                                            if (mes == 9)
                                            {
                                                lblResult.Text = "Mês de Setembro.";
                                            }
                                            else
                                            {
                                                if (mes == 10)
                                                {
                                                    lblResult.Text = "Mês de Outubro.";
                                                }
                                                else
                                                {
                                                    if (mes == 11)
                                                    {
                                                        lblResult.Text = "Mês de Novembro.";
                                                    }
                                                    else
                                                    {
                                                        if (mes == 12)
                                                        {
                                                            lblResult.Text = "Mês de Dezembro.";
                                                        }
                                                        else
                                                        {
                                                            lblResult.Text = "Mês inexistente.";
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
