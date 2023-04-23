using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej10Bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int año;
            Console.WriteLine("Ingrese año");
            año = Convert.ToInt32(Console.ReadLine());

            if (año % 400 == 0) {
                Console.WriteLine("Es bisiesto");
            } else if (año % 4 == 0 && año % 100 != 0) {
                Console.WriteLine("Es bisiesto");
            } else
            {
                Console.WriteLine("No es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
