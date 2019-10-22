using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.ComponentModel;

namespace Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn1_Clicked(object sender, EventArgs e)
        {
            operacion(1);
        }

        private void btn2_Clicked(object sender, EventArgs e)
        {
            operacion(2);
        }

        private void btn3_Clicked(object sender, EventArgs e)
        {
            operacion(3);
        }

        private void btn4_Clicked(object sender, EventArgs e)
        {
            operacion(4);
        }


        public void operacion(int boton)
        {
            if (txt1.Text != "" && ed1.Text != "")
            {
                double num1 = Convert.ToDouble(txt1.Text);
                double num2 = Convert.ToDouble(ed1.Text);
                double resultado = 0;

                switch (boton)
                {
                    case 1:
                        resultado = num1 + num2;
                        break;
                    case 2:
                        resultado = num1 - num2;
                        break;
                    case 3:
                        resultado = num1 * num2;
                        break;
                    case 4:
                        resultado = num1 / num2;
                        break;
                    default:
                        break;
                }

                lblResult.Text = Convert.ToString(resultado);
            }
        }

       

       
    }
}
