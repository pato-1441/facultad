using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjEnClase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promedioMatriz, promedioTotal, acumuladorTotal=0;
            int acumuladorMatriz, numero, contadorFila, contadorMatrizFila;
            bool diecisiete=false;

            Random random = new Random();

            for (contadorFila=0; contadorFila<5; contadorFila++)
            {
                numero = random.Next(-1,20);
                contadorMatrizFila = 0;
                acumuladorMatriz = 0;
                diecisiete = false;
                while (numero != -1)
                {
                    if (numero < 8 || numero > 14)
                    {
                        if (numero == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.BackgroundColor = ConsoleColor.Yellow;
                            Console.Write(numero);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                            numero *= 2;
                        }
                        if (numero == 17)
                        {
                            diecisiete = true;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.DarkGreen;
                            Console.Write(numero);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(" ");
                        }
                        if (numero != 17 || numero!= 6)
                        {
                            contadorMatrizFila++;
                            acumuladorMatriz += numero;
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Write(numero + " ");
                        }
                    }
                    
                    numero = random.Next(-1, 20);                    
                }

                if (numero != 1) {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.Write(numero);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Write(" ");
                }                

                if (diecisiete)
                {
                    promedioMatriz = 0;
                } else
                {
                    promedioMatriz = (double)acumuladorMatriz / contadorMatrizFila;
                }
                
                if ( promedioMatriz > 0 )
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0,6:f2}", promedioMatriz);
                    acumuladorTotal += promedioMatriz;
                } else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("0,00");
                }                             
            }
            promedioTotal = (double)acumuladorTotal / contadorFila;
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Promedio: {0,6:f2}", promedioTotal);
            Console.ReadKey();
        }
    }
}
