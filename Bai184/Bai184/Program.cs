using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai184
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {0, 9, 31, 37, 41, 43, 47, 53, 800 };
            IndexOfGreatestValue(arr);
            Console.ReadLine();
        }

        public static void IndexOfGreatestValue(int[] arr)
        {
            int index = 0;
            int value = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckPrime(arr[i]) == true)
                {
                    value = arr[i];
                    index = i;
                    break;
                }
            }
       

            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckPrime(arr[i])== true && arr[i] > value)
                {
                    value = arr[i];
                    index = i;
                }
            }

            Console.WriteLine("Index of Greatest Prime Number({0}): {1} ", value, index);
        }

        public static bool CheckPrime(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                return true;
            }
            return false;
        }
    }
}
