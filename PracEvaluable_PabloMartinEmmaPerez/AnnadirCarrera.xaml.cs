using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class AnnadirCarrera : ContentPage
    {
        private DictionaryCarreras carreras = App.dicCarreras;

        public AnnadirCarrera()
        {
            InitializeComponent();
            selectorFechaCarrera.MinimumDate = DateTime.Now;
            limpiarEntradaDatos();
        }

        void Button_Limpiar_Clicked(System.Object sender, System.EventArgs e)
        {
            limpiarEntradaDatos();
        }

        async void Button_Guardar_Clicked(System.Object sender, System.EventArgs e)
        {

            //Comprobamos que los campos tienen datos
            if (string.IsNullOrEmpty(entradaIdCarrera.Text) ||
                string.IsNullOrEmpty(entradaNombreCarrera.Text) ||
                string.IsNullOrEmpty(entradaLugarCarrera.Text))
            {
                //Si no es asi mostramos un aviso
                await DisplayAlert("Aviso", "Compruebe que los campos esten completos ", "Aceptar");
            }
            else
            {
                //Comprobamos que el nombre de la carrera no esta ya annadida
                if (!carreras.ContainsKey(entradaNombreCarrera.Text))
                {
                    //Si no lo esta, se comprueba que el id tampoco este duplicado
                    if (!carreras.ComprobarIdCarDuplicado(entradaIdCarrera.Text))
                    {
                        //Se annade la carrera
                        carreras.Add(entradaNombreCarrera.Text,
                                     new Carrera(entradaIdCarrera.Text,
                                                 entradaNombreCarrera.Text,
                                                 entradaLugarCarrera.Text,
                                                 selectorFechaCarrera.Date,
                                                 selectorHoraCarrera.Time,
                                                 gratuidadCarrera.IsToggled,
                                                 (Especialidad)Enum.Parse(typeof(Especialidad),
                                                 EspecialidadCarreraPicker.SelectedItem.ToString())));
                        //Se muestra un aviso de la confirmacion
                        await DisplayAlert("Añadida", "La carrera ha sido añadida correctamente", "Aceptar");
                    }
                    else
                    {
                        //Mostramos error porque el id este duplicado
                        await DisplayAlert("Error", "ID de la carrera duplicado", "Aceptar");
                    }
                }
                else
                {
                    //Mostramos error porque la carrera existe
                    await DisplayAlert("Error", "La carrera ya existe", "Aceptar");
                }

                //Se limpian los datos
                limpiarEntradaDatos();
            }
        }

        void limpiarEntradaDatos()
        {
            entradaIdCarrera.Text = string.Empty;
            entradaNombreCarrera.Text = string.Empty;
            entradaLugarCarrera.Text = string.Empty;
            selectorFechaCarrera.Date = DateTime.Now;
            selectorHoraCarrera.Time = DateTime.Now.TimeOfDay;
            gratuidadCarrera.IsToggled = false;
            EspecialidadCarreraPicker.SelectedItem = null;
        }
    }
}
