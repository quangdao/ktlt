using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai208
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 16, 22, 39, 56 };
            Console.WriteLine(SumSquareNumber(arr));
            Console.ReadLine();
        }

        public static int SumSquareNumber(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsSquareNumber(arr[i]) == true)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static bool IsSquareNumber (int number)
        {
            for (int i = 0; i <= number; i++)
            {
                if (Math.Pow(i,2) == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
