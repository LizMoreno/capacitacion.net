using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiLibreria
{
    public class Empleado
    {

        public Empleado()
        {
            Ciudad = "Buenos Aires";
        }
        public Empleado(string nombre) : base()
        {
            Nombre = nombre;

        }

        public Empleado(string nombre, string pepe) : this(nombre)
        {
            //otra logica

        }

        public String Ciudad { get; set; }
        public string Nombre
        {
            get;
            set;
        }
    }
}