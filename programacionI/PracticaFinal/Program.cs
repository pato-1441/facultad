using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaFinal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contadorEmbarques = 0, modeloMoto;
            double valorFabrica=0, valorTotal=0;

            Console.WriteLine("Ingrese modelo de la moto o -1 para salir.");
            modeloMoto = Convert.ToInt32(Console.ReadLine());
            if (modeloMoto != -1) {
                Console.WriteLine("Ingrese valor de fabrica o -1 para salir.");
                valorFabrica = Convert.ToInt32(Console.ReadLine());
            while (modeloMoto != -1 && valorFabrica!=-1)
            {
                double valor = CalcularValorActual(valorFabrica, modeloMoto);
                valorTotal += valor;
                contadorEmbarques++;
                Console.Clear();
                Console.WriteLine("Modelo del embarque: {0}, valor: {1:C2}", modeloMoto, valor);
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Ingrese modelo de la moto o -1 para salir.");
                modeloMoto = Convert.ToInt32(Console.ReadLine());
                if (modeloMoto != -1)
                {
                    Console.WriteLine("Ingrese valor de fabrica o -1 para salir.");
                    valorFabrica = Convert.ToInt32(Console.ReadLine());
                }
            }
            }
            Console.WriteLine("Valor total de los embarques: {0:C2}, cantidad de embarques: {1}", valorTotal, contadorEmbarques);
            Console.ReadKey();
        }
        static double CalcularValorActual(double valorFabrica, int modeloMoto)
        {
            double total = 0;
            total = valorFabrica * Math.Pow((0.90),(2023 - modeloMoto));
            return total;
        }
    }
}
