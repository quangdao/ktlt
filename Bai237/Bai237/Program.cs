using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai237
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 35, 500, 256, 258, 800,800, 4, 15, 22, 35, 800, 39, 56 };
            XuatHienNhieuNhat(arr);
            Console.ReadLine();
        }

        public static void XuatHienNhieuNhat(int[] arr)
        {
            int countValue = 0;
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (CountValueInArray(arr, i) > countValue)
                {
                    countValue = CountValueInArray(arr, i);
                    index = i;
                }
            }
            Console.WriteLine("Value ({0}): {1} times", arr[index],countValue);  ;
        }

        public static int CountValueInArray(int[] arr, int index)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == arr[index])
                {
                    count++;
                }
            }
            return count;
        }


    }
}
