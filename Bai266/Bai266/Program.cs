using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai266
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 29, 56, 346, 425, 39 };
            Insert(arr,2,99);
            Console.ReadLine();
        }

        public static void Insert(int[] arr, int posK, int valueX)
        {
            int[] temp = new int[arr.Length + 1];

            for (int i = 0; i < posK; i++)
            {
                temp[i] = arr[i];
            }
            temp[posK] = valueX;

            for (int j = posK + 1; j < temp.Length; j++)
            {
                temp[j] = arr[j-1];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                Console.WriteLine(temp[i]);
            }
        }

        


    }
}
