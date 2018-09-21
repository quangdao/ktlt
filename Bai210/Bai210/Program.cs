using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai210
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(Sum(arr));
            Console.ReadLine();
        }

        public static int Sum(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (IsFirstDigitEvenNumber(arr[i]) == true)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static bool IsFirstDigitEvenNumber(int number)
        {
            int temp = Math.Abs(number);
            int firstDigit = temp;
            while (temp > 0)
            {
                firstDigit = temp % 10;
                temp /= 10;
            }
            if (firstDigit % 2 == 0)
            {
                return true;
            }
            return false;
            {

            }
        }
    }
}
