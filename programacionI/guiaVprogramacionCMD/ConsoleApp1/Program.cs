using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----SHORT-------");

            short[] shortArray = new short[5];
            RandomGenerator.RandomArrayGenerator(shortArray);
            ShowArray(shortArray);
            Console.WriteLine("------------------------------");
            ClassIntegers.SelectionSort16(shortArray);
            ShowArray(shortArray);

            Console.WriteLine("-----INT64-------");


            Int64[] intArray = new Int64[5];
            RandomGenerator.RandomArrayGenerator(intArray);
            ShowArray(intArray);
            Console.WriteLine("------------------------------");
            ClassIntegers.SelectionSort64(intArray);
            ShowArray(intArray);

            Console.WriteLine("----------FLOAT-----------");

            float[] floatArray = new float[5];
            RandomGenerator.RandomArrayGenerator(floatArray);
            ShowArray(floatArray);
            Console.WriteLine("------------------------------");
            ClassDouble.SelectionSortFloat(floatArray);
            ShowArray(floatArray);

            Console.WriteLine("---------DECIMAL-----------");

            decimal[] decimalArray = new decimal[5];
            RandomGenerator.RandomArrayGenerator(decimalArray);
            ShowArray(decimalArray);
            Console.WriteLine("------------------------------");
            ClassDouble.SelectionSortDecimal(decimalArray);
            ShowArray(decimalArray);

            Console.WriteLine("----------STRING8----------");

            string[] stringArray8 = RandomGenerator.RandomStringsGenerator8(5);
            ShowArray(stringArray8);
            Console.WriteLine("------------------------------");
            ClassStrings.SelectionSortStrings(stringArray8);
            ShowArray(stringArray8);

            Console.WriteLine("----------STRING32---------");

            string[] stringArray32 = RandomGenerator.RandomStringsGenerator32(5);
            ShowArray(stringArray32);
            Console.WriteLine("------------------------------");
            ClassStrings.SelectionSortStrings(stringArray32);
            ShowArray(stringArray32);



            Console.ReadKey();
        }

        static public void ShowArray(Int64[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);                
            }
        }
        static public void ShowArray(short[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);                
            }
        }
        static public void ShowArray(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static public void ShowArray(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
        static public void ShowArray(string[] array)
        {
            foreach (string str in array)
            {
                Console.WriteLine(str);
            }
        }

    }
}
