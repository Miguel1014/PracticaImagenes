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
    public partial class Page10 : ContentPage
    {
        public Page10()
        {
            InitializeComponent();
            Imagen.Source = new UriImageSource()
            {
                Uri = new Uri("https://vignette3.wikia.nocookie.net/dragonball/images/9/9c/Goku_definitivo.png/revision/latest?cb=20150315230603&path-prefix=es")
            };

        }
        public class datos1
        {

            public static string Respuesta;
            public static string Resultado;
        }

        private void Res1(object sender, EventArgs e)
        {
            datos1.Respuesta = r1.Text;
            datos1.Resultado = "Incorrecto";


            Navigation.PushModalAsync(new Respuestas());
        }

        private void Res2(object sender, EventArgs e)
        {
            datos1.Respuesta = r2.Text;
            datos1.Resultado = "Correcto";
            Navigation.PushModalAsync(new Respuestas());
        }
        private void Res3(object sender, EventArgs e)
        {
            datos1.Respuesta = r3.Text;
            datos1.Resultado = "Incorrecto";
            Navigation.PushModalAsync(new Respuestas());
        }
    }
}