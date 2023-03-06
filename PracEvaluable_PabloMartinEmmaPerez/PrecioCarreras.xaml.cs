using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class PrecioCarreras : ContentPage
    {
        DictionaryCarreras carreras = App.dicCarreras;

        //Creamos dos listas auxiliares diferentes, una para las carreras gratis y otra para las que no lo son
        List<Carrera> carrerasGratis = new List<Carrera>();
        List<Carrera> carrerasNoGratis = new List<Carrera>();

        public PrecioCarreras()
        {
            InitializeComponent();

            //Recorremos cada carrera del diccionario
            foreach (Carrera carrera in carreras.Values)
            {
                //Lo volcamos en la lista correspondiente
                if (carrera.GratuidadCarrera) carrerasGratis.Add(carrera);
                else carrerasNoGratis.Add(carrera);
            }

            //Cargamos los datos en el listview
            listviewCarreras.ItemsSource = carrerasNoGratis;
        }

        void gratuidadCarrera_Toggled(System.Object sender, Xamarin.Forms.ToggledEventArgs e)
        {
            //Si el switch esta encendido
            if (gratuidadCarrera.IsToggled)
            {
                listviewCarreras.ItemsSource = carrerasGratis; //Se cargan las carreras gratuitas
            }
            //Si no lo esta
            else
            {
                listviewCarreras.ItemsSource = carrerasNoGratis; //Se cargan las no gratuitas
            }
        }

        async void listviewCarreras_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //Cada carrera envia a la pagina de mostrar los datos...
            await Navigation.PushAsync(new MostrarDatosCarrera((Carrera)e.SelectedItem));
        }
    }
}
