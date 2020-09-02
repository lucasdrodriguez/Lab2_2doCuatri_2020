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

            Estudiante[] arrayEstudiantes = new Estudiante[5];

            arrayEstudiantes[0] = new Estudiante("pepito", "juancito", 0000);
            arrayEstudiantes[1] = new Estudiante("pepito", "juancito", 1111);
            arrayEstudiantes[2] = new Estudiante("pepito", "juancito", 2222);
            arrayEstudiantes[3] = new Estudiante("pepito", "juancito", 3333);
            arrayEstudiantes[4] = new Estudiante("pepito", "juancito", 4444);

            Estudiante miEstudiante = new Estudiante("pepito", "juancito", 3333);

            
            if(arrayEstudiantes != miEstudiante)
            {
                Console.WriteLine("Existe el estudiante");
            }


            if (arrayEstudiantes + miEstudiante)
            {
                Console.WriteLine("agregado");
            }
              
            // int + int 
            // float + float 
            // Estudiante[] + Estudiante


            Estudiante miEstu = new Estudiante("pepito", "juancito", 123,"calle falsa 1.2");


            Console.WriteLine();

            Establecimiento.SetearInfoJardin("Los pipis");
            Establecimiento.SetearInfoJardin(123);



            Establecimiento.AgregarAlumno(new Estudiante("pepito", "juancito", 123));
            Establecimiento.AgregarAlumno(new Estudiante("asd", "asdadsad", 321));






            Console.WriteLine(Establecimiento.MostrarAlumnos());



            Console.ReadKey();

        }
    }
}
