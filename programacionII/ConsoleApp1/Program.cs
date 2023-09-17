using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ArrayList arrayList = new ArrayList();
            arrayList.Add(1);
            Console.ReadKey();
            arrayList.Add(2);
            Console.ReadKey();
            arrayList.Add(3);
            Console.ReadKey();
            Console.WriteLine("Count: "+arrayList.Count);
            Console.WriteLine("Capacity: " + arrayList.Capacity);
            Console.ReadKey();
            arrayList.Count = 2;
            Console.WriteLine("Count: " + arrayList.Count);
            Console.WriteLine("Capacity: " + arrayList.Capacity);
            Console.ReadKey();
            */

            
            ClaseBase objetoBase = new ClaseBase();
            ClaseDerivada objetoDerivada = new ClaseDerivada();
            objetoBase = objetoDerivada;
            objetoBase.MetodoBase();
            Console.ReadKey();
            
        }
    }
}

