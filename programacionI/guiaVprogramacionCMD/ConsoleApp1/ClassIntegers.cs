using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ClassIntegers
    {
        static public short[] SelectionSort16(short[] array)
        {
            short min, aux;
            for (short i = 0; i < array.Length - 1; i++)
            {
                min = i;

                for (short j = (short)(i + 1); j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                aux = array[min];
                array[min] = array[i];
                array[i] = aux;
            }
            return array;
        }

        static public Int64[] SelectionSort64(Int64[] array)
        {
            Int64 min, aux;
            for (Int64 i = 0; i < array.Length - 1; i++)
            {
                min = i;

                for (Int64 j = (Int64)(i + 1); j < array.Length; j++)
                {
                    if (array[j] < array[min])
                    {
                        min = j;
                    }
                }
                aux = array[min];
                array[min] = array[i];
                array[i] = aux;
            }
            return array;
        }
    }
}
