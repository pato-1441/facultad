using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList cities = new ArrayList();
            Console.WriteLine("Sistema de ciudades\n----------------------------------------");
            Console.ReadKey();

            Console.WriteLine("Ingrese el nombre de la ciudad que desea agregar o 'S' para salir");
            string city = Console.ReadLine();

            while (city != "s" && city != "S")
            {
                cities.Add(city);

                foreach (string citi in cities)
                {
                    Console.WriteLine("Ciudad: {0}\n", citi);
                }
                Console.ReadKey();
                Console.WriteLine("Ingrese el nombre de la ciudad que desea agregar o 'S' para salir");
                city = Console.ReadLine();
            }

            if(cities.Contains("Julieta Rutar"))
            {
                Console.WriteLine("Está Julieta!!!!!");
                cities.Remove("Julieta Rutar");
            }
            else 
            {
                Console.WriteLine("Julieta ausente");
            }

            foreach (string citi in cities)
            {
                Console.WriteLine("Ciudad: {0}\n", citi);
            }
            Console.ReadKey();
        }
    }
}
