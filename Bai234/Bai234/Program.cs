using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai234
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[] { 35, 50, 25, 28, 800,800, 4, 15, 22, 39, 56,15 };
            int[] arrB = new int[] { 35, 50, 1, 25,22, 39, 56,75,1,75 };
            LietKe(arrA, arrB);
            LietKe(arrB, arrA);
            Console.ReadLine();
        }

        public static void LietKe(int[] arrA, int[] arrB)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                if (ExistInBothArray(arrA[i],arrB) == false)
                {
                    if (CheckExistInArray(arrA,i) == false)
                    {
                        Console.WriteLine("Value ({0}: {1} time(s))", arrA[i], CountNumberInArray(arrA, arrA[i]));
                    }
                }
            }
            

        }

        public static bool CheckExistInArray(int[] arr, int index)
        {
            for (int i = index - 1; i >= 0; i--)
            {
                if (arr[i] == arr[index])
                    return true;
            }
            return false;
        }

        public static int CountNumberInArray(int[] arr, int number)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                    count++;
            }
            return count;
        }

        public static bool ExistInBothArray(int number, int[] arr )
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
