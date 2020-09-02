using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita_Implicita_Objetos
{
    class Alumno
    {
        public string nombre;
        public string apellido;
        public int edad;
        public string division;

        public Alumno(string nombre, string apellido, int edad, string division) : this(nombre, apellido, edad)
        {
            this.division = division;
        }

        public Alumno(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }


        public static explicit operator Alumno(Docente auxDocente)
        {
            return new Alumno(auxDocente.nombre, auxDocente.apellido, auxDocente.edad, "Sin division");

        }


    }
}
