using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class CarrerasCorredor : ContentPage
    {
        DictionaryCarreras carreras = App.dicCarreras;

        public CarrerasCorredor()
        {
            InitializeComponent();
        }

        //Al presionar el botón de busqueda...
        void busqueda_SearchButtonPressed(System.Object sender, System.EventArgs e)
        {
            //Creamos una lista de carreras para el corredor
            List<Carrera> carrerasCorredor = new List<Carrera>();

            //Recorremos cada carrera de diccionario
            foreach (Carrera carrera in carreras.Values)
            {
                //Si la cadena de entrada en la barra de busqueda coincide con el nif de un corredor de una carrera
                if (carrera.corredores.ContainsKey(busqueda.Text))
                {
                    //Se añade la carrera a la lista de carreras por corredor
                    carrerasCorredor.Add(carrera);

                }
            }
            //Cargamos los datos en la lista
            listviewCarreras.ItemsSource = carrerasCorredor;
        }
    }
}
