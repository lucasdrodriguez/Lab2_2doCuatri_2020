using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArrepentidor
{
    class Estudiante
    {

        string nombre;
        string apellido;
        int legajo;

        public Estudiante()
        {
            this.nombre = "sin nombre";
            this.apellido = "sin apellido";
            this.legajo = -1;

        }

        public Estudiante(string nomb,string ape,int leg)
        {
            this.apellido = ape;
            this.nombre = nomb; 
            this.legajo = leg;

        }
        public Estudiante(string nomb, int leg)
        {
            this.nombre = nomb;
            this.legajo = leg;

        }

        public Estudiante( int leg)
        {
          
            this.legajo = leg;

        }







        public string GetNombreYApellido()
        {

            return this.apellido + ","+this.nombre;


        }




    }
}
