using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracticaImagenes
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page6 : ContentPage
    {
        public Page6()
        {
            InitializeComponent();
            Imagen.Source = ImageSource.FromResource("PracticaImagenes.Bulma.png");


        }
        public class datos1
        {
            public static string Respuesta;
            public static string Resultado;
        }
        private void Res1(object sender, EventArgs e)
        {
            datos1.Respuesta = r1.Text;
            datos1.Resultado = "Correcto";
            Navigation.PushModalAsync(new Page7());
        }
        private void Res2(object sender, EventArgs e)
        {
            datos1.Respuesta = r2.Text;
            datos1.Resultado = "Incorrecto";
            Navigation.PushModalAsync(new Page7());
        }
        private void Res3(object sender, EventArgs e)
        {
            datos1.Respuesta = r3.Text;
            datos1.Resultado = "Incorrecto";
            Navigation.PushModalAsync(new Page7());
        }
    }
}