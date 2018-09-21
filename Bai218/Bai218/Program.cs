using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai218
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { -256, 500, 256, 258, 800, -258, 15, -22, 39, 22 };
            Console.WriteLine(Count(arr));
            Console.ReadLine();
        }

        public static int Count(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (IsSymMetric(arr[i - 1] , arr[i+1]) == true)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsSymMetric(int prevNumber, int nextNumber)
        {
            if (Math.Abs(prevNumber) == Math.Abs(nextNumber))
            {
                if (prevNumber > nextNumber || prevNumber < nextNumber)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
