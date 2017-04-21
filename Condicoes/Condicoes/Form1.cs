using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Condicoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int valor = 2;

            if (valor == 2 || valor == 2 && valor == 2)
            {
                lblResultado.Text = "If";
            }
            else if (valor < 2)
            {
                lblResultado.Text = "Else If";
            }
            else if (valor > 2)
            {
                lblResultado.Text = "Else If";
            }
            else
            {
                lblResultado.Text = "Else";
            }

            int valor2 = 3;

            switch (valor2)
            {
                case 1:
                    lblResultado.Text = "1";
                    break;
                case 2:
                    lblResultado.Text = "2";
                    break;
                case 3:
                    lblResultado.Text = "3";
                    break;
                default:
                    lblResultado.Text = "Default";
                    break;
            }

            int valor3 = 20;

            lblResultado.Text = valor3 == 20 ? "Sim" : "Não"; 
        }
    }
}
