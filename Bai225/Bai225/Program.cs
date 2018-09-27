using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai225
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = new float[] { 35, 500, 256, 258, 800, 4, 800, 15, 22, 39, 56 };
            Console.WriteLine(CountGreatest(arr));
            Console.ReadLine();
        }

        public static int CountGreatest(float[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == FindGreatestNumber(arr))
                {
                    count++;
                }
            }
            return count;
        }

        public static float FindGreatestNumber(float[] arr)
        {
            float greatest = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > greatest)
                {
                    greatest = arr[i];
                }
            }
            return greatest;
        }
    }
}
