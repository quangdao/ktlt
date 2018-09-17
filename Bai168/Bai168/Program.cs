using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai168
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 25, 500, 256, 258, 800, -125, 15, 22, 39, 56 };
            Console.WriteLine(LonNhat5MuK(arr));
            Console.ReadLine();
            //Console.WriteLine(CheckDang5MuK(125));
        }

        public static int LonNhat5MuK(int[] arr) {
            int lonnhat = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckDang5MuK(arr[i]) == true && arr[i] > lonnhat)
                {
                    lonnhat = arr[i];
                }
            }

            return lonnhat;
        }

        public static bool CheckDang5MuK(int number)
        {
            if (number <= 0) {
                return false;
            }
            int logarithm = Convert.ToInt32(Math.Log(number, 5));
            int temp = Convert.ToInt32(Math.Pow(5, logarithm));
            if ( temp == number)
            {
                return true;
            }
            return false;

        }
    }
}
