using System;
using System.Collections.Generic;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public class DictionaryCarreras : Dictionary<string, Carrera>
    {
        public DictionaryCarreras()
        {
        }

        public bool ComprobarIdCarDuplicado(string id)
        {
            foreach (Carrera carrera in this.Values)
            {
                if (carrera.IdCarrera.Equals(id))
                {
                    return true;
                }
            }
            return false;
        }

        //Datos de las carreras que se implementaran en el App.xaml.cs al principio del programa
        public void DatosMock()
        {
            this.Add("XXXV Cross de la Constitución", new Carrera("11111", "XXXV Cross de la Constitución", "Valladolid", new DateTime(2022, 12, 6), new TimeSpan(16, 00, 00), true, Especialidad.Marcha));
            this.Add("Cross El Crucero", new Carrera("22222", "Cross El Crucero", "Leon", new DateTime(2022, 12, 20), new TimeSpan(16, 00, 00), false, Especialidad.Marcha));
            this.Add("XXXI San Silvestre", new Carrera("33333", "XXXI San Silvestre", "Palencia", new DateTime(2022, 12, 29), new TimeSpan(16, 00, 00), false, Especialidad.Marcha));
            this.Add("Fin de Año", new Carrera("44444", "Fin de Año", "Valladolid", new DateTime(2022, 12, 31), new TimeSpan(16, 00, 00), false, Especialidad.Marcha));
            this.Add("XXXIV Carrera Popular Don Bosco", new Carrera("55555", "XXXIV Carrera Popular Don Bosc", "Valladolid", new DateTime(2023, 2, 9), new TimeSpan(12, 00, 00), true, Especialidad.Marcha));
            this.Add("Trail Running", new Carrera("66666", "Trail Running", "Segovia", new DateTime(2023, 3, 5), new TimeSpan(10, 00, 00), false, Especialidad.Trail));
            this.Add("XI Media Maraton", new Carrera("77777", "XI Media Maraton", "Salamanca", new DateTime(2023, 3, 15), new TimeSpan(16, 00, 00), false, Especialidad.Ruta));
            this.Add("V Subida al Palillo de Golmayo", new Carrera("88888", "V Subida al Palillo de Golmayo", "Golmayo", new DateTime(2023, 3, 15), new TimeSpan(10, 00, 00), false, Especialidad.Ruta));
            this.Add("VII Valdelagua", new Carrera("99999", "VII Valdelagua", "Valdelagua", new DateTime(2023, 4, 10), new TimeSpan(10, 00, 00), false, Especialidad.Marcha));
            this.Add("Tres Cerros Palentinos", new Carrera("10101", "Tres Cerros Palentinos", "Palencia", new DateTime(2023, 4, 12), new TimeSpan(10, 00, 00), false, Especialidad.Trail));
            this.Add("Master Marcha en Ruta", new Carrera("11110", "Master Marcha en Ruta", "Salamanca", new DateTime(2023, 4, 13), new TimeSpan(10, 00, 00), false, Especialidad.Marcha));
            this.Add("10km Villa de Simancas", new Carrera("12121", "10km Villa de Simancas", "Simancas", new DateTime(2023, 4, 15), new TimeSpan(10, 00, 00), false, Especialidad.Trail));
            this.Add("IX Carrera entre Castillos", new Carrera("13131", "IX Carrera entre Castillos", "Palencia", new DateTime(2023, 4, 24), new TimeSpan(18, 00, 00), false, Especialidad.Marcha));
            this.Add("Contra el Cancer", new Carrera("14141", "Contra el Cancer", "Salamanca", new DateTime(2022, 10, 24), new TimeSpan(10, 00, 00), false, Especialidad.Marcha));
            this.Add("Bedelalsa", new Carrera("15151", "Bedelalsa", "Bejar", new DateTime(2023, 05, 21), new TimeSpan(12, 00, 00), false, Especialidad.Marcha));
            this.Add("Charroad 2023", new Carrera("16161", "Charroad 2023", "Salamanca", new DateTime(2023, 5, 12), new TimeSpan(12, 00, 00), false, Especialidad.Marcha));
            this.Add("Arribes Ocultos", new Carrera("17171", "Arribes Ocultos", "Zamora", new DateTime(2023, 1, 22), new TimeSpan(12, 00, 00), false, Especialidad.Trail));
            this.Add("La cebrera", new Carrera("18181", "La cebrera", "Avila", new DateTime(2023, 3, 5), new TimeSpan(12, 00, 00), false, Especialidad.Trail));
            this.Add("La WychyZuli", new Carrera("19191", "La WychyZuli", "Burgos", new DateTime(2022, 12, 25), new TimeSpan(18, 00, 00), false, Especialidad.Trail));
            this.Add("X Transcandamia", new Carrera("20200", "X Transcandamia", "Leon", new DateTime(2023, 1, 15), new TimeSpan(12, 00, 00), false, Especialidad.Trail));
            this.Add("Peregrinos 2023", new Carrera("21211", "Peregrinos 2023", "Ponferrada", new DateTime(2023, 4, 23), new TimeSpan(12, 00, 00), true, Especialidad.Trail));

        }
    }
}
