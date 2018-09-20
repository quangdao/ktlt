using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai202
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 12002,22,14003,35001 };
            Console.WriteLine(TongLeDau(arr));
            Console.ReadLine();
        }

        public static int TongLeDau(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckLeDau(arr[i]) == true)
                {
                    sum += arr[i];
                }
            }
            return sum;
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
            if (leDau % 2 != 0)
            {
                return true;
            }
            return false;

        }
    }
}
