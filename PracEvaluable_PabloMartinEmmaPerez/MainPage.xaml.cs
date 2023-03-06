using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //Colocamos el fondo de pantalla...
            FileImageSource fondoPantalla = "fondoDePantalla.png";
            BackgroundImageSource = fondoPantalla;
            InitializeComponent();
        }

        //SI PRESIONAMOS ALGUNO DE LOS BOTONES...
        async void opc1_Clicked(object sender, System.EventArgs e)
        {
            //NOS LLEVA A LA PAGINA QUE INDIQUE
            await Navigation.PushAsync(new AnnadirCarrera());
        }

        async void opc2_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new GestionarCorredor());
        }

        async void opc3_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new ListadoCarreras());
        }

        async void opc4_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new PrecioCarreras());
        }

        async void opc5_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new EspecialidadCarreras());
        }

        async void opc6_Clicked(System.Object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new CarrerasCorredor());
        }
    }
}
