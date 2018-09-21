using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai217
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(CountNumber(arr));
            Console.ReadLine();
        }

        public static int CountNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] % 7 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
