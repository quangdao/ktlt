using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai226
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(CountKeChan(arr));
            Console.ReadLine();
        }

        public static int CountKeChan(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] % 2 == 0 && arr[i + 1] % 2 == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
