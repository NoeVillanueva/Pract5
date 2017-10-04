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
    public partial class Ingresa_datos : ContentPage
    {
        public Ingresa_datos()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Formulario());
        }

        private void Button_Clicked_1(object sender, EventArgs e)

        {
            Navigation.PushAsync(new Calculadora());
        }
    }
}