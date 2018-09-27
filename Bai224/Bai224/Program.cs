using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai224
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500,6, 256, 258, 8128, 800, 4, 28, 15, 22, 39, 56 };
            Console.WriteLine(CountPerfectNumber(arr));
            Console.Read();
        }


        public static int CountPerfectNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPerfectNumber(arr[i]) == true)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsPerfectNumber(int number)
        {
            int sum = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == number)
            {
                return true;
            }
            return false;
        }
    }
}
