using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai192
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, -800, 4, 15, 22, 39, 56 };
            LietKeChandau(arr);
            //Console.WriteLine(CheckChanDau(-800));
            Console.ReadLine();
        }

        public static void LietKeChandau(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckChanDau(arr[i]) == true)
                {
                    Console.WriteLine(arr[i]);
                }
            }
        }
        public static bool CheckChanDau(int number)
        {
            int temp = Math.Abs(number);
            int chanDau = temp;
            while (temp >= 10)
            {
                chanDau = temp / 10;
                temp /= 10;
            }
            if (chanDau % 2 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
