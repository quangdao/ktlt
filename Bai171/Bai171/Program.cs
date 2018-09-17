using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai171
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 75, 50, 30 };
            Console.WriteLine(GreatestCommonDivisor(arr));
            Console.ReadLine();
        }



        public static int GreatestCommonDivisor(int[] arr)
        {
            int gcd = 1;
            int lowest = LowestValue(arr);
            int gcdOfSmallest = CommonDivisor(lowest);

            for (int i = gcdOfSmallest; i >= 1; i--)
            {
                if (CheckCommonDivisor(arr, i) == true) {
                    gcd = i;
                    return gcd;
                }
            }

            return gcd;
            
        }

        public static bool CheckCommonDivisor(int[] arr, int divisor)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % divisor != 0) {
                    return false;
                }
            }
            return true;
        }

        public static int LowestValue(int[] arr)
        {
            int lowest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < lowest)
                {
                    lowest = arr[i];
                }
            }
            return lowest;
        }

        public static int CommonDivisor(int number)
        {
            int cd = 1;
            if (number < 0)
                return 1;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    cd = i;
                }
            }
            return cd;
        }

    }
}
