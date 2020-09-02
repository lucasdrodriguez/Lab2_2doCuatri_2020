using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionExplicita_Implicita
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CONVERSION IMPLICITA \n");
            //conversion implicita porque NO necesitamos aclarar la conversion: No hay perdida de datos
            int num = 10;

            float numeroFlotante;


            numeroFlotante = num;

            Console.WriteLine(numeroFlotante);

            Console.WriteLine("************************************** \n");

            //conversion EXPLICITA porque NECESITAMOS aclarar la conversion y hacernos cargo de la perdida de datos
           
            Console.WriteLine("CONVERSION EXPLICITA \n");
            
            float numeroFlotanteEjemplo2 = 10.5f;

           int ejemplo2 = (int) numeroFlotanteEjemplo2;


            Console.WriteLine(ejemplo2);
            Console.ReadKey();


        }
    }
}
