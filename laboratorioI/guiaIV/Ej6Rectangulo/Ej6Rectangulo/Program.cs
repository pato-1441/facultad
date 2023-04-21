using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6Rectangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baseRectangulo, alturaRectangulo;

			Console.WriteLine("Ingrese la base de la figura: ");
			baseRectangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese la altura de la figura: ");
            alturaRectangulo = Convert.ToDouble(Console.ReadLine());

			if (baseRectangulo == alturaRectangulo)
			{
				Console.WriteLine("Es un cuadrado");
			} else if (baseRectangulo > alturaRectangulo)
			{
                Console.WriteLine("Es un rectangulo horizontal");
            } else
			{
                Console.WriteLine("Es un rectangulo vertical");
            }

            Console.WriteLine("El area del rectangulo es: {0}", baseRectangulo*alturaRectangulo);
            Console.ReadKey();
        }
    }
}
