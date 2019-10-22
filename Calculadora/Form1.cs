using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operacion(1);
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operacion(2);
        }

        private void btnDivison_Click(object sender, EventArgs e)
        {
            operacion(3);
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operacion(4);
        }

        public void operacion(int boton)
        {
            if (txtNum1.Text != "" && txtNum2.Text != "")
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);
                double resultado = 0;

                switch (boton)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 * num2;
                        break;
                    case 3:
                        resultado = num1 / num2;
                        break;
                    case 4:
                        resultado = num1 - num2;
                        break;
                    default:
                        break;
                }

                lblNumResultado.Text = Convert.ToString(resultado);
            }
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsNumber(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsPunctuation(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }
    }
}
