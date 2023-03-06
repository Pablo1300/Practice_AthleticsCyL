using System;
namespace PracEvaluable_PabloMartinEmmaPerez
{
    public class Corredor
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Nif { get; set; } //Creimos que añadir el dni es muy util para identificar al corredor

        public Corredor() { }

        public Corredor(string nombre, string apellidos, string nif)
        {

            this.Nombre = nombre;
            this.Apellidos = apellidos;
            this.Nif = Nif;
        }
    }
}
