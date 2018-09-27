using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai239
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 35, 29, 56, 23, 29, 31, 37, 41, 29 };
            CountDistinctPrime(arr);
            Console.ReadLine();
        }

        public static void CountDistinctPrime(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (ExistInArray(arr, i) == false && CheckPrimeNumber(arr[i]) == true)
                {
                    count++;
                }
            }
            Console.WriteLine("Number of Distinct Prime: {0}", count);
        }

        public static bool ExistInArray(int[] arr, int index)
        {
            for (int i = index - 1; i >= 0 ; i--)
            {
                if (arr[i] == arr[index])
                {
                    return true;
                }
            }
            return false;
        }

        public static bool CheckPrimeNumber(int number)
        {
            int count = 0;
            if (number <= 1)
            {
                return false;
            }

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
