using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai213
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(AverageNumbersGreaterThanX(arr,300));
            Console.ReadLine();

        }

        public static float AverageNumbersGreaterThanX(float[] arr, int x)
        {
            int count = 0;
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > x)
                {
                    count++;
                    sum += arr[i];
                }
            }

            return sum / count;
        }
    }
}
