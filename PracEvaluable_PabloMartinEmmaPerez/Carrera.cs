using System;
namespace PracEvaluable_PabloMartinEmmaPerez
{
    public class Carrera
    {
        public string IdCarrera { get; set; }
        public string NomCarrera { get; set; }
        public string LugarCarrera { get; set; }
        public DateTime FechaCarrera { get; set; }
        public string FechaCarreraString { get; set; }
        public TimeSpan HoraCarrera { get; set; }
        public bool GratuidadCarrera { get; set; }
        public Especialidad Especialidad { get; set; }
        public DictionaryCorredores corredores { get; set; }


        public Carrera() { }


        public Carrera(string idCarrera, string nomCarrera, string lugarCarrera, DateTime fechaCarrera, TimeSpan horaCarrera, bool gratuidadCarrera, Especialidad especialidad)
        {
            this.IdCarrera = idCarrera;
            this.NomCarrera = nomCarrera;
            this.LugarCarrera = lugarCarrera;
            this.FechaCarrera = fechaCarrera;
            FechaCarreraString = this.FechaCarrera.ToShortDateString();
            this.HoraCarrera = horaCarrera;
            this.GratuidadCarrera = gratuidadCarrera;
            this.Especialidad = especialidad;
            corredores = new DictionaryCorredores();
        }

    }
}

