using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai231
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 15 , 258, 800, 4,256, 15, 22, 39, 56 };
            CountUniqueNumber(arr);
            Console.ReadLine();

        }

        public static void CountUniqueNumber(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsUnique(arr,arr[i]) == true)
                {
                    Console.WriteLine("{0}",arr[i]);
                }
            }
           
        }

        public static bool IsUnique(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            if (count > 1)
            {
                return false;
            }
            return true;
        }
    }
}
