using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RandomGenerator
    {
        static int seed = 240623;
        static Random randomGenerator = new Random(seed);
        

        static public void RandomArrayGenerator(short[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (short)randomGenerator.Next();
            }
        }

        static public void RandomArrayGenerator(Int64[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next();
            }
        }

        static public void RandomArrayGenerator(float[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next();
            }
        }
        static public void RandomArrayGenerator(decimal[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = randomGenerator.Next();
            }
        }

        static public string[] RandomStringsGenerator8(int size)
        {
            string[] randomStrings = new string[size];
            Random random = new Random(seed);

            for (int i = 0; i < size; i++)
            {
                string randomString = RandomString(8, random);
                randomStrings[i] = randomString;
            }

            return randomStrings;
        }

        static public string[] RandomStringsGenerator32(int size)
        {
            string[] randomStrings = new string[size];
            Random random = new Random(seed);

            for (int i = 0; i < size; i++)
            {
                string randomString = RandomString(32, random);
                randomStrings[i] = randomString;
            }

            return randomStrings;
        }

        static public string RandomString(int length, Random random)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char[] randomChars = new char[length];

            for (int i = 0; i < length; i++)
            {
                randomChars[i] = chars[random.Next(chars.Length)];
            }

            return new string(randomChars);
        }


    }
}
