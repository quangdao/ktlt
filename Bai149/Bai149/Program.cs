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
            int[] arr = new int[] { 5, 6, 8, 9, 28,23,22,11,6,18,496 };
           // Console.WriteLine(kiemtrahoanthien(6));
            Console.WriteLine(sohoanthiencuoi(arr));
            Console.ReadLine();
        }

        public static int sohoanthiencuoi(int[] arr) {
            int hoanthiencuoi = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (kiemtrahoanthien(arr[i]) == true) {
                    hoanthiencuoi = arr[i];
                }
            }
            return hoanthiencuoi;
        }


        public static bool kiemtrahoanthien(int number)
        {
            List<int> list = new List<int>();
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    list.Add(i);
                }
            }
            if (list.Sum() == number)
            {
                return true;
            }
            return false;
        }
    }
}
