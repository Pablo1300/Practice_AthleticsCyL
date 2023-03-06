using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class GestionarCorredor : ContentPage
    {
        private DictionaryCarreras carreras = App.dicCarreras;

        public GestionarCorredor()
        {
            InitializeComponent();
        }


        void Boton_Limpiar_Clicked(System.Object sender, System.EventArgs e)
        {
            limpiarEntradaDatos();
        }

        async void Boton_Guardar_Clicked(System.Object sender, System.EventArgs e)
        {
            //Comprobamos que los campos estan completos
            if (string.IsNullOrEmpty(entradaNombreCarrera.Text) ||
                string.IsNullOrEmpty(entradaNombreCorredor.Text) ||
                string.IsNullOrEmpty(entradaApellidosCorredor.Text) ||
                string.IsNullOrEmpty(entradaNifCorredor.Text))
            {
                //Si no es asi saltará un aviso
                await DisplayAlert("Aviso", "Compruebe que los campos esten completos ", "Aceptar");
            }
            else
            {
                //Buscamos que la carrera exista
                if (carreras.ContainsKey(entradaNombreCarrera.Text))
                {
                    //Buscamos que el corredor no exista aún
                    if (!carreras[entradaNombreCarrera.Text].corredores.ContainsKey(entradaNifCorredor.Text))
                    {
                        //Como no existe lo añadimos                        
                        carreras[entradaNombreCarrera.Text].corredores.Add(entradaNifCorredor.Text, new Corredor(entradaNifCorredor.Text,
                                                                                                 entradaNombreCorredor.Text,
                                                                                                 entradaApellidosCorredor.Text));
                        //Mostramos un aviso de confirmacion
                        await DisplayAlert("Añadido", "El corredor ha sido añadida correctamente", "Aceptar");

                    }
                    else
                    {
                        //Si el corredor ya existe se muestra otro aviso diferente
                        await DisplayAlert("Error", "Ya hay un corredor con ese NIF", "Aceptar");
                    }
                }
                else
                {
                    //Si la carrera no existe...
                    await DisplayAlert("Error", "La carrera no existe", "Aceptar");
                }
                //Por ultimo se limpia los datos
                limpiarEntradaDatos();
            }
        }

        async void Button_Eliminar_Clicked(System.Object sender, System.EventArgs e)
        {
            //Comprobamos que los campos estan completos
            if (string.IsNullOrEmpty(entradaNombreCarrera.Text) ||
                string.IsNullOrEmpty(entradaNombreCorredor.Text) ||
                string.IsNullOrEmpty(entradaApellidosCorredor.Text) ||
                string.IsNullOrEmpty(entradaNifCorredor.Text))
            {
                await DisplayAlert("Aviso", "Compruebe que los campos esten completos ", "Aceptar");
            }
            else
            {
                //Buscamos que la carrera exista
                if (carreras.ContainsKey(entradaNombreCarrera.Text))
                {
                    //Buscamos que el corredor exista
                    if (carreras[entradaNombreCarrera.Text].corredores.ContainsKey(entradaNifCorredor.Text))
                    {
                        //Como existe lo eliminamos                        
                        carreras[entradaNombreCarrera.Text].corredores.Remove(entradaNifCorredor.Text);
                        await DisplayAlert("Eliminado", "El corredor ha sido eliminado correctamente", "Aceptar");

                    }
                    else
                    {
                        //Si no existe mostramos un error
                        await DisplayAlert("Error", "No existe un corredor con ese NIF", "Aceptar");
                    }
                }
                else
                {
                    //Si la carrera no existe mostramos otro
                    await DisplayAlert("Error", "La carrera no existe", "Aceptar");
                }
                //Se vuelven a limpiar los datos
                limpiarEntradaDatos();
            }
        }

        void limpiarEntradaDatos()
        {
            entradaNombreCarrera.Text = string.Empty;
            entradaNombreCorredor.Text = string.Empty;
            entradaApellidosCorredor.Text = string.Empty;
            entradaNifCorredor.Text = string.Empty;
        }
    }
}
