using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1MayorMenor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota, mayor, menor, contador;
            mayor = -1;
            menor = 11;

            for (contador=1; contador <= 10; contador++)
            {
                Console.WriteLine("Ingrese {0}° nota:",contador);
                nota = Convert.ToInt32(Console.ReadLine());
                if (nota > mayor) {
                    mayor = nota;
                }
                if (nota < menor)
                {
                    menor = nota;
                }
            }
            Console.WriteLine("Mayor: {0}, \nMenor: {1}", mayor, menor);
            Console.ReadKey();
        }
    }
}
