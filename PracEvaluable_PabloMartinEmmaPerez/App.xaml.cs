using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public partial class App : Application
    {
        public static DictionaryCarreras dicCarreras = new DictionaryCarreras();
        public static DictionaryCorredores dicCorredores = new DictionaryCorredores();

        public App()
        {
            InitializeComponent();
            //Añadimos carreras al dictionaryCarreras 
            dicCarreras.DatosMock();
            //Por cada carrera añadida al dictionaryCarreras le añadimos una serie de corredores
            //(todas las carreras cuentan de inicio con los mismos participantes)
            foreach (Carrera carrera in dicCarreras.Values)
            {
                carrera.corredores.DatosMock();
            }
            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
