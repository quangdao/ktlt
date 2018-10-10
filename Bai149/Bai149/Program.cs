using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai149
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 5, 6, 8, 9, 28,23,22,11,6,18,496,535,322 };
           // Console.WriteLine(kiemtrahoanthien(6));
            Console.WriteLine(sohoanthiencuoi(arr));
            Console.ReadLine();
        }

        public static int sohoanthiencuoi(int[] arr) {
         
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (kiemtrahoanthien(arr[i]) == true) {
                    return arr[i];
                }
            }
            return -1;
        }


        public static bool kiemtrahoanthien(int number)
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
