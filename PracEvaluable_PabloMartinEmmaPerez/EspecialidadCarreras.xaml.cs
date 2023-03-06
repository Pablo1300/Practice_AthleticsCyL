using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class EspecialidadCarreras : ContentPage
    {
        DictionaryCarreras carreras = App.dicCarreras;

        //Creamos tres listas auxiliares diferentes para cada especialidad
        List<Carrera> carrerasRuta = new List<Carrera>();
        List<Carrera> carrerasTrail = new List<Carrera>();
        List<Carrera> carrerasMarcha = new List<Carrera>();

        public EspecialidadCarreras()
        {
            InitializeComponent();
            //Recorremos cada carrera
            foreach (Carrera carrera in carreras.Values)
            {
                //Dependiendo de la especialidad se iran annadiendo en cada lista correspondiente
                switch (carrera.Especialidad)
                {
                    case Especialidad.Ruta:
                        carrerasRuta.Add(carrera);
                        break;
                    case Especialidad.Trail:
                        carrerasTrail.Add(carrera);
                        break;
                    default:
                        carrerasMarcha.Add(carrera);
                        break;
                }
            }
        }

        //Si se presiona el boton siguiente...
        async void Boton_Siguiente_Clicked(System.Object sender, System.EventArgs e)
        {
           
            switch (EspecialidadCarreraPicker.SelectedIndex)
            {
                //El picker pasa al siguente elemento y se cargan las carreras de la especialidad siguiente
                case 0:
                    EspecialidadCarreraPicker.SelectedIndex = 1;  
                    listviewCarreras.ItemsSource = carrerasTrail;
                    break;
                case 1:
                    EspecialidadCarreraPicker.SelectedIndex = 2;
                    listviewCarreras.ItemsSource = carrerasMarcha;
                    break;
                case 2:
                    EspecialidadCarreraPicker.SelectedIndex = 0;
                    listviewCarreras.ItemsSource = carrerasRuta;
                    break;
                default:
                    await DisplayAlert("Aviso", "Seleccione primero una especialidad", "Aceptar"); //Si no se ha seleccionado nada salta un aviso
                    break;
            }
        }

        //Si se cambia el valor del picker...
        void EspecialidadCarreraPicker_SelectedIndexChanged(System.Object sender, System.EventArgs e)
        {
            //Dependiendo de la especialidad elegida
            switch (EspecialidadCarreraPicker.SelectedIndex)
            {
                //Se carga las carga las carreras de dicha especialidad
                case 0:
                    listviewCarreras.ItemsSource = carrerasRuta;
                    break;
                case 1:
                    listviewCarreras.ItemsSource = carrerasTrail;
                    break;
                default:
                    listviewCarreras.ItemsSource = carrerasMarcha;
                    break;
            }
        }

        //Si seleccionas una carrera...
        async void listviewCarreras_ItemSelected(System.Object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new MostrarDatosCarrera((Carrera)e.SelectedItem));
        }
    }
}
