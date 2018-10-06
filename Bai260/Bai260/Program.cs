using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai260
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[] { 35,29,56,23,31,37,41 };
            int[] arrB = new int[] { 41,29,35,37,23,56,31 };
            Console.WriteLine(KiemTraHoanVi(arrA,arrB));
            Console.ReadLine();
        }

        public static bool KiemTraHoanVi(int[] arrA, int[] arrB)
        {
            bool flag = true;
            if (arrA.Length != arrB.Length)
            {
                flag = false;
            }
            for (int i = 0; i < arrB.Length; i++)
            {
                if (CheckValue(arrA,arrB[i]) == false)
                {
                    flag = false;
                }
            }
            return flag;
        }

        public static bool CheckValue(int[] arr, int number)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
