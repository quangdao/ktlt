using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai256
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35,800, 500, 256,15, 258, 800, 4, 15, 22, 39, 56,15 };
            AscendingArray(arr);
            Console.ReadLine();

        }

        public static void AscendingArray(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
