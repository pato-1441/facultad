using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej7MayorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, mayor;

            Console.WriteLine("Ingrese el primer numero");
            n = Convert.ToInt32(Console.ReadLine());
            mayor = n;

            Console.WriteLine("Ingrese el segundo numero");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > mayor)
            {
                mayor = n;
            }

            Console.WriteLine("Ingrese el tercer numero");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > mayor)
            {
                mayor = n;
            }

            Console.WriteLine("Ingrese el cuarto numero");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > mayor)
            {
                mayor = n;
            }

            Console.WriteLine("Ingrese el quinto numero");
            n = Convert.ToInt32(Console.ReadLine());
            if (n > mayor)
            {
                mayor = n;
            }

            Console.WriteLine("El mayor es: {0}", mayor);
            Console.ReadKey();
        }
    }
}
