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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            Imagen.Source = ImageSource.FromFile("piccolo.png");
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


            Navigation.PushModalAsync(new Page3());
        }

        private void Res2(object sender, EventArgs e)
        {
            datos1.Respuesta = r2.Text;
            datos1.Resultado = "Incorrecto";
            Navigation.PushModalAsync(new Page3());
        }
        private void Res3(object sender, EventArgs e)
        {
            datos1.Respuesta = r3.Text;
            datos1.Resultado = "Correcto";
            Navigation.PushModalAsync(new Page3());
        }
    }
}