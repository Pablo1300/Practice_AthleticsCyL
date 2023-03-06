using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class MostrarDatosCarrera : ContentPage
    {
        public MostrarDatosCarrera(Carrera carreraMostrar)
        {
            InitializeComponent();
            bindingDatosCarrera(carreraMostrar);
        }

        void bindingDatosCarrera(Carrera carrera)
        {
            //Mostramos los datos de la carrera en los distintos labels
            labelIdCarrera.Text = carrera.IdCarrera;
            labelNombreCarrera.Text = carrera.NomCarrera;
            labelLugarCarrera.Text = carrera.LugarCarrera;
            labelEspecialidad.Text = carrera.Especialidad.ToString();
            if (carrera.GratuidadCarrera) labelGratis.Text = "Sí";
            else labelGratis.Text = "No";
            labelFechaCarrera.Text = carrera.FechaCarreraString;
            labelHoraCarrera.Text = carrera.HoraCarrera.ToString();

            //Tambien se muestran los corredores llamando a la siguiente funcion
            bindingDatosCorredores(carrera);
        }
        void bindingDatosCorredores(Carrera carrera)
        {
            DictionaryCorredores corredores = carrera.corredores;

            //Se crea una lista para guardar los corredores
            List<Corredor> listCorredores = new List<Corredor>();

            //Por cada corredor del diccionario
            foreach (Corredor corredor in corredores.Values)
            {
                //Lo annadimos a la lista
                listCorredores.Add(corredor);

            }
            //Mostramos los datos en el listview
            listviewCorredores.ItemsSource = listCorredores;
        }
    }
}
