using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai197
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800, 4, 1, 22, 39, 56 };
            LietKeGiaTriLeDau(arr);
            Console.ReadLine(); ;
        }
        public static void LietKeGiaTriLeDau(int[] arr)
        {
            foreach (var number in arr)
            {
                if (CheckLeDau(number) == true)
                {
                    Console.Write(" {0} ", number);
                }
            }
        }

        public static bool CheckLeDau(int number) 
        {
            int leDau = Math.Abs(number);
            int temp = Math.Abs(number);
            while (temp >= 1)
            {
                leDau = temp % 10;
                temp /= 10;
            }
            if (leDau % 2 !=0)
            {
                return true;
            }
            return false;
        }
    }
}
