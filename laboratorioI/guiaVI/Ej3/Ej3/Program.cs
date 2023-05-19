using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string localidad, candidato, candidatoGanador = "", localidadMayor = "";
            int cantVotos = 0, totalVotos = 0, mayorVotos = -1, mayorVotoLocalidad = 0, cantMesas, cantVotosTotal = 0;
            double porcLocalidad;

            for (int m = 0; m < 3; m++)
            {
                Console.WriteLine("Ingrese nombre de localidad:");
                localidad = Console.ReadLine();

                Console.WriteLine("Ingrese cantidad de mesas:");
                cantMesas = Convert.ToInt32(Console.ReadLine());

                for (int p = 0; p < cantMesas; p++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        totalVotos = 0;

                        Console.WriteLine("Ingrese nombre del candidato:");
                        candidato = Console.ReadLine();

                        Console.WriteLine("Ingrese cantidad de votos:");
                        cantVotos = Convert.ToInt32(Console.ReadLine());

                        cantVotosTotal = cantVotosTotal + cantVotos;

                        if (cantVotos > mayorVotos)
                        {
                            mayorVotos = cantVotos;
                            candidatoGanador = candidato;
                        }

                        totalVotos = totalVotos + cantVotos;
                        Console.WriteLine("El total de votos del candidato {0} es de: {1}.", candidato, totalVotos);
                    }
                    if (totalVotos > mayorVotoLocalidad)
                    {
                        mayorVotoLocalidad = totalVotos;
                        localidadMayor = localidad;
                    }

                    Console.WriteLine("El ganador es el candidato {0}, con la cantidad de: {1} votos.", candidatoGanador, mayorVotos);
                }
            }
            porcLocalidad = (mayorVotoLocalidad * 100) / cantVotosTotal;
            Console.WriteLine("La localidad con mayor porcentaje de votos es {0} con un {1}%.", localidadMayor, porcLocalidad);

            Console.WriteLine("Presione una tecla para salir.");
            Console.ReadKey();
        }
    }
}
