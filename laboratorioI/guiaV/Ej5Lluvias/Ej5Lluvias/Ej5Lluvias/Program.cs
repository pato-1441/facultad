using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej5Lluvias
{
    internal class Ej5Lluvias
    {
        static void Main(string[] args)
        {
            int medicion, mes, totalRegistrado, mayorMedicion, contadorMed;
            double promedio;

            contadorMed = 0;
            totalRegistrado = 0;
            mayorMedicion = 0;

            Console.Title = "Ej5Lluvias";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WindowHeight = 30;
            Console.WindowWidth = 70;
            Console.Clear();

            Console.CursorLeft = 2;
            Console.CursorTop = 1;
            Console.Write("Ingrese nro de mes a calcular mediciones: ");
            mes = Convert.ToInt32(Console.ReadLine());
            while (mes < 0 || mes > 12) {
                Console.CursorLeft = 2;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingrese un nro de mes válido por favor.");
                Console.CursorLeft = 2;
                mes = Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.CursorLeft = 2;
            Console.WriteLine("Ingrese medicion en mm, para salir ingrese -1 ");
            Console.CursorLeft = 2;
            medicion = Convert.ToInt32(Console.ReadLine());

            while (medicion != -1)
            {
                totalRegistrado = totalRegistrado + medicion;
                if (medicion > mayorMedicion)
                {
                    mayorMedicion = medicion;
                }
                contadorMed++;
                Console.CursorLeft = 2;
                Console.WriteLine("Ingrese medicion en mm, para salir ingrese -1 ");
                Console.CursorLeft = 2;
                medicion = Convert.ToInt32(Console.ReadLine());
            }
            if (totalRegistrado != 0)
            {
                promedio = (totalRegistrado / contadorMed );
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine();
                Console.CursorLeft = 2;
                Console.WriteLine("Total registrado en mes {0}: {1} mm.", mes, totalRegistrado);
                Console.CursorLeft = 2;
                Console.WriteLine("Promedio mm llovidos / dias registrados: {0} mm.",promedio);
                Console.CursorLeft = 2;
                Console.WriteLine("Mayor medicion: {0} mm.", mayorMedicion);
            }
            Console.ReadKey();
        }
    }
}
