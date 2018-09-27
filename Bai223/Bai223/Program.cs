using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai223
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(CountPrime(arr));
            Console.ReadLine();
        }

        public static int CountPrime(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrime(arr[i]) == true)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsPrime(int number)
        {
            int count = 0;
            for (int i = 0; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            return false;
        }

    }
}
