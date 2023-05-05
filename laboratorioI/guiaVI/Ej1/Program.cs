using System;

namespace Ej1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantViajes, edad = 0, valorTicket = 3, totalViajes = 0, totalDia = 0;

            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WindowHeight = 25;
            Console.WindowWidth = 75;
            Console.Clear();
            Console.WriteLine("Ingrese la cantidad de viajes a realizar:");
            cantViajes = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= cantViajes; i++)
            {
                Console.WriteLine("Inicio del viaje n°: {0}", i);
                Console.WriteLine("Ingrese la edad: ");
                edad = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine("Valor ticket: ${0}", valorTicket);
                    totalViajes++;
                    Console.WriteLine("Ingrese la edad del siguiente: (-1: para finalizar viaje)");
                    edad = Convert.ToInt32(Console.ReadLine());
                } while (edad != -1);
                

                Console.WriteLine("Recaudacion viaje n°{0}: ${1}",i, totalViajes*valorTicket);
                totalDia = (totalViajes * valorTicket) + totalDia;
                totalViajes = 0;
            }
            Console.WriteLine("Recaudacion del día: ${0}", totalDia);           
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}
