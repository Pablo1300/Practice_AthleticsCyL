using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class ListadoCarreras : ContentPage
    {
        DictionaryCarreras carreras = App.dicCarreras;
        List<Carrera> listCarreras = new List<Carrera>();

        public ListadoCarreras()
        {
            InitializeComponent();
            //Los valores del Dictionary no pueden ser usados para el e.selectedItem, ya que, da error
            //por lo tanto pasamos los datos a una lista y los mostramos
            foreach (Carrera carrera in carreras.Values)
            {
                listCarreras.Add(carrera);
            }
            listviewCarreras.ItemsSource = listCarreras;
        }

        //Si presionamos alguna de las carreras...
        async void listviewCarreras_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            //Nos lleva a otra pagina para mostrar los datos
            await Navigation.PushAsync(new MostrarDatosCarrera((Carrera)e.SelectedItem));
        }
    }
}
