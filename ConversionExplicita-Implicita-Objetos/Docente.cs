using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita_Implicita_Objetos
{
    class Docente
    {

       public string nombre;
       public string apellido;
       public int edad;
       public int cantidadAulasAsignadas;

        public Docente(string nombre,string apellido,int edad,int cantAulas):this(nombre,apellido,edad)
        {
            this.cantidadAulasAsignadas = cantAulas;
        }

        public Docente(string nombre, string apellido, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
        }

        public static implicit operator Docente(Alumno miAlumno)
        {

            return new Docente(miAlumno.nombre, miAlumno.apellido, miAlumno.edad);

        }

        public static implicit operator string(Docente miDoc)
        {
            return miDoc.nombre + "," + miDoc.apellido;
        }


    }
}
