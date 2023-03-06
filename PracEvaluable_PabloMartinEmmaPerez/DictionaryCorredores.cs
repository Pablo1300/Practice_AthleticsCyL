using System;
using System.Collections.Generic;

namespace PracEvaluable_PabloMartinEmmaPerez
{
    public class DictionaryCorredores : Dictionary<string, Corredor>
    {
        public DictionaryCorredores()
        {
        }
        //Datos de los corredores que se implementaran en App.xaml.cs al principio del programa
        public void DatosMock()
        {
            this.Add("11111111H", new Corredor("Pablo", "Martín Sánchez", "11111111H"));
            this.Add("22222222J", new Corredor("Emma", "Pérez García", "22222222J"));
            this.Add("72464885S", new Corredor("Cristina", "Gutierrez Gómez", "72464885S"));
            this.Add("72464892A", new Corredor("Miguel", "Fernandez Fernandez", "72464892A"));
            this.Add("72464899X", new Corredor("Ana", "García Ballesteros", "72464899X"));
            this.Add("72464906F", new Corredor("Carlos", "Gomez Fernandez", "72464906F"));
            this.Add("72464913G", new Corredor("Carmen", "Clemente Martín", "72464913G"));
            this.Add("72464920R", new Corredor("Sofia", "Vicente Gómez", "72464920R"));
            this.Add("72464927G", new Corredor("Martin", "Sanchez Sanchez", "72464927G"));
            this.Add("72464934S", new Corredor("Maria", "Perez Hernandez", "72464934S"));
            this.Add("72464941F", new Corredor("Alfonso", "Jimenez Moreno", "72464941F"));
            this.Add("72464948D", new Corredor("Angel", "García Alvarez", "72464948D"));
            this.Add("72464955V", new Corredor("Paula", "Martinez Rodriguez", "72464955V"));
            this.Add("72464962R", new Corredor("Conchi", "Muñoz Muñoz", "72464962R"));
            this.Add("72464969S", new Corredor("Antonio", "Alonso Romero", "72464969S"));
            this.Add("72464976F", new Corredor("Lucia", "Torres Hernandez", "72464976F"));
            this.Add("72464983H", new Corredor("Benito", "Moreno Garcia", "72464983H"));
            this.Add("72464990L", new Corredor("Carolina", "Calderon Martin", "72464990L"));
            this.Add("72464997J", new Corredor("Sergio", "Perez Perez", "72464997J"));
            this.Add("72445466P", new Corredor("Antonio", "Alonso Romero", "72445466P"));
            this.Add("51234945Y", new Corredor("Dania", "Torres Torres", "51234945Y"));
            this.Add("52464583H", new Corredor("Pedro", "Zudaire Peña", "52464583H"));
            this.Add("07248790R", new Corredor("Ivan", "Muñoz Garcia", "07248790R"));
            this.Add("07200997W", new Corredor("Ismael", "Martin Fernan", "07200997W"));
            this.Add("54428790V", new Corredor("Miriam", "Jimenez Garcia", "54428790V"));
            this.Add("79200997A", new Corredor("Silvia", "Alonso Gomez", "79200997A"));
        }
    }
}
