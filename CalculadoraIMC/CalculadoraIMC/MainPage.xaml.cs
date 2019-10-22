using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMC
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            Double peso = Convert.ToDouble(txtpeso.Text);
            Double estatura = Convert.ToDouble(txtaltura.Text);
            //string edad = cbEdad.SelectedValue.ToString();
            //string sexo = cbSexo.SelectedValue.ToString();

            double imc = CalcularIMC(peso, estatura);
            //En java esta propiedad .Text es setText
            lblResult.Text = imc.ToString();
            lblCategoria.Text = getBMICategoria(imc);
            //lblCompensacionIMC.Text = "IMC ideal = 18.5 - 25\nTu peso ideal es: " + PesoIdeal(estatura);
        }

        //String[] opcionesEdad = new String[] {"Al nacer","1 mes","2 meses","3 meses","4 meses", "5 meses", "6 meses", "7 meses", "8 meses","9 meses",
        //    "10 meses","11 meses","1 año","1 año 6 meses","2 años","2 años 6 meses","3 años","3 años 6 meses","4 años","4 años 6 meses",
        //    "5 años","5 años 6 meses", "6 años","6 años 6 meses", "7 años","7 años 6 meses","8 años","8 años 6 meses", "9 años","9 años 6 meses",
        //    "10 años","11 años","12 años","13 años","14 años","15 años","16 años","17 años","18 años","19 años",
        //    "20 años o mas"};

        //String[] opcionesSexo = new String[] { "Femenino", "Masculino" };


        private string PesoIdeal(double estatura)
        {
            double pesoIdeal1 = 18.5 * (estatura * estatura);
            double pesoIdeal2 = 25 * (estatura * estatura);
            return Convert.ToString(pesoIdeal1) + " - " + Convert.ToString(pesoIdeal2);
        }

        public Double CalcularIMC(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        private String getBMICategoria(Double imc)
        {
            IMC categoria;
            if (imc < 15)
                categoria = IMC.VERY_SEVERELY_UNDER_WEIGHT;
            else if (imc < 16)
                categoria = IMC.SEVERELY_UNDER_WEIGHT;
            else if (imc < 18.5)
                categoria = IMC.UNDER_WEIGHT;
            else if (imc < 25)
                categoria = IMC.NORMAL;
            else if (imc < 30)
                categoria = IMC.OVER_WEIGHT;
            else if (imc < 35)
                categoria = IMC.MODERATELY_OBESE;
            else if (imc < 40)
                categoria = IMC.SEVERELY_OBESE;
            else
            {
                categoria = IMC.VERY_SEVERELY_OBESE;
            }
            return IMCEnum.GetValue(categoria);
        }
        enum IMC
        {
            VERY_SEVERELY_UNDER_WEIGHT, SEVERELY_UNDER_WEIGHT,
            UNDER_WEIGHT, NORMAL, OVER_WEIGHT, MODERATELY_OBESE,
            SEVERELY_OBESE, VERY_SEVERELY_OBESE
        };

        class IMCEnum
        {
            //En java:  private static IMC imc;
            private IMC imc;

            public IMCEnum(IMC imc)
            {
                this.imc = imc;
            }


            public static String GetValue(IMC imc)
            {
                String imcStr = "Sin valor";

                switch (imc)
                {
                    case IMC.VERY_SEVERELY_UNDER_WEIGHT:
                        imcStr = "Muy severamente bajo de peso";
                        break;
                    case IMC.SEVERELY_UNDER_WEIGHT:
                        imcStr = "Severamente bajo de peso";
                        break;
                    case IMC.UNDER_WEIGHT:
                        imcStr = "Bajo de peso";
                        break;
                    case IMC.NORMAL:
                        imcStr = "Peso normal";
                        break;
                    case IMC.OVER_WEIGHT:
                        imcStr = "Sobre peso";
                        break;
                    case IMC.MODERATELY_OBESE:
                        imcStr = "Moderadamente obeso";
                        break;
                    case IMC.SEVERELY_OBESE:
                        imcStr = "Severamente obesoo";
                        break;
                    case IMC.VERY_SEVERELY_OBESE:
                        imcStr = "Muy severamente obeso";
                        break;
                }
                return imcStr;
            }

        }
    }
}
