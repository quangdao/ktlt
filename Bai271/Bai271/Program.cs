using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai271
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            DeleteValue(arr,3);
            Console.ReadLine();
        }

        public static void DeleteValue(int[] arr, int posK)
        {
            int[] temp = new int[arr.Length - 1];
            for (int i = 0; i < posK; i++)
            {
                temp[i] = arr[i];
            }
            for (int i = posK + 1; i < arr.Length; i++)
            {
                temp[i-1] = arr[i];
            }
            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }
    }
}
