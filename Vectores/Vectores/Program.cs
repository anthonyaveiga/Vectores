using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectores
{
    
    
class Program
    {
        public static void VectorInicializar()
        {
            int[] x = new int[8];
            x[0] = 10;
            x[1] = 2;
            x[2] = 20;
            x[3] = 8;
            x[4] = 15;
            x[5] = 1;
            x[6] = -9;
            x[7] = 14;


            int suma = 0;
            Console.WriteLine("\nElementos del vector \n=====================\n");
            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine("ELEMENTO INDICE {0} ----> {1}", (i + 1), x[i]);
                suma += x[i];
            }

            Console.WriteLine("La sumatoria es {0}", suma);
            Console.WriteLine("El promedio es {0}", (double)suma /x.Length);


        }
        static void Main(string[] args)
        {

            VectorInicializar();
            Console.ReadKey();
        }
    }
}
