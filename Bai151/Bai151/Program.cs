using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai151
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 0, 5, 7, 1, 29, 17, 19, 23, 0 };
            Console.WriteLine(GreatestPrimeNumber(arr));
            Console.ReadLine();
        }

        public static bool CheckPrime(int number)
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
            if (count == 2) {
                return true;
            }
            return false;
        }

        public static int GreatestPrimeNumber(int[] arr)
        {
            int greatest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckPrime(arr[i]) == true && arr[i] > greatest)
                {
                    greatest = arr[i];
                }
            }

            return greatest;
        }
    }


}
