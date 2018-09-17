using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai174
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            FindPairs(arr);
            Console.ReadLine();
        }

        public static void FindPairs(float[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (CheckPair(arr[i], arr[j]) == true)
                    {
                        Console.WriteLine("{0}, {1}", arr[i],arr[j]);
                    }
                }
            }
        }

        public static bool CheckPair(float numberA, float numberB)
        {
            if (numberA >= numberB)
            {
                return false;
            }
            return true;
        }
    }
}
