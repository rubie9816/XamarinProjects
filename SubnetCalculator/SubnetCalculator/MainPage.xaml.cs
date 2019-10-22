using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SubnetCalculator
{
    public partial class MainPage : ContentPage
    {
        int prefijo = 1;

        int[] int_enteros = new int[8] { 128, 64, 32, 16, 8, 4, 2, 1 };


        string[] subnetMask = new string[30] {
            "128.0.0.0","192.0.0.0","224.0.0.0","240.0.0.0","248.0.0.0","252.0.0.0","254.0.0.0","255.0.0.0",
            "255.128.0.0","255.192.0.0","255.224.0.0","255.240.0.0","255.248.0.0","255.252.0.0","255.254.0.0","255.255.0.0",
            "255.255.128.0","255.255.192.0","255.255.224.0","255.255.240.0","255.255.248.0","255.255.252.0","255.255.254.0","255.255.255.0",
            "255.255.255.128","255.255.255.192","255.255.255.224","255.255.255.240","255.255.255.248","255.255.255.252"};

        string[] wildCard = new string[30] {
            "127.255.255.255","63.255.255.255","31.255.255.255","15.255.255.255","7.255.255.255","3.255.255.255","1.255.255.255","0.255.255.255",
            "0.127.255.255","0.63.255.255","0.31.255.255","0.15.255.255","0.7.255.255","0.3.255.255","0.1.255.255","0.0.255.255",
            "0.0.127.255","0.0.63.255","0.0.31.255","0.0.15.255","0.0.7.255","0.0.3.255","0.0.1.255","0.0.0.255",
            "0.0.0.127","0.0.0.63","0.0.0.31","0.0.0.15","0.0.0.7","0.0.0.3" };

        string[] hostsNumber = new string[30] {
            "2147483646","1073741822","536870910","268435454","134217726","67108862","33554430","16777214","8388606","4194302",
            "2097150","1048574","524286","262142","131070","65534","32766","16382","8190",
            "4094","2046","1022","510","254","126","62","30","14","6","2"};



        public MainPage()
        {
            InitializeComponent();
            prefijo = 1;
        }

        public string AgregarCero(string octeto)
        {

            if (octeto.Length < 8)
            {
                int numero = 8 - octeto.Length;
                string numeros = "";

                for (int i = 0; i < numero; i++)
                {
                    numeros += "0";
                }

                octeto = numeros + octeto;
            }
            return octeto;
        }

        private void btnAtras_Clicked(object sender, EventArgs e)
        {
            if (prefijo != 1)
            {
                prefijo--;
                lblPrefijo.Text = "/" + prefijo;
                refrescar();
            }
        }

        private void btnAdelante_Clicked(object sender, EventArgs e)
        {
            if (prefijo < 30)
            {
                prefijo++;
                lblPrefijo.Text = "/" + prefijo;
                refrescar();
            }
        }

        public int Binario(string octeto, int prefijoOcteto)
        {
            int suma = 0;
            for (int i = 0; i < prefijoOcteto; i++)
            {
                if (octeto[i] == '1')
                {
                    suma = suma + int_enteros[i];
                }
            }
            return suma;
        }

        public int validarUltimoOcteto(string ultimoOcteto, int octeto)
        {
            int prefijoUltimoOcteto = prefijo;

            prefijoUltimoOcteto = prefijo - octeto;
            return prefijoUltimoOcteto;
        }

        public void refrescar()
        {

            string octetoA = Convert.ToString(ValidarLleno(txtA), 2);
            string octetoB = Convert.ToString(ValidarLleno(txtB), 2);
            string octetoC = Convert.ToString(ValidarLleno(txtC), 2);
            string octetoD = Convert.ToString(ValidarLleno(txtD), 2);


            octetoA = AgregarCero(octetoA);
            octetoB = AgregarCero(octetoB);
            octetoC = AgregarCero(octetoC);
            octetoD = AgregarCero(octetoD);

            if (prefijo > 24)
            {
                lblNetAdd.Text = Binario(octetoA, 8)
                    + "." + Binario(octetoB, 8)
                    + "." + Binario(octetoC, 8)
                    + "." + Binario(octetoD, validarUltimoOcteto(octetoD, 24));
            }
            else if (prefijo > 16)
            {
                lblNetAdd.Text = Binario(octetoA, 8)
                     + "." + Binario(octetoB, 8)
                     + "." + Binario(octetoC, validarUltimoOcteto(octetoC, 16))
                     + ".0";
            }
            else if (prefijo > 8)
            {
                lblNetAdd.Text = Binario(octetoA, 8)
                     + "." + Binario(octetoB, validarUltimoOcteto(octetoB, 8))
                     + ".0.0";
            }
            else
            {
                lblNetAdd.Text = Binario(octetoA, 8).ToString()
                + ".0.0.0";
            }
            lblMask.Text = subnetMask[prefijo - 1];
            lblHosts.Text = hostsNumber[prefijo - 1];
            lblWildCard.Text = wildCard[prefijo - 1];
        }

        private void txtA_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidarNumeros(txtA);
        }

        private void txtB_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidarNumeros(txtB);
        }

        private void txtC_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidarNumeros(txtC);
        }

        private void txtD_TextChanged(object sender, TextChangedEventArgs e)
        {
            ValidarNumeros(txtD);
        }

        public void ValidarNumeros(Editor txt)
        {
            int _limit = 3;
            string _text = txt.Text;
            if (_text.Length > _limit)
            {
                _text = _text.Remove(_text.Length - 1);
                txt.Text = _text;
            }
        }

        public int ValidarLleno(Editor txt)
        {
            if (txt.Text == "")
            {
                txt.Text = "0";
            }
            int valor_octeto = Convert.ToInt32(txt.Text);
            if (valor_octeto > 255)
            {
                txt.Text = "255";
            }
            return valor_octeto;
        }

    }
}
