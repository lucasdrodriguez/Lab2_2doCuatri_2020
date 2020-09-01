using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioArrepentidor
{
    static class Validaciones
    {
        static int numAux;

        static Validaciones()
        {
            numAux = 10;
        }

        public static bool NumeroMayor(int num1)
        {

            if (num1 > numAux)
                return true;
            else
                return false;

        }





    }
}
