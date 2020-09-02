using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArrepentidor
{
    class Program
    {
        static void Main(string[] args)
        {


            Estudiante miEstu = new Estudiante("pepito", "juancito", 123,"calle falsa 1.2");


            Console.WriteLine()

            Establecimiento.SetearInfoJardin("Los pipis");
            Establecimiento.SetearInfoJardin(123);



            Establecimiento.AgregarAlumno(new Estudiante("pepito", "juancito", 123));
            Establecimiento.AgregarAlumno(new Estudiante("asd", "asdadsad", 321));






            Console.WriteLine(Establecimiento.MostrarAlumnos());



            Console.ReadKey();

        }
    }
}
