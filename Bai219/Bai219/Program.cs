using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai219
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 35, 56 };
            Console.WriteLine(CountX(arr,35));
            Console.ReadLine();
        }

        public static int CountX(int[] arr, int x)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
