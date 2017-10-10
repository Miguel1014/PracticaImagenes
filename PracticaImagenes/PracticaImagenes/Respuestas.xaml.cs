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
    public partial class Respuestas : ContentPage
    {
        public Respuestas()
        {
            InitializeComponent();
            P1.Text = PracticaImagenes.MainPage.datos.Respuesta;
            P2.Text = PracticaImagenes.Page2.datos1.Respuesta;
            P3.Text = PracticaImagenes.Page3.datos1.Respuesta;
            P4.Text = PracticaImagenes.Page4.datos1.Respuesta;
            P5.Text = PracticaImagenes.Page5.datos1.Respuesta;
            P6.Text = PracticaImagenes.Page6.datos1.Respuesta;
            P7.Text = PracticaImagenes.Page7.datos1.Respuesta;
            P8.Text = PracticaImagenes.Page8.datos1.Respuesta;
            P9.Text = PracticaImagenes.Page9.datos1.Respuesta;
            P10.Text = PracticaImagenes.Page10.datos1.Respuesta;
            R1.Text = PracticaImagenes.MainPage.datos.Resultado;
            R2.Text = PracticaImagenes.Page2.datos1.Resultado;
            R3.Text = PracticaImagenes.Page3.datos1.Resultado;
            R4.Text = PracticaImagenes.Page4.datos1.Resultado;
            R5.Text = PracticaImagenes.Page5.datos1.Resultado;
            R6.Text = PracticaImagenes.Page6.datos1.Resultado;
            R7.Text = PracticaImagenes.Page7.datos1.Resultado;
            R8.Text = PracticaImagenes.Page8.datos1.Resultado;
            R9.Text = PracticaImagenes.Page9.datos1.Resultado;
            R10.Text = PracticaImagenes.Page10.datos1.Resultado;
        }
    }
}