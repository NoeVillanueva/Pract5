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
    public partial class Formulario : ContentPage
    {
        public Formulario()
        {
            InitializeComponent();
        }

        private void Enviar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Datos.!!", Nombre.Text + " " + Apellido.Text + "\n " + Direccion.Text + " \n " + TEL.Text + " \n" + Carrera.Text + " \n" + Semestre.Text + "\n " + Matricula.Text + "\n " + Correo.Text + "\n " + GitHub.Text, "Datos correctos");
            Navigation.PushAsync(new Calculadora());
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Ingresa_datos());
        }
    }
}