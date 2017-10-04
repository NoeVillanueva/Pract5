using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Pract5
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calculadora : ContentPage
    {
        double valor1;
        double valor2;
        double resultado;
        string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void Porcentaje_Clicked(object sender, EventArgs e)
        {

            caja.Text = caja.Text + "%";
            operacion = "%";
            valor1 = double.Parse(caja.Text);
            caja.Text = "";

        }

        private void Raiz_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "Villanueva";
            operacion = "Villanueva";
            valor1 = double.Parse(caja.Text);
            resultado = valor1;
            caja.Text = Math.Sqrt(valor1).ToString();
        }

        private void Potencia_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "^2";
            operacion = "^2";
            valor1 = double.Parse(caja.Text);
            resultado = valor1;
            caja.Text = Math.Pow(valor1, 2).ToString();

        }

        private void RI_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingresa_datos());
        }

        private void Ce_Clicked(object sender, EventArgs e)
        {
            caja.Text = null;
        }

        private void C_Clicked(object sender, EventArgs e)
        {
            caja.Text = null;
        }
        private void Division_Clicked(object sender, EventArgs e)
        {
            operacion = "/";
            valor1 = double.Parse(caja.Text);
            caja.Text = "";
        }

        private void Siete_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "7";
        }

        private void Ocho_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "8";
        }

        private void Nueve_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "9";
        }

        private void Multi_Clicked(object sender, EventArgs e)
        {
            operacion = "X";
            valor1 = double.Parse(caja.Text);
            caja.Text = "";
        }

        private void Cuatro_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "4";
        }

        private void Cinco_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "5";
        }

        private void Seis_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "6";
        }

        private void Menos_Clicked(object sender, EventArgs e)
        {
            operacion = "-";
            valor1 = double.Parse(caja.Text);
            caja.Text = "";
        }
        private void Uno_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "1";
        }

        private void Dos_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "2";
        }

        private void Tres_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "3";
        }
        private void Mas_Clicked(object sender, EventArgs e)
        {
            operacion = "+";
            valor1 = double.Parse(caja.Text);
            caja.Text = "";

        }
        private void Mm_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "±";
        }
        private void Cero_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + "0";
        }

        private void Punto_Clicked(object sender, EventArgs e)
        {
            caja.Text = caja.Text + ".";
        }
        private void Igual_Clicked(object sender, EventArgs e)
        {
            valor2 = double.Parse(caja.Text);
            switch (operacion)
            {
                case "+":
                    resultado = valor1 + valor2;
                    caja.Text = resultado.ToString();
                    break;

                case "-":
                    resultado = valor1 - valor2;
                    caja.Text = resultado.ToString();
                    break;

                case "X":

                    resultado = valor1 * valor2;
                    caja.Text = resultado.ToString();
                    break;

                case "/":
                    resultado = valor1 / valor2;
                    caja.Text = resultado.ToString();
                    break;

            }
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Formulario());
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingresa_datos());
        }
    }




}