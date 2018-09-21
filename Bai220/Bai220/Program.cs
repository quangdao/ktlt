using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai220
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(CountNumber(arr));
            Console.ReadLine();
        }

        public static int CountNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckLastDigit( arr[i]) == true)
                {
                    count++;
                }
            }
            return count;
        }

        public static bool CheckLastDigit(int number)
        {
            if (number % 10 == 5)
            {
                return true;
            }
            return false;
        }
    }
}
