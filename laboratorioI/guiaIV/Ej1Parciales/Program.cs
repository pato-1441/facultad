using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1Parciales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, promedio;

            Console.WriteLine("Ingrese sus notas: ");
            p1 = Convert.ToDouble(Console.ReadLine());
            p2 = Convert.ToDouble(Console.ReadLine());
            p3 = Convert.ToDouble(Console.ReadLine());

            promedio = (p1 + p2 + p3) / 3;

            if (promedio > 7)
            {
                Console.WriteLine("Promocionó");
            } else { Console.WriteLine("Rinde final"); }
            Console.ReadKey();
        }
    }
}
