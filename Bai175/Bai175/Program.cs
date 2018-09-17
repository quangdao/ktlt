using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai175
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            FindClosetPair(arr);
            Console.ReadLine();
        }

        public static void FindClosetPair(float[] arr)
        {
            float distance = CheckNumber(arr[0], arr[1]);
            float numberA = arr[0];
            float numberB = arr[1];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (CheckNumber(arr[i], arr[j]) < distance)
                    {
                        distance = CheckNumber(arr[i], arr[j]);
                        numberA = arr[i];
                        numberB = arr[j];
                    }
                }
            }
            Console.WriteLine("{0} and {1}, distance: {2}", numberA, numberB, distance);
        }

        public static float CheckNumber(float numberA, float numberB)
        {
            float distance = Math.Abs(numberB - numberA);
            return distance;
        }

    }
}
