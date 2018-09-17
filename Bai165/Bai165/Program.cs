using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai165
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 2288, 63, 2334, -938, 223, 123 };
            Console.WriteLine(DauLeDauTien(arr));
            Console.ReadLine();
        }

        public static int DauLeDauTien(int[] arr) {
            for (int i = 0; i < arr.Length; i++)

            {
                if (KiemTraLeDau(arr[i]) == true)
                {
                    return arr[i];
                }
            }
            return 0;
        }

        public static bool KiemTraLeDau(int number)
        {
            int ledau = 0;
            int temp = Math.Abs(number);
            while (temp >= 10)
            {
                ledau = temp /= 10;
            }

            if (ledau % 2 != 0)
            {
                return true;
            }
            return false;
        }

         



    }
}
