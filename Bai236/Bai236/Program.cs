using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai236
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrA = new int[] { 35, 500, 39, 56 };
            int[] arrB = new int[] { 35, 15,39, 22, 39, 56,56,35,39};

            CountAInB(arrA,arrB);
            Console.ReadLine();
        }

        public static void CountAInB(int[] arrA, int[] arrB)
        {
            for (int i = 0; i < arrA.Length; i++)
            {
                if (ExistInBothArray(arrA[i], arrB) == true)
                {
                    Console.WriteLine("Value ({0}): {1} time(s)",arrA[i],CountValueInArray(arrA[i],arrB));
                }
            }
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

        public static int CountValueInArray(int number, int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == number)
                {
                    count++;
                }
            }
            return count;
        }


    }
}
