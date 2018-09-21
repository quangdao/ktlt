using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai212
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 500, -256, 258, -800, 4, 15, -22, 39, 56 };
            Console.WriteLine(AveragePositiveNumbers(arr));
            Console.ReadLine();
        }

        public static float AveragePositiveNumbers (float[] arr)
        {
            int count = 0;
            float sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    count++;
                    sum += arr[i];
                }
            }
            return sum/count ;
        }
    }
}
