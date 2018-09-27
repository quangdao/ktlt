using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai235
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[] { 35, 500, 256, 258, 800, 4, 15, 22, 39, 56 };
            int[] arrB = new int[] { 35, 22,75, 99, 39, 56, 15 };

            LietKe(arrA, arrB);
            LietKe(arrB, arrA);

            Console.ReadLine();
        }

        public static void LietKe(int[] arrA, int[] arrB)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                if (ExistInBothArray(arrA[i], arrB) == false)
                {
                    if (ExistInArray(arrA,i) == false)
                    {
                        Console.WriteLine(arrA[i]);
                    }
                }
            }
        }

        public static bool ExistInArray(int[] arr, int index)
        {
            for (int i = index - 1; i >=0; i--)
            {
                if (arr[i] == arr[index])
                {
                    return true;
                }
            }
            return false;
        }

        public static bool ExistInBothArray(int number, int[] arr)
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
