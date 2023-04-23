using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej6Triatlon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nroComp, totalComp, nroGanador;
            double tCicli, tNata, tPede, menorCicli, menorNata, menorPede, tTotalComp, tTotalGanador;

            totalComp = 0;
            menorCicli = 10000000;
            menorNata = 10000000;
            menorPede = 10000000;
            tTotalGanador = 10000000;
            nroGanador = 0;

            Console.WriteLine("Ingrese numero de competidor, para salir ingrese -1");
            nroComp = Convert.ToInt32(Console.ReadLine());

            while (nroComp != -1)
            {
                Console.WriteLine("Ingrese tiempo en segundos realizado en Ciclismo:");
                tCicli = Convert.ToDouble(Console.ReadLine());
                if (tCicli < menorCicli)
                {
                    menorCicli=tCicli;
                }

                Console.WriteLine("Ingrese tiempo en segundos realizado en Natacion:");
                tNata = Convert.ToDouble(Console.ReadLine());
                if (tNata < menorNata)
                {
                    menorNata = tNata;
                }

                Console.WriteLine("Ingrese tiempo en segundos realizado en Pedestrismo:");
                tPede = Convert.ToDouble(Console.ReadLine());
                if (tPede < menorPede)
                {
                    menorPede = tPede;
                }

                tTotalComp = (tCicli + tNata + tPede);
                if (tTotalComp < tTotalGanador)
                {
                    tTotalGanador=tTotalComp;
                    nroGanador = nroComp;
                }
                totalComp++;

                Console.WriteLine("Ingrese numero de competidor, para salir ingrese -1");
                nroComp = Convert.ToInt32(Console.ReadLine());
            }
            if (totalComp != 0)
            {
                Console.WriteLine("Total de competidores: {0}", totalComp);
                Console.WriteLine("Menor tiempo en Ciclismo: {0}", menorCicli);
                Console.WriteLine("Menor tiempo en Natacion: {0}", menorNata);
                Console.WriteLine("Menor tiempo en Pedestrismo: {0}", menorPede);
                Console.WriteLine("Competidor ganador: {0}, tiempo realizado: {1}s", nroGanador, tTotalGanador);
            } else
            {
                Console.WriteLine("No se registraron competidores");
            }
            Console.ReadKey();
        }
    }
}
