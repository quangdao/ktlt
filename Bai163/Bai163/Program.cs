using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai163
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 258, 800, 4, 15, 22, 39, 56 };
            Console.WriteLine(ChinhPhuongDau(arr));        
            Console.ReadLine();

        }

        public static int ChinhPhuongDau(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (KiemTraChinhPhuong(arr[i]) == true)
                {
                    return arr[i];
                }
            }
            return 0;


        }

        public static bool KiemTraChinhPhuong(int number)
        {
            for (int i = 0; i < number; i++)
            {
                if (Math.Pow(i, 2) == number) {
                    //Console.WriteLine(i);
                    return true;
                    
                }
            }

            return false;
        }

    }
}
