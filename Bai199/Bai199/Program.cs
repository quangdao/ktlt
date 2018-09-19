using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai199
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] {0,1, 35, 23, 29, 31, 37, 43, 47, 800, 4, 15, 41, 22, 39, 56 };
            LietKeSoNguyenTo(arr);
            //Console.WriteLine(CheckPrimeNumber(97));
            Console.Read();
        }

        public static void LietKeSoNguyenTo(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckPrimeNumber(arr[i]) == true)
                {
                    Console.Write(" {0} ", arr[i]);
                }
            }
        }

        public static bool CheckPrimeNumber(int number)
        {
            int count = 0;
            if (number <= 1)
               return false;
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
