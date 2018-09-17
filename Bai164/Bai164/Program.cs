using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai164
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1233, 23442,3421243,12,41,12321,2314,224};
            Console.WriteLine(GanhDauTien(arr));
            Console.ReadLine();
        }


        public static int GanhDauTien(int[] arr)
        {

            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraGanh(arr[i]) == true)
                {
                    return arr[i];
                }
            }
            return 0;
        }

        public static bool KiemTraGanh(int number) {
            int digits = CountDigit(number, 0);
            int temp = number;
            int reverseNumber = 0;
            for (int i = 1; i <= digits; i++)
            {
                reverseNumber = reverseNumber * 10 + temp % 10;
                temp = temp / 10;
            }

            if (reverseNumber == number)
            {
                return true;
            }
            
            return false;

        }

        public static int CountDigit(int number, int count) {
            if (number == 0)
            {
                return count;
            }
            return CountDigit(number/10, ++count);
        }
    }
}
