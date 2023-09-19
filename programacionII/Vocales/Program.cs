using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string respuesta = "s";
            while (respuesta == "s" || respuesta == "S")
            {
                int contVocales = 0;
                Console.WriteLine("Ingrese una cadena de caracteres");
                string textoNormal = Console.ReadLine();
                string texto = textoNormal.ToLower();
                foreach (char c in texto)
                {
                    switch (c)
                    {
                        case 'a':
                            contVocales++;
                            break;
                        case 'e':
                            contVocales++;
                            break;
                        case 'i':
                            contVocales++;
                            break;
                        case 'o':
                            contVocales++;
                            break;
                        case 'u':
                            contVocales++;
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("La cantidad de vocales existentes es de: " + contVocales);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Si desea continuar con otra cadena ingrese [s/S], o [n/N] para salir.");
                respuesta = Console.ReadLine();
            }


        }
    }
}
