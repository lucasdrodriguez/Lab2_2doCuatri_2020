using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita_Implicita_Objetos
{
    class Program
    {
        static void Main(string[] args)
        {

            Docente[] arrayDocentes = new Docente[10];

            Docente docenteAux = new Docente("Pepe", "Peposo", 25, 1);


            Alumno miAlumnoAux = new Alumno("Romeo", "Gatuso", 20);

            Alumno miAlumno;


            int resultado;

            float num1 = 20.5f;

            resultado = (int) num1;


            miAlumno = (Alumno) docenteAux;



            docenteAux = miAlumnoAux;


            string nombreYApellidoDocente =  docenteAux;

            Console.WriteLine(nombreYApellidoDocente);

            Console.ReadKey();


        }
    }
}
