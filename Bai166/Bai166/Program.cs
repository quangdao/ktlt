using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai166
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 30, 500, -256, 258, 0, 800, 4, 15, 22, 39,56 };
            Console.WriteLine(GiaTriDau2MuK(arr));
            //Console.WriteLine(CheckDang2MuK(10));
            Console.ReadLine();
        }

        public static int GiaTriDau2MuK(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (CheckDang2MuK(arr[i]) == true)
                {
                    return arr[i];
                }
            }
            return 0;
        }

        public static bool CheckDang2MuK(int number)
        {
            if (number <= 0)
                return false;

            int logarithm = Convert.ToInt32(Math.Log(number, 2));
            if (Math.Pow(2,logarithm) == number)
            {
                return true;
            }
            return false;
        }


    }
}
