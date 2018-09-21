using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai211
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 2, 3, 5, 7, 11, 256, 258, 800, 4, 15, 13, 17, 19, 22, 39, 56 };
            Console.WriteLine(AveragePrimeNumbers(arr));
            Console.ReadLine();
        }

        public static float AveragePrimeNumbers(int[] arr)
        {
            int countPrime = 0;
            int sumPrime = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsPrimeNumber(arr[i]) == true)
                {
                    sumPrime += arr[i];
                    countPrime++;
                }
            }
            if (countPrime == 0)
            {
                return 0;
            }
            return (float)sumPrime / countPrime;
        }

        public static bool IsPrimeNumber(int number)
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
