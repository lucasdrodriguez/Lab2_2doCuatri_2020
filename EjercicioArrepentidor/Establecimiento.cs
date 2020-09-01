using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArrepentidor
{
   static class Establecimiento
    {

      static  string nombreDelJardin;
      static  Estudiante[] misEstudiantes;


        static Establecimiento()
        {
            nombreDelJardin = null;
            misEstudiantes = new Estudiante[10];
        }


        public static void SetearNombreJardin(string nombre)
        {
            if (string.IsNullOrEmpty(nombreDelJardin))
            {
                nombreDelJardin = nombre;
            }

        }

        public static void AgregarAlumno(Estudiante auxEstudiante)
        {
            for (int i = 0; i < misEstudiantes.Length; i++)
            {
                if(misEstudiantes[i] == null)
                {
                    misEstudiantes[i] = auxEstudiante;
                    break;
                }
            }
        }

        public static string MostrarAlumnos()
        {
            string auxString = null;

            for (int i = 0; i < misEstudiantes.Length; i++)
            {
                if (misEstudiantes[i] != null)
                {
                    auxString += "Apellido,nombre: " + misEstudiantes[i].GetNombreYApellido() + "\n" + "legajo: " + misEstudiantes[i].GetLegajo().ToString();
                    auxString += "\n";
              
                }
            }

            if (auxString == null)
                auxString = "Sin informacion de alumnos";

            return auxString;
        }

    }
}
