using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3PositivoNegativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Ingrese el numero: ");
            num=Convert.ToInt32(Console.ReadLine());

            if (num==0) {
                Console.WriteLine("Es cero");
            } else if (num > 0)
            {
                Console.WriteLine("Positivo");
            } else { Console.WriteLine("Negativo"); }
            Console.ReadKey();  
        }
    }
}
