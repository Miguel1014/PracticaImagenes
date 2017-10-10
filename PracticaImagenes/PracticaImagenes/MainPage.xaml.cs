using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracticaImagenes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            Imagen.Source = ImageSource.FromFile("krilin.png");

        }

        public class datos
        {

            public static string Respuesta;
            public static string Resultado;
        }


        private void Res1(object sender, EventArgs e)
        {
            datos.Respuesta = r1.Text;
            datos.Resultado = "Correcto";


            Navigation.PushModalAsync(new Page2());
        }

        private void Res2(object sender, EventArgs e)
        {
            datos.Respuesta = r2.Text;
            datos.Resultado = "Incorrecto";
            Navigation.PushModalAsync(new Page2());
        }
        private void Res3(object sender, EventArgs e)
        {
            datos.Respuesta = r3.Text;
            datos.Resultado = "Incorrecto";
            Navigation.PushModalAsync(new Page2());
        }
    }
}
