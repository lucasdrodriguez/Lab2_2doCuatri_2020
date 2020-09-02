using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArrepentidor
{
    class Estudiante
    {

        string nombre;
        string apellido;
        int    dni;
        int    alturaEnCm;
        string direccion;


        public Estudiante(string nomb,string ape,int dni, int alturaEnCm)
        {
            this.apellido = ape;
            this.nombre = nomb; 
            this.dni = dni;
            this.alturaEnCm = alturaEnCm;

        }

        public Estudiante(string nomb, string ape, int dni,string direccion): this(nomb,ape,dni)
        {
            this.direccion = direccion;
        }


        public Estudiante(string nomb, string apellido, int dni):this()
        {
            this.nombre = nomb;
            this.dni = dni;
            this.apellido = apellido;
        }

        //ctor tab tab
        private Estudiante()
        {
            this.nombre = "sin nombre";
            this.apellido = "sin apellido";
            this.dni = -1;
            this.alturaEnCm = -1;
            this.direccion = "sin direccion";
        }
      

        public string GetNombreYApellido()
        {
            //  Rodriguez,Lucas
            return this.apellido + ","+this.nombre;
        }


        public string GetNombreYApellido(string mensaje)
        {
            // return mensaje + "-" + this.apellido + "," + this.nombre;
            return mensaje + "-" + this.GetNombreYApellido();
        }

        
        public static bool operator ==(Estudiante[] arrayAux,Estudiante auxEstu)
        {
            bool retorno = false;
            for (int i = 0; i < arrayAux.Length; i++)
            {
                if(arrayAux[i].dni == auxEstu.dni )
                {
                    retorno =  true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Estudiante[] arrayAux, Estudiante auxEstu)
        {
            return !(arrayAux == auxEstu);
        }

        public static bool operator +(Estudiante[] arrayAux, Estudiante auxEstu)
        {
            bool retorno = false;
            if(arrayAux != auxEstu)
            {
                for (int i = 0; i < arrayAux.Length; i++)
                {
                    if (arrayAux[i] == null)
                    {
                        arrayAux[i] = auxEstu;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;

        }
        public static bool operator -(Estudiante[] arrayAux, Estudiante auxEstu)
        {
            bool retorno = false;
            if (arrayAux == auxEstu)
            {
                for (int i = 0; i < arrayAux.Length; i++)
                {
                    if (arrayAux[i] == auxEstu)
                    {
                        arrayAux[i] = null;
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;

        }


    }
}
